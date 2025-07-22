using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdultKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("Music_Button")]    public Button There_Inform;
[UnityEngine.Serialization.FormerlySerializedAs("Sound_Button")]    public Button Notch_Inform;
[UnityEngine.Serialization.FormerlySerializedAs("SoundIcon")]    public Image NotchWhig;
[UnityEngine.Serialization.FormerlySerializedAs("MusicIcon")]    public Image ThereWhig;
[UnityEngine.Serialization.FormerlySerializedAs("Continue_Button")]    public Button Struggle_Inform;
[UnityEngine.Serialization.FormerlySerializedAs("Restart_Button")]    public Button Permian_Inform;
[UnityEngine.Serialization.FormerlySerializedAs("BugButton")]    public Button InkInform;
[UnityEngine.Serialization.FormerlySerializedAs("MusicCloseSprite")]    /*public Button Home_Button;*/
    public Sprite ThereStarkVanish;
[UnityEngine.Serialization.FormerlySerializedAs("MusicOpenSprite")]    public Sprite ThereWifeVanish;
[UnityEngine.Serialization.FormerlySerializedAs("SoundCloseSprite")]    public Sprite NotchStarkVanish;
[UnityEngine.Serialization.FormerlySerializedAs("SoundOpenSprite")]    public Sprite NotchWifeVanish;

    int RenewBrace;

    public override void Display()
    {
        base.Display();
        RenewBrace = 0;
        ThereWhig.sprite = ThereOil.KeaTextural().MyThereEurope ? ThereWifeVanish : ThereStarkVanish;
        NotchWhig.sprite = ThereOil.KeaTextural().AlbedoThereEurope ? NotchWifeVanish : NotchStarkVanish;
        if (TreeTwigAbsence.GetInt(CSoviet.Or_Exact_It) == 1)
        {
            //Home_Button.gameObject.SetActive(false);
            Permian_Inform.gameObject.SetActive(false);
        }
        else
        {
            //Home_Button.gameObject.SetActive(true);
            Permian_Inform.gameObject.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Struggle_Inform.onClick.AddListener(() => {
            StarkUIWish(GetType().Name);
        });
        Permian_Inform.onClick.AddListener(() => {
            Seem.instance.ApartAsset();
            StarkUIWish(GetType().Name);
        });
        /*Home_Button.onClick.AddListener(() => {
            CloseUIForm(GetType().Name);
            Seem.instance.levelFinish();

        });*/
        There_Inform.onClick.AddListener(() => 
        {
            
            ThereOil.KeaTextural().MyThereEurope = !ThereOil.KeaTextural().MyThereEurope;
            ThereWhig.sprite = ThereOil.KeaTextural().MyThereEurope ? ThereWifeVanish : ThereStarkVanish;
        });
        Notch_Inform.onClick.AddListener(() => 
        {

            ThereOil.KeaTextural().AlbedoThereEurope = !ThereOil.KeaTextural().AlbedoThereEurope;
            NotchWhig.sprite = ThereOil.KeaTextural().AlbedoThereEurope ? NotchWifeVanish : NotchStarkVanish;
        });

        InkInform.onClick.AddListener(()=> {
            RenewBrace++;
            if (RenewBrace >= 5)
            {
                RenewBrace = 0;
                UIAbsence.KeaTextural().HeelUIDrape(nameof(RenewTourKrill));
            }
        });
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
