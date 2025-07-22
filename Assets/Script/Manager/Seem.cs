using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum RewardFrom
{
    LevelPass,
    HomeBank,
    LevelBank
}
public class Seem : MonoBehaviour
{
    public static Seem instance;
[UnityEngine.Serialization.FormerlySerializedAs("levelCreate")]    public ExactOmitAbsorb ApartAbsorb;
[UnityEngine.Serialization.FormerlySerializedAs("tileSelectGroup")]    public GameObject DeadPackerAsian;
[UnityEngine.Serialization.FormerlySerializedAs("FishManagerObj")]    public GameObject FareAbsenceShy;
[UnityEngine.Serialization.FormerlySerializedAs("cashShowNumber")]    public string WhimHeelSupply;
[UnityEngine.Serialization.FormerlySerializedAs("goldShowNumber")]    public string DivaHeelSupply;
[UnityEngine.Serialization.FormerlySerializedAs("amazonShowNumber")]    public string ActionHeelSupply;
[UnityEngine.Serialization.FormerlySerializedAs("expShowNumber")]    public int OffHeelSupply;
[UnityEngine.Serialization.FormerlySerializedAs("userLevelShowNumber")]    public int GrayExactHeelSupply;
[UnityEngine.Serialization.FormerlySerializedAs("starBoxShowExp")]    public int GiftNetHeelBut;
[UnityEngine.Serialization.FormerlySerializedAs("haveNeedUnlockFishTank")]    public bool KnowChugInsertFareSeep;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("BigRewardStartTime")]    public int WayBackupAssetPloy; // 大额奖励上次初始时间
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("BigRewardNum")]    public int WayBackupShy;    // 大额奖励消除次数
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("BigReward")]    public TileReward WayBackup;    // 大额奖励
    private Coroutine UseBackupNonporous;
    private bool AnGarden= false;
    /// <summary>
    /// 初始金币
    /// </summary>
    [Header("初始金币")]
[UnityEngine.Serialization.FormerlySerializedAs("initGoldValue")]    public int AsiaChicAttic;
    /// <summary>
    /// 初始现金
    /// </summary>
    [Header("初始现金")]
[UnityEngine.Serialization.FormerlySerializedAs("initCashValue")]    public float AsiaSoarAttic;

    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("GuideTiles")]    public string[][] WeedySixth= { new string[] { "8", "11" }, new string[] { "10", "11" }, new string[] { "12", "11" } };

    private void OnApplicationFocus(bool focus)
    {
        
    }
    void Awake()
    {
        Application.targetFrameRate = 60;
        instance = this;
    }

    
    /// <summary>
    /// 游戏初始化
    /// </summary>
    public void AnewDust()
    {
        if (!TreeTwigAbsence.GetBool(CSoviet.Or_ByTarExcite))
        {
            TreeTwigAbsence.SetInt(CSoviet.Or_GlueExact, 1);
            TreeTwigAbsence.SetInt(CSoviet.Or_PackerFareSeep, 2);
            TreeTwigAbsence.SetIntArray(CSoviet.Or_InsertFareSeepForm, new int[] { 0 });
            TreeTwigAbsence.SetInt(CSoviet.Or_PeruNetExact, 1);
            TreeTwigAbsence.SetInt(CSoviet.Or_BrushSedgeTrapJay, System.DateTime.Now.Day);
            //addGold(initGoldValue);
            //addCash(initCashValue);
            TreeTwigAbsence.SetBool(CSoviet.Or_ByTarExcite, true);
            if (LethalUtil.ByVague())
            {
                TreeTwigAbsence.SetBool(CSoviet.Or_TarGlueSpin + "1-1", true);
                TreeTwigAbsence.SetBool(CSoviet.Or_TarGlueSpin + "1-2", true);
                TreeTwigAbsence.SetBool(CSoviet.Or_TarGlueSpin + "1-3", true);
                TreeTwigAbsence.SetBool(CSoviet.Or_TarGlueSpin + "3", true);
            }
        }

        TugTourOil.instance.KeaReindeerTwig();

        FareAbsenceShy.SetActive(true);

        DivaHeelSupply = SupplyTide.InvestAtFir(TieChic());

        WhimHeelSupply = SupplyTide.InvestAtFir(TieSoar());

        ActionHeelSupply = SupplyTide.InvestAtFir(TieCarman());

        OffHeelSupply = TieBut();

        GiftNetHeelBut = TiePeruNetBut();
        List<int> unlockFishTankList = new List<int>(TreeTwigAbsence.GetIntArray(CSoviet.Or_InsertFareSeepForm));

        for (int i = 0; i < TugTourOil.instance.AnewTwig.AquariumShop.Count; i++)
        {
            AquariumShopItemData aquariumData = TugTourOil.instance.AnewTwig.AquariumShop[i];
            if (aquariumData.UnlockValue <= TiePastFareStyle() && !unlockFishTankList.Contains(i))
            {
                unlockFishTankList.Add(i);
            }
        }

        TreeTwigAbsence.SetIntArray(CSoviet.Or_InsertFareSeepForm, unlockFishTankList.ToArray());
        GrayExactHeelSupply = TieGlueExact();
        ThereOil.KeaTextural().BeerMy(ThereTern.UIMusic.Sound_TileFishBGM);
        ApartAsset();

        // 上报奖励事件 - 每日首次打开app
        string _utc = KeaUTCLeakEarthworm().ToString();
        if (!_utc.Equals(TreeTwigAbsence.GetString("app_open_time")))
        {
            LipidSowPool.Textural.CornBackupLipid(1401, "app_first_open_per_1401");
            TreeTwigAbsence.SetString("app_open_time", _utc);
        }
    }

    // 0时区0点时间戳
    public long KeaUTCLeakEarthworm()
    {
        DateTime todayUTC = DateTime.UtcNow.Date; // 获取当天0点UTC时间
        DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        return (long)(todayUTC - epoch).TotalSeconds;
    }
    /// <summary>
    /// 关卡开始
    /// </summary>
    public void ApartAsset()
    {
        LipidSowPool.Textural.CornBackupLipid(1403, "game_start_1403");
        ApartAbsorb.gameObject.SetActive(true);
        DeadPackerAsian.SetActive(true);
        ApartAbsorb.AsiaExact();

        if (UseBackupNonporous == null)
        {
            UseBackupNonporous = StartCoroutine(RidWayBackupPloy());
        }
        
    }

    public void resetWayBackupPloy()
    {
        WayBackupAssetPloy = 0;
        WayBackupShy = 0;
    }

    public void StemWayBackupPloy()
    {
        if (UseBackupNonporous != null)
        {
            StopCoroutine(UseBackupNonporous);
            UseBackupNonporous = null;
        }
    }
    public void SewSeemGarden(bool isfinish)
    {
        AnGarden = isfinish;
    }

    public bool KeaSeemGarden()
    {
        return AnGarden;
    }
    /// <summary>
    /// 关卡通过
    /// </summary>
    public void ApartAnyplace()
    {
        
        ApartAbsorb.gameObject.SetActive(false);
        DeadPackerAsian.SetActive(false);
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactKrill_Lira);
    }
    /// <summary>
    /// 广告通过关卡
    /// </summary>
    public Dictionary<string,int> OrExactGarden()
    {
        double cashNumber = Seem.instance.TieExactRustSoar();
        Seem.instance.RidSoar(cashNumber);
        Dictionary<string, int> dic = new Dictionary<string, int>();
        dic.Add("cash", (int)cashNumber);
        return dic;
    }
    /// <summary>
    /// 关卡结束
    /// </summary>
    public void ApartGarden()
    {
        //PostEventScript.GetInstance().SendEvent("1207", levelCreate.levelNumber.ToString(), levelCreate.mainData.target.Count.ToString());
        Seem.instance.AnewAdultDownYam();
        ApartAbsorb.GetComponent<ExactBeer>().AnyStump = false;
        ApartAbsorb.LiraMailAstronaut(()=> { 
            ApartAbsorb.gameObject.SetActive(false);
            DeadPackerAsian.SetActive(false);
            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactKrill_Lira);
            Seem.instance.ValidSeemAdultDownYam();
        });
    }
    /// <summary>
    /// 屏蔽游戏全部操作
    /// </summary>
    public void AnewAdultDownYam()
    {
        ApartAbsorb.GetComponent<ExactBeer>().AnyStump = false;
        UIAbsence.KeaTextural().HeelUIDrape(nameof(BackupKrill));
    }
    /// <summary>
    /// 取消全部屏蔽
    /// </summary>
    public void ValidSeemAdultDownYam()
    {
        //if(TreeTwigAbsence.GetBool(CSoviet.sv_NewUserStep + "1-2"))
        //{
        //    levelCreate.GetComponent<ExactBeer>().canTouch = true;
        //    UIAbsence.GetInstance().CloseOrReturnUIForms("BackupKrill");
        //}

        ApartAbsorb.GetComponent<ExactBeer>().AnyStump = true;
        UIAbsence.KeaTextural().StarkIDDecodeUIDrape("BackupKrill");
    }
    /// <summary>
    /// 获取现金alpha系数
    /// </summary>
    /// <returns></returns>
    public float TieSoarSharp()
    {
        float random = UnityEngine.Random.Range((float)TugTourOil.instance.DustTwig.cash_random[0], (float)TugTourOil.instance.DustTwig.cash_random[1]);
        double cumulativeCash = TreeTwigAbsence.GetDouble(CSoviet.Or_SkepticismSoarSupply);
        foreach (GroupItem item in TugTourOil.instance.DustTwig.cash_group)
        {
            if (item.max > cumulativeCash)
            {

                return item.multi * (1 + random);
            }
        }
        return 1;
    }
 

    /// <summary>
    /// 获取金币alpha系数
    /// </summary>
    /// <returns></returns>
    public int TieChicSharp()
    {
        double cumulativeGold = TreeTwigAbsence.GetDouble(CSoviet.Or_SkepticismChicSupply);
        foreach (GroupItem item in TugTourOil.instance.DustTwig.gold_group)
        {
            if (item.max > cumulativeGold)
            {

                return item.multi;
            }
        }
        return 1;
    }


    /// <summary>
    /// 获取amazon alpha系数
    /// </summary>
    /// <returns></returns>
    public int TieCarmanSharp()
    {
        double cumulativeAmazon = TreeTwigAbsence.GetDouble(CSoviet.Or_SkepticismCarmanSupply);
        foreach (GroupItem item in TugTourOil.instance.DustTwig.amazon_group)
        {
            if (item.max > cumulativeAmazon)
            {

                return item.multi;
            }
        }
        return 1;
    }

    /// <summary>
    /// 加金币
    /// </summary>
    /// <param name="gold_num"></param>
    public void RidChic(double gold_num, Transform transform = null)
    {
        double num = TieChic();
        num += gold_num;
        TreeTwigAbsence.SetDouble(CSoviet.Or_ChicSupply, num);
        HandfulTwig md = new HandfulTwig(transform);
        md.TroutInvest = gold_num;
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactKrill_DamChic, md);

        double cumulativeGold = TreeTwigAbsence.GetDouble(CSoviet.Or_SkepticismChicSupply);
        cumulativeGold += gold_num;
        TreeTwigAbsence.SetDouble(CSoviet.Or_SkepticismChicSupply, cumulativeGold);
    }
    /// <summary>
    /// 减金币
    /// </summary>
    /// <param name="gold_num"></param>
    public void GunChic(double gold_num)
    {
        double num = TieChic();
        num -= gold_num;
        DivaHeelSupply = SupplyTide.InvestAtFir(num);
        TreeTwigAbsence.SetDouble(CSoviet.Or_ChicSupply, num);
        HandfulTwig md = new HandfulTwig(-gold_num);
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactKrill_DamChic, md);
    }
    /// <summary>
    /// 获取金币
    /// </summary>
    /// <returns></returns>
    public double TieChic()
    {
        return TreeTwigAbsence.GetDouble(CSoviet.Or_ChicSupply);
    }
    /// <summary>
    /// 加现金
    /// </summary>
    /// <param name="cash_num"></param>
    public void RidSoar(double cash_num, Transform transform = null)
    {
        double num = TieSoar();
        num += cash_num;
        TreeTwigAbsence.SetDouble(CSoviet.Or_SoarSupply, num);
        //SOHOShopManager.instance.AddCash(cash_num);
        HandfulTwig md = new HandfulTwig(transform);
        md.TroutInvest = cash_num;
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactKrill_DamSoar, md);

        double cumulativeCash = TreeTwigAbsence.GetDouble(CSoviet.Or_SkepticismSoarSupply);
        cumulativeCash += cash_num;
        TreeTwigAbsence.SetDouble(CSoviet.Or_SkepticismSoarSupply, cumulativeCash);
    }
    /// <summary>
    /// 减现金
    /// </summary>
    /// <param name="cash_num"></param>
    public void GunSoar(double cash_num)
    {
        double num = TieSoar();
        num -= cash_num;
        WhimHeelSupply = SupplyTide.InvestAtFir(num);
        TreeTwigAbsence.SetDouble(CSoviet.Or_SoarSupply, num);
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactKrill_DamSoar, new HandfulTwig(-cash_num));
    }
    /// <summary>
    /// 获取现金
    /// </summary>
    /// <returns></returns>
    public double TieSoar()
    {
        return TreeTwigAbsence.GetDouble(CSoviet.Or_SoarSupply);
    }

    /// <summary>
    /// 增加Amazon卡
    /// </summary>
    /// <returns></returns>
    public void RidCarman(double amazon_num, Transform transform = null)
    {
        double num = TieCarman();
        num += amazon_num;
        TreeTwigAbsence.SetDouble(CSoviet.Or_CarmanSupply, num);
        HandfulTwig md = new HandfulTwig(transform);
        md.TroutInvest = amazon_num;
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactKrill_DamCarman, md);

        double cumulativeAmazon = TreeTwigAbsence.GetDouble(CSoviet.Or_SkepticismCarmanSupply);
        cumulativeAmazon += amazon_num;
        TreeTwigAbsence.SetDouble(CSoviet.Or_SkepticismCarmanSupply, cumulativeAmazon);
    }
    public void GunCarman(double amazon_num)
    {
        double num = TieCarman();
        num -= amazon_num;
        ActionHeelSupply = SupplyTide.InvestAtFir(num);
        TreeTwigAbsence.SetDouble(CSoviet.Or_CarmanSupply, num);
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactKrill_DamCarman, new HandfulTwig(-amazon_num));
    }

    public double TieCarman()
    {
        return TreeTwigAbsence.GetDouble(CSoviet.Or_CarmanSupply);
    }

    /// <summary>
    /// 获取通关现金奖励
    /// </summary>
    /// <returns></returns>
    public double TieExactRustSoar()
    {
        double baseCash = TugTourOil.instance.DustTwig.passlevel_cash_price;
        int passLevel = TreeTwigAbsence.GetInt(CSoviet.Or_SoarExactPass);
        passLevel++;
        float levelPassCashNumber = 0;
        
        TreeTwigAbsence.SetInt(CSoviet.Or_SoarExactPass, passLevel);
        return levelPassCashNumber;
    }

    /// <summary>
    /// 增加经验
    /// </summary>
    /// <param name="exp"></param>
    public void RidBut(int exp)
    {
        GameData AnewTwig= TugTourOil.instance.AnewTwig;
        int now_exp = TieBut();
        now_exp += exp;
        int now_level = TieGlueExact();
        UserLevelItemData next_level_data = null;
        foreach (UserLevelItemData leveldata in AnewTwig.UserLevel)
        {
            if (leveldata.Level > now_level)
            {
                next_level_data = leveldata;
                int nextNeedExp = next_level_data.Exp;
                if (nextNeedExp <= now_exp)
                {
                    now_exp -= nextNeedExp;
                    now_level++;
                } 
                else
                {
                    break;
                }
            }
        }
        TreeTwigAbsence.SetInt(CSoviet.Or_GlueBut, now_exp);
        TreeTwigAbsence.SetInt(CSoviet.Or_GlueExact, now_level);
    }
    /// <summary>
    /// 获取当前经验
    /// </summary>
    /// <returns></returns>
    public int TieBut()
    {
        return TreeTwigAbsence.GetInt(CSoviet.Or_GlueBut);
    }
    /// <summary>
    /// 获取升级进度
    /// </summary>
    /// <returns></returns>
    public float TieHeelExactOrUntapped()
    {
        GameData AnewTwig= TugTourOil.instance.AnewTwig;
        int now_level = GrayExactHeelSupply;
        int nowExp = OffHeelSupply;
        UserLevelItemData next_level_data = null;
        foreach (UserLevelItemData leveldata in AnewTwig.UserLevel)
        {
            if (leveldata.Level > now_level)
            {
                next_level_data = leveldata;
                break;
            }
        }
        int nextNeedExp = next_level_data.Exp;
        return (float)nowExp / (float)nextNeedExp;
    }
    /// <summary>
    /// 获取实际升级进度
    /// </summary>
    /// <returns></returns>
    public float TieFeedExactOrUntapped()
    {
        GameData AnewTwig= TugTourOil.instance.AnewTwig;
        int now_level = TieGlueExact();
        int nowExp = TieBut();
        UserLevelItemData next_level_data = null;
        foreach (UserLevelItemData leveldata in AnewTwig.UserLevel)
        {
            if (leveldata.Level > now_level)
            {
                next_level_data = leveldata;
                break;
            }
        }
        int nextNeedExp = next_level_data.Exp;
        return (float)nowExp / (float)nextNeedExp;
    }
    /// <summary>
    /// 获取当前等级
    /// </summary>
    /// <returns></returns>
    public int TieGlueExact()
    {
        return TreeTwigAbsence.GetInt(CSoviet.Or_GlueExact);
    }
    /// <summary>
    /// 获取商店鱼的状态
    /// </summary>
    /// <returns></returns>
    public int TieFareTern(int fish_index)
    {
        GameData AnewTwig= TugTourOil.instance.AnewTwig;
        if (AnewTwig.FishShop.Count > fish_index)
        {
            FishShopItemData lastItemData = null;
            if (fish_index > 0)
            {
                lastItemData = AnewTwig.FishShop[fish_index - 1];
            }
            FishShopItemData itemData = AnewTwig.FishShop[fish_index];
            if (itemData.UnlockType == "level")
            {
                if (itemData.UnlockValue <= TieGlueExact())
                {
                    //解锁状态
                    return 0;
                }
                else
                {
                    if (lastItemData != null)
                    {
                        if (lastItemData.UnlockValue <= TieGlueExact())
                        {
                            //即将解锁
                            return 1;
                        }
                        else
                        {
                            //锁定状态
                            return 2;
                        }
                    }
                    else
                    {
                        //锁定状态
                        return 1;
                    }
                }
            }
        }
        return 0;
    }
    /// <summary>
    /// 获取商店鱼的价格
    /// </summary>
    /// <param name="fish_index"></param>
    /// <returns></returns>
    public int TieOntoFareHurry(int fish_index)
    {
        GameData AnewTwig= TugTourOil.instance.AnewTwig;

        if (AnewTwig.FishShop.Count > fish_index)
        {
            FishShopItemData itemData = TugTourOil.instance.AnewTwig.FishShop[fish_index];
            int basePrice = itemData.BasePrice;
            int buyCount = TreeTwigAbsence.GetInt(CSoviet.Or_FareStyle + fish_index);
            if (!LethalUtil.ByVague() && fish_index == 0)
            {
                buyCount--;
            }
            int addPrice = itemData.AddPrice;
            int nowPrice = basePrice + buyCount * addPrice;
            return nowPrice;
        }
        return 0;
    }
    /// <summary>
    /// 购买鱼
    /// </summary>
    /// <param name="fish_index"></param>
    /// <returns></returns>
    public int buyFare(int fish_index)
    {
        //if (getGold() >= getShopFishPrice(fish_index) && getNowTankHaveFishCount() < 25)
        //{
        //    subGold(getShopFishPrice(fish_index));
        //    FareAbsence.instance.AddFish(fish_index);
        //    return 1;
        //}
        //else
        //{
        //    if (getGold() < getShopFishPrice(fish_index))
        //    {
        //        return 2;
        //    }
        //    if (getNowTankHaveFishCount() >= 25)
        //    {
        //        return 3;
        //    }
        //}
        FareAbsence.instance.DamFare(fish_index);
        return 1;
    }
    /// <summary>
    /// 获取即将解锁的鱼
    /// </summary>
    public int TieGenuInsertFareTwig()
    {
        
        List<string> fishUnlockList = new List<string>(TreeTwigAbsence.GetStringArray(CSoviet.Or_InsertFareForm));
        foreach (FishShopItemData data in TugTourOil.instance.AnewTwig.FishShop)
        {
            if (data.UnlockType == "level")
            {
                if (!fishUnlockList.Contains(data.Name))
                {
                    if (GrayExactHeelSupply >= data.UnlockValue)
                    {
                        fishUnlockList.Add(data.Name);
                        TreeTwigAbsence.SetStringArray(CSoviet.Or_InsertFareForm, fishUnlockList.ToArray());
                    }
                    else
                    {
                        return TugTourOil.instance.AnewTwig.FishShop.IndexOf(data);
                    }
                }
            }
        }
        return 0;
    }
    /// <summary>
    /// 获取拥有鱼的数量
    /// </summary>
    /// <returns></returns>
    public int TiePastFareStyle()
    {
        int count = 0;
        for (int i = 0; i < TugTourOil.instance.AnewTwig.FishShop.Count; i++)
        {
            count += TreeTwigAbsence.GetInt(CSoviet.Or_FareStyle + i);
        }
        return count;
    }
    /// <summary>
    /// 获取当前鱼缸拥有鱼的数量
    /// </summary>
    /// <returns></returns>
    public int TieNowSeepPastFareStyle()
    {
        int Calve= TreeTwigAbsence.GetInt(CSoviet.Or_PackerFareSeep);
        int tankFishCount = TreeTwigAbsence.GetIntArray(CSoviet.Or_SeepPastFareForm).Length;
        return tankFishCount;
    }
    /// <summary>
    /// 星星宝箱放鱼
    /// </summary>
    /// <param name="rewardFishIndex"></param>
    List<int> ArchSeepForm= new List<int>(new int[] { 2, 1, 3, 0, 4 });
    List<int> ArchSeepInsertForm= new List<int>(new int[] { 2, 10, 20, 30 });
    public void PeruNetSlowFare(int rewardFishIndex)
    {
        Seem.instance.AnewAdultDownYam();
        ApartAbsorb.GetComponent<ExactBeer>().AnyStump = false;
        ApartAbsorb.gameObject.SetActive(false);
        DeadPackerAsian.SetActive(false);
        Seem.instance.buyFare(rewardFishIndex);
        
        StartCoroutine(SlowGardenOntoPloy(rewardFishIndex));
    }
    IEnumerator SlowGardenOntoPloy(int rewardFishIndex)
    {
        //yield return new WaitForSeconds(1f);
        int fishCount = TreeTwigAbsence.GetIntArray(CSoviet.Or_SeepPastFareForm).Length;
        //if (fishTankUnlockList.Contains(fishCount))
        //{
        //    int index = fishTankUnlockList.IndexOf(fishCount) + 1;
        //}
        FareAbsence.instance.EuropeFareSeep(ArchSeepForm[(fishCount - 1) % 5]);
        yield return new WaitForSeconds(2f);
        
        ApartAbsorb.HeelMailAstronaut(() =>
        {
            Seem.instance.ValidSeemAdultDownYam();
            ApartAbsorb.GetComponent<ExactBeer>().AnyStump = true;
            if (!GameUtil.IsApple() && (!PlayerPrefs.HasKey(CSoviet.Or_Error_News + "Bool") || !TreeTwigAbsence.GetBool(CSoviet.Or_Error_News)))
            {
                UIAbsence.KeaTextural().HeelUIDrape(nameof(MustKrill));
            }
        });
        ApartAbsorb.gameObject.SetActive(true);
        DeadPackerAsian.SetActive(true);
    }
    /// <summary>
    /// 获取等级所需经验
    /// </summary>
    public int TieExactChugBut(int level)
    {
        foreach (UserLevelItemData data in TugTourOil.instance.AnewTwig.UserLevel)
        {
            if (data.Level >= level)
            {
                return data.Exp;
            }
        }
        return 100;
    }
    /// <summary>
    /// 获取鱼缸是否满足解锁条件
    /// </summary>
    public bool TieFareSeepByInsert(int index)
    {
        AquariumShopItemData Luck= TugTourOil.instance.AnewTwig.AquariumShop[index];
        int fishCount = TiePastFareStyle();
        if (LethalUtil.ByVague())
        {
            fishCount++;
        }
        if (Luck.UnlockValue <= fishCount)
        {
            return true;
        }
        return false;
    }
    /// <summary>
    /// 获取满足条件未解锁鱼缸
    /// </summary>
    public int TieFareSeepChugInsert()
    {
        List<int> unlockFishTankList = new List<int>(TreeTwigAbsence.GetIntArray(CSoviet.Or_InsertFareSeepForm));
        for (int i = 0; i < TugTourOil.instance.AnewTwig.AquariumShop.Count; i++)
        {
            AquariumShopItemData aquariumData = TugTourOil.instance.AnewTwig.AquariumShop[i];
            if (aquariumData.UnlockValue <= TiePastFareStyle() && !unlockFishTankList.Contains(i))
            {
                return i;
            }
        }
        return 0;
    }
    /// <summary>
    /// 解锁新鱼缸
    /// </summary>
    public void BehindSeepFare(int index)
    {
        List<int> unlockFishTankList = new List<int>(TreeTwigAbsence.GetIntArray(CSoviet.Or_InsertFareSeepForm));
        unlockFishTankList.Add(index);
        TreeTwigAbsence.SetIntArray(CSoviet.Or_InsertFareSeepForm,unlockFishTankList.ToArray());
    }
    /// <summary>
    /// 获取当前宝箱需要经验
    /// </summary>
    /// <returns></returns>
    public int TiePeruNetChugBut()
    {
        GameData AnewTwig= TugTourOil.instance.AnewTwig;
        int boxLevel = TreeTwigAbsence.GetInt(CSoviet.Or_PeruNetExact);
        foreach(BigChestItemData data in AnewTwig.BigChest)
        {
            if (boxLevel < data.Level)
            {
                return data.Exp;
            }
        }
        return 10000;
    }
    /// <summary>
    /// 获取当前宝箱数值
    /// </summary>
    /// <returns></returns>
    public BigChestItemData TieAssetNetBisTwig()
    {
        GameData AnewTwig= TugTourOil.instance.AnewTwig;
        int boxLevel = TreeTwigAbsence.GetInt(CSoviet.Or_PeruNetExact);
        foreach (BigChestItemData data in AnewTwig.BigChest)
        {
            if (boxLevel < data.Level)
            {
                return data;
            }
        }
        return null;
    }
    /// <summary>
    /// 获取星星宝箱当前经验值
    /// </summary>
    /// <returns></returns>
    public int TiePeruNetBut()
    {
        int starBoxExp = TreeTwigAbsence.GetInt(CSoviet.Or_PeruNetBut);
        return starBoxExp;
    }
    /// <summary>
    /// 增加星星经验值
    /// </summary>
    /// <returns></returns>
    public void DamPeruNetBut()
    {
        int starBoxExp = TreeTwigAbsence.GetInt(CSoviet.Or_PeruNetBut) + 1;
        int nextExp = TreeTwigAbsence.GetInt(CSoviet.Or_PeruNetGenuBut); ;
        if (starBoxExp > TiePeruNetChugBut())
        {
            nextExp += starBoxExp - TiePeruNetChugBut();
            starBoxExp = TiePeruNetChugBut();
        }
        TreeTwigAbsence.SetInt(CSoviet.Or_PeruNetGenuBut, nextExp);
        TreeTwigAbsence.SetInt(CSoviet.Or_PeruNetBut, starBoxExp);
    }
    /// <summary>
    /// 增加星星等级
    /// </summary>
    public void DamPeruNetExact()
    {
        BigChestItemData Luck= TieAssetNetBisTwig();
        foreach (ValueGroupData valueData in Luck.ValueGroup)
        {
            switch (valueData.type)
            {
                case "Gold":
                    RidChic(valueData.value);
                    break;
                case "Undo":
                    DamSightStyle(valueData.type,valueData.value);
                    break;
                case "Hint":
                    DamSightStyle(valueData.type, valueData.value);
                    break;
                case "Shuffle":
                    DamSightStyle(valueData.type, valueData.value);
                    break;
            }
        }
        TreeTwigAbsence.SetInt(CSoviet.Or_PeruNetExact, TreeTwigAbsence.GetInt(CSoviet.Or_PeruNetExact) + 1);
        BigChestItemData nextData = TieAssetNetBisTwig();
        GiftNetHeelBut = TreeTwigAbsence.GetInt(CSoviet.Or_PeruNetGenuBut);
        if (GiftNetHeelBut > TiePeruNetChugBut())
        {
            TreeTwigAbsence.SetInt(CSoviet.Or_PeruNetGenuBut, GiftNetHeelBut - TiePeruNetChugBut());
            GiftNetHeelBut = TiePeruNetChugBut();
        }
        else
        {
            TreeTwigAbsence.SetInt(CSoviet.Or_PeruNetGenuBut, 0);
        }
        TreeTwigAbsence.SetInt(CSoviet.Or_PeruNetBut, GiftNetHeelBut);
    }
    /// <summary>
    /// 增加技能次数
    /// </summary>
    public void DamSightStyle(string type,int count)
    {
        string saveKey = CSoviet.Or_SightEtchStyle;
        switch (type)
        {

            case "Undo":
                saveKey = CSoviet.Or_SightEtchStyle;
                break;
            case "Hint":
                saveKey = CSoviet.Or_SightHintStyle;
                break;
            case "Shuffle":
                saveKey = CSoviet.Or_SightRebirthStyle;
                break;
        }
        TreeTwigAbsence.SetInt(saveKey, TreeTwigAbsence.GetInt(saveKey) + count);

        HandfulCannonForth.KeaTextural().Corn("RefreshSkill");
    }
    /// <summary>
    /// 减少技能次数
    /// </summary>
    public void WadSightStyle(string type, int count)
    {
        string saveKey = CSoviet.Or_SightEtchStyle;
        switch (type)
        {

            case "Undo":
                saveKey = CSoviet.Or_SightEtchStyle;
                break;
            case "Hint":
                saveKey = CSoviet.Or_SightHintStyle;
                break;
            case "Shuffle":
                saveKey = CSoviet.Or_SightRebirthStyle;
                break;
        }
        TreeTwigAbsence.SetInt(saveKey, TreeTwigAbsence.GetInt(saveKey) - count);
    }
    /// <summary>
    /// 获取技能剩余次数
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public int TieSightStyle(string type)
    {
        string saveKey = CSoviet.Or_SightEtchStyle;
        switch (type)
        {

            case "Undo":
                saveKey = CSoviet.Or_SightEtchStyle;
                break;
            case "Hint":
                saveKey = CSoviet.Or_SightHintStyle;
                break;
            case "Shuffle":
                saveKey = CSoviet.Or_SightRebirthStyle;
                break;
        }
        return TreeTwigAbsence.GetInt(saveKey);
    }
    /// <summary>
    /// 获得当前签次数
    /// </summary>
    public int BrushSedgeKeaBrace()
    {
        int lastDay = TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeTrapJay);
        int Calve= TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle);
        if (lastDay != System.DateTime.Now.Day)
        {
            return Calve;
        }
        else
        {
            return 8;
        }
        
    }
    /// <summary>
    /// 领取签到奖励
    /// </summary>
    public void BrushAudioKeaBackup(bool isAD)
    {
        int lastDay = TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeTrapJay);
        int Calve= TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle);
        TreeTwigAbsence.SetInt(CSoviet.Or_BrushSedgeKeaStyle, Calve + 1 >= 7 ? 0: Calve + 1);
        TreeTwigAbsence.SetInt(CSoviet.Or_BrushSedgeTrapJay, System.DateTime.Now.Day);
        if (lastDay != System.DateTime.Now.Day)
        {
            if (TugTourOil.instance.AnewTwig.DailyBonus[Calve].Type == "Gold")
            {
                if (isAD)
                {
                    RidChic(TugTourOil.instance.AnewTwig.DailyBonus[Calve].Value * 5);
                }
                else
                {
                    RidChic(TugTourOil.instance.AnewTwig.DailyBonus[Calve].Value);   
                }
            }
        }
    }

    public void DamFareTenetTwig()
    {
        int fishCount = TiePastFareStyle();
        foreach (NewFishBonusItemData shelldata in TugTourOil.instance.AnewTwig.NewFishBonus)
        {
            if (shelldata.FishNumber == fishCount)
            {
                TreeTwigAbsence.SetInt(CSoviet.Or_TenetBackupStyle, TreeTwigAbsence.GetInt(CSoviet.Or_TenetBackupStyle) + 1);
                break;
            }
        }
    }

    public void DamPeru()
    {
        int star = TreeTwigAbsence.GetInt(CSoviet.Or_PeruShy);
        star += 1;
        TreeTwigAbsence.SetInt(CSoviet.Or_PeruShy, star);
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_FaucetPeru);
    }

    public int KeaPeruShy()
    {
        return TreeTwigAbsence.GetInt(CSoviet.Or_PeruShy);
    }

    public void HabitPeruShy()
    {
        TreeTwigAbsence.SetInt(CSoviet.Or_PeruShy, 0);
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_FaucetPeru);
    }


    private IEnumerator RidWayBackupPloy()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            WayBackupAssetPloy++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
