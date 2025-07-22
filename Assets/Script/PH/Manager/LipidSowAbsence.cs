using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 所有事件打点管理
/// </summary>
public class LipidSowAbsence : MonoBehaviour
{
    public static LipidSowAbsence Instance;

    private bool AnInhabitant;    // 当前是否在前台
    
    private long SeaportLeak;        // 当前0时区0点时间戳，用于计算是否跨天，如果跨天，则上报一次日活事件

    // 前后台累计时间
    private double _CrisscrossPloy= 0f;
    private double _MinimalistPloy= 0f;
    private double _WandEuropePloy;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        AnInhabitant = true;
        string savedActivedDate = PHTreeTwigAbsence.GetString("PH_active_date");
        SeaportLeak = string.IsNullOrEmpty(savedActivedDate) ? 0 :  long.Parse(savedActivedDate);

        string Cue= PHTide.KeaUTCLeakEarthworm().ToString();
        _CrisscrossPloy = PHTreeTwigAbsence.GetDouble("PH_foreground_duration_" + Cue);
        _MinimalistPloy = PHTreeTwigAbsence.GetDouble("PH_background_duration_" + Cue);
        _WandEuropePloy = Time.realtimeSinceStartup;
    }

    private void Update()
    {
        // 如果当前在前台，则累加前台时间
        if (Application.isFocused)
        {
            _CrisscrossPloy += Time.deltaTime;
        }
    }

    /// <summary>
    /// 游戏前后台切换
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        if (!PHAbsence.Instance.RavenProdigy) return;

        if (pause)
        {
            // 进入后台：记录当前时间
            float currentTime = Time.realtimeSinceStartup;
            _WandEuropePloy = currentTime;
            //Debug.Log("--- app enter background: " + currentTime + ", ad is showing:" + WePool.Instance.IsAdShowing());

            // 行为事件埋点 - background
            LipidSowPool.Textural.CornGlueLipid(10003, "sys_app_background_10003");
        }
        else
        {
            // 回到前台：记录当前时间，并累加时间
            float currentTime = Time.realtimeSinceStartup;
            // 如果是播放广告，累加到前台时间；否则，累加到后台时间
            if (WePool.Textural.ByWeGunfire())
            {
                _CrisscrossPloy += currentTime - _WandEuropePloy;
            }
            else
            {
                _MinimalistPloy += currentTime - _WandEuropePloy;
            }
            _WandEuropePloy = currentTime;
            //Debug.Log("--- app enter foreground: " + currentTime + ", ad is showing:" + WePool.Instance.IsAdShowing());

            // 行为事件埋点 - foreground
            LipidSowPool.Textural.CornGlueLipid(10004, "sys_app_foreground_10004");
        }
        // 前后台切换时，上报一次页面耗时
        CornFogLipid();

        AnInhabitant = !pause;
    }

#if UNITY_EDITOR
    void OnApplicationFocus(bool hasFocus)
    {
        if (!hasFocus)
        {
            // 失去焦点：记录当前时间
            float currentTime = Time.realtimeSinceStartup;
            _WandEuropePloy = currentTime;
        }
        else
        {
            // 获得焦点：记录当前时间，并累加后台时间
            float currentTime = Time.realtimeSinceStartup;
            _MinimalistPloy += currentTime - _WandEuropePloy;
            _WandEuropePloy = currentTime;
        }

        // 前后台切换时，上报一次页面耗时
        CornFogLipid();

        AnInhabitant = hasFocus;
    }
#endif

    /// <summary>
    /// 开启事件打点计时器
    /// </summary>
    public void AssetLipidSowVivid()
    {
        // 1、根据后台配置的事件上报频率(eventSendRule)，设置事件打点计时器
        // EventSendMethod == 1表示需要定时批量上报；EventSendMethod == 2表示需要实时上报
        UnwarySovietAnvil config = UnwarySovietPool.Textural.UnwarySoviet;
        EventSendRuleItem eventSendMethod = config.EventSendMethod;
        EventSendRuleItem eventIntervalSeconds = config.EventIntervalSeconds;
        if (eventSendMethod.dauEvents == 2)
        {
            InvokeRepeating(nameof(CornFogLipid), eventIntervalSeconds.dauEvents, eventIntervalSeconds.dauEvents);
        }
        
        if (eventSendMethod.userEvents == 1)
        {
            // 定时批量上报用户事件
            InvokeRepeating(nameof(TreatCornGlueLipid), eventIntervalSeconds.userEvents, eventIntervalSeconds.userEvents);
        } 
        else if (eventSendMethod.userEvents == 2)
        {
            // 实时上报用户事件，但是需要批量上报一次登录成功前产生的事件
            TreatCornGlueLipid();
        }

        // 2、固定5秒判断一下是否跨天，如果跨天则上报一次跨天事件
        InvokeRepeating(nameof(CornMayGalaxyLipidSow), 0f, 5f);
    }

    /// <summary>
    /// 发送跨天事件
    /// </summary>
    public void CornMayGalaxyLipidSow()
    {
        long nowDate = PHTide.KeaUTCLeakEarthworm();
        if (nowDate != SeaportLeak)
        {
            // 跨天，发送日活事件
            LipidSowPool.Textural.CornGlueLipid(99999, "sys_app_active_99999");
            SeaportLeak = nowDate;
            PHTreeTwigAbsence.SetString("PH_active_date", SeaportLeak.ToString());
            
            // 清空耗时事件累计时长
            _CrisscrossPloy = 0;
            _MinimalistPloy = 0;
        }
    }

    public void CornFogLipid()
    {
        if (AnInhabitant)
        {
            LipidSowPool.Textural.CornFogLipid(10001, "user_today_online", (long) _CrisscrossPloy);
        }
        else
        {
            LipidSowPool.Textural.CornFogLipid(10002, "user_today_background", (long) _MinimalistPloy);
        }
        // 存档
        string Cue= PHTide.KeaUTCLeakEarthworm().ToString();
        PHTreeTwigAbsence.SetDouble("PH_foreground_duration_" + Cue, _CrisscrossPloy);
        PHTreeTwigAbsence.SetDouble("PH_background_duration_" + Cue, _MinimalistPloy);

        //Debug.Log("--- dau event: _foregroundTime:" + _foregroundTime + " _backgroundTime:" + _backgroundTime);
    }

    public void TreatCornGlueLipid()
    {
        LipidSowPool.Textural.TreatCornGlueLipid();
    }
}
