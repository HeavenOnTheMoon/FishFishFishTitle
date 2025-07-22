using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BackupKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("CashBase")]    public GameObject SoarMote;
[UnityEngine.Serialization.FormerlySerializedAs("GoldBase")]    public GameObject ChicMote;
[UnityEngine.Serialization.FormerlySerializedAs("ExpBase")]    public GameObject ButMote;
[UnityEngine.Serialization.FormerlySerializedAs("StarExpBase")]    public GameObject PeruButMote;
[UnityEngine.Serialization.FormerlySerializedAs("PuzzleBase")]    public GameObject StitchMote;
[UnityEngine.Serialization.FormerlySerializedAs("ShellBase")]    public GameObject TenetMote;
[UnityEngine.Serialization.FormerlySerializedAs("FullMask")]    public GameObject DrugDown;
[UnityEngine.Serialization.FormerlySerializedAs("BottomMask")]    public GameObject BankerDown;
[UnityEngine.Serialization.FormerlySerializedAs("TopMask")]    public GameObject LapDown;
    protected override void Awake()
    {
        base.Awake();
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_BackupKrill_Beer,(messageData)=>
        {
            //if (messageData.valueString2 == null || messageData.valueString2 == "" || messageData.valueString2 == "Full")
            //{
            //    FullMask.SetActive(true);
            //}
            if (messageData.TroutMexico2 == "TopBottom")
            {
                DrugDown.SetActive(false);
                BankerDown.SetActive(true);
                LapDown.SetActive(true);
            }
            int count = messageData.TroutAsk;
            if (count == 0)
            {
                count = 5;
            }
            if (messageData.TroutMexico == "Gold")
            {
                GameObject Fx_Power = Instantiate(Resources.Load<GameObject>(CSoviet.SurmiseFXTract), messageData.TroutSeemFluent.transform);
                Fx_Power.SetActive(false);
                AstronautAttainment.ChicGiveKeel(ChicMote, count, ChicMote.transform, messageData.TroutSeemFluent.transform,() =>
                {
                    StarkUIWish(GetType().Name);
                    messageData.TextureCrewRoof?.Invoke();
                    Destroy(Fx_Power);
                });
            }
            if (messageData.TroutMexico == "Cash")
            {
                GameObject Fx_Power = Instantiate(Resources.Load<GameObject>(CSoviet.SurmiseFXTract), messageData.TroutSeemFluent2.transform);
                Fx_Power.SetActive(false);
                AstronautAttainment.ChicGiveKeel(SoarMote, count, SoarMote.transform, messageData.TroutSeemFluent2.transform, () =>
                {
                    StarkUIWish(GetType().Name);
                    messageData.TextureCrewRoof?.Invoke();
                    Destroy(Fx_Power);
                });
            }
            if (messageData.TroutMexico == "Exp")
            {
                GameObject Fx_Power = Instantiate(Resources.Load<GameObject>(CSoviet.SurmiseFXTract), messageData.TroutSeemFluent3.transform);
                Fx_Power.SetActive(false);
                AstronautAttainment.ChicGiveKeel(ButMote, 5, ButMote.transform, messageData.TroutSeemFluent3.transform, () =>
                {
                    StarkUIWish(GetType().Name);
                    messageData.TextureCrewRoof?.Invoke();
                    Destroy(Fx_Power);
                });
            }
            if (messageData.TroutMexico == "StarExp")
            {
                GameObject Fx_Power = Instantiate(Resources.Load<GameObject>(CSoviet.SurmiseFXTract), messageData.TroutSeemFluent4.transform);
                Fx_Power.SetActive(false);
                AstronautAttainment.ChicGiveKeel(PeruButMote,  1, PeruButMote.transform, messageData.TroutSeemFluent4.transform, () =>
                {
                    StarkUIWish(GetType().Name);
                    messageData.TextureCrewRoof?.Invoke();
                    Destroy(Fx_Power);
                });
            }
            if (messageData.TroutMexico == "Puzzle")
            {
                GameObject Fx_Power = Instantiate(Resources.Load<GameObject>(CSoviet.SurmiseFXTract), messageData.TroutSeemFluent5.transform);
                Fx_Power.SetActive(false);
                AstronautAttainment.ChicGiveKeel(StitchMote, 3, StitchMote.transform, messageData.TroutSeemFluent5.transform,  () =>
                {
                    StarkUIWish(GetType().Name);
                    messageData.TextureCrewRoof?.Invoke();
                    Destroy(Fx_Power);
                });
            }
            if (messageData.TroutMexico == "Shell")
            {
                GameObject Fx_Power = Instantiate(Resources.Load<GameObject>(CSoviet.SurmiseFXTract), messageData.TroutSeemFluent6.transform);
                Fx_Power.SetActive(false);
                AstronautAttainment.ChicGiveKeel(TenetMote,  1, TenetMote.transform, messageData.TroutSeemFluent6.transform, () =>
                {
                    StarkUIWish(GetType().Name);
                    messageData.TextureCrewRoof?.Invoke();
                    Destroy(Fx_Power);
                });
            }
            ThereOil.KeaTextural().BeerAlbedo(ThereTern.SceneMusic.Sound_HomeGold);
        
        });

    }
    public override void Display()
    {
        
        base.Display();
        DrugDown.SetActive(true);
        BankerDown.SetActive(false);
        LapDown.SetActive(false);
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
