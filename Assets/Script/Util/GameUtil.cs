using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtil : WellSweatshop<GameUtil>
{

    /// <summary>
    /// 游戏过程中，获得小额奖励
    /// </summary>
    /// <returns></returns>
    public TileReward getSmallReward()
    {
        //// 获奖概率
        if (!GliderTide.InLawyer(TugTourOil.instance.DustTwig.small_reward_chance))
        {
            return null;
        }
        TileReward result = new TileReward();
        string type = GliderTide.KeaCanoesGlider(TugTourOil.instance.DustTwig.small_reward_weight_group);
        // apple状态只能获得金币奖励
        RewardType rewardType = IsApple() ? RewardType.gold : (RewardType)Enum.Parse(typeof(RewardType), type);
        result.rewardType = rewardType;

        if (rewardType == RewardType.gold)
        {
            result.rewardValue = TugTourOil.instance.DustTwig.small_reward_gold_price * Seem.instance.TieChicSharp();
        }
        else if (rewardType == RewardType.cash)
        {
            result.rewardValue = TugTourOil.instance.DustTwig.small_reward_cash_price * Seem.instance.TieSoarSharp();
        }

        // Just For Debug
        //TileReward result = new TileReward();
        //result.rewardType = RewardType.gold;
        //result.rewardValue = 10;

        return result;
    }


    public TileReward getBigReward()
    {
        Seem.instance.WayBackupShy++;
        if (Seem.instance.WayBackupAssetPloy < TugTourOil.instance.DustTwig.big_reward_time || Seem.instance.WayBackupShy < GameConfig.BigRewardRemoveTimes)
        {
            return null;
        }

        TileReward result = new TileReward();
        string type = GliderTide.KeaCanoesGlider(TugTourOil.instance.DustTwig.big_reward_weight_group);
        // apple状态只能获得金币奖励
        RewardType rewardType = IsApple() ? RewardType.gold : (RewardType)Enum.Parse(typeof(RewardType), type);
        result.rewardType = rewardType;

        if (rewardType == RewardType.gold)
        {
            result.rewardValue = TugTourOil.instance.DustTwig.big_reward_gold_price * Seem.instance.TieChicSharp();
        }
        else if (rewardType == RewardType.cash)
        {
            result.rewardValue = TugTourOil.instance.DustTwig.big_reward_cash_price * Seem.instance.TieSoarSharp();
        }
        else if (rewardType == RewardType.amazon)
        {
            result.rewardValue = TugTourOil.instance.DustTwig.big_reward_amazon_price * Seem.instance.TieCarmanSharp();
        }
        else if (rewardType == RewardType.puzzle)
        {
            //Puzzle puzzle = SOHOShopManager.instance.GetRewardPuzzle();
            //// 如果没有进度未达到99%的碎片，则重新计算一个奖励
            //if (puzzle == null)
            //{
            //    NetInfoMgr.instance.InitData.big_reward_weight_group["puzzle"] = 0;
            //    return getBigReward();
            //}
            //else
            //{
            //    result.rewardValue = puzzle.reward_count;
            //    result.puzzle = puzzle;
            //}
        }
        return result;
    }

    // 开启星星宝箱所需星星数量
    public static int StarBoxNum()
    {
        int num = GameConfig.MaxStarNum;
        if (IsApple())
        {
            num = 300;
        }
        return num;
    }

    public static bool IsApple()
    {
        return LethalUtil.ByVague();
    }


    /// <summary>
    /// 获取multi系数
    /// </summary>
    /// <returns></returns>
    private static double GetMulti(RewardType type, double cumulative, MultiGroup[] multiGroup)
    {
        foreach (MultiGroup item in multiGroup)
        {
            if (item.max > cumulative)
            {
                if (type == RewardType.cash)
                {
                    float random = UnityEngine.Random.Range((float)TugTourOil.instance.DustTwig.cash_random[0], (float)TugTourOil.instance.DustTwig.cash_random[1]);
                    return item.multi * (1 + random);
                }
                else
                {
                    return item.multi;
                }
            }
        }
        return 1;
    }

    //public static double GetGoldMulti()
    //{
    //    return GetMulti(RewardType.gold, TreeTwigAbsence.GetDouble(CSoviet.sv_CumulativeGoldCoin), TugTourOil.instance.InitData.gold_group);
    //}

    //public static double GetCashMulti()
    //{
    //    return GetMulti(RewardType.cash, TreeTwigAbsence.GetDouble(CSoviet.sv_CumulativeToken), TugTourOil.instance.InitData.cash_group);
    //}
    //public static double GetAmazonMulti()
    //{
    //    return GetMulti(RewardType.amazon, TreeTwigAbsence.GetDouble(CSoviet.sv_CumulativeAmazon), TugTourOil.instance.InitData.amazon_group);
    //}
}


/// <summary>
/// 奖励类型
/// </summary>
public class TileReward
{
    public RewardType rewardType;
    public double rewardValue;
  //  public Puzzle puzzle;
}
public enum RewardType { gold, cash, amazon, puzzle, skill, fish }
