using System.Net.Sockets;
using System.Net;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

#if Old_UIFramework
public class RenewTourKrill : MoteUIDrape
#elif New_UIFramework
public class RenewTourKrill : BaseUI
#else
public class RenewTourKrill : MonoBehaviour
#endif
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button StarkBow;
[UnityEngine.Serialization.FormerlySerializedAs("DebugText")]    public Text RenewPile;
[UnityEngine.Serialization.FormerlySerializedAs("UpdateBtn")]    public Button RejoinBow;
[UnityEngine.Serialization.FormerlySerializedAs("ConfigIdInput")]    public InputField SovietItChalk;
[UnityEngine.Serialization.FormerlySerializedAs("UpdateConfigIdBtn")]    public Button RejoinSovietItBow;
[UnityEngine.Serialization.FormerlySerializedAs("AdLocationId")]    public InputField WeSavannahIt;
[UnityEngine.Serialization.FormerlySerializedAs("RewardBtn")]    public Button BackupBow;
[UnityEngine.Serialization.FormerlySerializedAs("IntBtn")]    public Button AskBow;

    // Start is called before the first frame update
    void Start()
    {
        StarkBow.onClick.AddListener(() =>
        {
#if Old_UIFramework
            StarkUIWish(GetType().Name);
#elif New_UIFramework
            UIAbsence.Instance.CloseUI();
#endif
        });


        RejoinBow.onClick.AddListener(() => {
            GlueAnvil newUser = new() {
                visitorId = PHTide.KeaUUID()
            };
            BurrowPool.Textural.RecipeAllende.SaveUserInfo(newUser);
            PHUIAbsence.Textural.HeelSpare("Account has been updated, please reopen the game to login again.");
        });

        RejoinSovietItBow.onClick.AddListener(async () => {
            if (string.IsNullOrEmpty(SovietItChalk.text))
            {
                PHUIAbsence.Textural.HeelSpare("Please input config id.");
                return;
            }
            string Air= $"{PHGloss.BASE_URL}/api/game/appversionconfig/ph/test?appVersionGroupId={int.Parse(SovietItChalk.text)}";
            var response = await BitePrevailPool.Textural.Kea(Air, true, false);
            if (response.IsSuccess)
            {
                PHUIAbsence.Textural.HeelSpare("Config id has been updated, please reopen the game to login again.");
            }
            else
            {
                PHUIAbsence.Textural.HeelSpare("Config id update failed, please check your network.");
            }
        });

        BackupBow.onClick.AddListener(() => {
            if (string.IsNullOrEmpty(WeSavannahIt.text))
            {
                PHUIAbsence.Textural.HeelSpare("Please input ad location id.");
                return;
            }
            WePool.Textural.BeerBackupWe(int.Parse(WeSavannahIt.text), (success) => { });
        });

        AskBow.onClick.AddListener(() => {
            if (string.IsNullOrEmpty(WeSavannahIt.text))
            {
                PHUIAbsence.Textural.HeelSpare("Please input ad location id.");
                return;
            }
            WePool.Textural.BeerContributionWe(int.Parse(WeSavannahIt.text), (success) => { });
        });
    }

#if Old_UIFramework
    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
#elif New_UIFramework
    public void Show()
    {
        base.Show();
#else
    public void Display()
    {
#endif

        HeelTour();
    }

    private async void HeelTour()
    {
        BoxModel AgoAnvil= await DailyPool.Textural.KeaNetTour();
        string ua = await BurrowPool.Textural.KeaGlueShear();

        StringBuilder sb = new StringBuilder();
        sb.Append("游戏的用户ID     ：");
        sb.Append(DailyPool.Textural.GlueTour.uid);
        sb.Append("\n");
        sb.Append("游戏关联的盒子用户ID ：");
        sb.Append(AgoAnvil?.uid);
        sb.Append("\n");
        sb.Append("游戏关联的盒子版本 ：");
        sb.Append(AgoAnvil?.appBuildVersion);
        sb.Append("\n");
        sb.Append("keychain拿到的数据");
        sb.Append("\n");
        sb.Append("keychainAppName : " + AgoAnvil?.appName);
        sb.Append("\n");
        sb.Append("keychainCampaign : " + AgoAnvil?.campaign);
        sb.Append("\n");
        sb.Append("keychainIdfv : " + AgoAnvil?.visitorId);
        sb.Append("\n");
        sb.Append("keychainBoxUid : " + AgoAnvil?.uid);
        sb.Append("\n");
        sb.Append("keychainEnvironment : " + AgoAnvil?.environment);
        sb.Append("\n");
        sb.Append("keychainVifv : " + AgoAnvil?.vifv);
        sb.Append("\n");
        sb.Append("版本号 ：");
        sb.Append(Application.version);
        sb.Append("\n");
        sb.Append("UA信息 ：");
        sb.Append(ua);
        sb.Append("\n");
        sb.Append("IP信息 ：");
        sb.Append(KeaScentIPv6());
        sb.Append("\n");
        sb.Append("campaign ：");
        sb.Append(AgoAnvil?.campaign);
        sb.Append("\n");
        sb.Append("deepLink ：");
        sb.Append(PHAbsence.Instance.HumpTossGem);
        sb.Append("\n");


        RenewPile.text = sb.ToString();
    }

    public string KeaScentIPv6()
    {
        string ipAddress = "";
        try
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    ipAddress = ip.ToString();
                    break;
                }
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("IP 获取失败" + e.Message);
        }
        return ipAddress;
    }
}
