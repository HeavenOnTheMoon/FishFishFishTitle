//
//  Test.cpp
//  TestFramework
//
//  Created by iOS_Developer on 2025/3/17.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <WebKit/WebKit.h>
#import <AdSupport/AdSupport.h>
#import <Security/Security.h>
#import <DeviceCheck/DeviceCheck.h>
#import <CoreMotion/CoreMotion.h>
#import <StoreKit/StoreKit.h>
#import <AppTrackingTransparency/AppTrackingTransparency.h>

// MARK: - 日期方法
extern "C" {
    char* UnityGetCurrentDate() {
        NSDateFormatter *fmt = [NSDateFormatter new];
        fmt.dateFormat = @"yyyy-MM-dd HH:mm:ss";
        NSString *str = [fmt stringFromDate:[NSDate date]];
        return strdup([str UTF8String]);
    }

    char* UnityGetCurrentDateWithFormat(char* format) {
        NSDateFormatter *fmt = [NSDateFormatter new];
        fmt.dateFormat = [NSString stringWithUTF8String:format];
        NSString *str = [fmt stringFromDate:[NSDate date]];
        return strdup([str UTF8String]);
    }
}

// MARK: - 安装时间
extern "C" {
    char* UnityGetInstallDate() {
        NSString *path = NSSearchPathForDirectoriesInDomains(NSDocumentDirectory, NSUserDomainMask, YES).firstObject;
        NSDictionary *attrs = [[NSFileManager defaultManager] attributesOfItemAtPath:path error:nil];
        NSDate *date = attrs[NSFileCreationDate];
        
        // 创建日期格式化器
        NSDateFormatter *formatter = [[NSDateFormatter alloc] init];
        [formatter setDateFormat:@"yyyy-MM-dd HH:mm:ss"];
        [formatter setTimeZone:[NSTimeZone timeZoneWithAbbreviation:@"UTC"]]; // 设置为UTC时区
        
        // 格式化为字符串
        NSString *formattedDate = [formatter stringFromDate:date];
        
        // 返回C字符串（需要释放）
        return strdup([formattedDate UTF8String]);
    }
}

// MARK: - UA获取（主线程安全）
static dispatch_once_t onceToken;
static dispatch_semaphore_t semaphore;
static WKWebView *wkWebView;

// NSString 转 C 字符串（自动内存管理）
static char* MakeStringCopy(const char* str) {
    if (str == NULL) return NULL;
    char* res = (char*)malloc(strlen(str) + 1);
    strcpy(res, str);
    return res;
}

extern "C" {
    void UnityGetUserAgent() {
        __block WKWebView *webView = [[WKWebView alloc] initWithFrame:CGRectZero];
         [webView evaluateJavaScript:@"navigator.userAgent" completionHandler:^(NSString *result, NSError * error) {
             webView = nil; /// 延迟webview释放，否则无法获取result
             if (!error && result && [result isKindOfClass:[NSString class]])
             {
                 NSString *userAgent = result;
                 NSLog(@"-----------userAgent :%@", userAgent);
                 UnitySendMessage("PHManager", "GetUserAgentReceived", userAgent.UTF8String);
             }
         }];
    }
}

// MARK: - Keychain
// 配置共享 Keychain 访问组（需替换为你的 Team ID）
#define SHARED_KEYCHAIN_GROUP @"com.playhive.task.app"
#define PRIVATE_KEYCHAIN_GROUP nil // 私有 Keychain 不使用访问组

static NSString* GetPrivateKeychainValue(NSString *key) {
    NSDictionary *query = @{
        (__bridge id)kSecClass: (__bridge id)kSecClassGenericPassword,
        (__bridge id)kSecAttrAccount: key,
        (__bridge id)kSecReturnData: @YES,
        (__bridge id)kSecMatchLimit: (__bridge id)kSecMatchLimitOne
    };
    
    CFTypeRef result = NULL;
    OSStatus status = SecItemCopyMatching((__bridge CFDictionaryRef)query, &result);
    if (status != errSecSuccess) return nil;
    
    NSData *data = (__bridge_transfer NSData *)result;
    return [[NSString alloc] initWithData:data encoding:NSUTF8StringEncoding];
}

static BOOL SetPrivateKeychainValue(NSString *key, NSString *value) {
    NSData *valueData = [value dataUsingEncoding:NSUTF8StringEncoding];
    if (!valueData) return NO;
    
    // 先删除旧值
    NSDictionary *deleteQuery = @{
        (__bridge id)kSecClass: (__bridge id)kSecClassGenericPassword,
        (__bridge id)kSecAttrAccount: key
    };
    SecItemDelete((__bridge CFDictionaryRef)deleteQuery);
    
    // 添加新值
    NSDictionary *item = @{
        (__bridge id)kSecClass: (__bridge id)kSecClassGenericPassword,
        (__bridge id)kSecAttrAccount: key,
        (__bridge id)kSecValueData: valueData,
        (__bridge id)kSecAttrAccessible: (__bridge id)kSecAttrAccessibleAfterFirstUnlock
    };
    
    return SecItemAdd((__bridge CFDictionaryRef)item, NULL) == errSecSuccess;
}

static NSString* GetSharedKeychainValue(NSString *account, NSString *service) {
    NSDictionary *query = @{
        (__bridge id)kSecClass: (__bridge id)kSecClassGenericPassword,
        (__bridge id)kSecAttrAccount: account,
        (__bridge id)kSecAttrService: service,
        (__bridge id)kSecReturnData: @YES
    };

    CFDataRef result = NULL;
    OSStatus status = SecItemCopyMatching((__bridge CFDictionaryRef)query, (CFTypeRef *)&result);

    if (status == errSecSuccess) {
        NSData *data = (__bridge_transfer NSData *)result;
        return [[NSString alloc] initWithData:data encoding:NSUTF8StringEncoding];
    } else {
        NSLog(@"Keychain read error: %d", (int)status);
        return nil;
    }
}

static BOOL SetSharedKeychainValue(NSString *account, NSString *service, NSString *value) {
    NSData *data = [value dataUsingEncoding:NSUTF8StringEncoding];
    
    // First check if the item already exists
    NSDictionary *query = @{
        (__bridge id)kSecClass: (__bridge id)kSecClassGenericPassword,
        (__bridge id)kSecAttrAccount: account,
        (__bridge id)kSecAttrService: service
    };
    
    OSStatus status = SecItemCopyMatching((__bridge CFDictionaryRef)query, NULL);
    
    if (status == errSecSuccess) {
        // Item exists, update it
        NSDictionary *update = @{
            (__bridge id)kSecValueData: data
        };
        status = SecItemUpdate((__bridge CFDictionaryRef)query, (__bridge CFDictionaryRef)update);
    } else if (status == errSecItemNotFound) {
        // Item doesn't exist, add it
        NSDictionary *add = @{
            (__bridge id)kSecClass: (__bridge id)kSecClassGenericPassword,
            (__bridge id)kSecAttrAccount: account,
            (__bridge id)kSecAttrService: service,
            (__bridge id)kSecValueData: data,
            (__bridge id)kSecAttrAccessible: (__bridge id)kSecAttrAccessibleWhenUnlocked
        };
        status = SecItemAdd((__bridge CFDictionaryRef)add, NULL);
    }
    
    if (status == errSecSuccess) {
        return YES;
    } else {
        NSLog(@"Keychain write error: %d", (int)status);
        return NO;
    }
}


extern "C" {
// 获取共享 Keychain 值
    char* UnityGetSharedKeychainValue(const char* key, const char* service) {
        NSString *nsKey = [NSString stringWithUTF8String:key];
        NSString *nsService = [NSString stringWithUTF8String:service];
        NSString *value = GetSharedKeychainValue(nsKey, nsService);
        return strdup(value ? [value UTF8String] : "");
    }
    char* UnitySetSharedKeychainValue(const char* key, const char* service, const char* value) {
        NSString *nsKey = [NSString stringWithUTF8String:key];
        NSString *nsService = [NSString stringWithUTF8String:service];
        NSString *nsValue = [NSString stringWithUTF8String:value];
        BOOL success = SetSharedKeychainValue(nsKey, nsService, nsValue);
        return strdup(success ? "1" : "0");
    }
    
    // 获取私有 Keychain 值
    char* UnityGetKeychainValue(const char *key) {
        if (!key) return strdup("");
        
        NSString *nsKey = [NSString stringWithUTF8String:key];
        NSString *value = GetPrivateKeychainValue(nsKey);
        return strdup(value ? [value UTF8String] : "");
    }
    
    // 设置私有 Keychain 值
    char* UnitySaveKeychainValue(const char *key, const char *value) {
        if (!key || !value) return strdup("0");
        
        NSString *nsKey = [NSString stringWithUTF8String:key];
        NSString *nsValue = [NSString stringWithUTF8String:value];
        
        BOOL success = SetPrivateKeychainValue(nsKey, nsValue);
        return strdup(success ? "1" : "0");
    }
}

// MARK: - 设备标识
extern "C" {
    char* UnityGetIDFV() {
        NSUUID *uuid = [UIDevice currentDevice].identifierForVendor;
        if (uuid == nil) {
            return strdup(""); // 返回空字符串，避免崩溃
        }
        return strdup([uuid.UUIDString UTF8String]);
    }

    // 请求跟踪权限 (iOS 14+)
    void RequestIDFAPermission() {
        if (@available(iOS 14, *)) {
            [ATTrackingManager requestTrackingAuthorizationWithCompletionHandler:^(ATTrackingManagerAuthorizationStatus status) {
                // 回调处理可以在这里添加
                if (status == ATTrackingManagerAuthorizationStatusAuthorized) {
                    UnitySendMessage("PHManager", "OnIDFAPermissionChanged", "1");
                } else {
                    UnitySendMessage("PHManager", "OnIDFAPermissionChanged", "2");
                }
            }];
        }
    }
    
    // 获取当前跟踪权限状态
    int GetTrackingAuthorizationStatus() {
        if (@available(iOS 14, *)) {
            return (int)[ATTrackingManager trackingAuthorizationStatus];
        }
        return 3; // 如果低于iOS14，返回3 (ATTrackingManagerAuthorizationStatusAuthorized)
    }
    
    // 获取IDFA
    char* UnityGetIDFA() {
        // 检查iOS14+权限
        if (@available(iOS 14, *)) {
            if ([ATTrackingManager trackingAuthorizationStatus] != ATTrackingManagerAuthorizationStatusAuthorized) {
                return strdup("");
            } else {
                NSUUID *idfa = [[ASIdentifierManager sharedManager] advertisingIdentifier];
                return strdup([[idfa UUIDString] UTF8String]);
            }
        } else {
            // 检查广告追踪是否可用
            if ([[ASIdentifierManager sharedManager] isAdvertisingTrackingEnabled]) {
                NSUUID *idfa = [[ASIdentifierManager sharedManager] advertisingIdentifier];
                return strdup([[idfa UUIDString] UTF8String]);
            }
        }
        return strdup("");
    }
}

// MARK: - 版本信息
extern "C" {
    char* UnityGetSystemVersion() {
        return strdup([[UIDevice currentDevice] systemVersion].UTF8String);
    }
    
    char* UnityGetBuildVersion() {
        NSString *version = [[NSBundle mainBundle] objectForInfoDictionaryKey:@"CFBundleVersion"];
        // 转换为C字符串（Unity会自动处理内存）
        return strdup([version UTF8String]);

    }
}

// MARK: - 检查是否使用VPN
extern "C" {
    const char* IsVPNConnected() {
        CFDictionaryRef cfDict = CFNetworkCopySystemProxySettings();
        NSDictionary *nsDict = (__bridge_transfer NSDictionary *)cfDict;
        NSDictionary *scopes = nsDict[@"__SCOPED__"];
        
        if (!scopes) {
            return strdup("1"); // 没有VPN
        }
        
        for (NSString *key in scopes.allKeys) {
            if ([key hasPrefix:@"tap"] ||    // OpenVPN、TUN/TAP
                [key hasPrefix:@"tun"] ||
                [key hasPrefix:@"ppp"] ||    // PPTP、L2TP
                [key hasPrefix:@"ipsec"] || // IPSec
                [key hasPrefix:@"utun"]) {  // IKEv2、TunnelKit
                return strdup("2"); // 检测到VPN
            }
        }
        
        return strdup("1"); // 没有VPN
    }
    
    void FreeMemory(const char* str) {
        free((void*)str);
    }
}

// MARK: - 获取DeviceToken
extern "C" {
    void GenerateDeviceToken() {
        if (@available(iOS 11.0, *)) {
            DCDevice *device = [DCDevice currentDevice];
            
            if (device.isSupported) {
                [device generateTokenWithCompletionHandler:^(NSData * _Nullable token, NSError * _Nullable error) {
                    if (error) {
                        UnitySendMessage("PHManager", "OnDeviceTokenReceived", "Error");
                    } else {
                        NSString *base64Token = [token base64EncodedStringWithOptions:0];
                        UnitySendMessage("PHManager", "OnDeviceTokenReceived", [base64Token UTF8String]);
                    }
                }];
            } else {
                UnitySendMessage("PHManager", "OnDeviceTokenReceived", "Unsupported");
            }
        } else {
            UnitySendMessage("PHManager", "OnDeviceTokenReceived", "Unsupported");
        }
    }
}

extern "C" {
    // 获取屏幕逻辑尺寸（points单位），返回"width*height"格式字符串
    const char* GetScreenLogicalSize() {
        CGSize size = [UIScreen mainScreen].bounds.size;
        NSString *result = [NSString stringWithFormat:@"%.2f*%.2f", size.width, size.height];
        return strdup([result UTF8String]);
    }
}

// MARK: - 传感器数据方法
// 定义传感器数据结构体
typedef struct {
    double x;
    double y;
    double z;
    long long timestamp; // 时间戳(毫秒)
    int errorCode; // 错误码: 0-成功, 1-未初始化, 2-传感器不可用, 3-数据不可用
} SensorData;

// 定义姿态数据结构体
typedef struct {
    double pitch;
    double roll;
    double yaw;
    long long timestamp; // 时间戳(毫秒)
    int errorCode; // 错误码
} AttitudeData;

static CMMotionManager *motionManager = nil;
// 初始化传感器系统
extern "C" {
    void UnityInitSensors() {
        if (!motionManager) {
            motionManager = [[CMMotionManager alloc] init];
        }
    }

    // MARK: - 加速计
    SensorData UnityGetAccelerometerData() {
        SensorData data = {0};
        data.errorCode = 1; // 默认未初始化
        
        if (motionManager) {
            if (!motionManager.isAccelerometerAvailable) {
                data.errorCode = 2; // 传感器不可用
                return data;
            }
            
            // 如果未启动，则临时启动以获取数据
            BOOL wasActive = motionManager.isAccelerometerActive;
            if (!wasActive) {
                motionManager.accelerometerUpdateInterval = 0.1;
                [motionManager startAccelerometerUpdates];
                [NSThread sleepForTimeInterval:0.05]; // 延迟50ms
            }
            
            CMAccelerometerData *accelData = motionManager.accelerometerData;
            if (accelData) {
                data.x = accelData.acceleration.x;
                data.y = accelData.acceleration.y;
                data.z = accelData.acceleration.z;
                data.timestamp = (long long)(accelData.timestamp * 1000);
                data.errorCode = 0; // 成功
            } else {
                data.errorCode = 3; // 数据不可用
            }
            
            // 如果之前未启动，则停止更新
            if (!wasActive) {
                [motionManager stopAccelerometerUpdates];
            }
        }
        
        return data;
    }
    
    // MARK: - 陀螺仪
    SensorData UnityGetGyroscopeData() {
        SensorData data = {0};
        data.errorCode = 1;
        
        if (motionManager) {
            if (!motionManager.isGyroAvailable) {
                data.errorCode = 2;
                return data;
            }
            
            BOOL wasActive = motionManager.isGyroActive;
            if (!wasActive) {
                motionManager.gyroUpdateInterval = 0.1;
                [motionManager startGyroUpdates];
                [NSThread sleepForTimeInterval:0.05]; // 延迟50ms
            }
            
            CMGyroData *gyroData = motionManager.gyroData;
            if (gyroData) {
                data.x = gyroData.rotationRate.x;
                data.y = gyroData.rotationRate.y;
                data.z = gyroData.rotationRate.z;
                data.timestamp = (long long)(gyroData.timestamp * 1000);
                data.errorCode = 0;
            } else {
                data.errorCode = 3;
            }
            
            if (!wasActive) {
                [motionManager stopGyroUpdates];
            }
        }
        
        return data;
    }
    
    // MARK: - 磁力计
    SensorData UnityGetMagnetometerData() {
        SensorData data = {0};
        data.errorCode = 1;
        
        if (motionManager) {
            if (!motionManager.isMagnetometerAvailable) {
                data.errorCode = 2;
                return data;
            }
            
            BOOL wasActive = motionManager.isMagnetometerActive;
            if (!wasActive) {
                motionManager.magnetometerUpdateInterval = 0.1;
                [motionManager startMagnetometerUpdates];
                [NSThread sleepForTimeInterval:0.05]; // 延迟50ms
            }
            
            CMMagnetometerData *magData = motionManager.magnetometerData;
            if (magData) {
                data.x = magData.magneticField.x;
                data.y = magData.magneticField.y;
                data.z = magData.magneticField.z;
                data.timestamp = (long long)(magData.timestamp * 1000);
                data.errorCode = 0;
            } else {
                data.errorCode = 3;
            }
            
            if (!wasActive) {
                [motionManager stopMagnetometerUpdates];
            }
        }
        
        return data;
    }
    
    // MARK: - 设备姿态
    AttitudeData UnityGetDeviceAttitude() {
        AttitudeData data = {0};
        data.errorCode = 1;
        
        if (motionManager) {
            if (!motionManager.isDeviceMotionAvailable) {
                data.errorCode = 2;
                return data;
            }
            
            BOOL wasActive = motionManager.isDeviceMotionActive;
            if (!wasActive) {
                motionManager.deviceMotionUpdateInterval = 0.1;
                [motionManager startDeviceMotionUpdates];
                [NSThread sleepForTimeInterval:0.05]; // 延迟50ms
            }
            
            CMDeviceMotion *deviceMotion = motionManager.deviceMotion;
            if (deviceMotion) {
                CMAttitude *attitude = deviceMotion.attitude;
                data.pitch = attitude.pitch;
                data.roll = attitude.roll;
                data.yaw = attitude.yaw;
                data.timestamp = (long long)(deviceMotion.timestamp * 1000);
                data.errorCode = 0;
            } else {
                data.errorCode = 3;
            }
            
            if (!wasActive) {
                [motionManager stopDeviceMotionUpdates];
            }
        }
        
        return data;
    }
    
    // 释放资源
    void UnityReleaseResources() {
        [motionManager stopAccelerometerUpdates];
        [motionManager stopGyroUpdates];
        [motionManager stopMagnetometerUpdates];
        [motionManager stopDeviceMotionUpdates];
        motionManager = nil;
    }

    // MARK: - 加速计数据字符串方法
    char* UnityGetAccelerometerstr() {
        SensorData data = UnityGetAccelerometerData();
        if (data.errorCode != 0) {
            return strdup("");
        }
        
        // 创建格式化字符串
        NSString *formatStr = @"%.6f,%.6f,%.6f";
        NSString *result = [NSString stringWithFormat:formatStr,
                           data.x, data.y, data.z];
        
        // 返回C字符串（需要调用者释放内存）
        return strdup([result UTF8String]);
    }

    // MARK: - 陀螺仪数据字符串方法
    char* UnityGetGyroscopestr() {
        SensorData data = UnityGetGyroscopeData();
        if (data.errorCode != 0) {
            return strdup("");
        }
        
        // 创建格式化字符串
        NSString *formatStr = @"%.6f,%.6f,%.6f";
        NSString *result = [NSString stringWithFormat:formatStr,
                           data.x, data.y, data.z];
        
        // 返回C字符串（需要调用者释放内存）
        return strdup([result UTF8String]);
    }

    // MARK: - 磁力计数据字符串方法
    char* UnityGetMagnetometerstr() {
        SensorData data = UnityGetMagnetometerData();
        if (data.errorCode != 0) {
            return strdup("");
        }
        
        // 创建格式化字符串
        NSString *formatStr = @"%.6f,%.6f,%.6f";
        NSString *result = [NSString stringWithFormat:formatStr,
                           data.x, data.y, data.z];
        
        // 返回C字符串（需要调用者释放内存）
        return strdup([result UTF8String]);
    }

     // MARK: - 设备姿态数据字符串方法
    char* UnityGetDeviceAttitudestr() {
        AttitudeData data = UnityGetDeviceAttitude();
        if (data.errorCode != 0) {
            return strdup("");
        }
        
        // 创建格式化字符串
        NSString *formatStr = @"%.6f,%.6f,%.6f";
        NSString *result = [NSString stringWithFormat:formatStr,
                           data.pitch, data.roll, data.yaw];
        
        // 返回C字符串（需要调用者释放内存）
        return strdup([result UTF8String]);
    }
}


//跳转任意连接
extern "C" {
    void openUrl(const char* url) { // 修改参数为url
        NSString *urlString = [NSString stringWithUTF8String:url];
        [[UIApplication sharedApplication] openURL:[NSURL URLWithString:urlString] options:@{} completionHandler:nil];
    }
}

// 打开好评弹窗
extern "C" {
    void RequestAppReview(const char* url) {
        // 1. 获取当前 keyWindow（兼容 iOS 13+）
        UIWindow *keyWindow = nil;
        if (@available(iOS 13.0, *)) {
            for (UIWindowScene *scene in [UIApplication sharedApplication].connectedScenes) {
                if (scene.activationState == UISceneActivationStateForegroundActive) {
                    for (UIWindow *window in scene.windows) {
                        if (window.isKeyWindow) {
                            keyWindow = window;
                            break;
                        }
                    }
                }
            }
        } else {
            keyWindow = [UIApplication sharedApplication].keyWindow;
        }

        if (!keyWindow) {
            openUrl(url);
            return;
        }

        // 2. 根据系统版本调用不同的 API
        if (@available(iOS 14.0, *)) {
            [SKStoreReviewController requestReviewInScene:keyWindow.windowScene];
        } else if (@available(iOS 10.3, *)) {
            [SKStoreReviewController requestReview];
        } else {
            openUrl(url);
        }
    }
}
