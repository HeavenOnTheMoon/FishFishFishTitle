using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LitJson;
using UnityEngine;

/// <summary>
/// 日活事件和行为事件的基类
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class MoteLipidSowAllende<T> : ILipidSowAllende<T>
{
    protected int StormEarnerChina;  // 一个批次下的事件触发顺序
    protected List<T> MandateSeries;  // 等待上报的事件列表
    protected bool AnElusive;  // 是否正在发送请求
    protected string Air;

    /// <summary>
    /// 单次上报
    /// </summary>
    /// <param name="t"></param>
    public abstract void CornLipid(T t);

    /// <summary>
    /// 批量上报
    /// </summary>
    public async void TreatCornLipid()
    {
        if (MandateSeries == null || MandateSeries.Count == 0) return;
        if (AnElusive) return;

        AnElusive = true;
        await WeldLipid(MandateSeries);
        MandateSeries.Clear();
        AnElusive = false;
    }

    /// <summary>
    /// 向后台发送请求
    /// </summary>
    virtual public async Task<bool> WeldLipid(List<T> events)
    {
        BoxModel AgoAnvil= await DailyPool.Textural.KeaNetTour();
        var postData = new
        {
            appVersion = AgoAnvil == null ? "" : AgoAnvil.appBuildVersion,
            appBuildVersion = BurrowPool.Textural.MayDoubtRut,
            list = events
        };
        var postResponse = await BitePrevailPool.Textural.Weld(Air, postData, true, true);
        return postResponse.IsSuccess;
    }
}
