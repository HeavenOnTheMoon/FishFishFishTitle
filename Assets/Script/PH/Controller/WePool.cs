using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Collections.Generic;
using UnityEngine;

public class WePool
{
    public static WePool instance;
    public static WePool Textural    {
        get
        {
            instance ??= new WePool();
            if (instance.OrAllende == null)
            {
#if MAX
                instance.OrAllende ??= new WeEkaAllende();
#else
                instance.adService ??= new WeBellAllende();
#endif
            }
            
            return instance;
        }
    }

    private IWeAllende OrAllende;

    // 连续n个广告填充失败，停止发奖
    private int OrOmitReside;       // 广告填充状态：1-正常状态；0-停止发奖状态
    public int WeOmitReside{ get { return OrOmitReside; } }
    private int OrOmitDripTimes;    // 广告连续load失败次数
    private int OrOmitProdigyChina;     // 广告连续load成功次数

    private long WandAdHeelPloy;        // 上次广告播放成功时间（时间戳，不区分激励视频还是插屏），控制播放频率
    private long WandBackupHeelPloy;    // 上次激励视频广告播放成功时间

    // 广告播放触发次数，控制广告播放频率
    private Dictionary<string, int> EndlessChina;

    // 记录每日广告播放数量，控制播放限制
    private string Cue;
    private Dictionary<string, int> _OrHeelChina;
    private Dictionary<string, int> OrHeelChina    {
        get
        {
            string _utc = PHTide.KeaUTCLeakEarthworm().ToString();
            if (_utc != Cue)
            {
                Cue = _utc;
                string PH_ad_showtimes = PHTreeTwigAbsence.GetString("PH_ad_showtimes_" + Cue);
                _OrHeelChina = string.IsNullOrEmpty(PH_ad_showtimes) ? new Dictionary<string, int>() : JsonMapper.ToObject<Dictionary<string, int>>(PH_ad_showtimes);
            }
            return _OrHeelChina;
        }
    }


    // 广告播放成功回调
    private Action _OnProdigyLipid;
    public event Action OnSuccessEvent
    {
        add
        {
            _OnProdigyLipid += value;
        }
        remove
        {
            _OnProdigyLipid -= value;
        }
    }


    public void DustWe()
    {
        // 初始化MaxSDK
        OrAllende.ManipulateSDK();

        // 广告填充状态
        OrOmitReside = PlayerPrefs.HasKey("PH_ad_load_status") ? PHTreeTwigAbsence.GetInt("PH_ad_load_status") : 1;
        OrOmitDripTimes = PHTreeTwigAbsence.GetInt("PH_ad_load_fail_times");
        OrOmitProdigyChina = PHTreeTwigAbsence.GetInt("PH_ad_load_success_times");

        WandAdHeelPloy = PHTide.JawboneOval();
        EndlessChina = new Dictionary<string, int>();
    }


    /// <summary>
    /// 广告加载成功
    /// </summary>
    public async void OmitProdigy()
    {
        OrOmitProdigyChina++;
        // 如果当前状态为停止发奖状态，如果连续加载成功次数>=配置的恢复次数，则恢复发奖状态，向后台发送请求
        int continuousLoadHaveAdv = UnwarySovietPool.Textural.UnwarySoviet.rewardsStopAndRecover.continuousLoadHaveAdv; // 连续n次广告有填充，恢复发奖，0表示不开启此功能
        Debug.Log($"--- adLoadSuccessTimes: {OrOmitProdigyChina}, adLoadStatus: {OrOmitReside}, continuousLoadHaveAdv: {continuousLoadHaveAdv}");
        if ((OrOmitReside == 0 || BackupPool.Textural.Stroke == 0) && continuousLoadHaveAdv != 0 && OrOmitProdigyChina >= continuousLoadHaveAdv)
        {
            Debug.Log("--- 广告加载成功，恢复发奖");
            if (OrOmitReside == 0)
            {
                OrOmitReside = 1;   // 先设置为1，防止重复发送请求
                LipidSowPool.Textural.CornGlueLipid(10008, "sys_app_have_ads_restart_reward_10008");    // 发送有广告填充事件
            }
            
            // 向后台发送恢复发奖请求
            bool res = await BackupPool.Textural.BluishStroke();
            // 如果停止发奖请求发送失败，则恢复状态
            if (res)
            {
                OrOmitDripTimes = 0;
            }
            else
            {
                OrOmitReside = 0;
            }
        }
        TreeWeReside();
    }

    /// <summary>
    /// 广告加载失败
    /// </summary>
    public async void OmitDrip()
    {
        OrOmitDripTimes++;
        // 如果当前为正常发奖状态，如果连续加载失败次数>=配置的停止次数，则停止发奖状态，向后台发送请求
        int continuousLoadNoAdv = UnwarySovietPool.Textural.UnwarySoviet.rewardsStopAndRecover.continuousLoadNoAdv; // 连续n次广告无填充，停止发奖，0表示不开启此功能
        Debug.Log($"--- adLoadFailTimes: {OrOmitDripTimes}, adLoadStatus: {OrOmitReside}, continuousLoadNoAdv: {continuousLoadNoAdv}");
        if ((OrOmitReside == 1 || BackupPool.Textural.Stroke == 1) && continuousLoadNoAdv != 0 && OrOmitDripTimes >= continuousLoadNoAdv)
        {
            Debug.Log("--- 广告加载失败，停止发奖");
            if (OrOmitReside == 1)
            {
                OrOmitReside = 0;   // 先设置为0，防止重复发送请求
                LipidSowPool.Textural.CornGlueLipid(10007, "sys_app_no_ads_stop_reward_10007"); // 发送有广告填充事件
            }
            // 向后台发送停止发奖请求
            bool res = await BackupPool.Textural.HearStroke();
            // 如果停止发奖请求发送失败，则恢复状态
            if (res)
            {
                OrOmitProdigyChina = 0;
            } 
            else
            {
                OrOmitReside = 1;
            }
        }
        TreeWeReside();
    }

    private void TreeWeReside()
    {
        PHTreeTwigAbsence.SetInt("PH_ad_load_status", OrOmitReside);
        PHTreeTwigAbsence.SetInt("PH_ad_load_fail_times", OrOmitDripTimes);
        PHTreeTwigAbsence.SetInt("PH_ad_load_success_times", OrOmitProdigyChina);
    }

    /// <summary>
    /// 获取广告事件代码，每个广告唯一
    /// </summary>
    /// <returns></returns>
    public string KeaLipidSing()
    {
        string Cue= PHTide.KeaUTCLeakEarthworm().ToString();
        int showOrder = PHTreeTwigAbsence.GetInt("PH_ad_order_" + Cue);
        showOrder++;
        PHTreeTwigAbsence.SetInt("PH_ad_order_" + Cue, showOrder);
        return PHAbsence.Instance.Alter + DailyPool.Textural.GlueTour.uid + Cue + showOrder;
    }

    private async UniTask OntoDaily()
    {
        await UniTask.WaitUntil(() =>
        {
            return DailyPool.Textural.ByDaily;
        });
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="num"></param>
    public async void BeerContributionWe(int adLocationId, Action<bool> callback = null, int num = 1)
    {
        if (EndlessChina == null)   // 说明此时广告还没初始化，不播放广告
        {
            callback?.Invoke(false);
            return;
        }

        // 增加触发次数
        if (!EndlessChina.ContainsKey("interstitial_" + adLocationId))
        {
            EndlessChina.Add("interstitial_" + adLocationId, 0);
        }
        EndlessChina["interstitial_" + adLocationId] += num;

        // 判断广告位是否有播放限制
        CheckAdCanShowRes checkRes = SonicWeTugHeel(AdType.Interstitial, adLocationId);
        if (!checkRes.AnyHeel)
        {
#if TEST_MODE
            if (adLocationId != 10001)
            {
                Debug.Log("--- " + checkRes.reason);
            }
#endif
            callback?.Invoke(false);
            return;
        }

        await OntoDaily();

        OrAllende.HeelContributionWe(adLocationId, (success) =>
        {
            if (success)
            {
                // 每个广告位当天的播放数量存档
                if (!OrHeelChina.ContainsKey("interstitial"))
                {
                    OrHeelChina.Add("interstitial", 0);
                }
                OrHeelChina["interstitial"] += 1;
                if (!OrHeelChina.ContainsKey("interstitial_" + adLocationId.ToString()))
                {
                    OrHeelChina.Add("interstitial_" + adLocationId.ToString(), 0);
                }
                OrHeelChina["interstitial_" + adLocationId.ToString()] += 1;
                PHTreeTwigAbsence.SetString("PH_ad_showtimes_" + Cue, JsonMapper.ToJson(OrHeelChina));

                WandAdHeelPloy = PHTide.JawboneOval();
                EndlessChina["interstitial_" + adLocationId] = 0;

                _OnProdigyLipid?.Invoke();
            }
            callback?.Invoke(success);
        });
    }



    /// <summary>
    /// 播放激励视频
    /// </summary>
    /// <param name="adLocationId"></param>
    public async void BeerBackupWe(int adLocationId, Action<bool> callback)
    {
        // 增加触发次数
        if (!EndlessChina.ContainsKey("rewarded_" + adLocationId))
        {
            EndlessChina.Add("rewarded_" + adLocationId, 0);
        }
        EndlessChina["rewarded_" + adLocationId] += 1;

        // 判断广告位是否有播放限制
        CheckAdCanShowRes checkRes = SonicWeTugHeel(AdType.Reward, adLocationId);
        if (!checkRes.AnyHeel)
        {
#if TEST_MODE
            Debug.Log("--- " + checkRes.reason);
            PHUIAbsence.Instance.ShowToast(checkRes.reason);
#else
            PHUIAbsence.Textural.HeelSpare("Please try again later...");
#endif
            callback?.Invoke(false);
            return;
        }

        await OntoDaily();

        OrAllende.HeelAdjacentWe(adLocationId, (success) =>
        {
            if (success)
            {
                // 每个广告位当天的播放数量存档
                if (!OrHeelChina.ContainsKey("rewarded"))
                {
                    OrHeelChina.Add("rewarded", 0);
                }
                OrHeelChina["rewarded"] += 1;
                if (!OrHeelChina.ContainsKey("rewarded_" + adLocationId.ToString()))
                {
                    OrHeelChina.Add("rewarded_" + adLocationId.ToString(), 0);
                }
                OrHeelChina["rewarded_" + adLocationId.ToString()] += 1;
                PHTreeTwigAbsence.SetString("PH_ad_showtimes_" + Cue, JsonMapper.ToJson(OrHeelChina));

                WandAdHeelPloy = PHTide.JawboneOval();
                WandBackupHeelPloy = PHTide.JawboneOval();
                EndlessChina["rewarded_" + adLocationId] = 0;

                _OnProdigyLipid?.Invoke();
            }
            callback?.Invoke(success);
        });
    }

    /// <summary>
    /// 当前是否可以展示广告
    /// </summary>
    /// <returns></returns>
    private CheckAdCanShowRes SonicWeTugHeel(AdType adType, int adLocationId = -1)
    {
        // 如果长时间无操作，不展示广告
        if (PHAbsence.Instance.ActiveReside == 0) return new CheckAdCanShowRes { AnyHeel = false, Estate = "Not activity" };

        if (OrAllende.AnGunfire) return new CheckAdCanShowRes { AnyHeel = false, Estate = "Ad is showing" };

        UnwarySovietAnvil config = UnwarySovietPool.Textural.UnwarySoviet;

        // 判断是否是新用户，新用户不展示广告
        if (adType != AdType.Reward && config.newUserSaveNoAdv != null
            && (!PlayerPrefs.HasKey("PH_ad_not_new_user" + "Bool") || !PHTreeTwigAbsence.GetBool("PH_ad_not_new_user"))) 
            return new CheckAdCanShowRes { AnyHeel = false, Estate = "New user" };

        // 判断是否超出了单个广告位的播放限制
        // 需要判断广告位是否有播放限制
        string key = "";
        switch (adType)
        {
            case AdType.Reward:
                key = "rewarded_" + adLocationId.ToString();
                break;
            case AdType.Interstitial:
                key = "interstitial_" + adLocationId.ToString();
                break;
            case AdType.Banner:
                key = "banner_" + adLocationId.ToString();
                break;
        }

        // 判断是否超出了类型的播放限制
        if (adType == AdType.Reward)
        {
            if (config.advRuleRewarded != null
                && config.advRuleRewarded.showTimesPerDay > 0
                && OrHeelChina.ContainsKey("rewarded")
                && OrHeelChina["rewarded"] >= config.advRuleRewarded.showTimesPerDay)
            {
                return new CheckAdCanShowRes { AnyHeel = false, Estate = "Exceeding the ad type limit" }; ;
            }
            if (PHTide.JawboneOval() - WandBackupHeelPloy < config.advRuleRewarded.showTimeIntervalSeconds * 1000)
            {
                return new CheckAdCanShowRes { AnyHeel = false, Estate = "Not enough time interval" };
            }
        }
        else if (adType == AdType.Interstitial)
        {
            if (config.advRuleInterstitial != null
                && config.advRuleInterstitial.showTimesPerDay > 0
                && OrHeelChina.ContainsKey("interstitial")
                && OrHeelChina["interstitial"] >= config.advRuleInterstitial.showTimesPerDay)
            {
                return new CheckAdCanShowRes { AnyHeel = false, Estate = "Exceeding the ad type limit" };
            }
            // 判断播放间隔
            if (PHTide.JawboneOval() - WandAdHeelPloy < config.advRuleInterstitial.showTimeIntervalSeconds * 1000)
            {
                return new CheckAdCanShowRes { AnyHeel = false, Estate = "Not enough time interval" };
            }
        }
        else if (adType == AdType.Banner)
        {
            if (config.advRuleBanner != null
                && config.advRuleBanner.showTimesPerDay > 0
                && OrHeelChina.ContainsKey("banner")
                && OrHeelChina["banner"] >= config.advRuleBanner.showTimesPerDay)
            {
                return new CheckAdCanShowRes { AnyHeel = false, Estate = "Exceeding the ad type limit" };
            }
        }

        // 判断是否超出了广告位播放限制
        // 没有配置广告位或者广告位开关为0，则不播广告
        if (!config.advLocationIsOpen.ContainsKey(key)) return new CheckAdCanShowRes { AnyHeel = false, Estate = "Has no ad location" };
        if (config.advLocationIsOpen[key].status == 0) return new CheckAdCanShowRes { AnyHeel = false, Estate = "Ad location is closed" };

        if (OrHeelChina.ContainsKey(key) && config.advLocationIsOpen[key].advLocationIdShowTimesPerDay > 0)
        {
            if (OrHeelChina[key] >= config.advLocationIsOpen[key].advLocationIdShowTimesPerDay)
                return new CheckAdCanShowRes { AnyHeel = false, Estate = "Exceeding the ad position limit" };
        }

        // 判断是否满足触发次数限制
        if (EndlessChina[key] < config.advLocationIsOpen[key].triggerTimesToDisplayAd)
        {
            return new CheckAdCanShowRes { AnyHeel = false, Estate = "Not enough trigger times" };
        }

        return new CheckAdCanShowRes { AnyHeel = true, Estate = "" };
    }

    private int ItemBeerReside= 1;    // 自动播放插屏广告状态，1-开启；0-关闭
    /// <summary>
    /// 暂停定时插屏广告计时
    /// </summary>
    public void AdultRomeBeerPloy()
    {
        ItemBeerReside = 0;
    }
    /// <summary>
    /// 恢复定时插屏广告计时
    /// </summary>
    public void BluishRomeBeerPloy()
    {
        ItemBeerReside = 1;
    }

    /// <summary>
    /// 增加在线时长，更新新用户免广告规则值
    /// 自动播放插屏广告
    /// </summary>
    /// <param name="seconds"></param>
    public void DamAthensEmotive(int seconds = 1)
    {
        if (ItemBeerReside == 0) return;

        if (UnwarySovietPool.Textural.UnwarySoviet.newUserSaveNoAdv.ruleClass == 1)
        {
            if (!PlayerPrefs.HasKey("PH_ad_not_new_user" + "Bool") || !PHTreeTwigAbsence.GetBool("PH_ad_not_new_user"))
            {
                DamTarGlueRageAttic(seconds);
            }
        }

        // 如果长时间无操作，暂停定时插屏广告计时
        if (PHAbsence.Instance.ActiveReside == 0)
        {
            return;
        }

        BeerContributionWe(10001, null, seconds);
    }

    /// <summary>
    /// 增加前后台切换次数
    /// 自动播放插屏广告
    /// </summary>
    /// <param name="num"></param>
    public void DamAdultChina(int num = 1)
    {
        BeerContributionWe(10002, null, num);
    }

    /// <summary>
    /// 增加过关次数
    /// </summary>
    /// <param name="num"></param>
    public void DamRustExact(int num = 1)
    {
        // 增加新用户免广告对应的值
        if (UnwarySovietPool.Textural.UnwarySoviet.newUserSaveNoAdv.ruleClass == 2)
        {
            DamTarGlueRageAttic(num);
        }
    }

    /// <summary>
    /// 增加新用户免广告对应的值
    /// 如果规则是1（时间类型），则表示增加在线时长
    /// 如果规则是2（次数类型），则表示增加过关次数
    /// </summary>
    /// <param name="num"></param>
    public void DamTarGlueRageAttic(int num = 1)
    {
        if (PlayerPrefs.HasKey("PH_ad_not_new_user" + "Bool") && PHTreeTwigAbsence.GetBool("PH_ad_not_new_user")) return;

        // 增加过关次数/在线时长
        double adNoUserValue = PHTreeTwigAbsence.GetDouble("PH_ad_new_user_value");
        adNoUserValue += num;
        PHTreeTwigAbsence.SetDouble("PH_ad_new_user_value", adNoUserValue);
        // 如果超过了规则值，则不再是新用户
        if (adNoUserValue >= UnwarySovietPool.Textural.UnwarySoviet.newUserSaveNoAdv.ruleValue)
        {
            PHTreeTwigAbsence.SetBool("PH_ad_not_new_user", true);
        }
    }

    public bool ByWeGunfire()
    {
        return OrAllende == null ? false : OrAllende.AnGunfire;
    }
}

// 广告类型，1：reward；2：interstitial；3：banner
public enum AdType
{
    None,
    Reward,
    Interstitial,
    Banner
}

public class CheckAdCanShowRes
{
    public bool AnyHeel;
    public string Estate;
}