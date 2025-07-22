using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;
public class PayFareKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("BuyButton")]    public Button PayInform;
[UnityEngine.Serialization.FormerlySerializedAs("CanelButton")]    public Button WriteInform;
[UnityEngine.Serialization.FormerlySerializedAs("fishSkeleton")]    public SkeletonGraphic ArchSubclass;
[UnityEngine.Serialization.FormerlySerializedAs("PriceText")]    public Text HurryPile;
[UnityEngine.Serialization.FormerlySerializedAs("FishNameText")]    public Text FareBoldPile;
    int ArchBrace;
    protected override void Awake()
    {
        base.Awake();
        PayInform.onClick.AddListener(() =>
        {
            int state = Seem.instance.buyFare(ArchBrace);
            if (state == 1)
            {
                HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HikeKrillEuropeEmit,new HandfulTwig(1));
                StarkUIWish(GetType().Name);
                ArchSubclass.gameObject.SetActive(false);
            }
            else
            {
                WifeUIWish("BarbKrill");
                if (state == 2)
                {
                    HandfulCannonForth.KeaTextural().Corn("tips", new HandfulTwig("gold"));
                }
                if (state == 3)
                {
                    HandfulCannonForth.KeaTextural().Corn("tips", new HandfulTwig("tank"));
                }
            }
        });
        WriteInform.onClick.AddListener(() =>
        {
            StarkUIWish(GetType().Name);
            ArchSubclass.gameObject.SetActive(false);
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_PayFareKrill_FareBrace, (messageData) =>
        {
            ArchBrace = messageData.TroutAsk;
            FishShopItemData itemData = TugTourOil.instance.AnewTwig.FishShop[ArchBrace];
            ArchSubclass.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2((float)itemData.Pos_X, (float)itemData.Pos_Y);
            ArchSubclass.skeletonDataAsset = Resources.Load<SkeletonDataAsset>(CSoviet.AstronautFareMat + itemData.ArtPath);
            ArchSubclass.initialSkinName = itemData.SkinName;
            ArchSubclass.Initialize(true);
            ArchSubclass.AnimationState.SetAnimation(0, "fish_await", true);
            HurryPile.text = Seem.instance.TieOntoFareHurry(ArchBrace).ToString();
            FareBoldPile.text = I2.Loc.LocalizationManager.GetTranslation(CSoviet.Fare + itemData.Name);
        });
    }
    public override void Display()
    {
        base.Display();
        ArchSubclass.gameObject.SetActive(true);
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
