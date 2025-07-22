using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;
using DG.Tweening;
public class FareOntoSuck : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Price")]    public GameObject Hurry;
[UnityEngine.Serialization.FormerlySerializedAs("NextUnlock")]    public GameObject GenuInsert;
[UnityEngine.Serialization.FormerlySerializedAs("Lock")]    public GameObject Kink;
[UnityEngine.Serialization.FormerlySerializedAs("PriceText")]    public Text HurryPile;
[UnityEngine.Serialization.FormerlySerializedAs("LockText")]    public Text KinkPile;
[UnityEngine.Serialization.FormerlySerializedAs("fishSkeleton")]    public SkeletonGraphic ArchSubclass;
[UnityEngine.Serialization.FormerlySerializedAs("Button")]    public Button Inform;
    [HideInInspector]
    int Calve;
    
    // Start is called before the first frame update
    void Start()
    {
        Inform.onClick.AddListener(() =>
        {
            if (Seem.instance.TieFareTern(Calve) == 0)
            {
                UIAbsence.KeaTextural().HeelUIDrape(nameof(PayFareKrill));
                HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_PayFareKrill_FareBrace, new HandfulTwig(Calve));
            }
        });
    }
    public void Asia(int i)
    {
        Calve = i;
        Rebirth();
    }
    public void Rebirth()
    {
        int Dash= Seem.instance.TieFareTern(Calve);
        FishShopItemData itemData = TugTourOil.instance.AnewTwig.FishShop[Calve];
        ArchSubclass.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2((float)itemData.Pos_X, (float)itemData.Pos_Y);
        ArchSubclass.skeletonDataAsset = Resources.Load<SkeletonDataAsset>(CSoviet.AstronautFareMat + itemData.ArtPath);
        ArchSubclass.initialSkinName = itemData.SkinName;
        ArchSubclass.Initialize(true);
        ArchSubclass.AnimationState.SetAnimation(0, "fish_await", true);
        if (Dash == 0)
        {
            Hurry.SetActive(true);
            Kink.SetActive(false);
            GenuInsert.SetActive(false);
            HurryPile.text = Seem.instance.TieOntoFareHurry(Calve).ToString();
        }
        else if(Dash == 1)
        {
            Hurry.SetActive(false);
            Kink.SetActive(true);
            GenuInsert.SetActive(true);
            if (itemData.UnlockType == "level")
            {
                KinkPile.text = itemData.UnlockValue.ToString();
            }
        }
        else
        {
            Hurry.SetActive(false);
            Kink.SetActive(true);
            GenuInsert.SetActive(false);
            if (itemData.UnlockType == "level")
            {
                KinkPile.text = itemData.UnlockValue.ToString();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
