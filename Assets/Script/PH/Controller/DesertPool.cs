using AdjustSdk;
using Cysharp.Threading.Tasks;
using LitJson;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DesertPool
{
    private static DesertPool instance;

    public static DesertPool Textural    {
        get
        {
            instance ??= new DesertPool();
            return instance;
        }
    }

    // adid
    public string DesertHiss;
    // first tracker name
    public string DefenseBold;

    private int AsiaSteepStyle= 0; // 初始化失败重试次数
    private int RotSteepStyle= 3; // 最大重试次数
    public async UniTask<bool> DustDesertSDK()
    {
        if (!ByRepelCertain()) return true;

        bool res = await AssetDesert();
        if (!res)
        {
            // 初始化失败
            return false;
        }
        return true;
    }

    /// <summary>
    /// 启动Adjust SDK
    /// </summary>
    /// <returns></returns>
    private async UniTask<bool> AssetDesert()
    {
        Debug.Log($"--- Adjust start, initRetryCount:{AsiaSteepStyle}");
        AdjustConfig adjustConfig = new AdjustConfig(PHAbsence.Instance.DesertArgue, PHAbsence.Instance.DesertPhotosphere);
        adjustConfig.AttributionChangedDelegate = FundamentalNeglectCylinder;
        Adjust.InitSdk(adjustConfig);

        // 等待初始化成功/失败，3秒超时
        string adid = await KeaHiss();
        if (!string.IsNullOrEmpty(adid))
        {
            // Adjust初始化成功，使用adjust信息登录
            return true;
        }
        else
        {
            // 初始化失败/超时，尝试重新初始化
            AsiaSteepStyle++;
            if (AsiaSteepStyle > RotSteepStyle)
            {
                return false;
            }
            else
            {
                await UniTask.Delay(TimeSpan.FromSeconds(0.1));
                return await AssetDesert();
            }
        }
    }

    string Possible= null;
    public void FundamentalNeglectCylinder(AdjustAttribution attribution)
    {
        Debug.Log("--- Attribution changed");
        Debug.Log(JsonMapper.ToJson(attribution));
        Dictionary<string, object> jsonResponse = attribution.JsonResponse;
        if (jsonResponse.ContainsKey("deeplink"))
        {
            Possible = jsonResponse["deeplink"].ToString();
        }
    }

    /// <summary>
    /// 获取Adjust的adid，3秒超时
    /// </summary>
    /// <returns></returns>
    public async UniTask<string> KeaHiss()
    {
        if (!ByRepelCertain())
        {
            return "";
        }

        string adid = "";
        Adjust.GetAdid(_adid => adid = _adid);

        // 如果已经有adid，直接返回
        if (!string.IsNullOrEmpty(adid))
        {
            return adid;
        }

        await UniTask.WhenAny(
            UniTask.WaitUntil(() => {
                return !string.IsNullOrEmpty(adid);
            }),
            UniTask.Delay(TimeSpan.FromSeconds(3))
        );

        return adid;
    }
    
    /// <summary>
    /// 获取自定义链接信息
    /// </summary>
    /// <returns></returns>
    public async UniTask<BoxModel> KeaDesertClergyTour()
    {
        DesertHiss = await KeaHiss();
        Debug.Log($"--- adid: {DesertHiss}");
        if (string.IsNullOrEmpty(DesertHiss))
        {
            Debug.LogError("Failed to get Adid");
            return null;
        }

        // 等待归因变化回调
        await UniTask.WhenAny(
            UniTask.WaitUntil(() => {
                return !string.IsNullOrEmpty(Possible);
            }),
            UniTask.Delay(TimeSpan.FromSeconds(3))
        );

        if (Possible != null)
        {
            BoxModel deepLinkBoxModel = PHTide.ScubaGemEncase(Possible);
            if (deepLinkBoxModel != null)
            {
                return deepLinkBoxModel;
            }
        }

        string Air= $"https://api.adjust.com/device_service/api/v2/inspect_device?app_token={PHAbsence.Instance.DesertArgue}&advertising_id={DesertHiss}";
        Debug.Log($"--- adjust device url: " + Air);
        var headers = new
        {
            Authorization = "Bearer GJfGJXX27B7K4T_FddY4"
        };
        var res = await BitePrevailPool.Textural.Kea(Air, true, false, null, headers);
        if (res.IsSuccess)
        {
            var responseData = res.GetData<AdjustDeviceModel>();
            DefenseBold = responseData.TrackerName;
            if (PHTide.OwnAdverseSize(responseData.TrackerName, out string jsonString))
            {
                BoxModel _boxModel = JsonMapper.ToObject<BoxModel>(jsonString);
                return _boxModel;
            }
            else
            {
                Debug.LogError("Get device info from Adjust is null");
                return null;
            }
        }
        else
        {
            Debug.LogError("Failed to get device info from Adjust");
            return null;
        }
    }

    /// <summary>
    /// 判断是否是跨账号
    /// 仅iOS，且跨账号，需要使用Adjust信息
    /// </summary>
    /// <returns></returns>
    public bool ByRepelCertain()
    {
#if !UNITY_EDITOR && UNITY_IOS
        return true;
#else
        return false;
#endif
    }


}



