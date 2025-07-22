using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 和Android平台相关的Native接口实现
/// </summary>
public class TherebyBurrowAllende : IBurrowAllende
{
    /// <summary>
    /// 获取用户用来登录的访客id
    /// 优先级 referrer > keychain
    /// </summary>
    /// <returns></returns>
    public async Task<string> GetVisitorId()
    {
        // 1、先查询referrer，判断是否有referrer和campaign字段
        BoxModel boxModel = await GetSharedData();
        // 如果referrer或共享区域中有visitorId，则直接返回visitorId
        if (boxModel != null && !string.IsNullOrEmpty(boxModel.visitorId))
        {
            return  boxModel.environment == "dev" ? boxModel.vifv : boxModel.visitorId;
        }

        // 2、如果获取不到visitorId，则尝试获取GAID
        string gaid = GAIDKnuckle.KeaGAID();
        if (!string.IsNullOrEmpty(gaid) && !gaid.Equals("00000000-0000-0000-0000-000000000000"))
        {
            Debug.Log("--- gaid:" + gaid);
            return gaid;
        }

        // 3、如果以上方式都获取不到的话，先查询本地存档，如果没有，使用UUID作为visitorId
        GlueAnvil savedUserInfo = GetSavedUserInfo();
        return savedUserInfo == null ? PHTide.KeaUUID() : savedUserInfo.visitorId;
    }

    public string GetIDFV()
    {
        // TODO
        return "";
    }

    public UniTask<string> GetIDFA()
    {
        // TODO
        return UniTask.FromResult("");
    }


    public async Task<BoxModel> GetSharedData()
    {
        BoxModel referrerModel = null;

        string referrer;
        // 先从共享区域查询
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject context = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity")
                            .Call<AndroidJavaObject>("getApplicationContext");
        using AndroidJavaClass javaClass = new AndroidJavaClass("com.playcube.gamelibrary.AndroidInfo");
        AndroidJavaObject instance = javaClass.CallStatic<AndroidJavaObject>("getInstance");
        referrer = instance.Call<string>("getKeychain", context);
        Debug.Log("--- keychain:" + referrer);
        referrer = PHTide.SonicReferrer(referrer);

        // 如果共享区域中没有数据，则尝试从安装referrer中获取
        if (string.IsNullOrEmpty(referrer))
        {
            string referrerRaw = await PlutonicKnuckle.FreshCarvingPlutonic();
            Debug.Log("--- referrer:" + referrerRaw);
            referrer = PHTide.SonicReferrer(referrerRaw);
        }

        if (!string.IsNullOrEmpty(referrer))
        {
            referrerModel = new BoxModel(referrer);
        }
        return referrerModel;
    }

    public string SetSharedData(string value)
    {
        return "1";
    }

    public Task<string> GetUserAgent()
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject context = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity")
                            .Call<AndroidJavaObject>("getApplicationContext");
        using AndroidJavaClass javaClass = new AndroidJavaClass("com.playcube.gamelibrary.AndroidInfo");
        AndroidJavaObject instance = javaClass.CallStatic<AndroidJavaObject>("getInstance");
        return Task.FromResult(instance.Call<string>("getUserAgent", context));
    }

    public string GetInstallTime()
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject context = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity")
                            .Call<AndroidJavaObject>("getApplicationContext");
        using AndroidJavaClass javaClass = new AndroidJavaClass("com.playcube.gamelibrary.AndroidInfo");
        AndroidJavaObject instance = javaClass.CallStatic<AndroidJavaObject>("getInstance");
        return instance.Call<string>("getInstallDate", context);
    }

    public int GetAppBuildVer()
    {
        var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        var currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        var packageManager = currentActivity.Call<AndroidJavaObject>("getPackageManager");
        var packageName = currentActivity.Call<string>("getPackageName");
        var packageInfo = packageManager.Call<AndroidJavaObject>("getPackageInfo", packageName, 0);

        return packageInfo.Get<int>("versionCode");
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
        // TODO: 待实现
        DrawingAnvil model = new DrawingAnvil();
        return model;
    }
}

