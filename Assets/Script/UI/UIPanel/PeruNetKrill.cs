using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Spine.Unity;

public class PeruNetKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("StarBox")]    public GameObject PeruNet;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_StarBoxOpen")]    public GameObject It_PeruNetWife;
[UnityEngine.Serialization.FormerlySerializedAs("EndTF")]    public List<GameObject> SonTF;
[UnityEngine.Serialization.FormerlySerializedAs("startX")]    public float XenonX;
[UnityEngine.Serialization.FormerlySerializedAs("startY")]    public float XenonY;
[UnityEngine.Serialization.FormerlySerializedAs("GetRewardBtn")]    public GameObject KeaBackupBow;
    List<GameObject> JazzForm;
[UnityEngine.Serialization.FormerlySerializedAs("GoldSprite")]    public Sprite ChicVanish;
[UnityEngine.Serialization.FormerlySerializedAs("UndoSprite")]    public Sprite EtchVanish;
[UnityEngine.Serialization.FormerlySerializedAs("HintSprite")]    public Sprite WhigVanish;
[UnityEngine.Serialization.FormerlySerializedAs("RefreshSprite")]    public Sprite RebirthVanish;
    Sequence BowUtterNephew;
[UnityEngine.Serialization.FormerlySerializedAs("fishSkeletonPrefab")]    public GameObject ArchSubclassChaste;


    private double QuartzSoar;
    private double QuartzChic;
    private double QuartzCarman;
    private string QuartzSightBold;
   // private Puzzle rewardPuzzle;
    private int QuartzFareBrace;


    public override void Display()
    {
        base.Display();

        // 计算奖励
        Init initData = TugTourOil.instance.DustTwig;
        QuartzSoar = initData.starbox_cash_price * Seem.instance.TieSoarSharp();
        QuartzChic = initData.starbox_gold_price * Seem.instance.TieChicSharp();
        QuartzCarman = initData.starbox_amazon_price * Seem.instance.TieCarmanSharp();
        if (GliderTide.InLawyer(initData.starbox_skill_chance))
        {
            string[] skills = new string[] { "Undo", "Hint", "Shuffle" };
            QuartzSightBold = skills[Random.Range(0, 3)];
        }
        else
        {
            QuartzSightBold = "";
        }
        //rewardPuzzle = SOHOShopManager.instance.GetRewardPuzzle();
        QuartzFareBrace = Seem.instance.TieNowSeepPastFareStyle() % TugTourOil.instance.AnewTwig.FishShop.Count;

        It_PeruNetWife.SetActive(false);
        KeaBackupBow.transform.localScale = new Vector3(0, 0, 0);
        PeruNet.transform.localScale = new Vector3(0, 0, 0);
        PeruNet.transform.position = new Vector3(XenonX, XenonY, PeruNet.transform.position.z);
        PeruNet.GetComponent<CanvasGroup>().alpha = 0;
        PeruNet.GetComponent<Transform>().Find("BoxTop").GetComponent<Image>().sprite = Resources.Load<Sprite>(CSoviet.SurmiseBackupNetLapStark);
        It_PeruNetWife.SetActive(false);
        for (int j = 0; j < SonTF.Count; j++) 
        {
            GameObject startPos = SonTF[j];
            startPos.GetComponent<CanvasGroup>().alpha = 0;
            startPos.transform.position = new Vector3(0, 0, 0);
        }
        WifeNet();
    }
    /// <summary>
    /// 按钮出现     !!点击之后记得销毁动画 我没写 交给你了遇哥!!
    /// </summary>
    public void WetNetBackup()
    {
        KeaBackupBow.transform.DOScale(new Vector3(1, 1, 1), 0.3f).SetEase(Ease.OutBack).OnComplete(() => 
        {
            BowUtterNephew = DOTween.Sequence();
            BowUtterNephew.Append(KeaBackupBow.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 1f));
            BowUtterNephew.Append(KeaBackupBow.transform.DOScale(new Vector3(1f,1f, 1f), 1f));
            BowUtterNephew.SetLoops(-1);
            BowUtterNephew.Play();
        });
    }
    /// <summary>
    /// 宝箱打开
    /// </summary>
    /// <param name="CardCount">奖励个数</param>
    public void WifeNet() 
    {
        foreach(GameObject obj in SonTF)
        {
            obj.transform.Find("RewardIcon").gameObject.SetActive(true);
            if (obj.transform.Find("FishImage") != null)
            {
                Destroy(obj.transform.Find("FishImage").gameObject);
            }
        }

        JazzForm = new List<GameObject>();
        // EndTF[0] : cash
      //  EndTF[0].transform.Find("Text").GetComponent<Text>().text = "+" + SupplyTide.DoubleToStr(rewardCash);
        //CardList.Add(EndTF[0]);
        
        // EndTF[1] : gold
        SonTF[1].transform.Find("Text").GetComponent<Text>().text = "+" + SupplyTide.InvestAtFir(QuartzChic);
        JazzForm.Add(SonTF[1]);
        
        // EndTF[2] : amazon
      //  EndTF[2].transform.Find("Text").GetComponent<Text>().text = "+" + SupplyTide.DoubleToStr(rewardAmazon);
      //  CardList.Add(EndTF[2]);
        
        // 技能奖励
        int Calve= 3;
        if (QuartzSightBold != "")
        {
            if (QuartzSightBold == "Undo")
            {
                SonTF[Calve].transform.Find("RewardIcon").GetComponent<Image>().sprite = EtchVanish;
            } else if (QuartzSightBold == "Hint")
            {
                SonTF[Calve].transform.Find("RewardIcon").GetComponent<Image>().sprite = WhigVanish;
            } else if (QuartzSightBold == "Shuffle")
            {
                SonTF[Calve].transform.Find("RewardIcon").GetComponent<Image>().sprite = RebirthVanish;
            }
            SonTF[Calve].transform.Find("Text").GetComponent<Text>().text = "+5";
            JazzForm.Add(SonTF[Calve]);
            Calve++;
        }

        // 碎片奖励
        //if (rewardPuzzle != null)
        //{
        //    EndTF[index].transform.Find("RewardIcon").GetComponent<Image>().sprite = Resources.Load<Sprite>(rewardPuzzle.puzzle_img);
        //    EndTF[index].transform.Find("Text").GetComponent<Text>().text = "+" + rewardPuzzle.reward_count;
        //    CardList.Add(EndTF[index]);
        //    index++;
        //}

        // 鱼奖励
        //EndTF[index].transform.Find("RewardIcon").gameObject.SetActive(false);
        //FishShopItemData fishData = TugTourOil.instance.gameData.FishShop[rewardFishIndex];
        //GameObject fish = Instantiate(fishSkeletonPrefab, EndTF[index].transform);
        //fish.name = "FishImage";
        //SkeletonGraphic fishSkeleton = fish.GetComponent<SkeletonGraphic>();
        //fishSkeleton.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2((float)fishData.Pos_X, (float)fishData.Pos_Y);
        //fishSkeleton.skeletonDataAsset = Resources.Load<SkeletonDataAsset>(CSoviet.AnimationFishAni + fishData.ArtPath);
        //fishSkeleton.initialSkinName = fishData.SkinName;
        //fishSkeleton.Initialize(true);
        //fishSkeleton.AnimationState.SetAnimation(0, "fish_await", true);
        //EndTF[index].transform.Find("Text").GetComponent<Text>().text = fishData.Name;
        //CardList.Add(EndTF[index]);

        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Notch_WifePeruNet);
        AstronautAttainment.PeruNetGive(PeruNet, 1, It_PeruNetWife, () =>
        {
            AstronautAttainment.PeruNetBackupHeel(JazzForm, JazzForm.Count, () =>
            {
                //宝箱打开动画结束
                WetNetBackup();
            });
        });
    }

    // Start is called before the first frame update
    void Start()
    {
        KeaBackupBow.GetComponent<Button>().onClick.AddListener(() =>
        {

            BowUtterNephew.Kill();
            //领取奖励
            Transform P= UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().Find("Normal/ExactKrill");
            Transform A = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>();
            AstronautAttainment.ChicGiveKeel(P.GetComponent<RectTransform>().Find("CashBar/CashIcon").gameObject, 15, A, P.GetComponent<RectTransform>().Find("CashBar/CashIcon"), () => 
            { 
                Seem.instance.RidSoar(QuartzSoar); 
            });

            AstronautAttainment.ChicGiveKeel(P.GetComponent<RectTransform>().Find("GoldBar/GoldIcon").gameObject, 15, A, P.GetComponent<RectTransform>().Find("GoldBar/GoldIcon"), () =>
            {
                Seem.instance.RidChic(QuartzChic);
            });

            AstronautAttainment.ChicGiveKeel(P.GetComponent<RectTransform>().Find("AmazonBar/AmazonIcon").gameObject, 15, A, P.GetComponent<RectTransform>().Find("AmazonBar/AmazonIcon"), () =>
            {
                Seem.instance.RidCarman(QuartzCarman);
            });
            
            if (QuartzSightBold != "")
            {
                Seem.instance.DamSightStyle(QuartzSightBold, 5);
            }
            //if (rewardPuzzle != null)
            //{
            //    SOHOShopManager.instance.AddRewardPuzzle(rewardPuzzle);
            //}
            //StartCoroutine(DropFish());
            Seem.instance.PeruNetSlowFare(QuartzFareBrace);
            StarkUIWish(GetType().Name);
            
        });
    }
    //IEnumerator DropFish()
    //{
    //    yield return new WaitForSeconds(0.5f);
    //    Seem.instance.levelFinish();
    //    Seem.instance.buyFish(rewardFishIndex);
    //}

    // Update is called once per frame
    void Update()
    {

    }

    public override void Hidding()
    {
        base.Hidding();

        
    }
}