using AdjustSdk;
using Cysharp.Threading.Tasks;
using LitJson;
using System.Threading.Tasks;
using UnityEngine;

public class PHAbsence : MonoBehaviour
{
    public static PHAbsence Instance;
[UnityEngine.Serialization.FormerlySerializedAs("appid")]
    public string Alter;    // 游戏appid，例如930001
[UnityEngine.Serialization.FormerlySerializedAs("AdjustToken")]    public string DesertArgue;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustEnvironment")]    public AdjustSdk.AdjustEnvironment DesertPhotosphere;

#if UNITY_IOS
    [Header("盒子服务api接口域名")]
    public string IOS_BASE_URL;     // 盒子服务api接口域名
    [Header("盒子log接口域名")]
    public string IOS_BASE_URL_LOG; // 盒子log接口域名
#elif UNITY_ANDROID
    [Header("盒子服务api接口域名")]
    public string Android_BASE_URL;     // 盒子服务api接口域名
    [Header("盒子log接口域名")]
    public string Android_BASE_URL_LOG; // 盒子log接口域名
#endif

    [HideInInspector]
    public bool RavenProdigy{ get; private set; }          // 登录成功
    [HideInInspector]
    public bool LeafySovietProdigy{ get; private set; }     // 获取配置成功
    [HideInInspector]
    public bool AsiaProdigy{ get; private set; }    // 初始化成功

    public BoxModel AgoAnvil{ get; private set; } // 共享区域数据（盒子信息）



    // 配置参数
    private float ConferenceTechnical= 30f; // 无操作30秒停止广告

    private float WandApprovalPloy;
    private int CandidReside;   // 是否处于无操作状态
    public int ActiveReside{ get { return CandidReside; } }

    public void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    async void Start()
    {
        // 行为事件埋点 - app_open
        LipidSowPool.Textural.CornGlueLipid(10000, "sys_app_open_show_10000");

        // 初始化数据
        HabitTwig();
        // 开始登录、获取配置、初始化SDK等流程
#if UNITY_EDITOR
        await DailySeem();
#else
        await AssetSeem();
#endif
        // 开启用户无操作检测
        CandidReside = PlayerPrefs.HasKey("PH_active_status") ? PHTreeTwigAbsence.GetInt("PH_active_status") : 1;
        WandApprovalPloy = Time.time;
        SonicResentment();

        // 行为事件埋点 - login
        LipidSowPool.Textural.CornGlueLipid(10001, "sys_login_success_10001");
    }

    private void Update()
    {
        // 检测任何用户输入
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) ||
            Input.touchCount > 0)
        {
            ComputerGlueApproval();
        }
    }

    // 初始化数据
    private void HabitTwig()
    {
        RavenProdigy = false;
        LeafySovietProdigy = false;
        AsiaProdigy = false;
    }

    public string HumpTossGem{ private set; get; }

    private async Task AssetSeem()
    {
        // 初始化Adjust
        bool adjustInitSuccess = await DesertPool.Textural.DustDesertSDK();
        if (!adjustInitSuccess)
        {
            // 初始化Adjust失败，提示超时
            Debug.Log("--- Adjust初始化失败");
            PHUIAbsence.Textural.HeelUIDrape("PrevailDrynessKrill");
            return;
        }
        string loginKey = "PH_adjust_login";
        if (PlayerPrefs.HasKey(loginKey + "Bool") && PHTreeTwigAbsence.GetBool(loginKey))
        {
            // 非首次登录，使用通用链接中的信息
            string deepLink = Application.absoluteURL;
            Debug.Log("--- deepLink: " + deepLink);
            HumpTossGem = deepLink;
            HumpTossTwig = PHTide.ScubaGemEncase(deepLink);
            if (HumpTossTwig != null)
            {
                // 保存盒子信息
                DailyPool.Textural.SewNetTour(HumpTossTwig);
            }
            await DailySeem();
        } 
        else
        {
            // 首次登录，向Adjust服务器请求归因信息
            BoxModel adjustDeviceModel = await DesertPool.Textural.KeaDesertClergyTour();
            if (adjustDeviceModel != null)
            {
                // 保存盒子信息
                DailyPool.Textural.SewNetTour(adjustDeviceModel);
            }
            await DailySeem();
            PHTreeTwigAbsence.SetBool(loginKey, true);
        }

        // 注册应用激活时的回调
        Application.deepLinkActivated += OnDeepLinkActivated;
    }

    private BoxModel HumpTossTwig;
    /// <summary>
    /// 应用热启动（应用切到后台后，再由DeepLink打开），需要重新登录
    /// </summary>
    /// <param name="url"></param>
    private async void OnDeepLinkActivated(string url)
    {
        // 热启动，解析深度链接中的信息
        HumpTossTwig = PHTide.ScubaGemEncase(url);
        HumpTossGem = url;
        if (HumpTossTwig != null)
        {
            // 保存盒子信息
            DailyPool.Textural.SewNetTour(HumpTossTwig);
            await DailySeem();
        }
    }

    /// <summary>
    /// 游戏前后台切换，每次切换到前台，都需要重新登录一次
    /// </summary>
    /// <param name="pause"></param>
    //private async void OnApplicationPause(bool pause)
    //{
    //    if (WePool.Instance.IsAdShowing()) return;
    //    if (!initSuccess) return;

    //    if (pause)
    //    {
    //        // 进入后台：清除上一次的DeepLink数据
    //        deepLinkData = null;
    //    }
    //    else
    //    {
    //        // 回到前台：如果DeepLink数据不为空，说明已经在DeepLink激活回中登录过了，否则，重新登录
    //        await UniTask.WaitForSeconds(1f);
    //        if (deepLinkData == null)
    //        {
    //            Debug.Log("--- 切换前后台，登录");
    //            await LoginGame();
    //        }
    //    }
    //}

    /// <summary>
    /// 开始游戏流程
    /// 1、登录/注册
    /// 2、发送登录日志（异步）
    /// 3、获取配置，判断是否需要更新
    /// 4、初始化SDK（异步）
    /// </summary>
    public async Task DailySeem()
    {
        // 现在有多次登录的情况，每次登录都先关闭登录失败弹窗
        PHUIAbsence.Textural.StarkUIWish("PrevailDrynessKrill");

        // 获取盒子信息
        AgoAnvil = await BurrowPool.Textural.KeaNetAnvil();

        // 1、登录/注册
        RavenProdigy = await DailyPool.Textural.Daily();
        if (!RavenProdigy)
        {
            // 登录/注册失败
            return;
        }

        // 2、发送登录日志（异步）
        DailyPool.Textural.CornDailySow();

        // 3、获取配置，判断是否需要更新
        LeafySovietProdigy = await UnwarySovietPool.Textural.FreshUnwarySoviet();
        UnwarySovietAnvil config;
        if (LeafySovietProdigy)
        {
            // 判断是否需要更新
            config = UnwarySovietPool.Textural.UnwarySoviet;
            int appBuildVersion = BurrowPool.Textural.MayDoubtRut;
            if (appBuildVersion < config.appVersionUpdate.minRequiredVersion)
            {
                Debug.Log($"Need Update! minRequiredVersion:{config.appVersionUpdate.minRequiredVersion}, appBuildVersion:{appBuildVersion}");
                PHUIAbsence.Textural.HeelUIDrape("RejoinKrill");
                // 阻塞线程，等待更新界面关闭
                await UniTask.WaitUntil(() =>
                {
                    if (!PHUIAbsence.Textural.ByAnyUIHeel()) return true;

                    return !PHUIAbsence.Textural.ByUIThree("RejoinKrill");
                });
            }
            // 客户端无操作检测配置
            ConferenceTechnical = config.clientNoOperationRule.stopRewardTimesSeconds;
        }
        else
        {
            // 提示超时
            PHUIAbsence.Textural.HeelUIDrape("PrevailDrynessKrill");
            return;
        }

        AsiaProdigy = true;

        // 4、初始化SDK（异步）
        // 4.1、初始化广告SDK
        WeAbsence.Instance.AssetWe();

        // 5、登录成功后，开启日志打点定时任务
        LipidSowAbsence.Instance.AssetLipidSowVivid();

        // 6、如果有之前保存的超时请求，重新发送一次
        BitePrevailPool.Textural.RevoltPrevail();

        // 7、风控检测

#if !UNITY_EDITOR
        if (config.firewallRule.rcsReportTime > 0)
        {
            InvokeRepeating(nameof(SonicRcsUnload), 0, config.firewallRule.rcsReportTime);
        }
#endif
    }

    /// <summary>
    /// 用户无操作检测 - 恢复发奖
    /// </summary>
    private async void ComputerGlueApproval()
    {
        if (!AsiaProdigy) return;

        WandApprovalPloy = Time.time;

        // 如果活动状态为0，恢复活动状态计时
        int recoverRewardTimesSeconds = UnwarySovietPool.Textural.UnwarySoviet.clientNoOperationRule.recoverRewardTimesSeconds;
        if ((CandidReside == 0 || BackupPool.Textural.Stroke == 0) && recoverRewardTimesSeconds != 0)
        {
            // Debug.Log("--- 有用户操作，恢复发奖");
            if (CandidReside == 0)
            {
                CandidReside = 1;   // 先设置为1，防止重复发送请求
                LipidSowPool.Textural.CornGlueLipid(10006, "sys_app_have_operation_restart_reward_ads_10006");  // 发送用户操作日志
            }
            // 向后台发送停止发奖请求
            bool res = await BackupPool.Textural.BluishStroke();
            // 如果停止发奖请求发送失败，则恢复活动状态
            CandidReside = res ? 1 : 0;

            PHTreeTwigAbsence.SetInt("PH_active_status", CandidReside);
        }
    }

    private async void SonicResentment()
    {
        while (true)
        {
            if (AsiaProdigy)
            {
                float inactiveTime = Time.time - WandApprovalPloy;
                //Debug.Log("Ads inactiveTime: " + inactiveTime + ", lastActivityTime:" + lastActivityTime);
                if ((CandidReside == 1 || BackupPool.Textural.Stroke == 1) && ConferenceTechnical != 0 && inactiveTime >= ConferenceTechnical)
                {
                    Debug.Log("--- 无用户操作，停止发奖");
                    if (CandidReside == 1)
                    {
                        CandidReside = 0;   // 先设置为0，防止重复发送请求
                        LipidSowPool.Textural.CornGlueLipid(10005, "sys_app_no_operation_stop_reward_ads_10005");    // 发送用户操作日志
                    }
                    // 向后台发送停止发奖请求
                    bool res = await BackupPool.Textural.HearStroke();
                    // 如果停止发奖请求发送失败，则恢复活动状态
                    CandidReside = res ? 0 : 1;

                    PHTreeTwigAbsence.SetInt("PH_active_status", CandidReside);
                }
            }
            await UniTask.Delay(1000); // 每秒检查一次
        }
    }

    /// <summary>
    /// 用于接收iOS的UA回调，目前貌似只有这种方法可行
    /// </summary>
    /// <param name="ua"></param>
    public void GetUserAgentReceived(string ua)
    {
        if (!string.IsNullOrEmpty(ua))
        {
            PHTreeTwigAbsence.SetString("PH_ua", ua);
        }
    }

    /// <summary>
    /// 风控检测
    /// </summary>
    private void SonicRcsUnload()
    {
        PeakPool.Textural.SonicPeak();
    }

    /// <summary>
    /// 用户接收iOS的deviceToken的回调
    /// </summary>
    /// <param name="token"></param>
    public void OnDeviceTokenReceived(string token)
    {
        BurrowPool.Textural.RecipeAllende.OnDeviceTokenReceived(token);
    }

    /// <summary>
    /// 用户接收iOS的是否允许广告跟踪的回调
    /// </summary>
    /// <param name="status"></param>
    public void OnIDFAPermissionChanged(string status)
    {
        Debug.Log("--- OnIDFAPermissionChanged status: " + status);
        PHTreeTwigAbsence.SetInt("PH_IDFA_status", int.Parse(status));
    }
}
