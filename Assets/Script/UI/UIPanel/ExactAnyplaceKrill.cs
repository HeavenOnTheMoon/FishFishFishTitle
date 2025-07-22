using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ExactAnyplaceKrill : MoteUIDrape
{
    [Header("图片和特效")]
[UnityEngine.Serialization.FormerlySerializedAs("FX_GroundLight")]    public GameObject FX_PeriodSurge;
[UnityEngine.Serialization.FormerlySerializedAs("FX_Star")]    public GameObject FX_Peru;
[UnityEngine.Serialization.FormerlySerializedAs("FX_FireworksRight")]    public GameObject FX_HostilityMatch;
[UnityEngine.Serialization.FormerlySerializedAs("FX_FireworksLift")]    public GameObject FX_HostilityIdle;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_LevelComplete")]    public GameObject It_ExactAnyplace;
[UnityEngine.Serialization.FormerlySerializedAs("StarImage")]    public GameObject PeruMouse;
[UnityEngine.Serialization.FormerlySerializedAs("GoldImage")]    public GameObject ChicMouse;
[UnityEngine.Serialization.FormerlySerializedAs("DiamondsImage")]    public GameObject TreelessMouse;
[UnityEngine.Serialization.FormerlySerializedAs("MoveOffset")]    public float GiveNephew;
[UnityEngine.Serialization.FormerlySerializedAs("CashImage")]    public GameObject SoarMouse;
[UnityEngine.Serialization.FormerlySerializedAs("GemImage")]    public GameObject SapMouse;
    [Header("list")]
[UnityEngine.Serialization.FormerlySerializedAs("LevelIcon")]    public List<GameObject> ExactWhig;
[UnityEngine.Serialization.FormerlySerializedAs("RewardValue")]    public List<GameObject> BackupAttic;
[UnityEngine.Serialization.FormerlySerializedAs("TopBarIcon")]    public List<GameObject> LapLetWhig;
[UnityEngine.Serialization.FormerlySerializedAs("Flash")]    public Material Steam;
    [Header("按钮")]
[UnityEngine.Serialization.FormerlySerializedAs("ADButton")]    public Button ADInform;
[UnityEngine.Serialization.FormerlySerializedAs("NextLevel")]    public Button GenuExact;
[UnityEngine.Serialization.FormerlySerializedAs("ADText")]    public GameObject ADPile;
    [Header("文案")]
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text SoarPile;
    [Header("转盘组")]
[UnityEngine.Serialization.FormerlySerializedAs("SlotBG")]    public FordAsian FordBG;

    private double Quartz;   // token奖励

    protected override void Awake()
    {
        base.Awake();
    }
    void Start()
    {
        ADInform.onClick.AddListener(() =>
        {
            WePool.Textural.BeerBackupWe(10003, (success) =>
            {
                if (success)
                {
                    // 播放成功逻辑处理
                    ADDecodeHikeKrill();
                    AstronautAttainment.Peasant(LapLetWhig[1], 0);
                }
            });
            
        });
        GenuExact.onClick.AddListener(() =>
        {
            //bx 插屏广告
            WePool.Textural.BeerContributionWe(10010, (success) =>
            {
                if (success)
                {
                    // 播放成功逻辑处理
                }
            });
            Transform P= UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().Find("Normal/ExactKrill/CashBar/CashIcon");
            Transform A = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>();
            AstronautAttainment.ChicGiveKeel(P.gameObject, 15, A, P, () => { });
            Seem.instance.RidChic(Quartz);
            Seem.instance.DivaHeelSupply = SupplyTide.InvestAtFir(Seem.instance.TieChic());
            StarkUIWish(GetType().Name);
            Seem.instance.ApartAsset();
            Seem.instance.DamPeru();
            
        });
    }
    public override void Display()
    {
        base.Display();
        LipidSowPool.Textural.CornBackupLipid(1402, "game_pass_level_1402");
        Quartz = TugTourOil.instance.DustTwig.passlevel_cash_price * Seem.instance.TieSoarSharp();
        SoarPile.text = "+" + SupplyTide.InvestAtFir(Quartz);

        if (GameUtil.IsApple())
        {
            SoarMouse.SetActive(false);
            SapMouse.SetActive(true);
        }
        else
        {
            SoarMouse.SetActive(true);
            SapMouse.SetActive(false);
        }

        Seem.instance.AnewAdultDownYam();
        StartCoroutine(VinePloyWriteDown());
        Unrecognizable();
        Beer();
        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Sound_LevelComplete);
        ADInform.gameObject.SetActive(true);

        if (AnTarGlue())
        {
            ADPile.SetActive(false);
            GenuExact.gameObject.SetActive(false);
        }
        else
        {
            ADPile.SetActive(true);
            GenuExact.gameObject.SetActive(true);
        }

        FordBG.AsiaSharp();
    }
    IEnumerator VinePloyWriteDown()
    {
        yield return new WaitForSeconds(1f);
        Seem.instance.ValidSeemAdultDownYam();
    }
    public void Unrecognizable() 
    {
       /* DiamondsImage.GetComponent<Transform>().position = new Vector3(DiamondsImage.GetComponent<Transform>().position.x, DiamondsImage.GetComponent<Transform>().position.y - MoveOffset, DiamondsImage.GetComponent<Transform>().position.z);
        DiamondsImage.GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
        DiamondsImage.GetComponent<Transform>().Find("Image").GetComponent<Transform>().position = new Vector3(0, DiamondsImage.GetComponent<Transform>().Find("Image").GetComponent<Transform>().position.y, DiamondsImage.GetComponent<Transform>().Find("Image").GetComponent<Transform>().position.z);
        DiamondsImage.GetComponent<Transform>().Find("NumberText").GetComponent<Transform>().position = new Vector3(0, DiamondsImage.GetComponent<Transform>().Find("Image").GetComponent<Transform>().position.y, DiamondsImage.GetComponent<Transform>().Find("Image").GetComponent<Transform>().position.z);*/
    }

    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.P))
        //{
        //    ReturnHomePanel();
        //    print("MUYU:ReturnHomePanel");
        //}
    }

    private bool AnTarGlue()
    {
        return !PlayerPrefs.HasKey(CSoviet.Or_NevusFord + "Bool") || TreeTwigAbsence.GetBool(CSoviet.Or_NevusFord);
    }

    public void DecodeHikeKrill()
    {
        StarkUIWish(GetType().Name);
        Seem.instance.ApartAnyplace();
    }
    public void ADDecodeHikeKrill()
    {
        if (AnTarGlue())
        {
            ADScenario();
        }
        else
        {
            ADScenario();
        }
    }
    private void ADScenario()
    {
        GenuExact.gameObject.SetActive(false);
        ADInform.gameObject.SetActive(false);
        int Calve= TieFordSharpBrace();
        FordBG.Cone(Calve, (multi) => {
            AstronautAttainment.FaucetSupply(Quartz, Quartz * multi, 0.1f, SoarPile, "+", () => {
                Quartz *= multi;
                SoarPile.text = "+" + SupplyTide.InvestAtFir(Quartz);
            });
            GenuExact.gameObject.SetActive(true);
        });

        TreeTwigAbsence.SetBool(CSoviet.Or_NevusFord, false);
    }

    private int TieFordSharpBrace()
    {
        // 新用户，第一次固定翻5倍
        if (AnTarGlue())
        {
            int Calve= 0;
            foreach (SlotItem wg in TugTourOil.instance.DustTwig.slot_group)
            {
                if (wg.multi == 5)
                {
                    return Calve;
                }
                Calve++;
            }
        }
        else
        {
            int sumWeight = 0;
            foreach (SlotItem wg in TugTourOil.instance.DustTwig.slot_group)
            {
                sumWeight += wg.weight;
            }
            int r = Random.Range(0, sumWeight);
            int nowWeight = 0;
            int Calve= 0;
            foreach (SlotItem wg in TugTourOil.instance.DustTwig.slot_group)
            {
                nowWeight += wg.weight;
                if (nowWeight > r)
                {
                    return Calve;
                }
                Calve++;
            }
            
        }
        return 0;
    }

    /// <summary>
    /// 播放
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
    public void Beer()
    {
        ExactAnyplaceMatHydroponically();
        BellExactNorwegianMat();
        LapLetBeer();
        ExactBackup();
        PeruMouseHeel(PeruMouse, It_ExactAnyplace);
        FX_HostilityMatch.SetActive(true);
        FX_HostilityIdle.SetActive(true);
        FX_PeriodSurge.SetActive(true);
        FX_Peru.SetActive(true);
    }


    /// <summary>
    /// 初始化关卡胜利小金鱼icon
    /// </summary>
    public void ExactAnyplaceMatHydroponically() 
    {
        for (int i = 0; i < ExactWhig.Count; i++) 
        {
            ExactWhig[i].transform.localScale = new Vector3(0, 0, 0);
        }
    }
    /// <summary>
    /// 关卡胜利小金鱼icon
    /// </summary>
    /// <param name="LevelIcon"></param>
    /// <param name="FinalOffestTransform_Y"></param>
    public void ExactNorwegianMat(GameObject LevelIcon,float FinalOffestTransform_Y) 
    {
        /*--------------------初始化--------------------*/
        LevelIcon.transform.localScale = new Vector3(0, 0, 0);
        LevelIcon.transform.position =new Vector3(LevelIcon.transform.position.x, LevelIcon.transform.position.y- FinalOffestTransform_Y, LevelIcon.transform.position.z);
        LevelIcon.GetComponent<Image>().color = new Color(LevelIcon.GetComponent<Image>().color.r, LevelIcon.GetComponent<Image>().color.g, LevelIcon.GetComponent<Image>().color.b, 0);
        /*--------------------动画--------------------*/
        LevelIcon.GetComponent<Image>().DOFade(1, 0.6f);
        LevelIcon.transform.DOMoveY(LevelIcon.transform.position.y + FinalOffestTransform_Y, 0.6f).SetEase(Ease.OutBack);
        LevelIcon.transform.DOScale(1f, 0.6f).SetEase(Ease.OutBack);
    }
    private IEnumerator OntoYetChorus(float time ,int i,float Offset) 
    { 
        yield return new WaitForSeconds(time);
        ExactNorwegianMat(ExactWhig[i], Offset);
    }
    public void BellExactNorwegianMat() 
    {
        for (int i = 0; i<ExactWhig.Count; i++) 
        {
            if (i <= 1)
            {
                StartCoroutine(OntoYetChorus(0, i, 1f));
            }
            else if (i > 1 && i < 4)
            {
                StartCoroutine(OntoYetChorus(0.2f, i,1f));
            }
            else 
            {
                StartCoroutine(OntoYetChorus(0.3f, i, 1f));
            }
        }
    }
    /// <summary>
    /// 收取金币
    /// </summary>
    public void DivaDamAstronaut(int goldCount = 0,int cashCount = 0)
    {
        Seem.instance.AnewAdultDownYam();
        GameObject Fx_Power = Instantiate(Resources.Load<GameObject>(CSoviet.SurmiseFXTract), TreelessMouse.GetComponent<Transform>().Find("Image").gameObject.transform);
        Fx_Power.SetActive(false);

        ExactChicGive(TreelessMouse.GetComponent<Transform>().Find("Image").gameObject, transform.parent, 5, ADInform.transform, TreelessMouse.GetComponent<Transform>().Find("Image").gameObject.transform, () => {
            Fx_Power.SetActive(true);
            AstronautAttainment.WhigJump(TreelessMouse.GetComponent<Transform>().Find("Image").gameObject);
        }, () => {
            AstronautAttainment.FaucetSupply(int.Parse(TreelessMouse.GetComponent<Transform>().Find("NumberText").GetComponent<Text>().text), int.Parse(TreelessMouse.GetComponent<Transform>().Find("NumberText").GetComponent<Text>().text) + cashCount, 0, TreelessMouse.GetComponent<Transform>().Find("NumberText").GetComponent<Text>(), () => {
                Fx_Power.SetActive(false);
                Seem.instance.ValidSeemAdultDownYam();
            });
        });
    }

    /// <summary>
    /// 关卡胜利幅条
    /// </summary>
    /// <param name="FinalOffestTransform_Y"></param>
    public  void LapLet(GameObject TopBarImage,float FinalOffestTransform_Y,int b,int c,float time_y) 
    {
        /*--------------------初始化--------------------*/
        FX_PeriodSurge.SetActive(false);
        FX_Peru.SetActive(false);
        FX_HostilityMatch.SetActive(false);
        FX_HostilityIdle.SetActive(false);
        TopBarImage.transform.position = new Vector3(TopBarImage.transform.position.x, TopBarImage.transform.position.y - FinalOffestTransform_Y, TopBarImage.transform.position.z);
        if (c > 0) 
        {
        TopBarImage.GetComponent<Image>().color = new Color(TopBarImage.GetComponent<Image>().color.r, TopBarImage.GetComponent<Image>().color.g, TopBarImage.GetComponent<Image>().color.b, 0);
        }
        TopBarImage.transform.localScale = new Vector3(0, 0, 0);
        /*--------------------动画--------------------*/
        if (b>0) 
        {
            float offset = -0.5f;
            TopBarImage.GetComponent<Image>().material = Steam;
            DOTween.To(() => offset, x => TopBarImage.GetComponent<Image>().material.SetFloat("_LightOffset", offset = x), 0.5f, 1f).SetDelay(1).OnComplete(() =>
            {
                TopBarImage.GetComponent<Image>().material.SetFloat("_LightOffset", -0.5f);
                TopBarImage.GetComponent<Image>().material = null;
            });
        }
        StartCoroutine(OntoYetChorusAttic(() => {
            if (c > 0) 
            {
                TopBarImage.GetComponent<Image>().DOFade(1, 0.5f);
                TopBarImage.transform.DOScale(1f, 0.5f).SetEase(Ease.OutBack);
            }
            else if(c <-1)
            {
                TopBarImage.transform.DOScale(1f, 0.5f).SetEase(Ease.OutBack);
            }
            else
            {
                TopBarImage.transform.DOScale(45f, 0.5f).SetEase(Ease.OutBack);
            }

            TopBarImage.transform.DOMoveY(TopBarImage.transform.position.y + FinalOffestTransform_Y, 0.5f).SetEase(Ease.OutBack);
        }, time_y));
    }

    public void BowHeel(GameObject BtnImage,float time_Y, float FinalOffestTransform_Y) 
    {
        Sequence s = DOTween.Sequence();
        BtnImage.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        BtnImage.transform.localScale = new Vector3(0, 0, 0);
        BtnImage.transform.position = new Vector3(BtnImage.transform.position.x, BtnImage.transform.position.y - FinalOffestTransform_Y, BtnImage.transform.position.z);
        s.Append(BtnImage.GetComponent<Image>().DOFade(1, 0.5f));
        s.Append(BtnImage.transform.DOMoveY(BtnImage.transform.position.y + FinalOffestTransform_Y, 0.5f).SetEase(Ease.OutBack));
        s.Append(BtnImage.transform.DOScale(1f, 0.5f).SetEase(Ease.OutBack));
        s.SetDelay(time_Y);
        s.Play();
    }
    public void LapLetBeer() 
    {
        for (int i = 0; i < LapLetWhig.Count; i++) 
        {
            if (i==1)
            {
                LapLet(LapLetWhig[i], 0.5f, 1, 1,0);
                AstronautAttainment.Peasant(LapLetWhig[1], 1);
            }
            else if (i == 0 )
            {
                LapLet(LapLetWhig[0], 0.5f, 0,1, 0);
            }
            else if (i == 2)
            {
                BowHeel(LapLetWhig[i], 2, 0.5f);
            }
            else if (i == 3) 
            {
                LapLet(LapLetWhig[i], 0.5f, 0,0, 0.75f);
                /*TopBarIcon[i].GetComponent<Transform>().Find("FX_ground").gameObject.SetActive(true);*/
            }
            else if (i == 4)
            {
                LapLet(LapLetWhig[i], 0.5f, 0, -2, 0.75f);
            }
        }
    }

    /// <summary>
    /// 星星奖励
    /// </summary>
    /// <param name="StarIamge"></param>
    /// <param name="Fx_LevelComplete"></param>
    public void PeruMouseHeel(GameObject StarIamge, GameObject Fx_LevelComplete) 
    {
        /*--------------------初始化--------------------*/
        Fx_LevelComplete.SetActive(false);
        PeruMouse.transform.eulerAngles = new Vector3(0, 0, -180);
        PeruMouse.transform.localScale = new Vector3(15, 15, 15);
        PeruMouse.SetActive(false);
        /*--------------------动画--------------------*/
        PeruMouse.SetActive(true);
        PeruMouse.transform.DORotate(new Vector3(0, 0, 0), 0.6f, RotateMode.FastBeyond360).OnComplete(() =>
        {
            Fx_LevelComplete.SetActive(true);
        });
        PeruMouse.transform.DOScale(new Vector3(1, 1, 1), 0.6f).OnComplete(() =>
        {
            PeruMouse.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 0.2f).OnComplete(() =>
            {
                PeruMouse.transform.DOScale(new Vector3(1, 1, 1), 0.2f);
            });
        });
    }

    /// <summary>
    /// 金币/现金值出现
    /// </summary>
    /// <param name="value"></param>
    /// <param name="FinalOffestTransform_Y"></param>
    public void ChicAttic(GameObject value, float FinalOffestTransform_Y)
    {
        /*--------------------初始化--------------------*/
        value.transform.position = new Vector3(value.transform.position.x, value.transform.position.y - FinalOffestTransform_Y, value.transform.position.z);
        value.GetComponent<CanvasGroup>().alpha = 0;
        value.transform.localScale = new Vector3(1, 1, 1);
        /*value.GetComponent<Transform>().Find("FX_Star").gameObject.SetActive(false);*/
        /*--------------------动画--------------------*/
        value.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        value.transform.DOMoveY(value.transform.position.y + FinalOffestTransform_Y, 0.5f).SetEase(Ease.OutBack).OnComplete(() => 
        {
            /*value.GetComponent<Transform>().Find("FX_Star").gameObject.SetActive(true);*/
        });
    }
    private IEnumerator OntoYetChorusAttic(System.Action finish, float time)
    {
        yield return new WaitForSeconds(time);
        finish();
    }
    public void ExactBackup() 
    {
        for (int i = 0; i < BackupAttic.Count; i++) 
        {
            if (i <= 0)
            {
                ChicAttic(BackupAttic[i],0.5f);
                StartCoroutine(OntoYetChorusAttic(()=> { },0));
            }
            else 
            {
                ChicAttic(BackupAttic[i], 0.5f);
                StartCoroutine(OntoYetChorusAttic(() => { },0.15f));
            }
        }
    }



    public static void ExactChicGive(GameObject GoldImage, Transform parent, int a, Transform GoldStart, Transform GoldFinal, System.Action NextShow, System.Action finish)
    {
        if (a == 0)
        {
            finish();
        }
        a = Mathf.Min(20, a); //避免生成太多金币，最多20个
        //float endtime = 0;
        //float starttime = Time.time;
        //Debug.Log("starttime = " + starttime);
        int finishCount = 0;
        float Delaytime = 0;
        int goldGroups = Mathf.Min(5, a);
        int GroupNum = a / 5 + 1;
        for (int i = 0; i < goldGroups; i++)
        {
            for (int j = 0; j < GroupNum; j++)
            {
                var s = DOTween.Sequence();
                GameObject GoldIcon = Instantiate(GoldImage, parent);
                GoldIcon.SetActive(true);
                GoldIcon.GetComponent<Transform>().position = GoldStart.position;
                GoldIcon.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                GoldIcon.GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
                float OffsetX = Random.Range(-0.75f, 0.75f);
                float OffsetY = Random.Range(-0.75f, 0.75f);
                /*-------------------------------------动画效果------------------------------------*/
                //Debug.Log(OffsetX);
                GoldIcon.GetComponent<Transform>().position = new Vector3(OffsetX, OffsetY, 0) + GoldIcon.GetComponent<Transform>().position;
                s.Append(GoldIcon.GetComponent<Image>().DOFade(1, 0.4f));
                s.Insert(0, GoldIcon.GetComponent<Transform>().DOScale(new Vector3(0.75f, 0.75f, 1), 0.4f).SetEase(Ease.OutBack));
                s.Append(GoldIcon.GetComponent<Transform>().DOMove(GoldFinal.position, 0.8f).SetEase(Ease.InBack)).SetDelay(0.15f + Delaytime).OnComplete(() =>
                {
                    NextShow();
                });
                s.Insert(0.55f + Delaytime, GoldIcon.GetComponent<Transform>().DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.8f));
                /*s.Append(GoldIcon.GetComponent<Transform>().DOScale(new Vector3(0.9f, 0.9f, 0.9f), 0.3f));*/

                finishCount++;
                if (finishCount == a)
                {
                    //    endtime = Time.time;
                    //    Debug.Log("endtime = " + endtime);
                    s.AppendCallback(() =>
                    {
                        s.Kill();
                        Destroy(GoldIcon);
                        finish();
                    });
                    s.Play();
                    return;
                }
                s.AppendCallback(() =>
                {
                    s.Kill();
                    Destroy(GoldIcon);
                });
                s.Play();

            }
            Delaytime += Random.Range(0.05f, 0.2f);
        }

    }
}