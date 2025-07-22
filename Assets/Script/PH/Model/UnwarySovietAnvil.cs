using LitJson;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// 服务器配置
/// </summary>
public class UnwarySovietAnvil
{
    public Dictionary<string, AdvLocationIsOpenItem> advLocationIsOpen;   // 广告位置埋点&开关
    public MaxActivatedUnitId advUnitIds;     // 广告位
    public NewUserSaveNoAdv newUserSaveNoAdv;         // 新用户的新手保护政策无广告
    public AdvRuleItem advRuleInterstitial;             // 插屏广告规则限制
    public AdvRuleItem advRuleRewarded;                 // 激励视频广告规则限制
    public AdvRuleItem advRuleBanner;                   // banner 展示规则限制
    public ClientNoOperationRule clientNoOperationRule;   // 客户端无操作检测
    public RewardsStopAndRecover rewardsStopAndRecover;   // 无广告启停发奖配置
    public AppVersionUpdate appVersionUpdate;   // 更新配置
    public EventsIsClose userEventsIsClose;   // 用户行为事件上报开关
    public EventsIsClose rewardsEventsIsClose;  // 游戏奖励事件开关
    public EventsIsClose advEventsIsClose;  // 广告事件开关
    public EventsIsClose dauEventsIsClose;  // 页面耗时事件开关
    public EventSendRuleItem EventIntervalSeconds;   // 事件上报频率
    public EventSendRuleItem EventSendMethod;   // 事件上报方式，1：定时批量上报 2：实时上报
    public GameReviewGuide gameReviewGuide;   // 好评引导位置埋点&开关
    public FirewallRule firewallRule;   // 风控检测开关
    public Dictionary<int, RewardEventLocationItem> rewardEventLocationList;   // 奖励事件位置列表

    public JsonData gameConfig;   // 游戏配置

    public UnwarySovietAnvil() { }

    public UnwarySovietAnvil(List<HttpReponseServerConfigModelItem> list)
    {
        advLocationIsOpen = new();
        rewardEventLocationList = new();

        foreach (var item in list)
        {
            int type = item.type;
            JsonData jsonData = GetConfigByLanguage(item.configJson);
            if (jsonData == null) continue;

            // 广告位置
            if (type == 101 && jsonData.ContainsKey("advLocationIsOpen"))
            {
                SetAdvLocationIsOpen(jsonData["advLocationIsOpen"]);
            }
            
            // 广告位&规则
            if (type == 102)
            {
                if (jsonData.ContainsKey("advUnitIds"))
                {
                    advUnitIds = new();
                    string interstitial = jsonData["advUnitIds"].ContainsKey("interstitial") ? (string)jsonData["advUnitIds"]["interstitial"] : "";
                    advUnitIds.interstitial = string.IsNullOrEmpty(interstitial) || interstitial.Trim() == "0" ? new List<string>() : interstitial.Split(",").Select(s => s.Trim()).ToList();
                    string rewarded = jsonData["advUnitIds"].ContainsKey("rewarded") ? (string)jsonData["advUnitIds"]["rewarded"] : "";
                    advUnitIds.rewarded = string.IsNullOrEmpty(rewarded) || rewarded.Trim() == "0" ? new List<string>() : rewarded.Split(",").Select(s => s.Trim()).ToList();
                    string banner = jsonData["advUnitIds"].ContainsKey("banner") ? (string)jsonData["advUnitIds"]["banner"] : "";
                    advUnitIds.banner = string.IsNullOrEmpty(banner) || banner.Trim() == "0" ? new List<string>() : banner.Split(",").Select(s => s.Trim()).ToList();
                }
                if (jsonData.ContainsKey("newUserSaveNoAdv"))
                {
                    newUserSaveNoAdv = JsonMapper.ToObject<NewUserSaveNoAdv>(JsonMapper.ToJson(jsonData["newUserSaveNoAdv"]));
                }
                if (jsonData.ContainsKey("advRuleInterstitial"))
                {
                    advRuleInterstitial = JsonMapper.ToObject<AdvRuleItem>(JsonMapper.ToJson(jsonData["advRuleInterstitial"]));
                }
                if (jsonData.ContainsKey("advRuleRewarded"))
                {
                    advRuleRewarded = JsonMapper.ToObject<AdvRuleItem>(JsonMapper.ToJson(jsonData["advRuleRewarded"]));
                }
                if (jsonData.ContainsKey("advRuleBanner"))
                {
                    advRuleBanner = JsonMapper.ToObject<AdvRuleItem>(JsonMapper.ToJson(jsonData["advRuleBanner"]));
                }
            }

            // 无操作&无广告
            if (type == 103)
            {
                if (jsonData.ContainsKey("clientNoOperationRule"))
                {
                    clientNoOperationRule = JsonMapper.ToObject<ClientNoOperationRule>(JsonMapper.ToJson(jsonData["clientNoOperationRule"]));
                }
                if (jsonData.ContainsKey("rewardsStopAndRecover"))
                {
                    rewardsStopAndRecover = JsonMapper.ToObject<RewardsStopAndRecover>(JsonMapper.ToJson(jsonData["rewardsStopAndRecover"]));
                }
            }

            // 更新
            if (type == 104)
            {
                appVersionUpdate = JsonMapper.ToObject<AppVersionUpdate>(JsonMapper.ToJson(jsonData));
            }
            
            // 事件
            if (type == 105)
            {
                if (jsonData.ContainsKey("userEventsIsClose"))
                {
                    userEventsIsClose = new();
                    userEventsIsClose.status = int.Parse(jsonData["userEventsIsClose"]["status"].ToString());
                    string eventListIsClose = (string)jsonData["userEventsIsClose"]["userEventListIsClose"];
                    userEventsIsClose.eventListIsClose = string.IsNullOrEmpty(eventListIsClose) ? new List<int>() : eventListIsClose.Split(",").Select(int.Parse).ToList();
                }
                if (jsonData.ContainsKey("rewardsEventsIsClose"))
                {
                    rewardsEventsIsClose = new();
                    rewardsEventsIsClose.status = int.Parse(jsonData["rewardsEventsIsClose"]["status"].ToString());
                    rewardsEventsIsClose.eventListIsClose = new List<int>();
                }
                if (jsonData.ContainsKey("advEventsIsClose"))
                {
                    advEventsIsClose = new();
                    advEventsIsClose.status = int.Parse(jsonData["advEventsIsClose"]["status"].ToString());
                    string eventListIsClose = (string)jsonData["advEventsIsClose"]["advEventListIsClose"];
                    advEventsIsClose.eventListIsClose = string.IsNullOrEmpty(eventListIsClose) ? new List<int>() : eventListIsClose.Split(",").Select(int.Parse).ToList();
                }
                if (jsonData.ContainsKey("dauEventsIsClose"))
                {
                    dauEventsIsClose = new();
                    dauEventsIsClose.status = int.Parse(jsonData["dauEventsIsClose"]["status"].ToString());
                    string eventListIsClose = (string)jsonData["dauEventsIsClose"]["dauEeventListIsClose"];
                    dauEventsIsClose.eventListIsClose = string.IsNullOrEmpty(eventListIsClose) ? new List<int>() : eventListIsClose.Split(",").Select(int.Parse).ToList();
                }
                if (jsonData.ContainsKey("EventSendMethod"))
                {
                    EventSendMethod = JsonMapper.ToObject<EventSendRuleItem>(JsonMapper.ToJson(jsonData["EventSendMethod"]));
                }
                if (jsonData.ContainsKey("EventIntervalSeconds"))
                {
                    EventIntervalSeconds = JsonMapper.ToObject<EventSendRuleItem>(JsonMapper.ToJson(jsonData["EventIntervalSeconds"]));
                }
            }
            
            // 好评引导
            if (type == 106)
            {
                gameReviewGuide = JsonMapper.ToObject<GameReviewGuide>(JsonMapper.ToJson(jsonData));
            }

            // 风控
            if (type == 107)
            {
                firewallRule = new();
                firewallRule.clientVpnCheckStatus = int.Parse(jsonData["clientVpnCheckStatus"].ToString());
                string serverAllowedAreas = (string)jsonData["serverAllowedAreas"];
                firewallRule.serverAllowedAreas = string.IsNullOrEmpty(serverAllowedAreas) ? new List<string>() : serverAllowedAreas.Split(",").Select(s => s.Trim()).ToList();
                firewallRule.rcsReportTime = int.Parse(jsonData["rcsReportTime"].ToString());
            }
            
            // 游戏配置
            if (type == 108)
            {
                gameConfig = jsonData;
            }

            // 奖励事件位置列表
            if (type == 111 && jsonData.ContainsKey("rewardEventLocationList"))
            {
                List<RewardEventLocationItem> rewardEventLocationItems = JsonMapper.ToObject<List<RewardEventLocationItem>>(JsonMapper.ToJson(jsonData["rewardEventLocationList"]));
                foreach (var item1 in rewardEventLocationItems)
                {
                    rewardEventLocationList[item1.locationEventId] = item1;
                }
            }
        }
    }

    private JsonData GetConfigByLanguage(string jsonStr)
    {
        JsonData jsonData = JsonMapper.ToObject(jsonStr);
        string language = BurrowPool.Textural.KeaCohesive();
        if (jsonData.ContainsKey(language))
        {
            return jsonData[language];
        }
        else
        {
            return jsonData["en"];
        }
    }

    public void SetAdvLocationIsOpen(JsonData data)
    {
        List<AdvLocationIsOpenItem> advLocationIsOpenItems = JsonMapper.ToObject<List<AdvLocationIsOpenItem>>(JsonMapper.ToJson(data));
        foreach (var advLocationIsOpenItem in advLocationIsOpenItems)
        {
            string adTypeStr = advLocationIsOpenItem.adType.ToString();
            switch (advLocationIsOpenItem.adType)
            {
                case 1:
                    adTypeStr = "rewarded";
                    break;
                case 2:
                    adTypeStr = "interstitial";
                    break;
                case 3:
                    adTypeStr = "banner";
                    break;
            }

            advLocationIsOpen.Add(adTypeStr + "_" + advLocationIsOpenItem.advLocationId, advLocationIsOpenItem);
        }
    }
}

/// <summary>
/// 广告位置埋点&开关
/// </summary>
public class AdvLocationIsOpenItem
{
    public int advLocationId;
    public string advLocationString;
    public int adType;
    public int advLocationIdShowTimesPerDay;
    public int triggerTimesToDisplayAd;
    public int status;
}

/// <summary>
/// 广告位 - 广告ID
/// </summary>
public class MaxActivatedUnitId
{
    public List<string> interstitial;
    public List<string> rewarded;
    public List<string> banner;
}

/// <summary>
/// 广告限制
/// </summary>
public class AdvRule
{
    public NewUserSaveNoAdv newUserSaveNoAdv;
    public AdvRuleItem advRuleInterstitial;
    public AdvRuleItem advRuleRewarded;
    public AdvRuleItem advRuleBanner;

    
}
public class NewUserSaveNoAdv
{
    public int ruleClass;
    public int ruleValue;
}
public class AdvRuleItem
{
    public int showTimesPerDay;
    public int showTimeIntervalSeconds;
}


/// <summary>
/// 客户端无操作检测
/// </summary>
public class ClientNoOperationRule
{
    public int stopRewardTimesSeconds;
    public int recoverRewardTimesSeconds;
}

/// <summary>
/// 无广告启停发奖配置
/// </summary>
public class RewardsStopAndRecover
{
    public int continuousLoadNoAdv;
    public int continuousLoadHaveAdv;
}

/// <summary>
/// 更新配置
/// </summary>
public class AppVersionUpdate
{
    public int updateType;  // 1: 强制更新 0: 非强制更新
    public int minRequiredVersion;  // 最小版本号
    public string appStoreUrl;  // 应用商店地址
    public string updateDesc;  // 更新描述
}

/// <summary>
/// 用户行为事件上报开关
/// </summary>
public class EventsIsClose
{
    public int status;
    public List<int> eventListIsClose;
}

/// <summary>
/// 事件上报频率
/// </summary>
public class EventSendRule
{
    public EventSendRuleItem EventIntervalSeconds;
}
public class EventSendRuleItem
{
    public int userEvents;
    public int rewardsEvents;
    public int advEvents;
    public int dauEvents;
}

/// <summary>
/// 好评引导位置埋点&开关
/// </summary>
public class GameReviewGuide
{
    public int isOpenReviewGuide;
    public string showLocation;
    public int popupType;
}

/// <summary>
/// 风控检测开关
/// </summary>
public class FirewallRule
{
    public int clientVpnCheckStatus;
    public List<string> serverAllowedAreas;
    public int rcsReportTime;
}

/// <summary>
/// 奖励事件埋点列表
/// </summary>
public class RewardEventLocationItem
{
    public int coolingTime;     // 发奖间隔时间（秒）
    public int locationEventId;  // 奖励事件ID
    public string locationEventName;  // 奖励事件名称
    public int status;
}



public class HttpReponseServerConfigModel
{
    public int id;
    public List<HttpReponseServerConfigModelItem> list;
}

public class HttpReponseServerConfigModelItem
{
    public int id;
    public int type;
    public string configJson;
}
