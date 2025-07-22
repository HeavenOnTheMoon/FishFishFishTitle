using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ExactKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("CashNumberText")]    public Text SoarSupplyPile;
[UnityEngine.Serialization.FormerlySerializedAs("CashImage")]    public Transform SoarMouse;
[UnityEngine.Serialization.FormerlySerializedAs("GoldNumberText")]    public Text ChicSupplyPile;
[UnityEngine.Serialization.FormerlySerializedAs("GoldImage")]    public Transform ChicMouse;
[UnityEngine.Serialization.FormerlySerializedAs("AmazonNumberText")]    public Text CarmanSupplyPile;
[UnityEngine.Serialization.FormerlySerializedAs("AmazonImage")]    public Transform CarmanMouse;
[UnityEngine.Serialization.FormerlySerializedAs("StarBoxText")]    public Text PeruNetPile;
[UnityEngine.Serialization.FormerlySerializedAs("LevelNumberText")]
    public Text ExactSupplyPile;
[UnityEngine.Serialization.FormerlySerializedAs("UndoButton")]    public Button EtchInform;
[UnityEngine.Serialization.FormerlySerializedAs("HintButton")]    public Button WhigInform;
[UnityEngine.Serialization.FormerlySerializedAs("ShuffleButton")]    public Button SurplusInform;
[UnityEngine.Serialization.FormerlySerializedAs("PauseButton")]    public Button AdultInform;
[UnityEngine.Serialization.FormerlySerializedAs("BankSliderImage")]   // public Button RedeemButton;
    public Image VeinFabricMouse;
[UnityEngine.Serialization.FormerlySerializedAs("BankButton")]    public Button VeinInform;
[UnityEngine.Serialization.FormerlySerializedAs("FullImage")]    public GameObject DrugMouse;
[UnityEngine.Serialization.FormerlySerializedAs("FX_Star")]    public GameObject FX_Peru;
[UnityEngine.Serialization.FormerlySerializedAs("FX_Ground")]    public GameObject FX_Period;
[UnityEngine.Serialization.FormerlySerializedAs("BaseCash")]    public GameObject MoteSoar;
[UnityEngine.Serialization.FormerlySerializedAs("TopBar")]    public GameObject LapLet;
[UnityEngine.Serialization.FormerlySerializedAs("BottonBar")]    public GameObject RepairLet;
[UnityEngine.Serialization.FormerlySerializedAs("AutoButton")]    public Button RomeInform;
[UnityEngine.Serialization.FormerlySerializedAs("StarBoxButton")]    public Button PeruNetInform;
[UnityEngine.Serialization.FormerlySerializedAs("GoldButton")]    public Button ChicInform;
[UnityEngine.Serialization.FormerlySerializedAs("AmazonButton")]    public Button CarmanInform;
[UnityEngine.Serialization.FormerlySerializedAs("PuzzleButton")]    public Button StitchInform;
[UnityEngine.Serialization.FormerlySerializedAs("PuzzleIcon")]    public Image StitchWhig;
[UnityEngine.Serialization.FormerlySerializedAs("flyManager")]    public TowAbsence SkiAbsence;
[UnityEngine.Serialization.FormerlySerializedAs("oldtop")]

    public GameObject Lumber;
[UnityEngine.Serialization.FormerlySerializedAs("oldbottom")]    public GameObject Volunteer;
[UnityEngine.Serialization.FormerlySerializedAs("newtop")]    public GameObject Banker;
[UnityEngine.Serialization.FormerlySerializedAs("newbottom")]    public GameObject Adventure;
[UnityEngine.Serialization.FormerlySerializedAs("newUndoButton")]    public Button EggEtchInform;
[UnityEngine.Serialization.FormerlySerializedAs("newHintButton")]    public Button EggWhigInform;
[UnityEngine.Serialization.FormerlySerializedAs("newShuffleButton")]    public Button EggSurplusInform;
[UnityEngine.Serialization.FormerlySerializedAs("newPauseButton")]    public Button EggAdultInform;
[UnityEngine.Serialization.FormerlySerializedAs("newLevelNumberText")]    public Text EggExactSupplyPile;
[UnityEngine.Serialization.FormerlySerializedAs("newGoldNumberText")]    public Text EggChicSupplyPile;
[UnityEngine.Serialization.FormerlySerializedAs("newGoldImage")]    public Transform EggChicMouse;

    Sequence SeemChicMat;
    int CorpTern= 1;
    bool AnyNutSight;

    private Sprite[] StitchArise;
    private int StitchWhigBrace;    // 当前显示的碎片
[UnityEngine.Serialization.FormerlySerializedAs("StartPanel")]    
    public GameObject AssetKrill;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button StarkBow;
[UnityEngine.Serialization.FormerlySerializedAs("newbg")]
    public GameObject Grind;

    // Start is called before the first frame update
    override protected void Awake()
    {
        if (LethalUtil.ByProhibit())
        {
            Grind.gameObject.SetActive(true);
            Lumber.gameObject.SetActive(false);
            Volunteer.gameObject.SetActive(false);
            Banker.gameObject.SetActive(true);
            Adventure.gameObject.SetActive(true);
        }
        else
        {
            Grind.gameObject.SetActive(false);
            Lumber.gameObject.SetActive(true);
            Volunteer.gameObject.SetActive(true);
            Banker.gameObject.SetActive(false);
            Adventure.gameObject.SetActive(false);

        }
        base.Awake();
        AssetKrill.gameObject.SetActive(true);
        StarkBow.onClick.AddListener(() =>
        {
            AssetKrill.gameObject.SetActive(false);
        });
        EtchInform.onClick.AddListener(() =>
        {
            if (AnyNutSight)
            {
                if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) > 2)
                {
                    if (Seem.instance.ApartAbsorb.GetComponent<ExactBeer>().ScriptMailForm.Count - Seem.instance.ApartAbsorb.GetComponent<ExactBeer>().VineAnswerForm.Count > 0)
                    {
                        if (Seem.instance.TieSightStyle("Undo") > 0)
                        {
                            Seem.instance.WadSightStyle("Undo", 1);
                            HandfulCannonForth.KeaTextural().Corn("mg_undo");
                            StartCoroutine(nameof(FrontTugNutOntoPloy));
                            ArabianSightStyle();
                            LipidSowPool.Textural.CornBackupLipid(1405, "used_props_once_1405");
                        }
                        else
                        {
                            UIAbsence.KeaTextural().HeelUIDrape(nameof(SightKrill));
                            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_SightTern, new HandfulTwig(CSoviet.Of_Push));
                        }
                    }
                }
                else
                {
                    TreeTwigAbsence.SetInt(CSoviet.Or_TarGlueSpin, 3);
                    TarGlueAbsence.KeaTextural().LiraDown(EtchInform.gameObject, true);
                    Seem.instance.DamSightStyle("Undo", 2);
                    HandfulCannonForth.KeaTextural().Corn("RefreshSkill");
                    HandfulCannonForth.KeaTextural().Corn("mg_undo");
                    StartCoroutine(nameof(FrontTugNutOntoPloy));
                }
            }
            
            
        });
        PeruNetInform.onClick.AddListener(() => 
        {
            //UIAbsence.GetInstance().ShowUIForms(nameof(PeruNetKrill));
            //return;
            if (Seem.instance.KeaPeruShy() < GameUtil.StarBoxNum())
            {
                SpareAbsence.KeaTextural().HeelSpare("Pass " + GameUtil.StarBoxNum() + " level to open the CHEST ");
                //AlertManager.GetInstance().ShowAlert("Pass " + GameUtil.StarBoxNum() + " level to open the CHEST ");
            }
            else
            {
                UIAbsence.KeaTextural().HeelUIDrape(nameof(PeruNetKrill));
            }
        });
        WhigInform.onClick.AddListener(() =>
        {
            if (AnyNutSight)
            {
                if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) > 3)
                {
                    if (Seem.instance.TieSightStyle("Hint") > 0)
                    {
                        Seem.instance.WadSightStyle("Hint", 1);
                        HandfulCannonForth.KeaTextural().Corn("mg_hint");
                        ArabianSightStyle();
                        StartCoroutine(nameof(FrontTugNutOntoPloy));
                        LipidSowPool.Textural.CornBackupLipid(1405, "used_props_once_1405");
                    }
                    else
                    {
                        UIAbsence.KeaTextural().HeelUIDrape(nameof(SightKrill));
                        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_SightTern, new HandfulTwig(CSoviet.Of_Cute));
                    }
                }
                else
                {
                    TreeTwigAbsence.SetInt(CSoviet.Or_TarGlueSpin, 4);
                    TarGlueAbsence.KeaTextural().LiraDown(WhigInform.gameObject, true);
                    Seem.instance.DamSightStyle("Hint", 2);
                    HandfulCannonForth.KeaTextural().Corn("RefreshSkill");
                    HandfulCannonForth.KeaTextural().Corn("mg_hint");
                    StartCoroutine(nameof(FrontTugNutOntoPloy));
                }
            }
            
        });
        SurplusInform.onClick.AddListener(() =>
        {
            if (AnyNutSight)
            {
                if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) > 4)
                {
                    if (Seem.instance.TieSightStyle("Shuffle") > 0)
                    {
                        Seem.instance.WadSightStyle("Shuffle", 1);
                        HandfulCannonForth.KeaTextural().Corn("mg_shuffle");
                        ArabianSightStyle();
                        StartCoroutine(nameof(FrontTugNutOntoPloy));
                        LipidSowPool.Textural.CornBackupLipid(1405, "used_props_once_1405");
                    }
                    else
                    {
                        UIAbsence.KeaTextural().HeelUIDrape(nameof(SightKrill));
                        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_SightTern, new HandfulTwig(CSoviet.Of_Imagist));
                    }
                }
                else
                {
                    TreeTwigAbsence.SetInt(CSoviet.Or_TarGlueSpin, 5);
                    TarGlueAbsence.KeaTextural().LiraDown(SurplusInform.gameObject, true);
                    Seem.instance.DamSightStyle("Shuffle", 2);
                    HandfulCannonForth.KeaTextural().Corn("RefreshSkill");
                    HandfulCannonForth.KeaTextural().Corn("mg_shuffle");
                    StartCoroutine(nameof(FrontTugNutOntoPloy));
                }
            }
        });
        RomeInform.onClick.AddListener(() => {
            Seem.instance.ApartAbsorb.GetComponent<ExactBeer>().RomeWheat();
            RomeInform.gameObject.SetActive(false);
        });
        AdultInform.onClick.AddListener(() =>
        {
            UIAbsence.KeaTextural().HeelUIDrape(nameof(AdultKrill));
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_ExactKrill_ExactSupply, (messageData) =>
        {
            ExactSupplyPile.text = ""+ messageData.TroutAsk;
            EggExactSupplyPile.text = "" + messageData.TroutAsk;
        });
        VeinInform.onClick.AddListener(() =>
        {
           
            WifeUIWish("BankPanel");
            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_VeinKrill_Aero, new HandfulTwig(GetType().Name));
        });

        EggAdultInform.onClick.AddListener(() =>
        {
            WePool.Textural.BeerContributionWe(10008, (success) =>
            {
                if (success)
                {
                    
                }
            });
            // 播放成功逻辑处理
            UIAbsence.KeaTextural().HeelUIDrape(nameof(AdultKrill));

        });
        EggEtchInform.onClick.AddListener(() =>
        {
            if (AnyNutSight)
            {
                if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) > 2)
                {
                    if (Seem.instance.ApartAbsorb.GetComponent<ExactBeer>().ScriptMailForm.Count - Seem.instance.ApartAbsorb.GetComponent<ExactBeer>().VineAnswerForm.Count > 0)
                    {
                        if (Seem.instance.TieSightStyle("Undo") > 0)
                        {
                            Seem.instance.WadSightStyle("Undo", 1);
                            HandfulCannonForth.KeaTextural().Corn("mg_undo");
                            StartCoroutine(nameof(FrontTugNutOntoPloy));
                            ArabianSightStyle();
                        }
                        else
                        {
                            UIAbsence.KeaTextural().HeelUIDrape(nameof(SightKrill));
                            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_SightTern, new HandfulTwig(CSoviet.Of_Push));
                        }
                    }
                }
                else
                {
                    TreeTwigAbsence.SetInt(CSoviet.Or_TarGlueSpin, 3);
                    TarGlueAbsence.KeaTextural().LiraDown(EggEtchInform.gameObject, true);
                    Seem.instance.DamSightStyle("Undo", 2);
                    HandfulCannonForth.KeaTextural().Corn("RefreshSkill");
                    HandfulCannonForth.KeaTextural().Corn("mg_undo");
                    StartCoroutine(nameof(FrontTugNutOntoPloy));
                }
            }
        });
        EggSurplusInform.onClick.AddListener(() =>
        {
            if (AnyNutSight)
            {
                if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) > 4)
                {
                    if (Seem.instance.TieSightStyle("Shuffle") > 0)
                    {
                        Seem.instance.WadSightStyle("Shuffle", 1);
                        HandfulCannonForth.KeaTextural().Corn("mg_shuffle");
                        ArabianSightStyle();
                        StartCoroutine(nameof(FrontTugNutOntoPloy));
                    }
                    else
                    {
                        UIAbsence.KeaTextural().HeelUIDrape(nameof(SightKrill));
                        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_SightTern, new HandfulTwig(CSoviet.Of_Imagist));
                    }
                }
                else
                {
                    TreeTwigAbsence.SetInt(CSoviet.Or_TarGlueSpin, 5);
                    TarGlueAbsence.KeaTextural().LiraDown(EggSurplusInform.gameObject, true);
                    Seem.instance.DamSightStyle("Shuffle", 2);
                    HandfulCannonForth.KeaTextural().Corn("RefreshSkill");
                    HandfulCannonForth.KeaTextural().Corn("mg_shuffle");
                    StartCoroutine(nameof(FrontTugNutOntoPloy));
                }
            }
        });
        EggWhigInform.onClick.AddListener(() =>
        {
            if (AnyNutSight)
            {
                if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) > 3)
                {
                    if (Seem.instance.TieSightStyle("Hint") > 0)
                    {
                        Seem.instance.WadSightStyle("Hint", 1);
                        HandfulCannonForth.KeaTextural().Corn("mg_hint");
                        ArabianSightStyle();
                        StartCoroutine(nameof(FrontTugNutOntoPloy));
                    }
                    else
                    {
                        UIAbsence.KeaTextural().HeelUIDrape(nameof(SightKrill));
                        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_SightTern, new HandfulTwig(CSoviet.Of_Cute));
                    }
                }
                else
                {
                    TreeTwigAbsence.SetInt(CSoviet.Or_TarGlueSpin, 4);
                    TarGlueAbsence.KeaTextural().LiraDown(EggWhigInform.gameObject, true);
                    Seem.instance.DamSightStyle("Hint", 2);
                    HandfulCannonForth.KeaTextural().Corn("RefreshSkill");
                    HandfulCannonForth.KeaTextural().Corn("mg_hint");
                    StartCoroutine(nameof(FrontTugNutOntoPloy));
                }
            }

        });
        //RedeemButton.onClick.AddListener(() => {
        //   //OpenUIForm("RedeemPanel");
        //    if (TreeTwigAbsence.GetInt(CSoviet.sv_NewUserStep) == 1)
        //    {
        //        TreeTwigAbsence.SetInt(CSoviet.sv_NewUserStep, 2);
        //        TarGlueAbsence.GetInstance().HideMask(RedeemButton.gameObject, true);
        //    }
        //});

        //GoldButton.onClick.AddListener(() => {
        //    SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
        //});
        //AmazonButton.onClick.AddListener(() => {
        //    SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
        //});
        //PuzzleButton.onClick.AddListener(() => {
        //    SOHOShopManager.instance.ShowRedeemGiftPanel();
        //});


        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_ExactKrill_VeinDam, (messageData) =>
        {
            Transform startTrans = messageData.TroutSeemFluent.transform;
            WhimMailAstronaut(startTrans, messageData.TroutAsk);
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_ExactKrill_VeinPeach, (messageData) =>
        {
            
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_ExactKrill_DamSoar, (messageData) =>
        {
            WhimDamAstronaut(messageData.TroutPrejudice, messageData.TroutInvest);
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_ExactKrill_DamChic, (messageData) =>
        {
            DivaDamAstronaut(messageData.TroutPrejudice, messageData.TroutInvest);
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_ExactKrill_DamCarman, (messageData) =>
        {
            ActionDamAstronaut(messageData.TroutPrejudice, messageData.TroutInvest);
        });
       
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_ExactKrill_Lira, (messageData) => {
            OnHide();
        });
        HandfulCannonForth.KeaTextural().Computer("RefreshSkill", (messageData) =>
        {
            ArabianSightStyle();
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_HeelRomeInform, (messageData) =>
        {
            if (RomeInform.gameObject.activeInHierarchy == false) 
            {
                RomeInform.gameObject.SetActive(true);
                AstronautAttainment.HikeVeinHeel(RomeInform.gameObject, 2f, () => { });
            }
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_OfferingRomeInform, (messageData) =>
        {
            RomeInform.gameObject.SetActive(false);
        });

        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_FaucetPeru, (messagegData) => {
            PrepayPeruNetShy();
        });


        // 现金提现引导
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_HeelSoarOntoWeedy, (messageData) => { 
            //if (!GameUtil.IsApple())
            //{
            //    if (TreeTwigAbsence.GetInt(CSoviet.sv_NewUserStep) == 1)
            //    {
            //        // 新用户引导
            //        TarGlueAbsence.GetInstance().ShowMask(true, true, RedeemButton.GetComponent<RectTransform>().localPosition, RedeemButton.gameObject);
            //    }
            //}
        });

        // 技能引导
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_HeelSightWeedy, (messageData) => {
            ArabianSightStyle();
            int ApartSupply= messageData.TroutAsk;
            int userGuideStep = TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin);
            if (userGuideStep == 2 && ApartSupply == 2)
            {
                if (LethalUtil.ByProhibit())
                {
                    Vector3 position = EggEtchInform.GetComponent<RectTransform>().localPosition;
                    TarGlueAbsence.KeaTextural().HeelDown(true, true, new Vector3(position.x, position.y + 50, position.z), EggEtchInform.gameObject);
                }
                else
                {
                    Vector3 position = EtchInform.GetComponent<RectTransform>().localPosition;
                    TarGlueAbsence.KeaTextural().HeelDown(true, true, new Vector3(position.x, position.y + 50, position.z), EtchInform.gameObject);
                }
            }
            else if (userGuideStep == 3 && ApartSupply == 3)
            {
                if (LethalUtil.ByProhibit())
                {
                    Vector3 position = EggWhigInform.GetComponent<RectTransform>().localPosition;
                    TarGlueAbsence.KeaTextural().HeelDown(true, true, new Vector3(position.x, position.y + 50, position.z), EggWhigInform.gameObject);
                }
                else
                {
                    Vector3 position = WhigInform.GetComponent<RectTransform>().localPosition;
                    TarGlueAbsence.KeaTextural().HeelDown(true, true, new Vector3(position.x, position.y + 50, position.z), WhigInform.gameObject);
                }

            }
            else if (userGuideStep == 4 && ApartSupply == 4)
            {
                if (LethalUtil.ByProhibit())
                {
                    Vector3 position = EggSurplusInform.GetComponent<RectTransform>().localPosition;
                    TarGlueAbsence.KeaTextural().HeelDown(true, true, new Vector3(position.x, position.y + 50, position.z), EggSurplusInform.gameObject);
                }
                else
                {
                    Vector3 position = SurplusInform.GetComponent<RectTransform>().localPosition;
                    TarGlueAbsence.KeaTextural().HeelDown(true, true, new Vector3(position.x, position.y + 50, position.z), SurplusInform.gameObject);
                }
            }
        });
    }
    IEnumerator FrontTugNutOntoPloy()
    {
        AnyNutSight = false;
        yield return new WaitForSeconds(0.8f);
        AnyNutSight = true;
    }
    public override void Display()
    {
        base.Display();

        if (LethalUtil.ByVague()) {
            // 审核模式
            SoarMouse.transform.parent.gameObject.SetActive(false);
            CarmanMouse.transform.parent.gameObject.SetActive(false);
            StitchInform.gameObject.SetActive(false);
           // RedeemButton.gameObject.SetActive(false);
            ChicInform.enabled = false;
        }
        else
        {
            SoarMouse.transform.parent.gameObject.SetActive(true);
            CarmanMouse.transform.parent.gameObject.SetActive(true);
            StitchInform.gameObject.SetActive(true);
           // RedeemButton.gameObject.SetActive(true);
            ChicInform.enabled = true;
        }

        AnyNutSight = true;
        FareAbsence.instance.WetPistonLira();
        OnShow();
        SoarSupplyPile.text = SupplyTide.InvestAtFir(Seem.instance.TieSoar());
        ChicSupplyPile.text = SupplyTide.InvestAtFir(Seem.instance.TieChic());
        EggChicSupplyPile.text = SupplyTide.InvestAtFir(Seem.instance.TieChic());
        CarmanSupplyPile.text = SupplyTide.InvestAtFir(Seem.instance.TieCarman());
        PrepayPeruNetShy();

        ArabianSightStyle();

        //showPuzzleShopIcon();
    }
    public override void Hidding()
    {
        base.Hidding();
    }
    public void ArabianSightStyle()
    {
        int ApartSupply= Seem.instance.ApartAbsorb.ApartSupply;
        if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) >= 2 && ApartSupply >= 2)
        {
            if (LethalUtil.ByProhibit())
            {
                EggEtchInform.transform.Find("LockImage").gameObject.SetActive(false);
            }
            else
            {
                EtchInform.transform.Find("LockImage").gameObject.SetActive(false);
            }
        }
    
        if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) >= 3 && ApartSupply >= 3)
        {
            if (LethalUtil.ByProhibit())
            {
                EggWhigInform.transform.Find("LockImage").gameObject.SetActive(false);
            }
            else
            {
                WhigInform.transform.Find("LockImage").gameObject.SetActive(false);
            }
        }
        if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) >= 4 && ApartSupply >= 4)
        {
            if (LethalUtil.ByProhibit())
            {
                EggSurplusInform.transform.Find("LockImage").gameObject.SetActive(false);
            }
            else
            {
                SurplusInform.transform.Find("LockImage").gameObject.SetActive(false);
            }
        }
        if (Seem.instance.TieSightStyle("Undo") > 0)
        {
            if (LethalUtil.ByProhibit())
            {
                EggEtchInform.transform.Find("SkillTime").gameObject.SetActive(true);
                EggEtchInform.transform.Find("SkillTime/Text").GetComponent<Text>().text = Seem.instance.TieSightStyle("Undo").ToString();
            }
            else
            {
                EtchInform.transform.Find("SkillTime").gameObject.SetActive(true);
                EtchInform.transform.Find("SkillTime/Text").GetComponent<Text>().text = Seem.instance.TieSightStyle("Undo").ToString();
            }
        }
        else
        {
            if (LethalUtil.ByProhibit())
            {
                EggEtchInform.transform.Find("SkillTime").gameObject.SetActive(false);
            }
            else
            {
                EtchInform.transform.Find("SkillTime").gameObject.SetActive(false);
            }
        }
        if (Seem.instance.TieSightStyle("Hint") > 0)
        {
            if (LethalUtil.ByProhibit())
            {
                EggWhigInform.transform.Find("SkillTime").gameObject.SetActive(true);
                EggWhigInform.transform.Find("SkillTime/Text").GetComponent<Text>().text = Seem.instance.TieSightStyle("Hint").ToString();
            }
            else
            {
                WhigInform.transform.Find("SkillTime").gameObject.SetActive(true);
                WhigInform.transform.Find("SkillTime/Text").GetComponent<Text>().text = Seem.instance.TieSightStyle("Hint").ToString();
            }
        }
        else
        {
            if (LethalUtil.ByProhibit())
            {
                EggWhigInform.transform.Find("SkillTime").gameObject.SetActive(false);
            }
            else
            {
                WhigInform.transform.Find("SkillTime").gameObject.SetActive(false);
            }
        }
        if (Seem.instance.TieSightStyle("Shuffle") > 0)
        {
            if (LethalUtil.ByProhibit())
            {
                EggSurplusInform.transform.Find("SkillTime").gameObject.SetActive(true);
                EggSurplusInform.transform.Find("SkillTime/Text").GetComponent<Text>().text = Seem.instance.TieSightStyle("Shuffle").ToString();
            }
            else
            {
                SurplusInform.transform.Find("SkillTime").gameObject.SetActive(true);
                SurplusInform.transform.Find("SkillTime/Text").GetComponent<Text>().text = Seem.instance.TieSightStyle("Shuffle").ToString();
            }
        }
        else
        {
            if (LethalUtil.ByProhibit())
            {
                EggSurplusInform.transform.Find("SkillTime").gameObject.SetActive(false);
            }
            else
            {
                SurplusInform.transform.Find("SkillTime").gameObject.SetActive(false);
            }
        }
    }
    
    public void WhimDamAstronaut(Transform startTransform, double num)
    {
        Transform P= UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().Find("Normal/ExactKrill/CashBar/CashIcon");
        if (startTransform != null)
        {
            GameObject goldobj = ChicMouse.gameObject;
            if (LethalUtil.ByProhibit())
            {
                goldobj = EggChicMouse.gameObject;
            }
            AstronautAttainment.ChicGiveKeel(goldobj, 15, startTransform, P, () =>
            {
                AstronautAttainment.FaucetSupply(double.Parse(SoarSupplyPile.text), (int)Seem.instance.TieSoar(), 0.1f, SoarSupplyPile, () => {
                    Seem.instance.WhimHeelSupply = SupplyTide.InvestAtFir(Seem.instance.TieSoar());
                    SoarSupplyPile.text = Seem.instance.WhimHeelSupply;
                });
            });
        }
        else
        {
            AstronautAttainment.FaucetSupply(double.Parse(SoarSupplyPile.text), (int)Seem.instance.TieSoar(), 0.1f, SoarSupplyPile, () => {
                Seem.instance.WhimHeelSupply = SupplyTide.InvestAtFir(Seem.instance.TieSoar());
                SoarSupplyPile.text = Seem.instance.WhimHeelSupply;
            });
        }
    }
    public void DivaDamAstronaut(Transform startTransform, double num)
    {
        Transform P = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().Find("Normal/ExactKrill/GoldBar/GoldIcon");
        if (startTransform != null)
        {
            GameObject goldobj = ChicMouse.gameObject;
            if (LethalUtil.ByProhibit())
            {
                goldobj = EggChicMouse.gameObject;
                P = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().Find("Normal/ExactKrill/NewTopGroup/GoldBar/GoldIcon");
            }
            AstronautAttainment.ChicGiveKeel(goldobj, Mathf.Max((int)num, 1), startTransform, P, () =>
            {
                if (LethalUtil.ByProhibit())
                {
                    AstronautAttainment.FaucetSupply(double.Parse(EggChicSupplyPile.text), Seem.instance.TieChic(), 0.1f, EggChicSupplyPile, () =>
                    {
                        Seem.instance.DivaHeelSupply = SupplyTide.InvestAtFir(Seem.instance.TieChic());
                        EggChicSupplyPile.text = Seem.instance.DivaHeelSupply;
                    });
                }
                else
                {
                    AstronautAttainment.FaucetSupply(double.Parse(ChicSupplyPile.text), Seem.instance.TieChic(), 0.1f, ChicSupplyPile, () =>
                    {
                        Seem.instance.DivaHeelSupply = SupplyTide.InvestAtFir(Seem.instance.TieChic());
                        ChicSupplyPile.text = Seem.instance.DivaHeelSupply;
                    });
                }
            });
        }
        else
        {
            if (LethalUtil.ByProhibit())
            {
                AstronautAttainment.FaucetSupply(double.Parse(EggChicSupplyPile.text), Seem.instance.TieChic(), 0.1f, EggChicSupplyPile, () => {
                    Seem.instance.DivaHeelSupply = SupplyTide.InvestAtFir(Seem.instance.TieChic());
                    EggChicSupplyPile.text = Seem.instance.DivaHeelSupply;
                });
            }
            else
            {
                AstronautAttainment.FaucetSupply(double.Parse(ChicSupplyPile.text), Seem.instance.TieChic(), 0.1f, ChicSupplyPile, () => {
                    Seem.instance.DivaHeelSupply = SupplyTide.InvestAtFir(Seem.instance.TieChic());
                    ChicSupplyPile.text = Seem.instance.DivaHeelSupply;
                });
            }
        }

    }
    public void ActionDamAstronaut(Transform startTransform, double num)
    {
        Transform P = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().Find("Normal/ExactKrill/AmazonBar/AmazonIcon");
        if (startTransform != null)
        {
            GameObject goldobj = ChicMouse.gameObject;
            if (LethalUtil.ByProhibit())
            {
                goldobj = EggChicMouse.gameObject;
            }
            AstronautAttainment.ChicGiveKeel(goldobj, Mathf.Max((int)num, 1), startTransform, P, () =>
            {
                AstronautAttainment.FaucetSupply(double.Parse(CarmanSupplyPile.text), Seem.instance.TieCarman(), 0.1f, CarmanSupplyPile, () => {
                    Seem.instance.ActionHeelSupply = SupplyTide.InvestAtFir(Seem.instance.TieCarman());
                    CarmanSupplyPile.text = Seem.instance.ActionHeelSupply;
                });
            });
        }
        else
        {
            AstronautAttainment.FaucetSupply(double.Parse(CarmanSupplyPile.text), Seem.instance.TieCarman(), 0.1f, CarmanSupplyPile, () => {
                Seem.instance.ActionHeelSupply = SupplyTide.InvestAtFir(Seem.instance.TieCarman());
                CarmanSupplyPile.text = Seem.instance.ActionHeelSupply;
            });
        }
    }
    public void WhimMailAstronaut(Transform startTrans,int bankType)
    {
        
        
    }

    // 修改星星宝箱星星数量
    private void PrepayPeruNetShy()
    {
        int starNum = Seem.instance.KeaPeruShy();
        int maxNum = GameUtil.StarBoxNum();
        PeruNetPile.text = starNum + "/" + maxNum;
        if (starNum >= maxNum)
        {
            // 自动打开星星宝箱
            UIAbsence.KeaTextural().HeelUIDrape(nameof(PeruNetKrill));
            Seem.instance.HabitPeruShy();
        }
    }

    // 修改提现商店和碎片商店的icon
    //private void showPuzzleShopIcon()
    //{
    //    if (PuzzleIcons == null || PuzzleIcons.Length == 0)
    //    {
    //        PuzzleIcons = Resources.LoadAll<Sprite>("SOHOShop/UI_Redeem/UI_Puzzle/Puzzle");
    //    }
    //    PuzzleIconIndex = 0;

    //    StartCoroutine(changePuzzleShopIcon());
    //}
    //private IEnumerator changePuzzleShopIcon()
    //{
    //    while(true)
    //    {
    //        PuzzleIcon.sprite = PuzzleIcons[PuzzleIconIndex];
    //        PuzzleIconIndex = (PuzzleIconIndex + 1) % PuzzleIcons.Length;

    //        yield return new WaitForSeconds(3);
    //    }
    //}

    

    void OnShow()
    {
        AstronautAttainment.HikeHeel(LapLet, 2, () => { });
        AstronautAttainment.HikeHeel(RepairLet, -2, () => {
        });
        
    }
    void OnHide()
    {
        AstronautAttainment.HikeLira(LapLet, 2, () => { });
        AstronautAttainment.HikeLira(RepairLet, -2, () => {
            UIAbsence.KeaTextural().StarkIDDecodeUIDrape(nameof(ExactKrill));
            UIAbsence.KeaTextural().HeelUIDrape("HomePanel");
        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
