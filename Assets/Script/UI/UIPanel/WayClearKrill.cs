using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WayClearKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("ProgressImage")]    public Image UntappedMouse;
[UnityEngine.Serialization.FormerlySerializedAs("needLevelNumberText")]    public Text RoarExactSupplyPile;
[UnityEngine.Serialization.FormerlySerializedAs("PlayButton")]    public Button BeerInform;
    public override void Display()
    {
        base.Display();
        BigChestItemData Luck= Seem.instance.TieAssetNetBisTwig();
        UntappedMouse.fillAmount = (float)Seem.instance.TiePeruNetBut() / Luck.Exp;
        int count = Luck.Exp - Seem.instance.TiePeruNetBut();
        GetComponent<I2.Loc.LocalizationParamsManager>().SetParameterValue("star_box", count.ToString());
        //needLevelNumberText.GetComponent<I2.Loc.Localize>().SetTerm(needLevelNumberText.GetComponent<I2.Loc.Localize>().Term);
        //needLevelNumberText.text = "play " + ((data.Exp - Seem.instance.getStarBoxExp()) / int.Parse(TugTourOil.instance.InitData.level_pass_bigchest)) + " more games to unlock big chest";
    }
    // Start is called before the first frame update
    void Start()
    {
        BeerInform.onClick.AddListener(() =>
        {
            StarkUIWish(GetType().Name);
            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HikeKrillExactAsset);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
