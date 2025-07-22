using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RapportKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("Sound_Button")]    public Button Notch_Inform;
[UnityEngine.Serialization.FormerlySerializedAs("Music_Button")]    public Button There_Inform;
[UnityEngine.Serialization.FormerlySerializedAs("SoundIcon")]    public Image NotchWhig;
[UnityEngine.Serialization.FormerlySerializedAs("MusicIcon")]    public Image ThereWhig;
[UnityEngine.Serialization.FormerlySerializedAs("Continue_Button")]    public Button Struggle_Inform;
[UnityEngine.Serialization.FormerlySerializedAs("Restart_Button")]    public Button Permian_Inform;
[UnityEngine.Serialization.FormerlySerializedAs("MusicCloseSprite")]    public Sprite ThereStarkVanish;
[UnityEngine.Serialization.FormerlySerializedAs("MusicOpenSprite")]    public Sprite ThereWifeVanish;
[UnityEngine.Serialization.FormerlySerializedAs("SoundCloseSprite")]    public Sprite NotchStarkVanish;
[UnityEngine.Serialization.FormerlySerializedAs("SoundOpenSprite")]    public Sprite NotchWifeVanish;

    public override void Display()
    {
        base.Display();
        ThereWhig.sprite = ThereOil.KeaTextural().MyThereEurope ? ThereWifeVanish : ThereStarkVanish;
        NotchWhig.sprite = ThereOil.KeaTextural().AlbedoThereEurope ? NotchWifeVanish : NotchStarkVanish;
    }
    // Start is called before the first frame update
    void Start()
    {
        Struggle_Inform.onClick.AddListener(() => {
            StarkUIWish(GetType().Name);
        });
        Permian_Inform.onClick.AddListener(() => {
            StarkUIWish(GetType().Name);
        });
        
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
    }

}
