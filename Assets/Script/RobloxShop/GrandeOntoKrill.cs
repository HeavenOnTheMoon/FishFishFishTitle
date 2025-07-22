using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

public class GrandeOntoKrill : MoteUIDrape
{
    public static GrandeOntoKrill instance;
[UnityEngine.Serialization.FormerlySerializedAs("BackBtn")]    public Button RoofBow;
[UnityEngine.Serialization.FormerlySerializedAs("RuleBtn")]
    public Button RageBow;
[UnityEngine.Serialization.FormerlySerializedAs("CurrenctOneText")]
    public Text MandibleDayPile;
[UnityEngine.Serialization.FormerlySerializedAs("CurrenctTwoText")]
    public Text MandibleEonPile;
[UnityEngine.Serialization.FormerlySerializedAs("TipsText")]
    public Text BarbPile;
[UnityEngine.Serialization.FormerlySerializedAs("TipsTwoText")]    public Text BarbEonPile;
[UnityEngine.Serialization.FormerlySerializedAs("RewardBtn")]
    public Button BackupBow;
[UnityEngine.Serialization.FormerlySerializedAs("CharacterBtn")]
    public Button ProtectorBow;
[UnityEngine.Serialization.FormerlySerializedAs("PropsBtn")]
    public Button SwordBow;
[UnityEngine.Serialization.FormerlySerializedAs("CharacterText")]    public Text ProtectorPile;
[UnityEngine.Serialization.FormerlySerializedAs("PropsText")]    public Text SwordPile;
[UnityEngine.Serialization.FormerlySerializedAs("costumesImage")]
    public GameObject CoverageMouse;
[UnityEngine.Serialization.FormerlySerializedAs("CircleGuideBtn")]
    public Button UnusedWeedyBow;
[UnityEngine.Serialization.FormerlySerializedAs("RectGuideBtn")]    public Button YardWeedyBow;
[UnityEngine.Serialization.FormerlySerializedAs("GoldImage")]
    public Image ChicMouse;
[UnityEngine.Serialization.FormerlySerializedAs("DiamondImage")]    
    public Image ConiferMouse;
[UnityEngine.Serialization.FormerlySerializedAs("BGImage")]    public Image BGMouse;
[UnityEngine.Serialization.FormerlySerializedAs("RewardObj")]
    public GameObject BackupShy;
[UnityEngine.Serialization.FormerlySerializedAs("CharacterObj")]
    public GameObject ProtectorShy;
[UnityEngine.Serialization.FormerlySerializedAs("CostumesObj")]
    public GameObject GeologicShy;
[UnityEngine.Serialization.FormerlySerializedAs("RobloxRewardObj")]

    public string GrandeBackupShy;
[UnityEngine.Serialization.FormerlySerializedAs("RobloxRewardTwoObj")]
    public string GrandeBackupEonShy;
[UnityEngine.Serialization.FormerlySerializedAs("RobloxRewardThreeObj")]
    public string GrandeBackupSevenShy;
[UnityEngine.Serialization.FormerlySerializedAs("InstrumentKrill")]
    public GameObject InstrumentKrill;
[UnityEngine.Serialization.FormerlySerializedAs("GetFragmentPanel")]
    public GameObject KeaCustomerKrill;
[UnityEngine.Serialization.FormerlySerializedAs("GrandeRageKrill")]
    public GameObject GrandeRageKrill;
[UnityEngine.Serialization.FormerlySerializedAs("UnusedBirdlike")]
    public GameObject UnusedBirdlike;
[UnityEngine.Serialization.FormerlySerializedAs("YardBirdlike")]    public GameObject YardBirdlike;
[UnityEngine.Serialization.FormerlySerializedAs("GuideCharacterImage")]
    public Image WeedyProtectorMouse;
[UnityEngine.Serialization.FormerlySerializedAs("GuideBackImage")]    public Image WeedyRoofMouse;

    private Image QuartzMouse;

    private Image StreetcarMouse;

    private Image SwordMouse;


    private Image DivergenceMouse;

    private Image SuperviseMouse;
[UnityEngine.Serialization.FormerlySerializedAs("rewardList")]
    public List<GameObject> QuartzForm= new List<GameObject>();
[UnityEngine.Serialization.FormerlySerializedAs("characterList")]
    public List<GameObject> StreetcarForm= new List<GameObject>();
[UnityEngine.Serialization.FormerlySerializedAs("Propsist")]
    public List<GameObject> Skeletal= new List<GameObject>();
[UnityEngine.Serialization.FormerlySerializedAs("SuccessPanel")]
    public GameObject ProdigyKrill;
[UnityEngine.Serialization.FormerlySerializedAs("TaskPanel")]    public GameObject SlatKrill;
    bool An_Sanskrit;
[UnityEngine.Serialization.FormerlySerializedAs("SenderFlaming")]    public GameObject SenderFlaming;
[UnityEngine.Serialization.FormerlySerializedAs("RewardScrollview")]    public GameObject BackupPercentage;
[UnityEngine.Serialization.FormerlySerializedAs("CharacterScrollview")]    public GameObject ProtectorPercentage;
[UnityEngine.Serialization.FormerlySerializedAs("PropsScrollview")]    public GameObject SwordPercentage;
    
    override protected void Awake()
    {
        base.Awake();
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        RoofBow.onClick.AddListener(RoofBowPhoto);
        RageBow.onClick.AddListener(RageBowPhoto);
        BackupBow.onClick.AddListener(BackupBowPhoto);
        ProtectorBow.onClick.AddListener(ProtectorBowPhoto);
        SwordBow.onClick.AddListener(SwordBowPhoto);

        UnusedWeedyBow.onClick.AddListener(WeedyBowPhoto);
        YardWeedyBow.onClick.AddListener(WeedyBowPhoto);

        //GoldImage.sprite = GrandeOntoTwigAbsence.instance.GetSpriteByID(0, 1);
        //DiamondImage.sprite = GrandeOntoTwigAbsence.instance.GetSpriteByID(0, 2);

        DustMandible(GrandeOntoTwigAbsence.instance.MandibleDay, GrandeOntoTwigAbsence.instance.MandibleEon);
        GrandeOntoTwigAbsence.instance.RebirthAttic = DustMandible;
        QuartzMouse = BackupBow.transform.Find("Image").GetComponent<Image>();
        QuartzMouse.gameObject.SetActive(true);
        StreetcarMouse = ProtectorBow.transform.Find("Image").GetComponent<Image>();
        SwordMouse = SwordBow.transform.Find("Image").GetComponent<Image>();
        //CreatGame();
        DwarfBackup();
        DwarfProtectorBackup();
        DwarfSwordBackup();

        OnEnable();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.LogError("horizontalNormalizedPosition == " + GameObj.transform.parent.parent.GetComponent<ScrollRect>().horizontalNormalizedPosition);
    }

    private void OnEnable()
    {
        //不是新手引导
        if (TreeTwigAbsence.GetBool("RobloxGuide"))
        {
            if (QuartzForm != null)
            {
                for (int i = 0; i < QuartzForm.Count; i++)
                {
                    QuartzForm[i].GetComponent<GrandeBackupLacquer>().RebirthBritain();
                }
            }
            if (StreetcarForm != null)
            {
                for (int i = 0; i < StreetcarForm.Count; i++)
                {
                    StreetcarForm[i].GetComponent<GrandeEonBackupCanoes>().RebirthBritain();
                }
            }
            if (Skeletal != null)
            {
                for (int i = 0; i < Skeletal.Count; i++)
                {
                    Skeletal[i].GetComponent<GrandeSevenBackupCanoes>().RebirthBritain();
                }
            }

            //默认是reward分口
            BackupBowPhoto();
        }
        //新手引导模式
        else
        {
            if (QuartzForm != null && QuartzForm.Count != 0)
            {
                QuartzForm[0].GetComponent<GrandeBackupLacquer>().WeedyMouse.gameObject.SetActive(true);
                DwarfWhom(QuartzForm[0].gameObject, false,  0);
            }
        }
    }

    /// <summary>
    /// 初始化数据
    /// </summary>
    /// <param name="value"></param>
    /// <param name="valueTwo"></param>
    public void DustMandible(int value, int valueTwo)
    {
        MandibleDayPile.text = value.ToString();
        MandibleEonPile.text = valueTwo.ToString();
        Communicative();
    }

    #region MyRegion

    private void DwarfWhom(GameObject self, bool isCricle,int index)
    {
        if (isCricle)
        {
            UnusedBirdlike.SetActive(true);
            UnusedBirdlike.GetComponent<UnusedBirdlike>().Dust(self.GetComponent<Image>());
        }
        else
        {
            YardBirdlike.SetActive(true);
            YardBirdlike.GetComponent<YardBirdlike>().Dust(self.GetComponent<Image>(),index);
        }
    }

    public void Weedy(int index)
    {
        if (GrandeOntoTwigAbsence.instance.GrandeOntoTwig.isStartCashShop == 0)
        {
            switch (index)
            {
                case 1 :
                    TreeTwigAbsence.SetBool("RobloxGuide", true);
                    QuartzForm[0].GetComponent<GrandeBackupLacquer>().WeedyMouse.gameObject.GetComponent<BeerMouseAstronaut>().LoosenMouse();
                    WeedyProtectorMouse.gameObject.SetActive(true);
                    DwarfWhom(ProtectorBow.gameObject, false, index);
                    break;
                case 2 :
                    WeedyProtectorMouse.gameObject.GetComponent<BeerMouseAstronaut>().LoosenMouse();
                    ProtectorBowPhoto();
                    StreetcarForm[2].GetComponent<GrandeEonBackupCanoes>().WeedyMouse.gameObject.SetActive(true);
                    DwarfWhom(StreetcarForm[2].gameObject, false, index);
                    break;
                case 3:
                    StreetcarForm[2].GetComponent<GrandeEonBackupCanoes>().WeedyMouse.gameObject.GetComponent<BeerMouseAstronaut>().LoosenMouse();
                    SenderFlaming.SetActive(true);
                    break;
                case 4 : 
                    WeedyRoofMouse.gameObject.SetActive(true);
                    DwarfWhom(RoofBow.gameObject, true, index);
                    break;
            }
        }
        else
        {
            TreeTwigAbsence.SetBool("RobloxGuide", true);
            QuartzForm[0].GetComponent<GrandeBackupLacquer>().WeedyMouse.gameObject.GetComponent<BeerMouseAstronaut>().LoosenMouse(); 
            WeedyRoofMouse.gameObject.SetActive(true);
            DwarfWhom(RoofBow.gameObject, true, 4);
        }
    }

    #endregion

    #region Refresh

    public void Communicative()
    {
        if (QuartzForm != null)
        {
            for (int i = 0; i < QuartzForm.Count; i++)
            {
                QuartzForm[i].GetComponent<GrandeBackupLacquer>().RebirthBritain();
            }
        }
    }

    public void RebirthProtector(int id)
    {
        if (StreetcarForm != null)
        {
            for (int i = 0; i < StreetcarForm.Count; i++)
            {
                //if(id == characterList[i].GetComponent<GrandeEonBackupCanoes>().ownRobloxItemData.ID)
                    StreetcarForm[i].GetComponent<GrandeEonBackupCanoes>().RebirthBritain();
            }
        }
    }

    public void RebirthSword(int id)
    {
        if (Skeletal != null)
        {
            for (int i = 0; i < Skeletal.Count; i++)
            {
                if(id == Skeletal[i].GetComponent<GrandeSevenBackupCanoes>().SawGrandeSuckEonTwig.ID)
                    Skeletal[i].GetComponent<GrandeSevenBackupCanoes>().RebirthBritain();
            }
        }
    }
    
    

    #endregion

    #region CreatPrefab

    /// <summary>
    /// 生成商店奖励
    /// </summary>
    private void DwarfBackup()
    {
        int initializationID = 2;
        if (GrandeOntoTwigAbsence.instance.GrandeOntoTwig.isStartCashShop == 0)
            initializationID = 3;
        for (int i = 0; i < GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[initializationID].Shop_list.Count; i++)
        {
            GameObject obj = Instantiate(Resources.Load<GameObject>(GrandeBackupShy));
        
            obj.transform.SetParent(BackupShy.transform, false);
            obj.GetComponent<GrandeBackupLacquer>().SawLevelTwig =
                GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[initializationID].Shop_list[i];
            GrandeOntoTwigAbsence.instance.SeaportSeem = initializationID;
            obj.GetComponent<GrandeBackupLacquer>().HeelPeckHailKrill = HeelInstrumentKrill;
            obj.GetComponent<GrandeBackupLacquer>().HeelTextGapDefine = BatAlbedo;
            obj.GetComponent<GrandeBackupLacquer>().ID = GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[initializationID].Shop_list[i].ID;
            obj.GetComponent<GrandeBackupLacquer>().SeemBold = GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[initializationID].unitName;
            obj.GetComponent<GrandeBackupLacquer>().SeemWhigTide = GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[initializationID].iconPath;
            obj.GetComponent<GrandeBackupLacquer>().RebirthTour();
            obj.SetActive(true);
            QuartzForm.Add(obj);
        }

        GrandeOntoTwigAbsence.instance.RebirthSeventyTour();
        RebirthSeem(initializationID);
    }
    
    /// <summary>
    /// 生成角色进度奖励
    /// </summary>
    private void DwarfProtectorBackup()
    {
        for (int i = 0; i < GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Characters_list.Count; i++)
        {
            GameObject obj = Instantiate(Resources.Load<GameObject>(GrandeBackupEonShy));
        
            obj.transform.SetParent(ProtectorShy.transform, false);
            obj.GetComponent<GrandeEonBackupCanoes>().SawGrandeSuckTwig =
                GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Characters_list[i];
            obj.GetComponent<GrandeEonBackupCanoes>().HeelKeaCustomerKrill = HeelKeaCustomerKrill;
            StreetcarForm.Add(obj);
        }
    }
    public void RebirthProtectorBackup()
    {
        for (int i = 0; i < StreetcarForm.Count; i++)
        {
            StreetcarForm[i].GetComponent<GrandeEonBackupCanoes>().SawGrandeSuckTwig = GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Characters_list[i];
            StreetcarForm[i].GetComponent<GrandeEonBackupCanoes>().Arabian();
        }
    }

    /// <summary>
    /// 生成装饰物进度奖励
    /// </summary>
    /// <param name="type"></param>
    private void DwarfSwordBackup()
    {
        for (int i = 0; i < GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Props_list.Count; i++)
        {
            GameObject obj = Instantiate(Resources.Load<GameObject>(GrandeBackupSevenShy));
            obj.transform.SetParent(GeologicShy.transform, false);
            obj.GetComponent<GrandeSevenBackupCanoes>().SawGrandeSuckEonTwig =
                GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Props_list[i];
            obj.GetComponent<GrandeSevenBackupCanoes>().HeelKeaCustomerKrill = HeelKeaCustomerKrill;
            Skeletal.Add(obj);
        }
    }

    #endregion
    

    #region BtnClickEvent

    public void RoofBowPhoto()
    {
        /*GuideBackImage.gameObject.SetActive(false);
        CloseUIForm(GetType().Name);
        HandfulCannonForth.GetInstance().Send(CSoviet.mg_HomePanelNextGuide);*/
        
#if EmojiMerge
        GuideBackImage.gameObject.SetActive(false);
        //CloseUIForm(GetType().Name);
        UIAbsence.GetInstance().RobloxCanvas.transform.Find("GrandeOntoKrill").gameObject.SetActive(false);
#elif ZenMerge
        GuideBackImage.gameObject.SetActive(false);
        gameObject.SetActive(false);
        CubeManager.instance.timeResume();
#else
        WeedyRoofMouse.gameObject.SetActive(false);
        StarkUIWish(GetType().Name);
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HikeKrillGenuWeedy);
#endif
        
    }

    private void RageBowPhoto()
    {
        GrandeRageKrill.gameObject.SetActive(true);
    }

    private void BackupBowPhoto()
    {
        if (QuartzMouse != null)
        {
            QuartzMouse.gameObject.SetActive(true);
            StreetcarMouse.gameObject.SetActive(false);
            SwordMouse.gameObject.SetActive(false);
            CoverageMouse.gameObject.SetActive(false);
            BackupPercentage.SetActive(true);
            ProtectorPercentage.SetActive(false);
            SwordPercentage.SetActive(false);
        }
    }

    private void ProtectorBowPhoto()
    {
        QuartzMouse.gameObject.SetActive(false);
        StreetcarMouse.gameObject.SetActive(true);
        SwordMouse.gameObject.SetActive(false);
        CoverageMouse.gameObject.SetActive(false);
        BackupPercentage.SetActive(false);
        ProtectorPercentage.SetActive(true);
        SwordPercentage.SetActive(false);
    }
    
    //3 4 绑定
    private void SwordBowPhoto()
    {
        QuartzMouse.gameObject.SetActive(false);
        StreetcarMouse.gameObject.SetActive(false);
        SwordMouse.gameObject.SetActive(true);
            CoverageMouse.gameObject.SetActive(true);
        BackupPercentage.SetActive(false);
        ProtectorPercentage.SetActive(false);
        SwordPercentage.SetActive(true);
    }

   

    private void WeedyBowPhoto()
    {
        
    }

    #endregion

    #region Invoke

    private int CryID;

    public void RebirthSeem(int id)
    {
        GrandeOntoTwigAbsence.instance.SeaportSeem = id;
        BGMouse.sprite = GrandeOntoTwigAbsence.instance.KeaVanishOfID(GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[id].bgPath);
        if(id == 3)
        {
            ProtectorBow.interactable = true;
            SwordBow.interactable = true;
            ProtectorPile.color = Color.white;
            SwordPile.color = Color.white;
        }
        else
        {
            ProtectorBow.interactable = false;
            SwordBow.interactable = false;
            ProtectorPile.color = Color.gray;
            SwordPile.color = Color.gray;
            BackupBowPhoto();
        }
        for (int i = 0; i < QuartzForm.Count; i++)
        {
            QuartzForm[i].GetComponent<GrandeBackupLacquer>().SawLevelTwig = GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[id].Shop_list[i];
            QuartzForm[i].GetComponent<GrandeBackupLacquer>().ID = GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[id].Shop_list[i].ID;
            QuartzForm[i].GetComponent<GrandeBackupLacquer>().SeemBold = GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[id].unitName;
            QuartzForm[i].GetComponent<GrandeBackupLacquer>().SeemWhigTide = GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[id].iconPath;
            QuartzForm[i].GetComponent<GrandeBackupLacquer>().RebirthTour();
        }
    }
    private void HeelInstrumentKrill(int id)
    {
        GrandeOntoTwigAbsence.instance.PinID = id;
        InstrumentKrill.gameObject.SetActive(true);
    }
    public void HeelProdigyKrill()
    {
        ProdigyKrill.SetActive(true);
    }
    public void HeelSlatKrill()
    {
        TaskItemData taskItemData = GrandeOntoTwigAbsence.instance.KeaGrandeSlat(GrandeOntoTwigAbsence.instance.HayLanguish);
        if (taskItemData != null)
        {
            SlatKrill.SetActive(true);
        }
        else
        {
            HeelProdigyKrill();
        }
    }
    public void SewGrandeBackupLanguish(int id)
    {
        KeaGrandeBackupLacquer(id).EuropeWomanLanguish();
    }
    public void SewGrandeBackupAnyplace(int id)
    {
        KeaGrandeBackupLacquer(id).EuropeWomanAnyplace();
    }
    public GrandeBackupLacquer KeaGrandeBackupLacquer(int id)
    {
        foreach (GameObject robloxReward in QuartzForm)
        {
            if (robloxReward.GetComponent<GrandeBackupLacquer>().ID == id)
            {
                return robloxReward.GetComponent<GrandeBackupLacquer>();
            }
        }
        return null;
    }
    private void HeelKeaCustomerKrill(int id)
    {
        KeaCustomerKrill.GetComponent<KeaFrequencyKrill>().ID = id;
        KeaCustomerKrill.gameObject.SetActive(true);
    }
    
    private bool ByMelangeBat= false;
    public void BatAlbedo(string des, bool isShow = false)
    {
        if (ByMelangeBat) return;
        ByMelangeBat = true;
        if (isShow)
        {
            BarbPile.gameObject.SetActive(false);
            BarbEonPile.gameObject.SetActive(true);
            BarbEonPile.transform.parent.localPosition = Vector3.zero;
            BarbEonPile.text = des;
            BarbEonPile.transform.parent.DOLocalMoveY(200, 1.5f).SetEase(Ease.OutQuad).OnComplete(() =>
            {
                BarbEonPile.gameObject.SetActive(false);
                ByMelangeBat = false;
            });
        }
        else
        {
            
            BarbEonPile.gameObject.SetActive(false);
            
            BarbPile.transform.parent.GetChild(int.Parse(des)).gameObject.SetActive(true);
            BarbPile.transform.parent.GetChild(int.Parse(des)).localPosition = Vector3.zero;
            //TipsText.transform.parent.GetChild(int.Parse(des)).gameObject.GetComponent<Text>().text = des;
            BarbPile.transform.parent.GetChild(int.Parse(des)).transform.DOLocalMoveY(200, 1f).SetEase(Ease.OutQuad).OnComplete(() =>
            {
                BarbPile.transform.parent.GetChild(int.Parse(des)).gameObject.SetActive(false);
                ByMelangeBat = false;
            });
            /*TipsText.gameObject.SetActive(true);
            TipsText.transform.localPosition = Vector3.zero;
            TipsText.text = des;
            TipsText.transform.DOLocalMoveY(200, 1f).SetEase(Ease.OutQuad).OnComplete(() =>
            {
                TipsText.gameObject.SetActive(false);
                IsPlayingTip = false;
            });*/
        }
        
    }
    
    /// <summary>
    /// 弹窗消失
    /// </summary>
    /// <param name="popUp">弹出的窗口组件</param>
    /// <param name="finished"></param>
    /// <param name="finished">[可选]弹窗效果类型</param>
    public void PitOrLira(GameObject popUp, Action finished)
    {
        popUp.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
        popUp.transform.DOScale(popUp.transform.localScale * 0.01f, 0.5f).SetEase(Ease.InBack, 1.5f).OnComplete(() =>
        {
            finished();
        });
    }
    
    private Dictionary<GameObject, Vector3> IceOrForm= new Dictionary<GameObject, Vector3>();
    /// <summary>
    /// 弹窗出现
    /// </summary>
    /// <param name="popUp">弹出的窗口组件</param>
    /// <param name="finished"></param>
    /// <param name="finished">[可选]弹窗效果类型</param>
    public void PitOrHeel(GameObject popUp, Action finished)
    {

        
        //Vector3 scale = popUp.transform.localScale;
        //popUp.transform.localScale = scale * 0.01f;
        if (!IceOrForm.ContainsKey(popUp))
        {
            Vector3 Grama= popUp.transform.localScale;
            IceOrForm.Add(popUp, Grama);
            popUp.transform.localScale = Grama * 0.01f;
        }
        popUp.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        popUp.transform.DOScale(popUp.transform.localScale * 100f, 0.5f).SetEase(Ease.OutBack, 1.5f).OnComplete(() =>
        {
            finished();
        });

    }

    #endregion

    
}
