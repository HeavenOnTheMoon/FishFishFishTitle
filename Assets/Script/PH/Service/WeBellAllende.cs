using System;
using UnityEngine;

/// <summary>
/// 测试使用的广告服务，只实现了显示插屏广告和播放激励视频广告的接口，不做任何实际的广告展示
/// </summary>
public class WeBellAllende : IWeAllende
{
    public bool AnGunfire{ get; set; }

    /// <summary>
    /// 初始化广告SDK
    /// </summary>
    public void ManipulateSDK()
    {
        AnGunfire = false;
    }

    /// <summary>
    /// 显示插屏广告
    /// </summary>
    /// <param name="adLocationId"></param>
    /// <param name="callback"></param>
    public void HeelContributionWe(int adLocationId, Action<bool> callback)
    {
        Debug.Log("--- 播放插屏广告:" + adLocationId);
        callback?.Invoke(true);
    }

    /// <summary>
    /// 播放激励视频广告
    /// </summary>
    public void HeelAdjacentWe(int adLocationId, Action<bool> callback)
    {
        Debug.Log("--- 播放激励视频:" + adLocationId);
        callback?.Invoke(true);
    }
}
