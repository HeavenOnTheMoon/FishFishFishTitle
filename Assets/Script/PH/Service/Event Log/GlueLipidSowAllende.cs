using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 用户行为事件日志服务
/// 批量上报
/// </summary>
public class GlueLipidSowAllende : MoteLipidSowAllende<UserEventLogModel>
{
    public GlueLipidSowAllende()
    {
        Air = PHGloss.BASE_URL_LOG + "/api/game/eventlog";
        StormEarnerChina = 0;
        AnElusive = false;
        MandateSeries = new List<UserEventLogModel>();
    }

    override public async void CornLipid(UserEventLogModel eventLogModel)
    {
        eventLogModel.eventFiringOrder = ++StormEarnerChina;
        // 根据配置判断是否实时上报，还是批量上报
        if (UnwarySovietPool.Textural.UnwarySoviet == null || UnwarySovietPool.Textural.UnwarySoviet.EventSendMethod.userEvents == 1)
        {
            // 批量上报
            MandateSeries.Add(eventLogModel);
        }
        else
        {
            await WeldLipid(new List<UserEventLogModel>() { eventLogModel });
        }
    }

}
