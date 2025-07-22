using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 登录接口返回的用户信息
/// </summary>
public class GlueAnvil
{
    public int uid;             // 用户id - 后台返回
    public string token;        // 登录token - 后台返回
    public string pre;          // 签名前缀 - 后台返回
    public string visitorId;    // 访客id（苹果idfv，安卓gaid）
    public int wstate;          // 发奖状态
}

/// <summary>
/// 盒子共享信息
/// </summary>
public class BoxModel
{
    public string visitorId;        // 盒子用户ID
    public string appName;          // 盒子包名
    public string campaign;         // campaign
    public string uid;                 // 盒子用户id
    public string environment;      // 环境类型（dev pro）
    public string vifv;             // 游戏测试id
    public string appBuildVersion;     // 盒子版本号
    public string idfa;             // 盒子的idfa
    public string idfv;             // 盒子的idfv

    public BoxModel()
    {

    }

    public BoxModel(string referrer)
    {
        var pairs = referrer.Split('&');
        visitorId       = pairs.Length > 0 ? pairs[0] : "";
        appName         = pairs.Length > 1 ? pairs[1] : "";
        campaign        = pairs.Length > 2 ? pairs[2] : "";
        uid             = pairs.Length > 3 ? pairs[3] : "";
        environment     = pairs.Length > 4 ? pairs[4] : "";
        vifv            = pairs.Length > 5 ? pairs[5] : "";
        appBuildVersion = pairs.Length > 6 ? pairs[6] : "";
    }
}

public class AdjustDeviceModel
{
    public string Adid;
    public string TrackerName;
    public string FirstTrackerName;
}