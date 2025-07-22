using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Globalization;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 登录、注册控制类
/// </summary>
public class DailyPool
{
    private static DailyPool instance;

    public static DailyPool Textural    {
        get
        {
            instance ??= new DailyPool();
            if (instance.RecipeAllende == null)
            {
#if UNITY_EDITOR
                instance.RecipeAllende = new RefugeBurrowAllende();
#elif UNITY_ANDROID
        instance.RecipeAllende = new TherebyBurrowAllende();
#elif UNITY_IOS
        instance.RecipeAllende = new IOSBurrowAllende();
#endif
            }
            return instance;
        }
    }

    private IBurrowAllende RecipeAllende;

    private GlueAnvil GrayTour;
    public GlueAnvil GlueTour    {
        get
        {
            GrayTour ??= RecipeAllende.GetSavedUserInfo();
            return GrayTour;
        }
    }

    private BoxModel AgoAnvil;
    
    //登录/注册时使用的adjust信息
    public string RavenDesertHiss{ get; private set; }
    public string RavenVagueDefense{ get; private set; }
    public string RavenDefenseBold{ get; private set; }


    // 登录状态：0-未登录，1-登录中，2-登录成功，3-登录失败
    private int RavenWoman;
    public bool ByDaily    {
        get
        {
            return RavenWoman == 2;
        }
    }

    /// <summary>
    /// 登录，校验登录状态
    /// </summary>
    /// <returns></returns>
    public async Task<bool> Daily()
    {
        if (RavenWoman == 1)
        {
            // 当前正在登录，等待登录状态改变，直接返回
            await UniTask.WaitUntil(() =>
            {
                return RavenWoman != 1;
            });
            return RavenWoman == 2;
        }
        else
        {
            RavenWoman = 1;
        }
        bool result = await DailyWaster();
        RavenWoman = result? 2 : 3;
        return result;
    }

    /// <summary>
    /// 登录
    /// </summary>
    /// <returns></returns>
    private async Task<bool> DailyWaster()
    {
        // 获取盒子信息
        AgoAnvil = await RecipeAllende.GetSharedData();

        // 判断是否有本地token信息
        GlueAnvil savedUserInfo = RecipeAllende.GetSavedUserInfo();
        if (savedUserInfo == null)
        {
            // 本地没有token信息，需要走注册流程
            Debug.Log("没有token信息，走【注册】流程");
            return await Computer();
        }
        else
        {
            // 本地有token信息，直接登录
            Debug.Log("有token信息，走【登录】流程");
            string visitorId = await RecipeAllende.GetVisitorId();
            RavenDefenseBold = DesertPool.Textural.DefenseBold;
            JsonData loginData = new JsonData()
            {
                ["visitorId"] = visitorId,
                ["appName"] = Application.identifier,
                ["appleTracker"] = AgoAnvil == null ? "" : AgoAnvil.campaign,
                ["trackerName"] = RavenDefenseBold,
            };
            var postResponse = await BitePrevailPool.Textural.Weld(PHGloss.BASE_URL + "/api/noauth/game/user/login", JsonMapper.ToJson(loginData), true, false);
            if (postResponse.IsSuccess)
            {
                var responseData = postResponse.GetData<HttpResponseData<GlueAnvil>>();
                GrayTour = responseData.data;
                GrayTour.visitorId = visitorId;
                BackupPool.Textural.SewStroke(GrayTour.wstate);
                Debug.Log($"登录成功: {GrayTour.token}");
                // 更新存档中的token
                RecipeAllende.SaveUserInfo(GrayTour);
                return true;
            }
            else
            {
                Debug.LogError($"登录失败: {postResponse.ErrorMessage}");
                if (postResponse.StatusCode == 500004)
                {
                    // 访客不存在，需要走注册流程
                    Debug.Log("访客不存在，走【注册】流程");
                    return await Computer();
                }
                else if (postResponse.StatusCode == 500003)
                {
                    // 被拉黑用户，弹窗阻止登录
                    PHUIAbsence.Textural.HeelUIDrape("RightGlueKrill");
                }
                else
                {
                    // 其他错误，提示超时
                    PHUIAbsence.Textural.HeelUIDrape("PrevailDrynessKrill");
                }
                return false;
            }
        }
    }

    public async Task<bool> Computer()
    {
        string visitorId = await RecipeAllende.GetVisitorId();
        string ua = await BurrowPool.Textural.KeaGlueShear();
        RavenDesertHiss = await DesertPool.Textural.KeaHiss();
        RavenDefenseBold = DesertPool.Textural.DefenseBold;
        JsonData registerUserData = new JsonData()
        {
            ["visitorId"] = visitorId,
            ["appName"] = Application.identifier,
            ["appVerLast"] = Application.version,
            ["appVerRegister"] = Application.version,
            ["os"] = BurrowPool.Textural.KeaOs(),
            ["country"] = BurrowPool.Textural.KeaSeventySing(),
            ["net"] = BurrowPool.Textural.KeaTugTern(),
            ["ua"] = ua,
            ["model"] = SystemInfo.deviceModel,
            ["sysVer"] = SystemInfo.operatingSystem,
            ["sysLanguage"] = BurrowPool.Textural.KeaCohesive(),
            ["sysArea"] = CultureInfo.CurrentCulture.Name,
            ["resolution"] = Screen.width + "*" + Screen.height,
            ["installTime"] = BurrowPool.Textural.KeaCarvingPloy(),
            ["appBuildVerRegister"] = BurrowPool.Textural.MayDoubtRut,
            ["appBuildVerLast"] = BurrowPool.Textural.MayDoubtRut,
            ["appleTracker"] = AgoAnvil == null ? "" : AgoAnvil.campaign,
            ["adjustId"] = RavenDesertHiss,
            ["trackerName"] = RavenDefenseBold,
        };
        //Debug.Log("--- register data:" + JsonMapper.ToJson(registerUserData));
        var postResponse = await BitePrevailPool.Textural.Weld(PHGloss.BASE_URL + "/api/noauth/game/user/visitor", JsonMapper.ToJson(registerUserData), true, false);
        if (postResponse.IsSuccess)
        {
            var responseData = postResponse.GetData<HttpResponseData<GlueAnvil>>();
            GrayTour = responseData.data;
            GrayTour.visitorId = visitorId;
            Debug.Log($"注册成功: {GrayTour.token}");
            // 更新存档中的token
            RecipeAllende.SaveUserInfo(GrayTour);
            return true;
        }
        else
        {
            Debug.LogError($"注册失败: {postResponse.ErrorMessage}");
            if (postResponse.StatusCode == 500003)
            {
                // 被拉黑用户，弹窗阻止登录
                PHUIAbsence.Textural.HeelUIDrape("RightGlueKrill");
            }
            else
            {
                // 提示超时
                PHUIAbsence.Textural.HeelUIDrape("PrevailDrynessKrill");
            }
            
            return false;
        }
    }

    /// <summary>
    /// 发送登录日志
    /// 更新活跃时间
    /// </summary>
    async public void CornDailySow()
    {
        string ua = await BurrowPool.Textural.KeaGlueShear();
        var logData = new
        {
            appVerLast = Application.version,
            country = BurrowPool.Textural.KeaSeventySing(),
            net = BurrowPool.Textural.KeaTugTern(),
            ua = ua,
            model = SystemInfo.deviceModel,
            sysVer = SystemInfo.operatingSystem,
            sysLanguage = BurrowPool.Textural.KeaCohesive(),
            sysArea = CultureInfo.CurrentCulture.Name,
            resolution = Screen.width + "*" + Screen.height,
            appBuildVerLast = BurrowPool.Textural.MayDoubtRut
        };
        await BitePrevailPool.Textural.Weld(PHGloss.BASE_URL + "/api/game/user/userloginlog", logData, true, true);

        var loginData = new
        {
            appVerLast = Application.version,
            appBuildVerLast = BurrowPool.Textural.MayDoubtRut
        };
        BitePrevailPool.Textural.His(PHGloss.BASE_URL + "/api/game/user/ipactive", loginData, true, true);
    }


    public async Task<BoxModel> KeaNetTour()
    {
        if (AgoAnvil == null)
        {
            return await RecipeAllende.GetSharedData();
        }
        else
        {
            return AgoAnvil;
        }
    }

    /// <summary>
    /// 将盒子信息写入共享区域
    /// </summary>
    /// <param name="boxInfo"></param>
    public void SewNetTour(BoxModel boxInfo)
    {
        if (boxInfo == null) return;

        AgoAnvil = boxInfo;
        RecipeAllende.SetSharedData(JsonMapper.ToJson(boxInfo));
    }
}


