using UnityEngine;

/// <summary>
/// 广告播放日志服务
/// 实时上报
/// </summary>
public class WeLipidSowAllende : ILipidSowAllende<WeLipidSowAnvil>
{
    private string Air= PHGloss.BASE_URL_LOG + "/api/game/gameeventadslog";

    public void TreatCornLipid()
    {
        Debug.LogError("广告日志不支持批量上传，请勿调用");
        throw new System.NotImplementedException();
    }

    public void CornLipid(WeLipidSowAnvil eventLogModel)
    {
        BitePrevailPool.Textural.Weld(Air, eventLogModel, true, true);
    }

    public void CornLipidOfAloneBitPrevail(WeLipidSowAnvil eventLogModel)
    {
        BitePrevailPool.Textural.Weld(Air, eventLogModel, true, true, null, null, true);
    }
}


public enum AdEventType
{
    Loaded,
    LoadFailed,
    Displayed,
    Clicked,
    RevenuePaid,
    Hidden,
    DisplayFailed,
    ReceivedReward,
    StartShow           // 触发广告播放
}