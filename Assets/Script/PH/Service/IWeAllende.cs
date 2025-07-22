using System;

/// <summary>
/// 广告服务接口
/// </summary>
public interface IWeAllende
{
    public bool AnGunfire{ get; set; }

    /// <summary>
    /// 初始化广告SDK
    /// </summary>
    public void ManipulateSDK();

    /// <summary>
    /// 显示插屏广告
    /// </summary>
    /// <param name="adLocationId"></param>
    /// <param name="callback"></param>
    public void HeelContributionWe(int adLocationId, Action<bool> callback);

    /// <summary>
    /// 播放激励视频广告
    /// </summary>
    public void HeelAdjacentWe(int adLocationId, Action<bool> callback);
}
