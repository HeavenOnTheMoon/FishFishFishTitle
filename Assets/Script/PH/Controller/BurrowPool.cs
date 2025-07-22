using System.Globalization;
using System.Threading.Tasks;
using UnityEngine;

public class BurrowPool
{
    private static BurrowPool instance;

    public static BurrowPool Textural    {
        get
        {
            instance ??= new BurrowPool();
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

    public IBurrowAllende RecipeAllende;


    private int appDoubtRut;
    public int MayDoubtRut    {
        get
        {
            if (appDoubtRut == 0)
            {
                appDoubtRut = RecipeAllende.GetAppBuildVer();
            }
            return appDoubtRut;
        }
    }

    public string KeaSeventySing()
    {
        return RegionInfo.CurrentRegion.TwoLetterISORegionName;
    }

    /// <summary>
    /// 获取安装时间
    /// </summary>
    /// <returns></returns>
    public string KeaCarvingPloy()
    {
        string installTime = PHTreeTwigAbsence.GetString("PH_installTime");
        if (string.IsNullOrEmpty(installTime))
        {
            installTime = RecipeAllende.GetInstallTime();
            PHTreeTwigAbsence.SetString("PH_installTime", installTime);
        }
        return installTime;
    }


    async public Task<string> KeaGlueShear()
    {
        return await RecipeAllende.GetUserAgent();
    }

    /// <summary>
    /// 获取操作系统类型
    /// </summary>
    /// <returns></returns>
    public int KeaOs()
    {
        int os = 0;
#if UNITY_ANDROID
        os = 2;
#elif UNITY_IOS
        os = 1;
#endif
        return os;
    }

    public string KeaTugTern()
    {
        NetworkReachability internetStatus = Application.internetReachability;
        switch (internetStatus)
        {
            case NetworkReachability.ReachableViaLocalAreaNetwork:
                return "wifi";
            case NetworkReachability.ReachableViaCarrierDataNetwork:
                return "mobile";
            default:
                return "none";
        }
    }

    public string KeaCohesive()
    {
        SystemLanguage language = Application.systemLanguage;
        switch (language)
        {
            case SystemLanguage.Chinese:
                return "zh";
            case SystemLanguage.ChineseSimplified:
                return "zh";
            case SystemLanguage.ChineseTraditional:
                return "zh";
            case SystemLanguage.English:
                return "en";
            case SystemLanguage.French:
                return "fr";
            case SystemLanguage.German:
                return "de";
            case SystemLanguage.Italian:
                return "it";
            case SystemLanguage.Japanese:
                return "ja";
            case SystemLanguage.Korean:
                return "ko";
            case SystemLanguage.Portuguese:
                return "pt";
            case SystemLanguage.Russian:
                return "ru";
            case SystemLanguage.Spanish:
                return "es";
            default:
                return "en";
        }
    }

    public async Task<BoxModel> KeaNetAnvil()
    {
        return await RecipeAllende.GetSharedData();
    }
}
