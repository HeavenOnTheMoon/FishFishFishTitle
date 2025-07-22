using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;
using Spine.Unity;
[System.Serializable]
public struct LimitStruct
{
    public float Cry;
    public float Rot;
}

[System.Serializable]
public class FishLayerData
{
    /// <summary>
    /// 所在层的显示颜色
    /// </summary>
    /// 
    [Header("所在层的显示颜色")]
    public Color Minor;
    /// <summary>
    /// 所在层速度区间
    /// </summary>
    /// 
    [Header("所在层速度区间")]
    public LimitStruct ChestLower;
    /// <summary>
    /// 所在层尺寸
    /// </summary>
    /// 
    [Header("所在层尺寸")]
    public float Grama;
    /// <summary>
    /// 所在层父节点(处理显示层级)
    /// </summary>
    /// 
    [Header("所在层父节点(处理显示层级)")]
    public Transform Assist;
}
[System.Serializable]
public class FishData
{
    /// <summary>
    /// 鱼的出现间隔区间
    /// </summary>
    /// 
    [Header("鱼的出现间隔区间")]
    public LimitStruct HeelLower;
    /// <summary>
    /// 最大旋转角度
    /// </summary>
    /// 
    [Header("最大旋转角度")]
    public float EkaSpecimen;
    /// <summary>
    /// 一次旋转动作所用时间区间
    /// </summary>
    /// 
    [Header("一次旋转动作所用时间区间")]
    public LimitStruct WalrusPloy;

    /// <summary>
    /// 旋转角速度
    /// </summary>
    [Header("旋转角速度")]
    public float ExpressMarginal;

    /// <summary>
    /// 两次旋转动作的间隔区间
    /// </summary>
    /// 
    [Header("两次旋转动作的间隔区间")]
    public LimitStruct WalrusLower;
    /// <summary>
    /// 加速倍数区间
    /// </summary>
    /// 
    [Header("加速倍数区间")]
    public LimitStruct WeftChest;
    /// <summary>
    /// 加速动作间隔区间
    /// </summary>
    /// 
    [Header("加速动作间隔区间")]
    public LimitStruct WeftLower;
    /// <summary>
    /// 最下层
    /// </summary>
    /// 
    [Header("最下层")]
    public FishLayerData Banker;
    /// <summary>
    /// 中间
    /// </summary>
    /// 
    [Header("中间层")]
    public FishLayerData Bet;
    /// <summary>
    /// 最上层
    /// </summary>
    /// 
    [Header("最上层")]
    public FishLayerData Lap;
    
}
public class FareAbsence : MonoBehaviour
{
    public static FareAbsence instance;
[UnityEngine.Serialization.FormerlySerializedAs("BG")]    public GameObject BG; 
[UnityEngine.Serialization.FormerlySerializedAs("OldBG")]    public GameObject NowBG; 
[UnityEngine.Serialization.FormerlySerializedAs("point_left")]    public Transform Perch_Yolk;
[UnityEngine.Serialization.FormerlySerializedAs("point_right")]    public Transform Perch_Pluto;
[UnityEngine.Serialization.FormerlySerializedAs("point_top_up")]    public Transform Perch_Run_If;
[UnityEngine.Serialization.FormerlySerializedAs("point_top_down")]    public Transform Perch_Run_Bold;
[UnityEngine.Serialization.FormerlySerializedAs("point_mid_up")]    public Transform Perch_Maw_If;
[UnityEngine.Serialization.FormerlySerializedAs("point_mid_down")]    public Transform Perch_Maw_Bold;
[UnityEngine.Serialization.FormerlySerializedAs("point_bottom_up")]    public Transform Perch_Unique_If;
[UnityEngine.Serialization.FormerlySerializedAs("point_bottom_down")]    public Transform Perch_Unique_Bold;
[UnityEngine.Serialization.FormerlySerializedAs("BackImage")]    public Image RoofMouse;
[UnityEngine.Serialization.FormerlySerializedAs("FrontImage")]    public Image FetusMouse;
[UnityEngine.Serialization.FormerlySerializedAs("MidImage")]    public Image BetMouse;
[UnityEngine.Serialization.FormerlySerializedAs("FishPrefab")]    public GameObject FareChaste;
[UnityEngine.Serialization.FormerlySerializedAs("Data")]    public FishData Twig;
[UnityEngine.Serialization.FormerlySerializedAs("RewardGroup")]    public Transform BackupAsian;
[UnityEngine.Serialization.FormerlySerializedAs("RewardBubblePrefab")]    public GameObject BackupPistonChaste;
[UnityEngine.Serialization.FormerlySerializedAs("GoldRewardBubble")]    public Sprite ChicBackupPiston;
[UnityEngine.Serialization.FormerlySerializedAs("CashRewardBubble")]    public Sprite SoarBackupPiston;
[UnityEngine.Serialization.FormerlySerializedAs("ShellRewardBubble")]    public Sprite TenetBackupPiston;
[UnityEngine.Serialization.FormerlySerializedAs("PuzzleRewardBubble")]    public Sprite StitchBackupPiston;
[UnityEngine.Serialization.FormerlySerializedAs("mask")]    public GameObject Rust;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("FishList")]    public List<GameObject> FareForm;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("stopFishList")]    public List<GameObject> StemFareForm;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("stopFishIndexList")]    public List<int> StemFareBraceForm; 
    bool AnyKeaSoarOvertax= true;
    bool AnyKeaChicOvertax= true;
    bool AnyKeaTenetOvertax= true;
    bool AnyKeaStitchOvertax= true;
    int ScowlOvertaxKeaStyle= 0;
    int WeightOvertaxKeaStyle= 0;
[UnityEngine.Serialization.FormerlySerializedAs("newbgobj")]
    public GameObject Selfless;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        int fishTankIndex = TreeTwigAbsence.GetInt(CSoviet.Or_PackerFareSeep);
        //BG.GetComponent<Image>().sprite = Resources.Load<Sprite>(CSoviet.SScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScTex_TileFishBG + (fishTankIndex + 1));
        //BackImage.sprite = Resources.Load<Sprite>(CSoviet.SScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScBack);
        //FrontImage.sprite = Resources.Load<Sprite>(CSoviet.SScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScFront);
        //MidImage.sprite = Resources.Load<Sprite>(CSoviet.SScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScMid);
        Debug.Log("FishList:" + FareForm.Count);
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_PackerFareSeep, (messageData) =>
        {
            EuropeFareSeep(messageData.TroutAsk);
        });
        AnyKeaTenetOvertax = false;
        DustFare();
        //新手引导1-1
        if (!TreeTwigAbsence.GetBool(CSoviet.Or_TarGlueSpin + "1-1"))
        {
            DamFare(0);
            TreeTwigAbsence.SetBool(CSoviet.Or_TarGlueSpin + "1-1", true);
            Seem.instance.AnewAdultDownYam();
        }
    }
    /// <summary>
    /// 初始化鱼
    /// </summary>
    void DustFare()
    {
        GameData Luck= TugTourOil.instance.AnewTwig;
        Selfless.gameObject.SetActive(false);
        int fishPoolCount = 25;
        FareForm = new List<GameObject>();
        for (int i = 0; i < fishPoolCount; i++)
        {
            GameObject fishItem = Instantiate(FareChaste, Twig.Banker.Assist);
            FareForm.Add(fishItem);
        }
        StemFareForm = new List<GameObject>(FareForm);
        int nowTankIndex = TreeTwigAbsence.GetInt(CSoviet.Or_PackerFareSeep);
        StemFareBraceForm = new List<int>(TreeTwigAbsence.GetIntArray(CSoviet.Or_SeepPastFareForm));
        StartCoroutine(nameof(HeelFare));
        //initFishReward();
    }
    void AsiaFareBackup()
    {
        List<int> FishGoldList = new List<int>(TreeTwigAbsence.GetIntArray(CSoviet.Or_FarePastChicTreat));
        List<float> FishCashList = new List<float>(TreeTwigAbsence.GetFloatArray(CSoviet.Or_FarePastSoarTreat));
        float sw = KeaVesselTwig.KeaTextural().TieCoursePosit();
        float sh = KeaVesselTwig.KeaTextural().TieCourseSponge();
        float xmax = sw / 2 - 1;
        float xmin = -sw / 2 + 1;
        float ymax = sh / 2 - 2;
        float ymin = -sh / 2 + 2;
        foreach (int goldNum in FishGoldList)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("type", "Gold");
            dic.Add("num", goldNum.ToString());
            GameObject FishReward = Instantiate(BackupPistonChaste, BackupAsian);
            FishReward.transform.position = new Vector3(Random.Range(xmin, xmax), Random.Range(ymin, ymax), 0);
            FishReward.GetComponent<Image>().sprite = ChicBackupPiston;
            FishReward.GetComponent<BackupPistonFlavin>().Asia(dic);
        }
        foreach (float cashNum in FishCashList)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("type", "Cash");
            dic.Add("num", cashNum.ToString());
            GameObject FishReward = Instantiate(BackupPistonChaste, BackupAsian);
            FishReward.transform.position = new Vector3(Random.Range(xmin, xmax), Random.Range(ymin, ymax), 0);
            FishReward.GetComponent<Image>().sprite = SoarBackupPiston;
            FishReward.GetComponent<BackupPistonFlavin>().Asia(dic);
        }
        int shellHaveCount = TreeTwigAbsence.GetInt(CSoviet.Or_TenetPastStyle);
        for(int i = 0; i < shellHaveCount; i++)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("type", "Shell");
            GameObject FishReward = Instantiate(BackupPistonChaste, BackupAsian);
            FishReward.transform.position = new Vector3(Random.Range(xmin, xmax), Random.Range(ymin, ymax), 0);
            FishReward.GetComponent<Image>().material = Resources.Load<Material>(CSoviet.SurmiseFenTenetSteam); 
            GameObject It_Peru= Instantiate(Resources.Load<GameObject>(CSoviet.SurmiseFxPeru), FishReward.transform);
            FishReward.GetComponent<Image>().sprite = TenetBackupPiston;
            FishReward.GetComponent<BackupPistonFlavin>().Asia(dic);
        }
    }
    /// <summary>
    /// 切换鱼缸
    /// </summary>
    /// <param name="fishTankIndex"></param>
    public void EuropeFareSeep(int fishTankIndex)
    {
        int oldTankIndex = TreeTwigAbsence.GetInt(CSoviet.Or_PackerFareSeep);
        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Notch_Therapeutic);
        //换图
     //   OldBG.GetComponent<Image>().sprite = Resources.Load<Sprite>(CSoviet.SScTex_TileFishBG + (oldTankIndex + 1) + CSoviet.ScTex_TileFishBG + (oldTankIndex + 1));
        //OldBG.GetComponent<Image>().material = null;
     //   OldBG.SetActive(true);
        //BG.GetComponent<Image>().sprite = Resources.Load<Sprite>(CSoviet.SScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScTex_TileFishBG + (fishTankIndex + 1));
        //BackImage.sprite = Resources.Load<Sprite>(CSoviet.SScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScTex_TileFishBG + (fishTankIndex + 1)+ CSoviet.ScBack);
        //FrontImage.sprite = Resources.Load<Sprite>(CSoviet.SScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScTex_TileFishBG + (fishTankIndex + 1)+ CSoviet.ScFront);
        //MidImage.sprite = Resources.Load<Sprite>(CSoviet.SScTex_TileFishBG + (fishTankIndex + 1) + CSoviet.ScTex_TileFishBG + (fishTankIndex + 1)+ CSoviet.ScMid);
        //AstronautAttainment.ScreenTransitions(OldBG, () => { OldBG.SetActive(false); });
        //StopCoroutine("ShowFish");
        //foreach (GameObject fish in FishList)
        //{
        //    fish.SetActive(false);
        //}
        int nowTankIndex = fishTankIndex;
        TreeTwigAbsence.SetInt(CSoviet.Or_PackerFareSeep,fishTankIndex);
        //stopFishIndexList = new List<int>(TreeTwigAbsence.GetIntArray(CSoviet.sv_TankHaveFishList + nowTankIndex));
        //stopFishList = new List<GameObject>(FishList);
        //StartCoroutine(nameof(ShowFish));
    }
    /// <summary>
    /// 添加新鱼
    /// </summary>
    /// <param name="fishIndex"></param>
    public void DamFare(int fishIndex)
    {
        if (StemFareForm.Count > 0)
        {
            int nowTankIndex = TreeTwigAbsence.GetInt(CSoviet.Or_PackerFareSeep);
            List<int> nowTankHaveFishList = new List<int>(TreeTwigAbsence.GetIntArray(CSoviet.Or_SeepPastFareForm));
            nowTankHaveFishList.Add(fishIndex);
            //GrandeOntoTwigAbsence.instance.SetTaskValue(1001, 1);
            TreeTwigAbsence.SetIntArray(CSoviet.Or_SeepPastFareForm,nowTankHaveFishList.ToArray());
            TreeTwigAbsence.SetInt(CSoviet.Or_FareStyle + fishIndex, TreeTwigAbsence.GetInt(CSoviet.Or_FareStyle + fishIndex) + 1);
            GameObject fish = StemFareForm[0];
            FishLayerData layerData = Twig.Banker;
            fish.GetComponent<FareGive>().RotY = Perch_Unique_If.position.y;
            fish.GetComponent<FareGive>().CryY = Perch_Unique_Bold.position.y;
            fish.transform.SetParent(layerData.Assist);
            fish.transform.localScale = new Vector3(layerData.Grama * 1, layerData.Grama, layerData.Grama) * ((float)Screen.width / 750f);
            FishShopItemData itemData = TugTourOil.instance.AnewTwig.FishShop[fishIndex];
            fish.GetComponent<SkeletonGraphic>().skeletonDataAsset = Resources.Load<SkeletonDataAsset>(CSoviet.AstronautFareMat + itemData.ArtPath);
            fish.GetComponent<SkeletonGraphic>().initialSkinName = itemData.SkinName;
            fish.GetComponent<SkeletonGraphic>().Initialize(true);
            fish.GetComponent<SkeletonGraphic>().color = layerData.Minor;
            fish.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "fish_await", true);
            fish.SetActive(true);
            StemFareForm.Remove(fish);
            fish.GetComponent<FareGive>().ArchBrace = fishIndex;
            fish.GetComponent<FareGive>().Physician = 0;
            fish.GetComponent<FareGive>().Lower = 0;
            fish.GetComponent<Collider2D>().enabled = true;
            AnyKeaTenetOvertax = false;
            Seem.instance.DamFareTenetTwig();
            Dictionary<string, string> AmateurFlu= new Dictionary<string, string>();
            AmateurFlu.Add("type", "Shell");
            //新购买的鱼
            AmateurFlu.Add("num", "1");
            fish.GetComponent<FareGive>().WetOvertax(AmateurFlu);
            ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Notch_PayFareOnSeep);
            JuryFare(fish,() =>
            {
                fish.GetComponent<FareGive>().Physician = -1;
                fish.GetComponent<FareGive>().Lower = Random.Range(layerData.ChestLower.Cry, layerData.ChestLower.Rot);
            });

        }
    }
    /// <summary>
    /// 放鱼动画
    /// </summary>
    /// <param name="Newfish"></param>
    /// <param name="finish"></param>
    void JuryFare(GameObject Newfish, System.Action finish)
    {

        GameObject Fx_FishAdd = Instantiate(Resources.Load<GameObject>(CSoviet.AMatItPistonBet), Newfish.transform);
        Fx_FishAdd.SetActive(true);
        Newfish.transform.position = new Vector3(KeaVesselTwig.KeaTextural().TieCoursePosit() / 2, KeaVesselTwig.KeaTextural().TieCourseSponge() / 2, 0);
        var NewfishAni = DOTween.Sequence();
        NewfishAni.Append(Newfish.transform.DOMoveX(0, 2f).SetEase(Ease.OutExpo));
        NewfishAni.Insert(0.12f, Newfish.transform.DORotate(new Vector3(0, 0, 45), 0.2f));
        NewfishAni.Insert(0, Newfish.transform.DOMoveY(-0.1f, 3f));
        NewfishAni.Insert(0.62f, Newfish.transform.DORotate(new Vector3(0, 0, 15), 2f));
        NewfishAni.Insert(2.62f, Newfish.transform.DORotate(new Vector3(0, 0, 12), 0.3f).OnComplete(() =>
        {
            Fx_FishAdd.SetActive(false);
            Destroy(Fx_FishAdd);
            finish();
        }));
        NewfishAni.Play();
    }
    /// <summary>
    /// 生成鱼
    /// </summary>
    /// <returns></returns>
    IEnumerator HeelFare()
    {
        while (true)
        {
            int nowTankIndex = TreeTwigAbsence.GetInt(CSoviet.Or_PackerFareSeep);
            int canMoveCount = TreeTwigAbsence.GetIntArray(CSoviet.Or_SeepPastFareForm).Length;
            if (StemFareBraceForm.Count > 0)
            {
                int YolkOrMatch= Random.Range(0, 2);
                int Radio= Random.Range(0, 3);

                Vector3 initPos = KeaDustParadigm(YolkOrMatch, Radio);
                GameObject fish = StemFareForm[Random.Range(0, StemFareForm.Count)];
                FishLayerData layerData = null;
                switch (Radio)
                {
                    case 0:
                        layerData = Twig.Banker;
                        fish.GetComponent<FareGive>().RotY = Perch_Unique_If.position.y;
                        fish.GetComponent<FareGive>().CryY = Perch_Unique_Bold.position.y;
                        fish.GetComponent<Collider2D>().enabled = true;
                        Dictionary<string, string> AmateurFlu= KeaOvertax();
                        if (AmateurFlu != null)
                        {
                            fish.GetComponent<FareGive>().WetOvertax(AmateurFlu);
                        }
                        break;
                    case 1:
                        layerData = Twig.Bet;
                        fish.GetComponent<FareGive>().RotY = Perch_Maw_If.position.y;
                        fish.GetComponent<FareGive>().CryY = Perch_Maw_Bold.position.y;
                        fish.GetComponent<Collider2D>().enabled = false;
                        break;
                    case 2:
                        layerData = Twig.Lap;
                        fish.GetComponent<FareGive>().RotY = Perch_Run_If.position.y;
                        fish.GetComponent<FareGive>().CryY = Perch_Run_Bold.position.y;
                        fish.GetComponent<Collider2D>().enabled = false;
                        break;
                }
                fish.transform.SetParent(layerData.Assist);
                fish.transform.position = initPos;
                fish.transform.localScale = new Vector3(layerData.Grama * (initPos.x > 0 ? 1 : -1), layerData.Grama, layerData.Grama) * ((float)Screen.width /  750f);
                fish.GetComponent<FareGive>().Physician = initPos.x > 0 ? -1 : 1;
                fish.GetComponent<FareGive>().Lower = Random.Range(layerData.ChestLower.Cry, layerData.ChestLower.Rot);
                
                int ArchBrace= StemFareBraceForm[Random.Range(0,StemFareBraceForm.Count)];
                fish.GetComponent<FareGive>().ArchBrace = ArchBrace;
                FishShopItemData itemData = TugTourOil.instance.AnewTwig.FishShop[ArchBrace];
                fish.GetComponent<SkeletonGraphic>().skeletonDataAsset = Resources.Load<SkeletonDataAsset>(CSoviet.AstronautFareMat + itemData.ArtPath);
                fish.GetComponent<SkeletonGraphic>().initialSkinName = itemData.SkinName;
                fish.GetComponent<SkeletonGraphic>().Initialize(true);
                fish.GetComponent<SkeletonGraphic>().color = layerData.Minor;
                fish.GetComponent<SkeletonGraphic>().AnimationState.SetAnimation(0, "fish_await", true);
                fish.SetActive(true);
                
                StemFareBraceForm.Remove(ArchBrace);
                StemFareForm.Remove(fish);
            }
            float showFishLimit = Random.Range(Twig.HeelLower.Cry, Twig.HeelLower.Rot);
            yield return new WaitForSeconds(showFishLimit);
        }
    }
    /// <summary>
    /// 获取出生点
    /// </summary>
    /// <param name="leftOrRight"></param>
    /// <param name="layerType"></param>
    /// <returns></returns>
    Vector3 KeaDustParadigm(int leftOrRight, int layerType)
    {
        float x;
        float y;

        if (leftOrRight == 0)
        {
            x = Perch_Yolk.transform.position.x ;
        }
        else
        {
            x = Perch_Pluto.transform.position.x ;
        }
        if (layerType == 0)
        {
            y = UnityEngine.Random.Range(Perch_Unique_Bold.position.y, Perch_Unique_If.position.y);
        }
        else if (layerType == 1)
        {
            y = UnityEngine.Random.Range(Perch_Maw_Bold.position.y, Perch_Maw_If.position.y) ;
        }
        else
        {
            y = UnityEngine.Random.Range(Perch_Run_Bold.position.y, Perch_Run_If.position.y);
        }
        return new Vector3(x, y, 0);
    }

    /// <summary>
    /// 鱼生产资源
    /// </summary>
    /// <param name="Reward">生产的资源</param>
    /// <param name="FishImage">鱼的图片</param>
    public void FareMakeBackup(GameObject FishImage,Dictionary<string,string> dic) 
    {
        //DOTweenPath RewardPath;
        float x = 1;
        float y = 1f;
        float xOffset = Random.Range(-KeaVesselTwig.KeaTextural().TieCoursePosit()/2+x, KeaVesselTwig.KeaTextural().TieCoursePosit() / 2 - x);
        float yOffset = Random.Range(-KeaVesselTwig.KeaTextural().TieCourseSponge()/2 +y,FishImage.transform.position.y);
        float Lower= KeaVesselTwig.KeaTextural().TieCourseSponge() / 2;
        float ytime1 = -yOffset / Lower;
        GameObject FishReward   = Instantiate(BackupPistonChaste, BackupAsian);
        FishReward.GetComponent<RectTransform>().sizeDelta = new Vector2(110, 82);
        FishReward.transform.position = FishImage.transform.position;
        if (dic["type"] == "Gold")
        {
            FishReward.GetComponent<Image>().material = null;
            FishReward.GetComponent<Image>().sprite = ChicBackupPiston;
        }
        else if (dic["type"] == "Cash")
        {
            FishReward.GetComponent<Image>().material = null;
            FishReward.GetComponent<Image>().sprite = SoarBackupPiston;
        }
        else if (dic["type"] == "Puzzle")
        {
            FishReward.GetComponent<Image>().material = null;
            FishReward.GetComponent<Image>().sprite = StitchBackupPiston;
        }
        else
        {
            FishReward.GetComponent<Image>().material = Resources.Load<Material>(CSoviet.SurmiseFenTenetSteam);
            GameObject It_Peru= Instantiate(Resources.Load<GameObject>(CSoviet.SurmiseFxPeru), FishReward.transform);
            FishReward.GetComponent<Image>().sprite = TenetBackupPiston;
        }
        GameObject Fx_Reward = Instantiate(Resources.Load<GameObject>(CSoviet.AMatItJumpLightnessBattle), FishReward.transform);
        Fx_Reward.transform.localScale = new Vector3(150, 150, 150);
        Fx_Reward.SetActive(true);
        Lower /= 3;
        if (ytime1 < 1) 
        {
            ytime1+= 1;
        }
        if (-yOffset > 3)
        {
            ytime1 += 0.7f;
        }
        var s = DOTween.Sequence();
        s.Append(FishReward.transform.DOMoveX(xOffset, 0.53f+ytime1));
        s.Insert(0,FishReward.transform.DOMoveY((FishReward.transform.position.y + 0.5f), 0.33f)).OnComplete(() =>
        {
            Destroy(Fx_Reward);
        });
        s.Insert(0.53f, FishReward.transform.DOMoveY(yOffset, ytime1));
        s.Insert(0.53f + ytime1, FishReward.transform.DOMoveY((yOffset + 0.1f), 0.5f));
        s.AppendCallback(() =>
        {

            FishReward.GetComponent<BackupPistonFlavin>().Asia(dic);
            
            
        });
    }



    /// <summary>
    /// 领取任务
    /// </summary>
    /// <returns></returns>
    public Dictionary<string,string> KeaOvertax()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        if (AnyKeaTenetOvertax)
        {
            if (TreeTwigAbsence.GetInt(CSoviet.Or_TenetPastStyle) + ScowlOvertaxKeaStyle < TreeTwigAbsence.GetInt(CSoviet.Or_TenetBackupStyle))
            {
                ScowlOvertaxKeaStyle++;
                dic.Add("type", "Shell");
                //关卡贝壳
                dic.Add("num", "2");
                AnyKeaTenetOvertax = false;
                return dic;
            }
        }
        if (AnyKeaStitchOvertax)
        {
            if (TreeTwigAbsence.GetInt(CSoviet.Or_StitchBackupStyle) > WeightOvertaxKeaStyle + TreeTwigAbsence.GetInt(CSoviet.Or_StitchPastStyle))
            {
                WeightOvertaxKeaStyle++;
                dic.Add("type", "Puzzle");
                dic.Add("num", "1");
                AnyKeaStitchOvertax = false;
                return dic;
            }
        }
        if (AnyKeaSoarOvertax)
        {
            int allCashCount = TreeTwigAbsence.GetInt(CSoviet.Or_FareBackupSoarStyle);
            float allCashNum = TreeTwigAbsence.GetFloat(CSoviet.Or_FareBackupSoarShy);
            if (allCashCount > 0)
            {
                float onceTimeNum = allCashNum / allCashCount;
                dic.Add("type", "Cash");
                dic.Add("num", onceTimeNum.ToString());
                AnyKeaSoarOvertax = false;
                return dic;
            }
        }
        if (AnyKeaChicOvertax)
        {
            int allGoldCount = TreeTwigAbsence.GetInt(CSoviet.Or_FareBackupChicStyle);
            int allGoldNum = TreeTwigAbsence.GetInt(CSoviet.Or_FareBackupChicShy);
            if (allGoldCount > 0)
            {
                int onceTimeNum = allGoldNum / allGoldCount;
                dic.Add("type", "Gold");
                dic.Add("num", onceTimeNum.ToString());
                AnyKeaChicOvertax = false;
                return dic;
            }
        }
        
        return null;
    }
    
    public void WetPistonLira()
    {
        //for (int i = 0; i < RewardGroup.childCount; i++)
        //{
        //    GameObject bubble = RewardGroup.GetChild(i).gameObject;
        //    bubble.GetComponent<Image>().DOFade(0.5f, 0.3f);
        //}
        BackupAsian.GetComponent<CanvasGroup>().DOFade(0.5f, 0.3f);
        
    }
    public void WetPistonHeel()
    {
        //for (int i = 0; i < RewardGroup.childCount; i++)
        //{
        //    GameObject bubble = RewardGroup.GetChild(i).gameObject;
        //    bubble.GetComponent<Image>().DOFade(1f, 0.3f);
        //}
        BackupAsian.GetComponent<CanvasGroup>().DOFade(1f, 0.3f);
    }
    // Update is called once per frame
    void Update()
    {
    }
    /// <summary>
    /// 奖励的流光
    /// </summary>
    /// <param name="Reward"></param>
    public void FareBackupSteam(GameObject Reward)
    {
        float offset = -0.6f;
        var RewardAni = DOTween.Sequence();
        RewardAni.Insert(2f, DOTween.To(() => offset, x => Reward.GetComponent<Image>().material.SetFloat("_LightOffset", offset = x), 0.6f, 1f).SetLoops(-1));
    }
}
