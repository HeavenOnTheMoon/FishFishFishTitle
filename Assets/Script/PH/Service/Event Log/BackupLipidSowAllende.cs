using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 奖励事件日志服务
/// 实时上报
/// </summary>
public class BackupLipidSowAllende : ILipidSowAllende<RewardEventLogModel>
{
    private string Air= PHGloss.BASE_URL + "/api/game/rewardeventrecord";

    public async void CornLipid(RewardEventLogModel eventLogModel)
    {
        var postSuccess = await WeldLipid(eventLogModel);
        if (!postSuccess.IsSuccess)
        {
            if (postSuccess.StatusCode == 500027)
            {
                await PHTide.OntoDaily(Air);
                // 加签失败，重新计算加签，并重新请求
                string sourceStr = DailyPool.Textural.GlueTour.pre + eventLogModel.eventCode + eventLogModel.recordCode + "gamebox";
                eventLogModel.signature = PHTide.InnovatorMD5(sourceStr);
                await WeldLipid(eventLogModel);
            }
        }
    }

    public void TreatCornLipid()
    {
        Debug.LogError("广告日志不支持批量上传，请勿调用");
        throw new System.NotImplementedException();
    }

    private async Task<BiteEmbolism> WeldLipid(RewardEventLogModel eventLog)
    {
        var postData = new
        {
            signature = eventLog.signature,
            boxAppBuildVersion = PHAbsence.Instance.AgoAnvil?.appBuildVersion,
            gameAppBuildVersion = BurrowPool.Textural.MayDoubtRut.ToString(),
            coin = KeaText(BackupPool.Textural.BackupTextForm),
            coinOld = KeaText(BackupPool.Textural.BackupTextNowForm),
            events = new List<object> { 
                new {
                    eventCode = eventLog.eventCode,
                    recordCode = eventLog.recordCode,
                }
            }
        };
        var postResponse = await BitePrevailPool.Textural.Weld(Air, postData, false, false);
        if (postResponse.IsSuccess)
        {
            RewardEventLogResponseData responseData = postResponse.GetData<RewardEventLogResponseData>();
            BackupPool.Textural.DamBackupText(responseData.coin, responseData.coinOld);
        }
        else
        {
            Debug.LogError("奖励事件日志上传失败:" + postResponse.StatusCode + " " + postResponse.ErrorMessage);
        }
        return postResponse;
    }

    /// <summary>
    /// 获取奖励金币数量
    /// 最近10次返回的值 ，前9次累加  最后1次*3再累加
    /// 如果不满10次 就都传0
    /// </summary>
    /// <param name="coinList"></param>
    /// <returns></returns>
    private int KeaText(List<int> coinList)
    {
        int coin = 0;
        if (coinList.Count >= 10)
        {
            for (int i = coinList.Count - 1; i >= coinList.Count - 10; i--)
            {
                coin += i == coinList.Count - 1 ? coinList[i] * 3 : coinList[i];
            }
        }
        return coin;
    }
}
