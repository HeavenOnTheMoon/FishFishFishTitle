using LitJson;
using UnityEngine;

public class PeakPool
{
    private static PeakPool instance;

    public static PeakPool Textural    {
        get
        {
            instance ??= new PeakPool();
            return instance;
        }
    }

    /// <summary>
    /// 风险检测
    /// </summary>
    public void SonicPeak()
    {
#if UNITY_EDITOR
        // 编辑器下不进行风险检测
        Debug.Log("--- Risk detection in editor");

#elif UNITY_IOS
        // 获取设备Token，等待回调
        BurrowPool.Textural.RecipeAllende.RiskManagement(LintelArgueScenario);
#elif UNITY_ANDROID
        // TODO
#endif
    }

    /// <summary>
    /// 设备token回调，上报用户信息日志
    /// </summary>
    /// <param name="token"></param>
    private async void LintelArgueScenario(string token)
    {
        await PHTide.OntoDaily("/api/game/gameuserinfolog");

        Debug.Log("--- Device token: " + token);
        if (string.IsNullOrEmpty(token) || token == "Error" || token == "Unsupported")
        {
            Debug.Log("--- Device token is null or error, please check your device.");
            token = "";
        }

        string vpn = BurrowPool.Textural.RecipeAllende.CheckVPN();  // 是否开启VPN
        Vector2 size = BurrowPool.Textural.RecipeAllende.GetLogicalSize();
        JsonData json = new()
        {
            ["model"] = SystemInfo.deviceModel,
            ["appBuildVerLast"] = BurrowPool.Textural.MayDoubtRut,
            ["vpn"] = vpn,
            ["deviceCheckToken"] = token,
            ["sizeWidth"] = (int)size.x,
            ["sizeHigh"] = (int)size.y,
            ["pixelWidth"] = Screen.width,
            ["pixelHigh"] = Screen.height,
            ["sysVer"] = SystemInfo.operatingSystem,
            ["os"] = BurrowPool.Textural.KeaOs(),
        };
        // 传感器数据
        DrawingAnvil sensorsModel = BurrowPool.Textural.RecipeAllende.GetSensorsData();
        if (sensorsModel != null)
        {
            json["accelerometer"] = sensorsModel.accelerometer;
            json["gyroscope"] = sensorsModel.gyroscope;
            json["magnetometer"] = sensorsModel.magnetometer;
            json["equipmentPosture"] = sensorsModel.equipmentPosture;
        }
        string signature = PHTide.AtVirtueSunAtticMexico(json);
        string pre = DailyPool.Textural.GlueTour.pre;
        json["signature"] = PHTide.InnovatorMD5(pre + signature + "gamebox");
        var postResponse = await BitePrevailPool.Textural.Weld(PHGloss.BASE_URL + "/api/game/gameuserinfolog", JsonMapper.ToJson(json), true, false);
        if (!postResponse.IsSuccess)
        {
            // 加签失败
            if (postResponse.StatusCode == 500027)
            {
                await PHTide.OntoDaily("/api/game/gameuserinfolog");
                if (pre != DailyPool.Textural.GlueTour.pre)
                {
                    // 加签失败，重新计算加签，并重新请求
                    json["signature"] = PHTide.InnovatorMD5(DailyPool.Textural.GlueTour.pre + signature + "gamebox");
                    await BitePrevailPool.Textural.Weld(PHGloss.BASE_URL + "/api/game/gameuserinfolog", JsonMapper.ToJson(json), true, false);
                }
            }
        }
    }
}
