using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;
using DG.Tweening;

public class ExactInsertFareKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("LevelIconList")]    public List<GameObject> ExactWhigForm;
[UnityEngine.Serialization.FormerlySerializedAs("UnlockProgress")]    public Image InsertUntapped;
[UnityEngine.Serialization.FormerlySerializedAs("PlayButton")]    public Button BeerInform;
[UnityEngine.Serialization.FormerlySerializedAs("PlayButtonText")]    public Text BeerInformPile;
[UnityEngine.Serialization.FormerlySerializedAs("UnlockButtonText")]    public Text InsertInformPile;
[UnityEngine.Serialization.FormerlySerializedAs("UnlockText")]    public Text InsertPile;
[UnityEngine.Serialization.FormerlySerializedAs("LevelText")]    public Text ExactPile;
[UnityEngine.Serialization.FormerlySerializedAs("FishBubbleImage")]    public GameObject FarePistonMouse;
[UnityEngine.Serialization.FormerlySerializedAs("FishImage")]    public GameObject FareMouse;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_UnlockFish")]    public GameObject It_InsertFare;
[UnityEngine.Serialization.FormerlySerializedAs("lockImage")]    public GameObject lockMouse;
[UnityEngine.Serialization.FormerlySerializedAs("EndPos")]    public GameObject SonPer;
[UnityEngine.Serialization.FormerlySerializedAs("levelIconLock")]    public Sprite ApartWhigKink;
[UnityEngine.Serialization.FormerlySerializedAs("levelIconUnlock")]    public Sprite ApartWhigInsert;
[UnityEngine.Serialization.FormerlySerializedAs("closeButton")]    public Button UnityInform;
    int OffShy1;
    int OffShy2;
    int ApartShy1;
    int ApartShy2;
    int  MildInsertFareBrace;
    // Start is called before the first frame update

    protected override void Awake()
    {
        base.Awake();
        BeerInform.onClick.AddListener(() =>
        {
            if (BeerInformPile.gameObject.activeSelf)
            {
                StarkUIWish(GetType().Name);
                HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HikeKrillExactAsset);
            }
            else
            {
                ExactInsert();
            }
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_ExactInsertSonPer, (messageData) =>
        {
            SonPer = messageData.TroutSeemFluent;
            Asia();
        });
    }
    
    public override void Display()
    {
        base.Display();
        FareMouse.SetActive(true);
        OffShy1 = Seem.instance.OffHeelSupply;
        OffShy2 = Seem.instance.TieBut();
        ApartShy1 = Seem.instance.GrayExactHeelSupply;
        ApartShy2 = Seem.instance.TieGlueExact();
        MildInsertFareBrace = Seem.instance.TieGenuInsertFareTwig();
        lockMouse.SetActive(true);
        lockMouse.GetComponent<Transform>().Find("LockimageTop").GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        FarePistonMouse.GetComponent<CanvasGroup>().alpha = 1;
        FarePistonMouse.GetComponent<Transform>().Find("FishImage").GetComponent<SkeletonGraphic>().color = new Color(FarePistonMouse.GetComponent<Transform>().Find("FishImage").GetComponent<SkeletonGraphic>().color.r, FarePistonMouse.GetComponent<Transform>().Find("FishImage").GetComponent<SkeletonGraphic>().color.g, FarePistonMouse.GetComponent<Transform>().Find("FishImage").GetComponent<SkeletonGraphic>().color.b, 1);
    }
    public void Asia()
    {
        
        int startLevelNum = 1;
        if (MildInsertFareBrace != 0)
        {
            startLevelNum = TugTourOil.instance.AnewTwig.FishShop[MildInsertFareBrace - 1].UnlockValue;
        }
        int endLevelNum = TugTourOil.instance.AnewTwig.FishShop[MildInsertFareBrace].UnlockValue;
        int limit = endLevelNum - startLevelNum;
        float space = (InsertUntapped.GetComponent<RectTransform>().sizeDelta.x * InsertUntapped.transform.localScale.x - 60) / limit;
        for (int i = 0; i <= limit; i++)
        {
            GameObject levelIcon = ExactWhigForm[i];
            if (startLevelNum + i <= ApartShy1)
            {
                levelIcon.GetComponent<Image>().sprite = ApartWhigInsert;
                levelIcon.transform.Find("Text").GetComponent<Text>().color = Color.white;
            }
            else
            {
                levelIcon.GetComponent<Image>().sprite = ApartWhigKink;
                levelIcon.transform.Find("Text").GetComponent<Text>().color = Color.gray;
            }
            levelIcon.transform.Find("Text").GetComponent<Text>().text = (startLevelNum + i).ToString();
            levelIcon.GetComponent<RectTransform>().anchoredPosition = new Vector2(i * space + 30, 0);
            levelIcon.SetActive(true);
        }
        ExactPile.text = "" + Seem.instance.TieGlueExact();
        int needLevelCount = 0;
        for (int i = ApartShy2; i < endLevelNum; i++)
        {
            int needExp = Seem.instance.TieExactChugBut(i);
            if (i == ApartShy2)
            {
                needExp -= OffShy2;
            }
            needLevelCount += needExp;
        }

        //UnlockText.text = "play " + needLevelCount + " more game to unlock this fish";
        GetComponent<I2.Loc.LocalizationParamsManager>().SetParameterValue("unlock_fish", needLevelCount.ToString());
        //UnlockText.GetComponent<I2.Loc.Localize>().SetTerm(UnlockText.GetComponent<I2.Loc.Localize>().Term);
        FishShopItemData itemData = TugTourOil.instance.AnewTwig.FishShop[MildInsertFareBrace];
        FareMouse.GetComponent<RectTransform>().anchoredPosition = new Vector2((float)itemData.Pos_X, (float)itemData.Pos_Y);
        FareMouse.GetComponent<SkeletonGraphic>().skeletonDataAsset = Resources.Load<SkeletonDataAsset>(CSoviet.AstronautFareMat + TugTourOil.instance.AnewTwig.FishShop[MildInsertFareBrace].ArtPath);
        FareMouse.GetComponent<SkeletonGraphic>().initialSkinName = TugTourOil.instance.AnewTwig.FishShop[MildInsertFareBrace].SkinName;
        FareMouse.GetComponent<SkeletonGraphic>().Initialize(true);
        FareMouse.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "fish_await", true);
        int level1NeedExp = Seem.instance.TieExactChugBut(ApartShy1 + 1);
        int level2NeedExp = Seem.instance.TieExactChugBut(ApartShy2);
        float progress1 = (ApartShy1 - startLevelNum) * (1f / (float)limit) + ((float)OffShy1 / (float)level1NeedExp) * (1f / (float)limit);
        float progress2 = (ApartShy2 - startLevelNum) * (1f / (float)limit) + ((float)OffShy2 / (float)level2NeedExp) * (1f / (float)limit);
        InsertUntapped.fillAmount = progress1;
        
            
        if (Seem.instance.OffHeelSupply != Seem.instance.TieBut() || Seem.instance.GrayExactHeelSupply != Seem.instance.TieGlueExact())
        {
            UnityInform.gameObject.SetActive(false);
            BeerInform.gameObject.SetActive(false);
            Seem.instance.AnewAdultDownYam();
            Sequence Pry= DOTween.Sequence();
            Pry.AppendInterval(1f);
            int count = ApartShy1;
            for (int i = ApartShy1; i < ApartShy2; i++)
            {
                float lastProgress;
                float nowProgress = (i + 1 - startLevelNum) * (1f / (float)limit);
                if (ApartShy1 == i)
                {
                    lastProgress = progress1;
                }
                else
                {
                    lastProgress = (i - startLevelNum) * (1f / (float)limit);
                }
                Pry.Append(DOTween.To(() => lastProgress, x => InsertUntapped.fillAmount = x, nowProgress, 2f * (nowProgress - lastProgress))).SetEase(Ease.Linear);
                Pry.AppendCallback(() =>
                {
                    int Calve= count - startLevelNum + 1;
                    ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Sound_LevelUp);
                    AstronautAttainment.ExactInsertIConUtter(ExactWhigForm[Calve], ApartWhigInsert, ExactWhigForm[Calve].transform.Find("Text").GetComponent<Text>(), () =>
                    {

                    });
                    count++;
                    if (count == ApartShy2)
                    {
                        if (ApartShy2 == endLevelNum)
                        {

                            ExactInsertHeel(() => {
                                Seem.instance.ValidSeemAdultDownYam();
                                InsertInformPile.gameObject.SetActive(true);
                                BeerInformPile.gameObject.SetActive(false);
                                BeerInform.gameObject.SetActive(true);
                            });
                        }
                        else
                        {
                            InsertInformPile.gameObject.SetActive(false);
                            BeerInformPile.gameObject.SetActive(true);
                            if (OffShy2 != 0)
                            {
                                float last= (ApartShy2 - startLevelNum) * (1f / (float)limit);
                                Pry.Append(DOTween.To(() => last, x => InsertUntapped.fillAmount = x, progress2, 2f * (progress2 - last))).SetEase(Ease.Linear);
                                Pry.AppendCallback(() =>
                                {
                                    Seem.instance.ValidSeemAdultDownYam();
                                    BeerInform.gameObject.SetActive(true);
                                    UnityInform.gameObject.SetActive(true);
                                });
                            }
                            else
                            {
                                Seem.instance.ValidSeemAdultDownYam();
                                BeerInform.gameObject.SetActive(true);
                                UnityInform.gameObject.SetActive(true);
                            }
                        }
                    }
                });
            }
        }
        else
        {
            
            if (Seem.instance.GrayExactHeelSupply == endLevelNum)
            {
                FareMouse.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "fish_swimming", true);
                InsertInformPile.gameObject.SetActive(true);
                BeerInformPile.gameObject.SetActive(false);
                BeerInform.gameObject.SetActive(true);
            }
            else
            {
                FareMouse.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "fish_await", true);
                InsertInformPile.gameObject.SetActive(false);
                BeerInformPile.gameObject.SetActive(true);
                BeerInform.gameObject.SetActive(true);
                UnityInform.gameObject.SetActive(true);
            }
        }

    }

    
    /// <summary>
    /// 满足解锁条件动画
    /// </summary>
    public void ExactInsertHeel(System.Action finish)
    {
        It_InsertFare.SetActive(true);
        //鱼开始swimming
        FarePistonMouse.GetComponent<Transform>().Find("FishImage").GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "fish_swimming",true);
        FarePistonMouse.transform.DOScaleY(1.15f, 0.2f);
        FarePistonMouse.transform.DOScaleX(0.85f, 0.2f).OnComplete(() =>
        {
            FarePistonMouse.transform.DOScaleY(1f, 0.2f);
            FarePistonMouse.transform.DOScaleX(1.15f, 0.2f).OnComplete(() =>
            {
                FarePistonMouse.transform.DOScaleY(1.15f, 0.2f);
                FarePistonMouse.transform.DOScaleX(0.85f, 0.2f).OnComplete(() =>
                {
                    FarePistonMouse.transform.DOScaleY(1f, 0.2f).SetEase(Ease.OutBack);
                    FarePistonMouse.transform.DOScaleX(1f, 0.2f).SetEase(Ease.OutBack).OnComplete(() => 
                    {
                        It_InsertFare.SetActive(false);
                        finish();
                    });
                });
            });
        });
    }

    /// <summary>
    /// 点击解锁Btn
    /// </summary>
    public void ExactInsert() 
    {
        Seem.instance.AnewAdultDownYam();
        lockMouse.GetComponent<Transform>().Find("LockimageTop").GetComponent<Transform>().DORotate(new Vector3(0, 0, -20), 0.2f).SetDelay(0.2f);
        lockMouse.transform.DOScale(1.3f, 0.25f).OnComplete(() => 
        {
            lockMouse.transform.DOScale(1f, 0.25f).OnComplete(() => 
            {
                It_InsertFare.SetActive(true);
                FarePistonMouse.transform.DOScaleY(1.15f, 0.2f);
                FarePistonMouse.transform.DOScaleX(0.85f, 0.2f).OnComplete(() => 
                {
                    FarePistonMouse.transform.DOScaleY(0.85f, 0.2f);
                    FarePistonMouse.transform.DOScaleX(1.15f, 0.2f).OnComplete(() => 
                    {
                        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Sound_UnlockFish);
                        //关闭弹窗
                        It_InsertFare.SetActive(false);
                        StarkUIWish(GetType().Name);
                        FarePistonMouse.transform.localScale = new Vector3(1f, 1f, 1f);
                        FareAtChordLet(FarePistonMouse, SonPer, lockMouse, ()=> 
                        {
                            Seem.instance.ValidSeemAdultDownYam();
                        });   
                    });
                });
            });
        });
    }

    /// <summary>
    /// 解锁鱼之后的动画
    /// </summary>
    /// <param name="ScreenFishImage"></param>
    /// <param name="FishMoveOffset"></param>
    /// <param name="EndPos"></param>
    public static void FareAtChordLet(GameObject UnlockFishImage, GameObject EndPos,GameObject lockImage,System.Action finish) 
    {
        /*-----------------------------------物体准备----------------------------------*/
        lockImage.SetActive(false);
        lockImage.transform.localScale = new Vector3(1, 1, 1);
        GameObject ScreenFishImage = Instantiate(UnlockFishImage, UIAbsence.KeaTextural().PinkCyclic.transform);
        ScreenFishImage.GetComponent<Transform>().Find("FishImage").gameObject.SetActive(true);
        ScreenFishImage.SetActive(true);
        ScreenFishImage.transform.position = new Vector3(0, 0, 0);
        ScreenFishImage.transform.localScale = new Vector3(0, 0, 0);
        float Chest= 2.2f / 0.7f;
        float t2 = (2.2f - EndPos.transform.position.y) / Chest;
        Debug.Log("t2 =" + t2);
        /*-----------------------------------动画开始----------------------------------*/
        var s = DOTween.Sequence();
        s.Append(ScreenFishImage.transform.DOScale(0.6f, 0.3f).SetDelay(0.1f).OnComplete(() =>
        {
            ScreenFishImage.transform.DOScaleY(0.45f, 0.2f);
            ScreenFishImage.transform.DOScaleX(0.75f, 0.2f).OnComplete(() =>
            {
                ScreenFishImage.transform.DOScaleY(0.75f, 0.2f);
                ScreenFishImage.transform.DOScaleX(0.45f, 0.2f).OnComplete(() =>
                {
                    ScreenFishImage.transform.DOScaleX(0.6f, 0.2f).SetEase(Ease.OutBack);
                    ScreenFishImage.transform.DOScaleY(0.6f, 0.2f);
                });
            });
        }));//用时1.1f
        s.Insert(1.2f, ScreenFishImage.transform.DOScale(0.35f, 0.5f));
        s.Insert(0,ScreenFishImage.transform.DOMoveX(EndPos.transform.position.x,2f));//用时1.8f
        s.Insert(0, ScreenFishImage.transform.DOMoveY((ScreenFishImage.transform.position.y + 1.7f),0.5f));
        s.Insert(0.6f, ScreenFishImage.transform.DORotate(new Vector3(0, 0, 60), 1f).SetDelay(0.3f));
        s.Insert(1.5f, ScreenFishImage.GetComponent<Transform>().Find("FishImage").GetComponent<SkeletonGraphic>().DOFade(0, 0.5f));
        s.Insert(1.5f, ScreenFishImage.GetComponent<CanvasGroup>().DOFade(0, 0.7f));
        s.Insert(0.6f, ScreenFishImage.transform.DOMoveY(EndPos.transform.position.y, 1.2f).SetEase(Ease.InQuart).OnComplete(() =>
        {
            ScreenFishImage.transform.DOScale(0, 0.01f);
            TarGlueAbsence.KeaTextural().IngoingLipid(TriggerType.Arch_Behind);
        }));
        /*s.AppendCallback(()=> { Destroy(ScreenFishImage); });*/
        s.InsertCallback(2.4f, () => 
        {
            Destroy(ScreenFishImage);
            finish();
        });
    }

    
    public override void Hidding()
    {
        base.Hidding();
        FareMouse.SetActive(false);
        if (!TreeTwigAbsence.GetBool(CSoviet.Or_Error_News) && Seem.instance.TieGlueExact() >= 3)
        {
            WifeUIWish("MustKrill");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
