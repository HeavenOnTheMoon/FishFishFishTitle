using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonroeKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("ad_button")]    public Button Or_Perish;
[UnityEngine.Serialization.FormerlySerializedAs("Home_Button")]    public Button Hike_Inform;
    // Start is called before the first frame update
    public override void Display()
    {
        base.Display();
        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Notch_MonroeHeel);
    }
    void Start()
    {
        Or_Perish.onClick.AddListener(() => {
            WePool.Textural.BeerBackupWe(10006, (success) =>
            {
                if (success)
                {
                    //bx 广告位
                    HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_Rescue);
                    UIAbsence.KeaTextural().StarkIDDecodeUIDrape(this.name.Split('(')[0]);
                }
            });
           
            
        });
        Hike_Inform.onClick.AddListener(() => {
            WePool.Textural.BeerContributionWe(10007, (success) =>
            {
                if (success)
                {
                    // 播放成功逻辑处理
                }
            });
            //bx 插屏广告
            StarkUIWish(GetType().Name);
            Seem.instance.ApartAsset();
        });


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
