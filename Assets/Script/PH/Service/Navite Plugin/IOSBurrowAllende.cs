using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// iOS平台相关的Native接口实现
/// </summary>
public class IOSBurrowAllende : IBurrowAllende
{
    [DllImport("__Internal")]
    private static extern string UnityGetIDFV();

    [DllImport("__Internal")]
    private static extern string UnityGetInstallDate();

    [DllImport("__Internal")]
    private static extern string UnityGetSharedKeychainValue(string key, string service);

    [DllImport("__Internal")]
    private static extern string UnityGetKeychainValue(string key);

    [DllImport("__Internal")]
    private static extern string UnitySaveKeychainValue(string key, string value);


    /// <summary>
    /// 和iOS平台相关的Native接口实现
    /// </summary>
    public Task<string> GetVisitorId()
    {
        // 1、先查询本地存储的visitorId
        GlueAnvil savedUserInfo = GetSavedUserInfo();
        if (savedUserInfo!= null && !string.IsNullOrEmpty(savedUserInfo.visitorId))
        {
            return Task.FromResult(savedUserInfo.visitorId);
        }

        // 2、如果获取不到visitorId，则尝试获取IDFV
        string idfvStr = GetIDFV();
        if (!string.IsNullOrEmpty(idfvStr))
        {
            return Task.FromResult(idfvStr);
        }

        // 3、如果以上方式都获取不到的话，使用UUID作为visitorId
        return Task.FromResult(PHTide.KeaUUID());
    }

    public string GetIDFV()
    {
        string idfvStr = UnityGetIDFV();
        Debug.Log("--- 原生代码获取IDFV:" + idfvStr);
        if (!string.IsNullOrEmpty(idfvStr) && !idfvStr.Equals("00000000-0000-0000-0000-000000000000"))
        {
            return idfvStr;
        }
        else
        {
            return "";
        }
    }

    // 跟踪授权状态枚举 (对应iOS的ATTrackingManagerAuthorizationStatus)
    public enum TrackingAuthorizationStatus
    {
        NotDetermined = 0,
        Restricted = 1,
        Denied = 2,
        Authorized = 3
    }
    [DllImport("__Internal")]
    private static extern void RequestIDFAPermission();
    [DllImport("__Internal")]
    private static extern int GetTrackingAuthorizationStatus();
    [DllImport("__Internal")]
    private static extern string UnityGetIDFA();

    /// <summary>
    /// 请求IDFA权限 (iOS14+)
    /// </summary>
    public static void RequestPermission()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            RequestIDFAPermission();
        }
    }
    /// <summary>
    /// 获取当前跟踪权限状态
    /// </summary>
    public static TrackingAuthorizationStatus GetAuthorizationStatus()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            return (TrackingAuthorizationStatus)GetTrackingAuthorizationStatus();
        }
        return TrackingAuthorizationStatus.Authorized;
    }
    async public UniTask<string> GetIDFA()
    {
        // 检查权限状态
        var status = GetAuthorizationStatus();
        // 如果未确定权限，请求权限
        if (status == TrackingAuthorizationStatus.NotDetermined)
        {
            RequestPermission();
            await UniTask.WaitUntil(() => PHTreeTwigAbsence.GetInt("PH_IDFA_status") != 0);
        }

        string idfaStr = UnityGetIDFA();
        Debug.Log("--- 原生代码获取IDFA:" + idfaStr);
        if (!string.IsNullOrEmpty(idfaStr) && !idfaStr.Equals("00000000-0000-000000000000"))
        {
            return idfaStr;
        }
        else
        {
            return "";
        }
    }
    
    public string GetInstallTime()
    {
        return UnityGetInstallDate();
    }

    [DllImport("__Internal")]
    private static extern string UnityGetUserAgent();
    async public Task<string> GetUserAgent()
    {
        if (!string.IsNullOrEmpty(PHTreeTwigAbsence.GetString("PH_ua")))
        {
            return PHTreeTwigAbsence.GetString("PH_ua");
        }
        UnityGetUserAgent();
        // iOS获取ua是异步获取的，此处等待1s，如果未获取到，则不再等待，返回空
        CancellationTokenSource cts = new CancellationTokenSource(1000); // 1秒超时
        try
        {
            await Task.Run(async () =>
            {
                while (string.IsNullOrEmpty(PHTreeTwigAbsence.GetString("PH_ua")))
                {
                    await Task.Delay(100, cts.Token); // 每100ms检查一次，避免高频轮询
                }
            }, cts.Token);
        }
        catch (TaskCanceledException)
        {
            // 超时后返回空
            return PHTreeTwigAbsence.GetString("PH_ua");
        }

        // 4. 返回最终结果（可能是新获取的 UA，也可能是空）
        return PHTreeTwigAbsence.GetString("PH_ua");
    }

    [DllImport("__Internal")]
    private static extern string UnityGetBuildVersion();
    public int GetAppBuildVer()
    {
        string version = UnityGetBuildVersion();
        return int.Parse(version);
    }

    /// <summary>
    /// 共享区域数据
    /// </summary>
    /// <returns></returns>
    public Task<BoxModel> GetSharedData()
    {
        string key = "com.green.task.app";
        string service = "com.playhive.task.app";
        string referrer = UnityGetSharedKeychainValue(key, service);
        Debug.Log("--- keychain:" + referrer);
        referrer = PHTide.SonicReferrer(referrer);
        BoxModel referrerModel = null;
        if (!string.IsNullOrEmpty(referrer) && PHTide.ByValidSize(referrer))
        {
            referrerModel = JsonMapper.ToObject<BoxModel>(referrer);
        }
        return Task.FromResult(referrerModel);
    }

    /// <summary>
    /// 设置共享区域数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [DllImport("__Internal")]
    private static extern string UnitySetSharedKeychainValue(string key, string service, string value);
    public string SetSharedData(string value)
    {
        string key = "com.green.task.app";
        string service = "com.playhive.task.app";
        string res = UnitySetSharedKeychainValue(key, service, value);
        return res;
    }

    /// <summary>
    /// 获取存档的用户信息
    /// </summary>
    /// <returns></returns>
    public GlueAnvil GetSavedUserInfo()
    {
        string savedKeychain = UnityGetKeychainValue("IOSJSON");
        if (string.IsNullOrEmpty(savedKeychain))
        {
            savedKeychain = PHTreeTwigAbsence.GetString("PH_user_info");
        }
        if (!string.IsNullOrEmpty(savedKeychain) && PHTide.ByValidSize(savedKeychain))
        {
            GlueAnvil userModel = JsonMapper.ToObject<GlueAnvil>(savedKeychain);
            if (string.IsNullOrEmpty(userModel.visitorId))
            {
                return null;
            }
            else
            {
                return userModel;
            }
        }
        return null;
    }

    /// <summary>
    /// 保存用户信息到存档
    /// </summary>
    /// <param name="userModel"></param>
    public void SaveUserInfo(GlueAnvil userModel)
    {
        string str = JsonMapper.ToJson(userModel);
        UnitySaveKeychainValue("IOSJSON", str);
        PHTreeTwigAbsence.SetString("PH_user_info", str);
    }

    public void ClearSavedUserInfo()
    {
        UnitySaveKeychainValue("IOSJSON", "");
        PHTreeTwigAbsence.SetString("PH_user_info", "");
    }

    [DllImport("__Internal")]
    private static extern void GenerateDeviceToken();

    private Action<string> riskManagementCallback;
    /// <summary>
    /// 风险控制，获取设备Token
    /// </summary>
    public void RiskManagement(Action<string> callback)
    {
        riskManagementCallback = callback;
        GenerateDeviceToken();
    }

    /// <summary>
    /// 设备Token回调
    /// </summary>
    /// <param name="deviceToken"></param>
    public void OnDeviceTokenReceived(string deviceToken)
    {
        riskManagementCallback?.Invoke(deviceToken);
    }


    [DllImport("__Internal")]
    private static extern string IsVPNConnected();


    public string CheckVPN()
    {
        string res = IsVPNConnected();
        return res;
    }

    [DllImport("__Internal")]
    private static extern string GetScreenLogicalSize();
    public Vector2 GetLogicalSize()
    {
        string size = GetScreenLogicalSize();
        string[] sizes = size.Split('*');
        float width = float.Parse(sizes[0]);
        float height = float.Parse(sizes[1]);
        return new Vector2(width, height);
    }

    [DllImport("__Internal")]
    private static extern void UnityInitSensors();
    [DllImport("__Internal")]
    private static extern string UnityGetAccelerometerstr();
    [DllImport("__Internal")]
    private static extern string UnityGetGyroscopestr();
    [DllImport("__Internal")]
    private static extern string UnityGetMagnetometerstr();
    [DllImport("__Internal")]
    private static extern string UnityGetDeviceAttitudestr();
    public DrawingAnvil GetSensorsData()
    {
        UnityInitSensors();
        DrawingAnvil model = new DrawingAnvil();
        // 加速度计
        string accStr = UnityGetAccelerometerstr();
        Debug.Log("--- 原生代码获取加速计:" + accStr);
        model.accelerometer = accStr;
        // 陀螺仪
        string gyroscope = UnityGetGyroscopestr();
        Debug.Log("--- 原生代码获取陀螺仪:" + gyroscope);
        model.gyroscope = gyroscope;
        // 磁力计
        string magnetometer = UnityGetMagnetometerstr();
        Debug.Log("--- 原生代码获取磁力计:" + magnetometer);
        model.magnetometer = magnetometer;
        // 设备姿态
        string deviceAttitude = UnityGetDeviceAttitudestr();
        Debug.Log("--- 原生代码获取设备姿态:" + deviceAttitude);
        model.equipmentPosture = deviceAttitude;

        return model;
    }
}

