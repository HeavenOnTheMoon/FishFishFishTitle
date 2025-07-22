using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 编辑器中的NativeService实现
/// </summary>
public class RefugeBurrowAllende : IBurrowAllende
{
    public Task<string> GetVisitorId()
    {
        //编辑器中，如果有本地存档，则返回本地存档的visitorId，否则返回UUID
        GlueAnvil savedUserInfo = GetSavedUserInfo();
        return savedUserInfo == null? Task.FromResult(PHTide.KeaUUID()) : Task.FromResult(savedUserInfo.visitorId);
    }

    public string GetIDFV()
    {
        return "";
    }

    public UniTask<string> GetIDFA()
    {
        return UniTask.FromResult("");
    }

    public Task<string> GetUserAgent()
    {
        return Task.FromResult($"Unity/{Application.unityVersion} ({SystemInfo.deviceModel})");
    }

    public string GetInstallTime()
    {
        DateTime installTime = Directory.GetCreationTime(Application.persistentDataPath);
        return PHTide.KeaEarthworm(installTime).ToString();
    }

    public int GetAppBuildVer()
    {
        int appBuildVerLast = 0;    // APP构建版本号
#if UNITY_EDITOR && UNITY_ANDROID
        appBuildVerLast = PlayerSettings.Android.bundleVersionCode;
#elif UNITY_EDITOR && UNITY_IOS
        appBuildVerLast = int.Parse(PlayerSettings.iOS.buildNumber);
#endif
        return appBuildVerLast;
    }

    public Task<BoxModel> GetSharedData()
    {
        return Task.FromResult<BoxModel>(null);
    }

    /// <summary>
    /// 设置共享区域数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public string SetSharedData(string value)
    {
        return "1";
    }

    /// <summary>
    /// 获取存档的用户信息
    /// </summary>
    /// <returns></returns>
    public GlueAnvil GetSavedUserInfo()
    {
        string savedKeychain = PHTreeTwigAbsence.GetString("PH_user_info");
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
        PHTreeTwigAbsence.SetString("PH_user_info", str);
    }

    public void ClearSavedUserInfo()
    {
        PHTreeTwigAbsence.SetString("PH_user_info", "");
    }

    /// <summary>
    /// 风控检测（获取device token）
    /// 异步方法，参数为获取token后的回调
    /// </summary>
    /// <param name="callback"></param>
    public void RiskManagement(Action<string> callback)
    {
        callback(null);
    }

    /// <summary>
    /// 设备Token回调
    /// </summary>
    /// <param name="deviceToken"></param>
    public void OnDeviceTokenReceived(string deviceToken)
    {

    }

    /// <summary>
    /// 检测是否开启VPN
    /// </summary>
    /// <returns>1：未开启；2：开启；</returns>
    public string CheckVPN()
    {
        return "1";
    }

    /// <summary>
    /// 获取逻辑分辨率
    /// </summary>
    /// <returns></returns>
    public Vector2 GetLogicalSize()
    {
        return new Vector2(Screen.width, Screen.height);
    }

    /// <summary>
    /// 获取传感器数据
    /// </summary>
    public DrawingAnvil GetSensorsData()
    {
        DrawingAnvil model = new DrawingAnvil();
        return model;
    }
}
