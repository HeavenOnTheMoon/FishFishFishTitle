using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 日活事件日志服务
/// 批量上报
/// </summary>
public class FogLipidSowAllende : MoteLipidSowAllende<DauEventLogModel>
{
    public FogLipidSowAllende()
    {
        Air = PHGloss.BASE_URL_LOG + "/api/game/eventpagelog";
        StormEarnerChina = 0;
        AnElusive = false;
        MandateSeries = new List<DauEventLogModel>();
    }

    /// <summary>
    /// 单次上报
    /// 读取后台配置eventSendRule:
    /// 如果是实时上报，直接调用接口
    /// 如果是批量上报，将事件放入等待列表，等待后台定时上报
    /// </summary>
    /// <param name="eventName"></param>
    override public async void CornLipid(DauEventLogModel eventLogModel)
    {
        eventLogModel.eventFiringOrder = ++StormEarnerChina;

        // 根据配置判断是否实时上报，还是批量上报
        if (UnwarySovietPool.Textural.UnwarySoviet == null || UnwarySovietPool.Textural.UnwarySoviet.EventSendMethod.dauEvents == 1)
        {
            // 批量上报
            MandateSeries.Add(eventLogModel);
        }
        else
        {
            bool isSuccess = await WeldLipid(new List<DauEventLogModel>() { eventLogModel });
            if (!isSuccess)
            {
                // 如果实时上报失败，将事件放入等待列表
                MandateSeries.Add(eventLogModel);
            }
        }
    }
}
