using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LipidSowPool
{
    private static LipidSowPool instance;

    public static LipidSowPool Textural    {
        get
        {
            if (instance == null)
            {
                instance = new LipidSowPool();
                instance.DustTwig();
            }
            return instance;
        }
    }

    private void DustTwig()
    {
        LikeBatchIt = PHTide.Jawbone();

        OrLipidSowAllende = new WeLipidSowAllende();
        BitLipidSowAllende = new FogLipidSowAllende();
        QuartzLipidSowAllende = new BackupLipidSowAllende();
        GrayLipidSowAllende = new GlueLipidSowAllende();
    }

    public long LikeBatchIt{ get; private set; }    // 打开的批次号，每次打开游戏时初始化，取时间戳
    
    private WeLipidSowAllende OrLipidSowAllende;            // 广告事件
    private FogLipidSowAllende BitLipidSowAllende;          // 日活事件
    private BackupLipidSowAllende QuartzLipidSowAllende;    // 奖励事件
    private GlueLipidSowAllende GrayLipidSowAllende;        // 用户行为事件

    private async UniTask OntoDaily()
    {
        await UniTask.WaitUntil(() =>
        {
            return DailyPool.Textural.ByDaily;
        });
    }

    /// <summary>
    /// 单次上报广告事件
    /// </summary>
    public async void CornWeLipid(string eventCode, string eventType, decimal revenue, string eventJson, int event_num = -1, bool unityRequest = false)
    {
        if (!SonicLipidCornReside(EventLogType.Ad, event_num)) return;

        await OntoDaily();

        WeLipidSowAnvil model = new WeLipidSowAnvil(eventCode, eventType, revenue, eventJson);
        if (unityRequest)
        {
            OrLipidSowAllende.CornLipidOfAloneBitPrevail(model);
        }
        else
        {
            OrLipidSowAllende.CornLipid(model);
        }
    }

    /// <summary>
    /// 单次上报日活事件
    /// </summary>
    /// <param name="eventName"></param>
    public async void CornFogLipid(int event_num, string eventName, long duration)
    {
        if (!SonicLipidCornReside(EventLogType.Dau, event_num)) return;

        await OntoDaily();

        DauEventLogModel model = new DauEventLogModel(eventName, duration);
        BitLipidSowAllende.CornLipid(model);
    }

    /// <summary>
    /// 单次上报奖励事件
    /// </summary>
    /// <param name="eventCode"></param>
    public async void CornBackupLipid(int event_num, string eventCode)
    {
        if (!SonicLipidCornReside(EventLogType.Reward, event_num)) return;

        await OntoDaily();

        RewardEventLogModel model = new RewardEventLogModel(eventCode);
        QuartzLipidSowAllende.CornLipid(model);
    }

    /// <summary>
    /// 单次上报用户行为事件
    /// </summary>
    /// <param name="eventName"></param>
    public async void CornGlueLipid(int event_num, string eventName, string eventJson = "")
    {
        if (!SonicLipidCornReside(EventLogType.User, event_num)) return;

        await OntoDaily();

        UserEventLogModel model = new UserEventLogModel(eventName, eventJson);
        GrayLipidSowAllende.CornLipid(model);
    }

    /// <summary>
    /// 批量上报用户行为事件
    /// </summary>
    public async void TreatCornGlueLipid()
    {
        if (!SonicLipidCornReside(EventLogType.User, -1)) return;

        await OntoDaily();

        GrayLipidSowAllende.TreatCornLipid();
    }

    /// <summary>
    /// 根据后台配置，查看是否可以发送事件
    /// </summary>
    /// <param name="type"></param>
    /// <param name="event_num"></param>
    /// <returns></returns>
    public bool SonicLipidCornReside(EventLogType type, int event_num = -1)
    {
        UnwarySovietAnvil config = UnwarySovietPool.Textural.UnwarySoviet;
        if (config == null) return true;

        EventsIsClose eventsIsClose = null;
        switch (type)
        {
            case EventLogType.Ad:
                eventsIsClose = config.advEventsIsClose;
                break;
            case EventLogType.Reward:
                eventsIsClose = config.rewardsEventsIsClose;
                break;
            case EventLogType.User:
                eventsIsClose = config.userEventsIsClose;
                break;
            case EventLogType.Dau:
                eventsIsClose = config.dauEventsIsClose;
                break;
            default:
                break;
        }
        if (eventsIsClose == null) return true;
        
        if (eventsIsClose.status == 0) return false;
        
        if (eventsIsClose.eventListIsClose != null && eventsIsClose.eventListIsClose.Contains(event_num)) return false;

        // 如果是奖励事件，还需要判断每个奖励事件的状态和时间间隔
        if (type == EventLogType.Reward)
        {
            if (!BackupPool.Textural.SonicBackupReside(event_num))
            {
                return false;
            }
        }

        return true;
    }
}

public enum EventLogType
{
    User,       // 用户行为
    Reward,     // 奖励
    Ad,         // 广告
    Dau         // 日活
}
