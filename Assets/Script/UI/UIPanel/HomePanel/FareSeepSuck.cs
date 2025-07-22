using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FareSeepSuck : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("BannerImage")]    public Image StrictMouse;
[UnityEngine.Serialization.FormerlySerializedAs("LockMask")]    public GameObject KinkDown;
[UnityEngine.Serialization.FormerlySerializedAs("NameText")]    public Text BoldPile;
[UnityEngine.Serialization.FormerlySerializedAs("CapacityText")]    public Text ToleratePile;
[UnityEngine.Serialization.FormerlySerializedAs("Button")]    public Button Inform;
[UnityEngine.Serialization.FormerlySerializedAs("selectImage")]    public Image ScriptMouse;
[UnityEngine.Serialization.FormerlySerializedAs("selectSprite")]    public Sprite ScriptVanish;
[UnityEngine.Serialization.FormerlySerializedAs("normalSprite")]    public Sprite RenameVanish;
[UnityEngine.Serialization.FormerlySerializedAs("TankIcon")]    public Image SeepWhig;
    int Calve;
    private void Awake()
    {
        Inform.onClick.AddListener(() =>
        {
            if (TreeTwigAbsence.GetInt(CSoviet.Or_PackerFareSeep) != Calve && Seem.instance.TieFareSeepByInsert(Calve))
            {
                HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_PackerFareSeep,new HandfulTwig(Calve));
                ScriptMouse.sprite = ScriptVanish;
            }
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_PackerFareSeep, (messageData) =>
        {
            if (messageData.TroutAsk != Calve)
            {
                ScriptMouse.sprite = RenameVanish;
            }
        });
    }
    public void Asia(int i)
    {
        Calve = i;
        
        StrictMouse.sprite = Resources.Load<Sprite>(CSoviet.SeepStrictFareSeepSC + (1+i));
        SeepWhig.sprite = Resources.Load<Sprite>(CSoviet.SAxTex_MailFareBG + (Calve + 1) + CSoviet.AxSon_MailFareBG + (Calve + 1) + CSoviet.AxSeep);
        BoldPile.text = I2.Loc.LocalizationManager.GetTranslation("Aq/"+ TugTourOil.instance.AnewTwig.AquariumShop[i].Name);
        
        Arabian();
    }
    public void Arabian()
    {
        if (Seem.instance.TieFareSeepByInsert(Calve))
        {
            KinkDown.SetActive(false);
        }
        else
        {
            KinkDown.SetActive(true);
        }
        if (TreeTwigAbsence.GetInt(CSoviet.Or_PackerFareSeep) == Calve)
        {
            ScriptMouse.sprite = ScriptVanish;
        }
        else
        {
            ScriptMouse.sprite = RenameVanish;
        }
        ToleratePile.text = TreeTwigAbsence.GetIntArray(CSoviet.Or_SeepPastFareForm).Length + "/" + TugTourOil.instance.AnewTwig.AquariumShop[Calve].Capacity;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
