using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BeKinkFareSeepKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("Fx_FireWorkLift")]    public GameObject It_HearCubeIdle;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_FireWorkRight")]    public GameObject It_HearCubeMatch;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_Star")]    public GameObject It_Peru;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_BubbleTransitions")]    public GameObject It_PistonTherapeutic;
[UnityEngine.Serialization.FormerlySerializedAs("FishTank")]    public GameObject FareSeep;
[UnityEngine.Serialization.FormerlySerializedAs("Content")]    public GameObject Kestrel;
[UnityEngine.Serialization.FormerlySerializedAs("GetBtn")]    public GameObject KeaBow;
[UnityEngine.Serialization.FormerlySerializedAs("TileText")]    public GameObject MailPile;
[UnityEngine.Serialization.FormerlySerializedAs("BGImage")]    public GameObject BGMouse;
[UnityEngine.Serialization.FormerlySerializedAs("TankIcon")]    public Image SeepWhig;
[UnityEngine.Serialization.FormerlySerializedAs("fishNameText")]    public Text ArchBoldPile;
[UnityEngine.Serialization.FormerlySerializedAs("MoveOffset")]    public float GiveNephew;
    int Calve;

    /// <summary>
    /// 初始化
    /// </summary>
    public override void Display()
    {
        base.Display();
        It_PistonTherapeutic.transform.position = new Vector3(It_PistonTherapeutic.transform.position.x, It_PistonTherapeutic.transform.position.y - 10, It_PistonTherapeutic.transform.position.z);
        It_PistonTherapeutic.SetActive(false);
        It_HearCubeIdle.SetActive(false);
        It_HearCubeMatch.SetActive(false);
        It_Peru.SetActive(false);
        MailPile.SetActive(true);
        KeaBow.SetActive(true);
        FareSeep.SetActive(true);
        FareSeep.transform.position = new Vector3(FareSeep.transform.position.x, FareSeep.transform.position.y - GiveNephew, FareSeep.transform.position.z);
        KeaBow.transform.position = new Vector3(KeaBow.transform.position.x, KeaBow.transform.position.y - GiveNephew, KeaBow.transform.position.z);
        MailPile.transform.position = new Vector3(MailPile.transform.position.x, MailPile.transform.position.y - GiveNephew, MailPile.transform.position.z);
        Kestrel.GetComponent<CanvasGroup>().alpha = 0;
        BGMouse.GetComponent<Image>().material = null;
        InsertFareSeep();
    }
    /// <summary>
    /// 解锁鱼缸
    /// </summary>
    /// <param name="finish"></param>
    public void InsertFareSeep() 
    {
        Seem.instance.AnewAdultDownYam();
        It_HearCubeIdle.SetActive(true);
        It_HearCubeMatch.SetActive(true);
        It_Peru.SetActive(true);
        Kestrel.GetComponent<CanvasGroup>().DOFade(1, 0.4f);
        var s = DOTween.Sequence();
        s.Append(MailPile.transform.DOMoveY((MailPile.transform.position.y + GiveNephew), 0.3f).SetEase(Ease.OutBack));
        s.Insert(0.1f, FareSeep.transform.DOMoveY((FareSeep.transform.position.y + GiveNephew), 0.3f).SetEase(Ease.OutBack));
        s.Insert(0.2f, KeaBow.transform.DOMoveY((KeaBow.transform.position.y + GiveNephew), 0.3f).SetEase(Ease.OutBack)).OnComplete(() => 
        {
            Seem.instance.ValidSeemAdultDownYam();
            /* finish();*/
        });
    }
    /// <summary>
    /// 鱼缸切换
    /// </summary>
    /// <param name="finish"></param>
    public void FareSeepTherapeutic() 
    {
        Seem.instance.AnewAdultDownYam();
        It_PistonTherapeutic.SetActive(true);
        float Star = 1;
        BGMouse.GetComponent<Image>().material = Resources.Load<Material>(CSoviet.SurmiseGiveNephew);
        MailPile.SetActive(false);
        KeaBow.SetActive(false);
        FareSeep.SetActive(false);
        It_PistonTherapeutic.transform.position = new Vector3(It_PistonTherapeutic.transform.position.x, -KeaVesselTwig.KeaTextural().TieCourseSponge() / 2, It_PistonTherapeutic.transform.position.z);
        It_PistonTherapeutic.transform.DOMoveY(KeaVesselTwig.KeaTextural().TieCourseSponge() / 2, 1.6f);
        DOTween.To(() => Star, x => BGMouse.GetComponent<Image>().material.SetFloat("_MoveOffset", Star = x), -10, 1.5f).OnComplete(() => 
        {
            StarkUIWish(GetType().Name);
            Seem.instance.ValidSeemAdultDownYam();
        });
    }
    void Start()
    {
        
    }
    protected override void Awake()
    {
        base.Awake();
        KeaBow.GetComponent<Button>().onClick.AddListener(() =>
        {
            Seem.instance.BehindSeepFare(Calve);
            FareSeepTherapeutic();
            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_PackerFareSeep, new HandfulTwig(Calve));
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_InsertFareSeepKrillBrace, (messageData) =>
        {
            Calve = messageData.TroutAsk;
            AquariumShopItemData Luck= TugTourOil.instance.AnewTwig.AquariumShop[messageData.TroutAsk];
            ArchBoldPile.text = Luck.Name;
            SeepWhig.sprite = Resources.Load<Sprite>(CSoviet.SAxTex_MailFareBG + (Calve + 1) + CSoviet.AxSon_MailFareBG + (Calve + 1) + CSoviet.AxSeep);

        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
