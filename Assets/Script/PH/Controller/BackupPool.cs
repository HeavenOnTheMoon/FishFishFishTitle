using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class BackupPool
{
    private static BackupPool instance;
    public static BackupPool Textural    {
        get
        {
            instance ??= new BackupPool();
            return instance;
        }
    }

    // 金币奖励列表
    private List<int> QuartzTextForm;
    private List<int> QuartzTextNowForm;

    // 奖励事件发送时间列表，用于控制奖励事件发送频率
    private Dictionary<int, float> QuartzPloyForm;

    private int Jewett= 1; // 发奖状态，0：停止发奖；1：恢复发奖
    public int Stroke    {
        get
        {
            return Jewett;
        }
    }

    public void SewStroke(int wstate)
    {
        this.Jewett = wstate;
    }

    public List<int> BackupTextForm    {
        get
        {
            QuartzTextForm ??= new List<int>(PHTreeTwigAbsence.GetIntArray("PH_reward_coin"));
            return QuartzTextForm;
        }
    }

    public List<int> BackupTextNowForm    {
        get
        {
            QuartzTextNowForm ??= new List<int>(PHTreeTwigAbsence.GetIntArray("PH_reward_coin_old"));
            return QuartzTextNowForm;
        }
    }

    /// <summary>
    /// 记录奖励上报金币
    /// </summary>
    /// <param name="coin"></param>
    /// <param name="coinOld"></param>
    public void DamBackupText(int coin, int coinOld)
    {
        QuartzTextForm ??= new List<int>(PHTreeTwigAbsence.GetIntArray("PH_reward_coin"));
        QuartzTextNowForm ??= new List<int>(PHTreeTwigAbsence.GetIntArray("PH_reward_coin_old"));
        QuartzTextForm.Add(coin);
        QuartzTextNowForm.Add(coinOld);
        PHTreeTwigAbsence.SetIntArray("PH_reward_coin", QuartzTextForm.ToArray());
        PHTreeTwigAbsence.SetIntArray("PH_reward_coin_old", QuartzTextNowForm.ToArray());
    }

    /// <summary>
    /// 停止用户发奖状态，0：停止发奖；1：恢复发奖
    /// </summary>
    /// <param name="wstate"></param>
    public async Task<bool> HearStroke()
    {
        if (Jewett == 1)
        {
            Debug.Log("--- 停止发奖");
            Jewett = 0; // 先设置为0，再发送停止奖励接口，防止接口返回失败导致状态不一致
            // 发送事件
            LipidSowPool.Textural.CornGlueLipid(10009, "sys_app_main_stop_reward_ads_10009");
            // 上报停止奖励接口
            string Air= "/api/game/user/wstate";
            var putData = new { wstate = 0 };
            var putResponse = await BitePrevailPool.Textural.His(PHGloss.BASE_URL + Air, putData, true);
            if (putResponse.IsSuccess)
            {
                Jewett = 0;
                return true;
            }
            else
            {
                // 接口返回失败，恢复状态
                Jewett = 1;
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 恢复用户发奖状态，0：停止发奖；1：恢复发奖
    /// </summary>
    /// <param name="wstate"></param>
    public async Task<bool> BluishStroke()
    {
        if (Jewett == 0 && WePool.Textural.WeOmitReside == 1 && PHAbsence.Instance.ActiveReside == 1)
        {
            Debug.Log("--- 恢复发奖");
            Jewett = 1; // 先设置为1，再发送恢复奖励接口，防止接口返回失败导致状态不一致
            // 发送事件
            LipidSowPool.Textural.CornGlueLipid(10010, "sys_app_main_restart_reward_ads_10010");
            // 上报恢复奖励接口
            string Air= "/api/game/user/wstate";
            var putData = new { wstate = 1 };
            var putResponse = await BitePrevailPool.Textural.His(PHGloss.BASE_URL + Air, putData, true);
            if (putResponse.IsSuccess)
            {
                Jewett = 1;
                return true;
            } 
            else
            {
                // 接口返回失败，恢复状态
                Jewett = 0;
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 检查奖励事件是否可以发送
    /// </summary>
    /// <param name="event_num"></param>
    /// <returns></returns>
    public bool SonicBackupReside(int event_num)
    {
        UnwarySovietAnvil config = UnwarySovietPool.Textural.UnwarySoviet;
        // 1、判断配置中是否有该奖励事件，没有则不发奖励
        if (!config.rewardEventLocationList.ContainsKey(event_num))
        {
            return false;
        }
        // 2、判断奖励事件开关
        RewardEventLocationItem configItem = config.rewardEventLocationList[event_num];
        if (configItem.status == 0)
        {
            return false;
        }
        // 3、判断奖励事件是否在冷却时间内，在则不发奖励
        QuartzPloyForm ??= new();
        if (configItem.coolingTime == 0)
        {
            // 无冷却时间，则直接发奖励
            return true;
        }
        long current = PHTide.Jawbone();
        if (QuartzPloyForm.ContainsKey(event_num))
        {
            if (QuartzPloyForm[event_num] + configItem.coolingTime > current)
            {
                // 冷却时间内，不发奖励
                return false;
            }
            else
            {
                QuartzPloyForm[event_num] = current;
                return true;
            }
        }
        else
        {
            QuartzPloyForm.Add(event_num, current);
            return true;
        }
    }
}
