using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkAbsence : MonoBehaviour
{
    public static PinkAbsence instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update

    //    void Start()
    //    {

    //    }

    //    public void gameInit()
    //    {
    //        bool isNewPlayer = !PlayerPrefs.HasKey(CSoviet.sv_IsNewPlayer + "Bool") || TreeTwigAbsence.GetBool(CSoviet.sv_IsNewPlayer);
    //        AdjustInitManager.Instance.InitAdjustData(isNewPlayer);
    //        if (isNewPlayer)
    //        {
    //            // 新用户
    //            TreeTwigAbsence.SetBool(CSoviet.sv_IsNewPlayer, false);
    //        }

    //        ThereOil.GetInstance().PlayBg(ThereTern.SceneMusic.Sound_BGM);

    //        UIAbsence.GetInstance().ShowUIForms(nameof( SeemKrill));

    //        SeemTwigAbsence.GetInstance().InitGameData();

    //#if SOHOShop
    //        SOHOShopManager.instance.InitSOHOShop();
    //#endif

    //    }

}
