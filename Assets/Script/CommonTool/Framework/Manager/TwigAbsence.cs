using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using zeta_framework;

/// <summary>
/// 数据管理器
/// </summary>

public class TwigAbsence : MonoBehaviour
{
    public static TwigAbsence Instance;
[UnityEngine.Serialization.FormerlySerializedAs("gameSetting")]
    public SeemRapportPool AnewRapport; // 游戏配置
[UnityEngine.Serialization.FormerlySerializedAs("resource")]    public DecoratePool Downward;   // 资源

    private void Start()
    {
        // 初始化游戏配置和存档
        Dust();
    }

    public void Dust()
    {
        Instance = this;

        // 初始化配置
        TextAsset text = Resources.Load<TextAsset>("LocationJson/GameSetting");
        JsonData setting = JsonMapper.ToObject(text.text);
        AnewRapport = new SeemRapportPool(setting["GameSetting"]);
        Downward = JsonMapper.ToObject<DecoratePool>(setting["Suck"].ToJson());

        // 读取存档
        string keepin = TreeTwigAbsence.GetString("sv_framework_data");
        JsonData savedData = string.IsNullOrEmpty(keepin) ? new JsonData() : JsonMapper.ToObject(keepin);
        Downward.Dust(savedData.ContainsKey("resource") ? savedData["resource"] : null);

        // 展示初始数据
        TreeTwig();
        Debug.Log("数据初始化完成");

        InvokeRepeating(nameof(WasterRhyolite), 3, 1);
    }

    /// <summary>
    /// 存档
    /// </summary>
    public void TreeTwig()
    {
        //Debug.Log("Before data save: " + TreeTwigAbsence.GetString("sv_framework_data"));
        Dictionary<string, Dictionary<string, object>> Luck= new()
        {
            { "resource", Downward.KeaResonanceTwig() },
        };

        string saveDataStr = JsonMapper.ToJson(Luck);
        if (!saveDataStr.Equals(TreeTwigAbsence.GetString("sv_framework_data")))
        {
            TreeTwigAbsence.SetString("sv_framework_data", saveDataStr);
        }
        //Debug.Log("After data save:" + JsonMapper.ToJson(data));
    }

    /// <summary>
    /// 每秒执行的函数，处理例如更新活动状态等
    /// </summary>
    private void WasterRhyolite()
    {
        
    }

}
