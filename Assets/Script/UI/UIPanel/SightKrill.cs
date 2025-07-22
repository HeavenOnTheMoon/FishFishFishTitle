using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SightKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("skill_icon")]    public Image Front_icon;
[UnityEngine.Serialization.FormerlySerializedAs("undo_sprite")]    public Sprite Push_Rennin;
[UnityEngine.Serialization.FormerlySerializedAs("hint_sprite")]    public Sprite Cute_Rennin;
[UnityEngine.Serialization.FormerlySerializedAs("shuffle_sprite")]    public Sprite Imagist_Rennin;
[UnityEngine.Serialization.FormerlySerializedAs("undo_text")]    public GameObject Push_Code;
[UnityEngine.Serialization.FormerlySerializedAs("hint_text")]    public GameObject Cute_Code;
[UnityEngine.Serialization.FormerlySerializedAs("shuffle_text")]    public GameObject Imagist_Code;
[UnityEngine.Serialization.FormerlySerializedAs("ad_button")]    public Button Or_Perish;
    string Dash;
    public override void Display()
    {
        base.Display();
        

    }
    // Start is called before the first frame update
    override protected void Awake()
    {
        base.Awake();
        int ad_index = 0;
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_SightTern, (data) =>
        {
            Dash = data.TroutMexico;
            
            switch (data.TroutMexico)
            {
                case "mg_undo":
                    ad_index = 102;
                    Front_icon.sprite = Push_Rennin;
                    Push_Code.SetActive(true);
                    Cute_Code.SetActive(false);
                    Imagist_Code.SetActive(false);
                    break;
                case "mg_hint":
                    ad_index = 103;
                    Front_icon.sprite = Cute_Rennin;
                    Push_Code.SetActive(false);
                    Cute_Code.SetActive(true);
                    Imagist_Code.SetActive(false);
                    break;
                case "mg_shuffle":
                    ad_index = 104;
                    Front_icon.sprite = Imagist_Rennin;
                    Push_Code.SetActive(false);
                    Cute_Code.SetActive(false);
                    Imagist_Code.SetActive(true);
                    break;
            }
        });
        Or_Perish.onClick.AddListener(() =>
        {
            WePool.Textural.BeerBackupWe(10005, (success) =>
            {
                if (success)
                {
                    // bx 广告位
                    HandfulCannonForth.KeaTextural().Corn(Dash);
                    UIAbsence.KeaTextural().StarkIDDecodeUIDrape(this.name.Split('(')[0]);
                }
            });
           
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
