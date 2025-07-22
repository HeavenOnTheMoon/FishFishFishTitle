/**
 * 
 * 常量配置
 * 
 * 
 * **/
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSoviet 
{
    #region 常量字段
    //登录url
    public const string DailyGem= "/api/client/user/getId?gameCode=";
    //配置url
    public const string SovietGem= "/api/client/config?gameCode=";
    //时间戳url
    public const string PloyGem= "/api/client/common/current_timestamp?gameCode=";
    //更新AdjustId url
    public const string DesertGem= "/api/client/user/setAdjustId?gameCode=";
    #endregion

    #region 本地存储的字符串
    /// <summary>
    /// 本地用户id (string)
    /// </summary>
    public const string sv_ScentGlueIt= "sv_LocalUserId";
    /// <summary>
    /// 本地服务器id (string)
    /// </summary>
    public const string Or_ScentUnwaryIt= "sv_LocalServerId";
    /// <summary>
    /// 是否是新用户玩家 (bool)
    /// </summary>
    public const string Or_ByTarExcite= "sv_IsNewPlayer";
    /// <summary>
    /// 关卡id (int)
    /// </summary>
    public const string Or_Exact_It= "sv_Level_Id";
    /// <summary>
    /// 金币余额 (int)
    /// </summary>
    public const string Or_ChicSupply= "sv_GoldNumber";
    /// <summary>
    /// 累计金币数量
    /// </summary>
    public const string Or_SkepticismChicSupply= "sv_CumulativeGoldNumber";
    /// <summary>
    /// 现金余额 (float)
    /// </summary>
    public const string Or_SoarSupply= "sv_CashNumber";
    /// <summary>
    /// 累计现金数量
    /// </summary>
    public const string Or_SkepticismSoarSupply= "sv_CumulativeCashNumber";
    /// <summary>
    /// Amazon余额
    /// </summary>
    public const string Or_CarmanSupply= "sv_AmazonNumber";
    /// <summary>
    /// 累计Amazon卡
    /// </summary>
    public const string Or_SkepticismCarmanSupply= "sv_CumulativeAmazonNumber";
    
    /// <summary>
    /// 贝壳余额 (int)
    /// </summary>
    public const string Or_TenetSupply= "sv_ShellNumber";
    /// <summary>
    /// 通过现金奖励间隔 (int)
    /// </summary>
    public const string Or_SoarExactPass= "sv_CashLevelPass";
    /// <summary>
    /// 存钱罐当前钱数 (float)
    /// </summary>
    public const string Or_VeinSupply= "sv_BankNumber";
    /// <summary>
    /// 存钱罐累计钱数 (float)
    /// </summary>
    public const string Or_VeinYamKeaSupply= "sv_BankAllGetNumber";
    /// <summary>
    /// 关卡持续时间 (int)
    /// </summary>
    public const string Or_ExactYamPloy= "sv_LevelAllTime";
    /// <summary>
    /// 用户等级 (int)
    /// </summary>
    public const string Or_GlueExact= "sv_UserLevel";
    /// <summary>
    /// 当前经验值 (int)
    /// </summary>
    public const string Or_GlueBut= "sv_UserExp";
    /// <summary>
    /// 拥有某种鱼的总数量(计算鱼的售价使用) 需要拼接鱼的id (int)
    /// </summary>
    public const string Or_FareStyle= "sv_FishCount_";
    /// <summary>
    ///解锁鱼的列表 (int array)
    /// </summary>
    public const string Or_InsertFareForm= "sv_UnlockFishList";
    /// <summary>
    /// 鱼缸包含鱼列表 需要拼接鱼缸的id (int array)
    /// </summary>
    public const string Or_SeepPastFareForm= "sv_TankHaveFishList";
    /// <summary>
    /// 当前选用鱼缸 (int)
    /// </summary>
    public const string Or_PackerFareSeep= "sv_SelectFishTank";
    /// <summary>
    /// 解锁鱼缸列表 (int array)
    /// </summary>
    public const string Or_InsertFareSeepForm= "sv_UnlockFishTankList";
    /// <summary>
    /// 星星宝箱等级 (int)
    /// </summary>
    public const string Or_PeruNetExact= "sv_StarBoxLevel";
    /// <summary>
    /// 星星宝箱经验值 (int)
    /// </summary>
    public const string Or_PeruNetBut= "sv_StarBoxExp";
    /// <summary>
    /// 星星宝箱溢出经验值 (int)
    /// </summary>
    public const string Or_PeruNetGenuBut= "sv_StarBoxNextExp";
    /// <summary>
    /// 回退技能免费次数 (int)
    /// </summary>
    public const string Or_SightEtchStyle= "sv_SkillUndoCount";
    /// <summary>
    /// 提示技能免费次数 (int)
    /// </summary>
    public const string Or_SightHintStyle= "sv_SkillHintCount";
    /// <summary>
    /// 刷新技能免费次数 (int)
    /// </summary>
    public const string Or_SightRebirthStyle= "sv_SkillRefreshCount";
    /// <summary>
    /// 签到次数 (int)
    /// </summary>
    public const string Or_BrushSedgeKeaStyle= "sv_DailyBounsGetCount";
    /// <summary>
    /// 签到最后日期 (int)
    /// </summary>
    public const string Or_BrushSedgeTrapJay= "sv_DailyBounsLastDay";
    /// <summary>
    /// 鱼奖励未发放金币金额 (int)
    /// </summary>
    public const string Or_FareBackupChicShy= "sv_FishRewardGoldNum";
    /// <summary>
    /// 鱼奖励剩余发放金币次数 (int)
    /// </summary>
    public const string Or_FareBackupChicStyle= "sv_FishRewardGoldCount";
    /// <summary>
    /// 鱼奖励未发放现金金额 (float)
    /// </summary>
    public const string Or_FareBackupSoarShy= "sv_FishRewardCashNum";
    /// <summary>
    /// 鱼奖励剩余发放现金次数 (int)
    /// </summary>
    public const string Or_FareBackupSoarStyle= "sv_FishRewardCashCount";

    /// <summary>
    /// 鱼已经生成的金币奖励队列 (int array)
    /// </summary>
    public const string Or_FarePastChicTreat= "sv_FishHaveGoldArray";
    /// <summary>
    /// 鱼已经生成的现金奖励队列 (int array)
    /// </summary>
    public const string Or_FarePastSoarTreat= "sv_FishHaveGoldArray";

    /// <summary>
    /// 贝壳已产生数量 (int)
    /// </summary>
    public const string Or_TenetPastStyle= "sv_ShellHaveCount";
    /// <summary>
    /// 贝壳奖励种类List (string array)
    /// </summary>
    public const string Or_TenetBackupTernForm= "sv_ShellRewardTypeList";
    /// <summary>
    /// 碎片以生产数量
    /// </summary>
    public const string Or_StitchPastStyle= "sv_PuzzleHaveCount";
    /// <summary>
    /// 碎片待释放数量
    /// </summary>
    public const string Or_StitchBackupStyle= "sv_PuzzleRewardCount";
    /// <summary>
    /// 贝壳待释放数量 (int)
    /// </summary>
    public const string Or_TenetBackupStyle= "sv_ShellRewardCount";
    /// <summary>
    /// 新手引导步数完成状态需要拼接id(bool)
    /// </summary>
    public const string Or_TarGlueSpin= "sv_NewUserStep_";
    /// <summary>
    /// 评价弹窗 (bool)
    /// </summary>
    public const string Or_Error_News= "sv_ready_rate";
    /// <summary>
    /// 星星数量
    /// </summary>
    public const string Or_PeruShy= "sv_StarNum";
    /// <summary>
    /// 是否为第一次结算翻倍
    /// </summary>
    public const string Or_NevusFord= "sv_FirstSlot";

    /// <summary>
    /// adjust adid
    /// </summary>
    public const string Or_DesertHiss= "sv_AdjustAdid";

    /// <summary>
    /// 签到最后日期 (int)
    /// </summary>
    public const string Or_BrushSedgeLeak= "sv_DailyBounsDate";

    /// <summary>
    /// 金币余额
    /// </summary>
    public const string Or_ChicText= "sv_GoldCoin";
    /// <summary>
    /// 累计金币总数
    /// </summary>
    public const string Or_SkepticismChicText= "sv_CumulativeGoldCoin";
    /// <summary>
    /// 钻石/现金余额
    /// </summary>
    public const string Or_Soar= "sv_Cash";
    /// <summary>
    /// 累计钻石/现金总数
    /// </summary>
    public const string Or_SkepticismSoar= "sv_CumulativeCash";
    /// <summary>
    /// 钻石Amazon
    /// </summary>
    public const string Or_Carman= "sv_Amazon";
    /// <summary>
    /// 累计Amazon总数
    /// </summary>
    public const string Or_SkepticismCarman= "sv_CumulativeAmazon";
    /// <summary>
    /// 游戏总时长
    /// </summary>
    public const string Or_GlazeSeemPloy= "sv_TotalGameTime";
    /// <summary>
    /// 第一次获得钻石奖励
    /// </summary>
    public const string Or_NevusKeaArgue= "sv_FirstGetToken";
    /// <summary>
    /// 是否已显示评级弹框
    /// </summary>
    public const string Or_OweHeelMustKrill= "sv_HasShowRatePanel";
    /// <summary>
    /// 累计Roblox奖券总数
    /// </summary>
    public const string Or_SkepticismCoexist= "sv_CumulativeLottery";
    /// <summary>
    /// 已经通过一次的关卡(int array)
    /// </summary>
    public const string Or_DeclineRustLevels= "sv_AlreadyPassLevels";
    /// <summary>
    /// 新手引导
    /// </summary>
    public const string Or_TarGlueSpinGarden= "sv_NewUserStepFinish";
    public const string Or_Keen_Apart_Broad= "sv_task_level_count";

    /// <summary>
    /// 广告相关 - trial_num
    /// </summary>
    public const string Or_ad_trial_Lay= "sv_ad_trial_num";
    /// <summary>
    /// 看广告总次数
    /// </summary>
    public const string Or_State_Or_Lay= "sv_total_ad_num";
    /// <summary>
    /// 语言
    /// </summary>
    public const string Oat_Rainfall= "Language";
    /// <summary>
    /// 语言
    /// </summary>
    public const string Oat_Douse= "sys_Newbg";
    #endregion

    #region 监听发送的消息
    /// <summary>
    /// undo技能
    /// </summary>
    public static string Of_Push= "mg_undo";
    /// <summary>
    /// hint
    /// </summary>
    public static string Of_Cute= "mg_hint";
    /// <summary>
    /// shuffle
    /// </summary>
    public static string Of_Imagist= "mg_shuffle";
    /// <summary>
    /// revive
    /// </summary>
    public static string Of_Rescue= "mg_revive";
    /// <summary>
    /// 有窗口打开
    /// </summary>
    public static string Of_AroundWife= "mg_WindowOpen";
    /// <summary>
    /// 窗口关闭
    /// </summary>
    public static string Of_AroundStark= "mg_WindowClose";
    /// <summary>
    /// LevelPanel关卡id刷新
    /// </summary>
    public static string Of_ExactKrill_ExactSupply= "mg_LevelPanel_LevelNumber";
    /// <summary>
    /// 技能种类
    /// </summary>
    public static string Of_SightTern= "mg_SkillType";
    /// <summary>
    /// LevelCompletePanel奖励刷新
    /// </summary>
    public static string Of_ExactAnyplaceKrill_Backup= "mg_LevelCompletePanel_Reward";
    /// <summary>
    /// levelPanel存钱罐增加刷新
    /// </summary>
    public static string Of_ExactKrill_VeinDam= "mg_LevelPanel_BankAdd";
    /// <summary>
    /// levelPanel存钱罐取出后状态刷新
    /// </summary>
    public static string Of_ExactKrill_VeinPeach= "mg_LevelPanel_BankClear";
    /// <summary>
    /// HomePanel存钱罐取出后状态刷新
    /// </summary>
    public static string Of_HikeKrill_VeinPeach= "mg_HomePanel_BankClear";
    /// <summary>
    /// levelpanel增加现金
    /// </summary>
    public static string Of_ExactKrill_DamSoar= "mg_LevelPanel_AddCash";
    /// <summary>
    /// 增加金币
    /// </summary>
    public static string Of_ExactKrill_DamChic= "mg_LevelPanel_AddGold";
    /// <summary>
    /// 增加amazon
    /// </summary>
    public static string Of_ExactKrill_DamCarman= "mg_LevelPanel_AddAmazon";
    /// <summary>
    /// homePanel 增加钱数
    /// </summary>
    public static string Of_HikeKrill_DamSoar= "mg_HomePanel_AddCash";
    /// <summary>
    /// RewardPanel动画播放
    /// </summary>
    public static string Of_BackupKrill_Beer= "mg_RewardPanel_Play";
    /// <summary>
    /// 关卡中需要提高余额层级
    /// </summary>
    public static string Of_ExactKrill_SoarOrderFaucet= "mg_LevelPanel_CashOrderChange";
    /// <summary>
    /// 首页中需要提高余额层级
    /// </summary>
    public static string Of_HikeKrill_SoarOrderFaucet= "mg_HomePanel_CashOrderChange";
    /// <summary>
    /// 存钱罐页面打开来源
    /// </summary>
    public static string Of_VeinKrill_Aero= "mg_BankPanel_From";
    /// <summary>
    /// levelPanel关闭动画
    /// </summary>
    public static string Of_ExactKrill_Lira= "mg_LevelPanel_Hide";
    /// <summary>
    /// BuyFishPanel传递哪条鱼
    /// </summary>
    public static string Of_PayFareKrill_FareBrace= "mg_BuyFishPanel_FishIndex";
    /// <summary>
    /// 刷新金额
    /// </summary>
    public static string Of_RebirthChicSoar= "mg_RefreshGoldCash";
    /// <summary>
    /// 首页三个也面的切换通知
    /// </summary>
    public static string Of_HikeKrillEuropeEmit= "mg_HomePanelSwitchPage";
    /// <summary>
    /// 首页开始游戏
    /// </summary>
    public static string Of_HikeKrillExactAsset= "mg_HomePanelLevelStart";
    /// <summary>
    /// 传递homepanel商店按键坐标点
    /// </summary>
    public static string Of_ExactInsertSonPer= "mg_LevelUnlockEndPos";
    /// <summary>
    /// 选中鱼缸
    /// </summary>
    public static string Of_PackerFareSeep= "mg_SelectFishTank";
    /// <summary>
    /// 解锁鱼缸页面传递鱼缸id
    /// </summary>
    public static string Of_InsertFareSeepKrillBrace= "mg_UnlockFishTankPanelIndex";
    /// <summary>
    /// 领取星星宝箱奖励
    /// </summary>
    public static string Of_KeaPeruNetBackup= "mg_GetStarBoxReward";
    /// <summary>
    /// 点击鱼奖励
    /// </summary>
    public static string Of_HikeKrillKeaFareBackup= "mg_HomePanelGetFishReward";
    /// <summary>
    /// 新手引导消息传递2
    /// </summary>
    public static string Of_HikeKrillGrandeWeedy= "mg_HomePanelRobloxGuide";
    /// <summary>
    /// 新手引导消息传递3
    /// </summary>
    public static string Of_HikeKrillGenuWeedy= "mg_HomePanelNextGuide";
    /// <summary>
    /// 新手引导消息传递4
    /// </summary>
    public static string Of_HikeKrillBeerWeedy= "mg_HomePanelPlayGuide";
    /// <summary>
    /// 碎片动画
    /// </summary>
    public static string Of_HikeKrillDamStitch= "mg_HomePanelAddPuzzle";
    /// <summary>
    /// 显示自动收按键
    /// </summary>
    public static string Of_HeelRomeInform= "mg_ShowAutoButton";
    /// <summary>
    /// 隐藏自动收按键
    /// </summary>
    public static string Of_OfferingRomeInform= "mg_DissmissAutoButton";
    /// <summary>
    /// 修改星星数量
    /// </summary>
    public static string Of_FaucetPeru= "mg_ChangeStar";
    /// <summary>
    /// 技能引导
    /// </summary>
    public static string Of_HeelSightWeedy= "mg_ShowSkillGuide";
    /// <summary>
    /// 提现商店引导
    /// </summary>
    public static string Of_HeelSoarOntoWeedy= "mg_ShowCashShopGuide";

    public static string Vas_Unity_Quill_Bis_Xenon= "msg_close_panel_and_start";
    /// <summary>
    /// 关卡结算时传值
    /// </summary>
    public static string Of_Go_Ornamentation= "mg_ui_levelcomplete";
    /// <summary>
    /// 增加金币
    /// </summary>
    public static string Of_Go_Usually= "mg_ui_addgold";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string Of_Go_Supplant= "mg_ui_addtoken";
    /// <summary>
    /// 增加amazon
    /// </summary>
    public static string Of_Go_Mutoscope= "mg_ui_addamazon";

    /// <summary>
    /// 游戏暂停/继续
    /// </summary>
    public static string Of_SeemTribute= "mg_GameSuspend";

    /// <summary>
    /// 游戏资源数量变化
    /// </summary>
    public static string Of_SuckFaucet_= "mg_ItemChange_";

    /// <summary>
    /// 活动状态变更
    /// </summary>
    public static string Of_ApprovalWomanFaucet_= "mg_ActivityStateChange_";

    /// <summary>
    /// 关卡最大等级变更
    /// </summary>
    public static string Of_ExactEkaExactFaucet= "mg_LevelMaxLevelChange";

    /// <summary>
    /// 关卡结束
    /// </summary>
    public static string Of_RustExact= "mg_PassLevel";

    /// <summary>
    /// 关卡结束
    /// </summary>
    public static string Of_AssetExact= "mg_StartLevel";
    #endregion

    #region 动态加载资源的路径
    //关卡的路径
    public static string ExactTide= "LevelArea/";
    //关卡上的节点
    public static string ExactTangTide= "LevelNode/";

    public static string SAxTex_MailFareBG= "ScTex/ScTex_TileFishBG_";
    public static string AxSon_MailFareBG= "/ScTex_TileFishBG_";
    public static string AxRoof= "_Back";
    public static string AxSeep= "_Tank";

    public static string AxFetus= "_Front";
    public static string AxBet= "_Mid";
    public static string AstronautFareMat= "Animation/FishAni/";
    public static string SurmiseFenTenetSteam= "Effects/Mat_ShellFlash";
    public static string SurmiseFxPeru= "Effects/Fx_Star";
    public static string AMatItJumpLightnessBattle= "Animation/AniFx/Fx_SoulExplosionOrange";
    public static string AMatItPistonBet= "Animation/AniFx/FX_BubbleMid";
    public static string ExactSizeExact= "LevelJson/Level_";
    public static string ChasteMailSuck= "Prefab/MailSuck";
    public static string TMailBellLack= "TileTestCube/TileTestCube_";
    public static string Fatal= "Empty";
    public static string Drug= "Full";
    public static string ChasteExactWorth= "Prefab/ExactWorth";
    public static string ChasteMailOpenSuck= "Prefab/TileEditItem";
    public static string GrandeOntoGrandeExpressionlessExact= "RobloxShop/RobloxImage/robloximg_Level";
    public static string RGrandeSizeSeventyTwig= "RobloxShop/RobloxJson/CountryData";
    public static string RGrandeSizeGrandeTwig= "RobloxShop/RobloxJson/RobloxData";
    public static string RGrandeParadoxicallyExact= "RobloxShop/RobloxImage/robloximg_Level";

    public static string RGrandeGrandeWhigBow= "RobloxShop/RobloxProfab/RobloxIconBtn";
    public static string ASo_Audio_Chic= "Art/Tex/UI/UI_BonusReward/So_Audio_Chic";
    public static string ASo_Audio_Soar= "Art/Tex/UI/UI_BonusReward/So_Audio_Chic";
    public static string ASo_Audio_Carman= "Art/Tex/UI/UI_BonusReward/So_Audio_Chic";

    public static string Fare= "Fish/";
    public static string SurmiseBrushBackup7= "Effects/UI_DailyReward7";
    public static string SurmiseBrushBackup= "Effects/UI_DailyReward";
    public static string SurmiseBrushBackup7Wife= "Effects/UI_DailyReward7Open";
    public static string SurmiseBrushWife= "Effects/UI_DailyOpen";
    public static string SeepStrictFareSeepSC= "TankBanner/UI_FishTankSC";
    public static string SurmiseFXTract= "Effects/FX_Power";
    public static string SurmiseBackupNetLapStark= "Effects/UI_RewardBoxTopClose";
    public static string SurmiseGiveNephew= "Effects/Mat_MoveOffset";



    








    #endregion
}

