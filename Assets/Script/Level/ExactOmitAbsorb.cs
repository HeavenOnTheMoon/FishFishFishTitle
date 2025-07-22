using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class TileAnimationData
{
    public Vector2 Xenon_Gel;
    public Vector2 Dam_Gel;
    public Transform Quilt;
    
}
public class ExactOmitAbsorb : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("isTest")]    public bool AnBell;
[UnityEngine.Serialization.FormerlySerializedAs("mainData")]    public LevelMainData ClipTwig;
[UnityEngine.Serialization.FormerlySerializedAs("tileBG")]    public GameObject DeadBG;
[UnityEngine.Serialization.FormerlySerializedAs("tileGroup")]    public GameObject DeadAsian;
[UnityEngine.Serialization.FormerlySerializedAs("tileDic")]    public Dictionary<LevelItemData, GameObject> DeadFlu;
[UnityEngine.Serialization.FormerlySerializedAs("imgNameList")]    public Dictionary<int,int> AshNameForm;
    Dictionary<int, int> CubeWorthStyleFlu;
[UnityEngine.Serialization.FormerlySerializedAs("selectTileGroup")]    public GameObject ScriptMailAsian;
[UnityEngine.Serialization.FormerlySerializedAs("levelNumber")]    public int ApartSupply;
[UnityEngine.Serialization.FormerlySerializedAs("newUserMask")]    public GameObject EggGlueDown;
[UnityEngine.Serialization.FormerlySerializedAs("SelectTileGroupLayout")]

    //MUYU
    //public int lastLevelScore;
    //public levelDD userLevelDD;
    //public enum levelDD 
    //{
    //    master = 0,
    //    hard = -1,
    //    mid = -2,
    //    easy = -3     
    //}

    public RomeSpeedy PackerMailAsianSpeedy;
    GameObject DeadSuckChaste;
    float Unify_x= -0.2f;
    float Unify_y= -0.3f;
    //float layerOffectY = 0.153f;
    Color[] BoundForm= new Color[] {
        new Color(255.0f / 255f ,54.0f/ 255f ,54.0f/ 255f),
        new Color(149.0f/ 255f  ,255.0f/ 255f  ,54.0f/ 255f),
        new Color(54.0f / 255f ,65.0f / 255f ,255.0f/ 255f),
        new Color(255.0f/ 255f ,147.0f/ 255f,54.0f/ 255f),
        new Color(54.0f/ 255f ,255.0f/ 255f  ,161.0f/ 255f),
        new Color(154.0f / 255f ,54.0f / 255f,255.0f/ 255f),
        new Color(255.0f/ 255f  ,232.0f/ 255f  ,54.0f/ 255f),
        new Color(54.0f / 255f ,176.0f / 255f ,255.0f/ 255f),
        new Color(255.0f / 255f,54.0f / 255f,238.0f/ 255f),
    };

    //public LevelOriginalMainData omainData;
    private void Awake()
    {
        if (AnBell)
        {
            TreeTwigAbsence.SetInt(CSoviet.Or_Exact_It, ApartSupply);
        }
        DeadSuckChaste = Resources.Load<GameObject>(CSoviet.ChasteMailSuck);
    }
    /// <summary>
    /// 读取json
    /// </summary>
    /// <param name="levelName"></param>
    public void loadExactSize(string levelName)
    {
        CubeWorthStyleFlu = new Dictionary<int, int>();
        ClipTwig = new LevelMainData();
        string LevelJsonString = Resources.Load<TextAsset>( CSoviet.ExactSizeExact + levelName).ToString();
        //Debug.Log("LevelJsonString:" + LevelJsonString);
        LevelOriginalMainData originalMainData = JsonMapper.ToObject<LevelOriginalMainData>(LevelJsonString);
        List<LevelItemData> levelItemDataList = new List<LevelItemData>();
        for(int i = 0; i < originalMainData.target.Count; i++)
        {
            LevelOriginalItemData odata = originalMainData.target[i];
            LevelItemData Luck= new LevelItemData();
            Luck.px = odata.px;
            Luck.py = odata.py;
            Luck.layer = odata.layer;
            levelItemDataList.Insert(0,Luck);
        }
        ClipTwig.target = new List<LevelItemData>();
        for (int i = 0; i < levelItemDataList.Count; i++)
        {
            LevelItemData Luck= levelItemDataList[i];
            int diff_layer = TieYardWorth(Luck, ClipTwig.target);
            //Debug.Log("diff_layer:"+diff_layer);
            if (CubeWorthStyleFlu.ContainsKey(diff_layer))
            {
                CubeWorthStyleFlu[diff_layer]++;
            }
            else
            {
                CubeWorthStyleFlu.Add(diff_layer, 1);
            }
            Luck.diff_layer = diff_layer.ToString();
            LevelItemData data1 = Luck;
            bool is_insert = false;
            for (int j = 0; j < ClipTwig.target.Count; j++)
            {
                LevelItemData data2 = ClipTwig.target[j];
                if (int.Parse(data2.diff_layer) >= int.Parse(data1.diff_layer))
                {
                    ClipTwig.target.Insert(j, data1);
                    is_insert = true;
                    break;
                }
            }
            if (!is_insert)
            {
                ClipTwig.target.Add(data1);
            }
        }
        ClipTwig.figureNum = originalMainData.figureNum;
        WetMouseAsian();
    }
    /// <summary>
    /// 获取关卡中tile实际层级
    /// </summary>
    /// <param name="select_data">获取目标</param>
    /// <param name="levelItemDataList">全部方块情况</param>
    /// <returns></returns>
    int TieYardWorth(LevelItemData select_data, List<LevelItemData> levelItemDataList)
    {
        int Radio= int.Parse(select_data.layer);
        int At= int.Parse(select_data.px);
        int Me= int.Parse(select_data.py);
        List<LevelItemData> upList = new List<LevelItemData>();
        foreach (LevelItemData odata in levelItemDataList)
        {
            if (int.Parse(odata.layer) > Radio)
            {
                upList.Add(odata);
            }
        }
        List<string> upLayerList = new List<string>();
        int diffLayerMax = -1;
        foreach (LevelItemData upData in upList)
        {
            int up_px = int.Parse(upData.px);
            int up_py = int.Parse(upData.py);
            if (up_px >= At - 1 && up_px <= At + 1 && up_py >= Me - 1 && up_py <= Me + 1)
            {
                if (int.Parse(upData.diff_layer) > diffLayerMax)
                {
                    diffLayerMax = int.Parse(upData.diff_layer);
                }
            }
        }
        return diffLayerMax+1;
    }
    /// <summary>
    /// 生成关卡tile
    /// </summary>
    void RepeatExactMail()
    {
        DeadFlu = new Dictionary<LevelItemData, GameObject>();
        float bg_w = KeaVesselTwig.KeaTextural().TieVanishThin(DeadBG).x;
        float bg_h = KeaVesselTwig.KeaTextural().TieVanishThin(DeadBG).y;
        float base_tile_w = KeaVesselTwig.KeaTextural().TieVanishThin(DeadSuckChaste).x;
        float base_tile_h = KeaVesselTwig.KeaTextural().TieVanishThin(DeadSuckChaste).y;
        float group_w = base_tile_w * 11f + Unify_x * 10f;
        float group_h = base_tile_h * 11f + Unify_y * 10f;
        float group_scale = bg_w / (base_tile_w * 8f + Unify_x * 7f);
        Vector2 bg_pos = DeadBG.transform.position;
        DeadAsian.transform.position = bg_pos;
        Vector2 oddV2 = new Vector2(-group_w / 2f, group_h / 2f);
        Vector2 evenV2 = new Vector2(-(base_tile_w * 10f + Unify_x * 9f) / 2f, (base_tile_h * 10f + Unify_y * 9f) / 2f);
        for (int i = 0; i < ClipTwig.target.Count; i++)
        {
            LevelItemData Luck= ClipTwig.target[i];
            GameObject tileItem = Instantiate<GameObject>(DeadSuckChaste);
            float pos_x = 0;
            float pos_y = 0;
            int At= int.Parse(Luck.px) / 2;
            int Me= int.Parse(Luck.py) / 2;
            if (int.Parse(Luck.px) % 2 == 0)
            {
                pos_x = oddV2.x + At * (base_tile_w + Unify_x) + base_tile_w / 2f;
            }
            else
            {
                pos_x = evenV2.x + At * (base_tile_w + Unify_x) + base_tile_w / 2f;
            }
            if (int.Parse(Luck.py) % 2 == 0)
            {
                pos_y = oddV2.y - Me * (base_tile_h + Unify_y) - base_tile_h / 2f;
            }
            else
            {
                pos_y = evenV2.y - Me * (base_tile_h + Unify_y) - base_tile_h / 2f;
            }
            pos_y -=1;
            tileItem.transform.parent = DeadAsian.transform;
            tileItem.transform.localPosition = new Vector3(pos_x, pos_y + KeaVesselTwig.KeaTextural().TieCourseSponge() * 1.5f + 1, 0);
            tileItem.GetComponent<MailSuck>().WetWorth((int.Parse(Luck.layer) + 1).ToString(), (int.Parse(Luck.py) * 21 + int.Parse(Luck.px)) * 4);
            tileItem.GetComponent<MailSuck>().PrepayWoman(int.Parse(Luck.diff_layer));
            tileItem.GetComponent<MailSuck>().Luck = Luck;
            //设置图片
            if (ApartSupply != 1)
            {
                int img_name = TieMailMouse(Luck);
                tileItem.GetComponent<MailSuck>().WetMailMouse(img_name);
                Luck.img_name = img_name.ToString();
            }
            else
            {
                if ((Luck.px == Seem.instance.WeedySixth[0][0] && Luck.py == Seem.instance.WeedySixth[0][1]) 
                    || (Luck.px == Seem.instance.WeedySixth[1][0] && Luck.py == Seem.instance.WeedySixth[1][1]) 
                    || (Luck.px == Seem.instance.WeedySixth[2][0] && Luck.py == Seem.instance.WeedySixth[2][1]))
                {
                    List<int> keys = new List<int>(AshNameForm.Keys);
                    tileItem.GetComponent<MailSuck>().WetMailMouse(keys[0]);
                    Luck.img_name = keys[0].ToString();
                }
                else
                {
                    int img_name = TieMailMouse(Luck);
                    tileItem.GetComponent<MailSuck>().WetMailMouse(img_name);
                    Luck.img_name = img_name.ToString();
                }
            }
            
            //调整动画终点位置
            Luck.pos = new Vector2(pos_x * group_scale, pos_y * group_scale+0.5f);
            Luck.layer_name = (int.Parse(Luck.layer) + 1).ToString();
            Luck.layer_order = (int.Parse(Luck.py) * 21 + int.Parse(Luck.px)) * 4;

            Luck.anmData = new TileAnimationData();
            Luck.anmData.Xenon_Gel = new Vector2(pos_x * group_scale, pos_y  * group_scale + KeaVesselTwig.KeaTextural().TieCourseSponge() * 1.5f + 1);
            Luck.anmData.Dam_Gel = Luck.pos;
            Luck.anmData.Quilt = tileItem.transform;

            DeadFlu.Add(Luck, tileItem);
        }
        DeadAsian.transform.localScale = new Vector3(group_scale, group_scale, 0);
        ScriptMailAsian.transform.localScale = new Vector3(group_scale, group_scale+0.2f, 0);
        PackerMailAsianSpeedy.SevereAffair();
        Seem.instance.AnewAdultDownYam();
        HeelMailAstronaut(()=> {
            Seem.instance.ValidSeemAdultDownYam();
            TarGlueAbsence.KeaTextural().IngoingLipid(TriggerType.Apart_Xenon);

            if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) == 0)
            {
                EggGlueSpin();
            }
            else if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) == 1)
            {
                if (GameUtil.IsApple())
                {
                    TreeTwigAbsence.SetInt(CSoviet.Or_TarGlueSpin, 2);
                }
                else
                {
                    HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HeelSoarOntoWeedy);
                }
            }
            
        });
    }

    public void HeelMailAstronaut(System.Action finish = null)
    {
        GetComponent<ExactBeer>().AnyStump = false;
        //UIAbsence.GetInstance().ShowUIForms("BackupKrill");
        
        List<TileAnimationData> list = new List<TileAnimationData>();
        for (int i = ClipTwig.target.Count - 1; i >= 0; i--)
        {
            LevelItemData Luck= ClipTwig.target[i];
            TileAnimationData anmData = Luck.anmData;
            list.Add(anmData);
        }
        AstronautAttainment.LackHeel(list, () =>
        {
            GetComponent<ExactBeer>().AnyStump = true;
            
            if (finish != null)
            {
                finish();
            }
        });
    }
    public void LiraMailAstronaut(System.Action finish = null)
    {
        GetComponent<ExactBeer>().AnyStump = false;
        finish();
        //List<TileAnimationData> list = new List<TileAnimationData>();
        //for (int i = 0; i < mainData.target.Count; i++)
        //{
        //    LevelItemData data = mainData.target[i];
        //    TileAnimationData anmData = data.anmData;
        //    list.Add(anmData);
        //}
        //AstronautAttainment.CubeHide(list, () =>
        //{
        //    if (finish != null)
        //    {
        //        finish();
        //    }
            
        //});
    }

    /// <summary>
    /// 获取tile图片
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    int TieMailMouse(LevelItemData data)
    {
        int m = int.Parse(data.diff_layer);
        //Debug.Log("m:" + m);
        int A = 0;
        for (int a = 0; a <= m; a++)
        {
            A += CubeWorthStyleFlu[a];
            if (a == m && A <= 3)
            {
                if (CubeWorthStyleFlu.ContainsKey(m + 1))
                {
                    m += 1;
                }
            }
        }

        List<int> allKeyList = new List<int>(AshNameForm.Keys);
        //Debug.Log(allKeyList[0]);
        int kMax = (A / 2) < allKeyList.Count ? (A / 2) : allKeyList.Count;
        if (kMax <= 0)
        {
            kMax = 1;
        }
        List<int> canUseKeyList = new List<int>();
        int i = 0;
        while (i < kMax)
        {
            int key = allKeyList[i];
            if (AshNameForm[key] > 0)
            {
                canUseKeyList.Add(key);
            }
            i++;
        }
        if (canUseKeyList.Count == 0)
        {
            i = 0;
            while (canUseKeyList.Count < kMax && i < allKeyList.Count)
            {
                int key = allKeyList[i];
                if (AshNameForm[key] > 0)
                {
                    canUseKeyList.Add(key);
                }
                i++;
            }
        }

        int img_name = canUseKeyList[Random.Range(0, canUseKeyList.Count)];
        AshNameForm[img_name]--;
        return img_name;
    }

    /// <summary>
    /// 获取当前关卡图案数（附加难度动态调整） //MUYU
    /// </summary>
    /// <returns></returns>
    int TieUpsideShy()
    {
        
        int UsefulNum= int.Parse(ClipTwig.figureNum) + (int)ExactDDAbsence.Textural.GrayExactDD;
        Debug.Log("getFigureNum: " + UsefulNum + ", " + int.Parse(ClipTwig.figureNum) + ", " + ExactDDAbsence.Textural.GrayExactDD);
        return UsefulNum > 3 ? UsefulNum : 3;
    }

    /// <summary>
    /// 初始化图片池
    /// </summary>
    void WetMouseAsian()
    {
        AshNameForm = new Dictionary<int, int>();
        List<int> groupList = new List<int>();
        
        int tileCount = ClipTwig.target.Count;
        if (ApartSupply == 1)
        {
            tileCount -= 3;
        }
        int groupCount = tileCount / 3;
        int UsefulNum= TieUpsideShy(); //MUYU  
        if (groupCount <= UsefulNum) 
        {
            int[] random = KeaVesselTwig.KeaTextural().KeaGliderFacility(15, groupCount);
            for (int i = 0; i < groupCount; i++)
            {
                AshNameForm.Add(random[i] + 1, 3);
            }
        }
        else
        {
            int[] random1 = KeaVesselTwig.KeaTextural().KeaGliderFacility(15, UsefulNum);
            int[] random2 = KeaVesselTwig.KeaTextural().KeaGliderFacility(random1.Length, groupCount % UsefulNum);
            for (int i = 0;i < groupCount; i++)
            {
                if (i < groupCount - groupCount % UsefulNum)
                {
                    if (AshNameForm.ContainsKey(random1[i % UsefulNum] + 1))
                    {
                        AshNameForm[random1[i % UsefulNum] + 1] += 3;
                    }
                    else
                    {
                        AshNameForm.Add(random1[i % UsefulNum] + 1, 3);
                    }
                }
                else
                {
                    //Debug.Log("random2item:" + random2[i % figureNum]);
                    //Debug.Log("random1item:" + random1[random2[i % figureNum]]);
                    AshNameForm[random1[random2[i % UsefulNum]] + 1] += 3;
                }
            }
        }

    }
    /// <summary>
    /// 根据牌池中剩余图案刷新image
    /// </summary>
    public void FrontRebirthMouse(List<GameObject> selectTileList)
    {
        //Debug.Log("skillRefreshImage");
        int[] randomArray = KeaVesselTwig.KeaTextural().KeaGliderFacility(ClipTwig.target.Count, ClipTwig.target.Count);
        AshNameForm = new Dictionary<int, int>();
        for(int i = 0; i < ClipTwig.target.Count; i++)
        {
            LevelItemData Luck= ClipTwig.target[randomArray[i]];
            if (AshNameForm.ContainsKey(int.Parse(Luck.img_name)))
            {
                AshNameForm[int.Parse(Luck.img_name)] += 1;
            }
            else
            {
                AshNameForm.Add(int.Parse(Luck.img_name), 1);
            }
        }
        if (selectTileList.Count > 0)
        {
            List<string> selectGroupImageList = new List<string>();
            foreach (GameObject obj in selectTileList)
            {
                if (!selectGroupImageList.Contains(obj.GetComponent<MailSuck>().Luck.img_name))
                {
                    selectGroupImageList.Add(obj.GetComponent<MailSuck>().Luck.img_name);
                }
            }
            Dictionary<int, int> imageDic = new Dictionary<int, int>(AshNameForm);
            AshNameForm = new Dictionary<int, int>();
            foreach (string imgName in selectGroupImageList)
            {
                //Debug.Log("imgName:" + imgName);
                AshNameForm.Add(int.Parse(imgName), imageDic[int.Parse(imgName)]);
            }
            foreach (int key in imageDic.Keys)
            {
                if (!AshNameForm.ContainsKey(key))
                {
                    AshNameForm.Add(key, imageDic[key]);
                }
            }
            List<int> keys = new List<int>(AshNameForm.Keys);
            //Debug.Log("imgNameList First:" + keys[0]);
        }
        //设置图片
        foreach (LevelItemData data in ClipTwig.target)
        {
            int img_name = TieMailMouse(data);
            data.img_name = img_name.ToString(); ;
            DeadFlu[data].GetComponent<MailSuck>().WetMailMouse(img_name);
            DeadFlu[data].GetComponent<MailSuck>().Luck = data;
        }
    }
    /// <summary>
    /// 回退后刷新显示关系
    /// </summary>
    /// <param name="data"></param>
    /// <param name="obj"></param>
    public void PushSightRebirth(LevelItemData data,GameObject obj)
    {
        //mainData.target.Add(data);
        LevelItemData data1 = data;
        bool is_insert = false;
        for (int j = 0; j < ClipTwig.target.Count; j++)
        {
            LevelItemData data2 = ClipTwig.target[j];
            if (int.Parse(data2.diff_layer) >= int.Parse(data1.diff_layer))
            {
                ClipTwig.target.Insert(j, data1);
                is_insert = true;
                break;
            }
        }
        if (!is_insert)
        {
            ClipTwig.target.Add(data1);
        }
        DeadFlu.Add(data, obj);
        CubeWorthStyleFlu = new Dictionary<int, int>();
        foreach (LevelItemData itemData in ClipTwig.target)
        {
            int diffLayer = TieYardWorth(itemData, ClipTwig.target);
            if (CubeWorthStyleFlu.ContainsKey(diffLayer))
            {
                CubeWorthStyleFlu[diffLayer]++;
            }
            else
            {
                CubeWorthStyleFlu.Add(diffLayer, 1);
            }
            itemData.diff_layer = diffLayer.ToString();
            if (diffLayer != 0)
            {
                DeadFlu[itemData].GetComponent<MailSuck>().PrepayWoman(diffLayer);
            }
        }
    }
    /// <summary>
    /// 点击后刷新数据和下方层级关系
    /// </summary>
    /// <param name="data">单块数据</param>
    public void ScriptMailRebirth(LevelItemData data)
    {
        ClipTwig.target.Remove(data);
        DeadFlu.Remove(data);
        CubeWorthStyleFlu = new Dictionary<int, int>();
        foreach (LevelItemData itemData in ClipTwig.target)
        {
            int diffLayer = TieYardWorth(itemData, ClipTwig.target);
            if (CubeWorthStyleFlu.ContainsKey(diffLayer))
            {
                CubeWorthStyleFlu[diffLayer]++;
            }
            else
            {
                CubeWorthStyleFlu.Add(diffLayer, 1);
            }
            itemData.diff_layer = diffLayer.ToString();
            if (diffLayer == 0)
            {
                DeadFlu[itemData].GetComponent<MailSuck>().PrepayWoman(diffLayer);
            }
        }
    }
    /// <summary>
    /// 初始化关卡
    /// </summary>
    public void AsiaExact()
    {
        for (int i = 0; i < DeadAsian.transform.childCount; i++)
        {
            Destroy(DeadAsian.transform.GetChild(i).gameObject);
        }
        if (TreeTwigAbsence.GetInt(CSoviet.Or_Exact_It) == 0)
        {
            TreeTwigAbsence.SetInt(CSoviet.Or_Exact_It,1);
        }
        ApartSupply = TreeTwigAbsence.GetInt(CSoviet.Or_Exact_It);
        UIAbsence.KeaTextural().HeelUIDrape(nameof(ExactKrill));
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactKrill_ExactSupply, new HandfulTwig(ApartSupply));
        DeadAsian.transform.localScale = new Vector3(1, 1, 1);
        ScriptMailAsian.transform.localScale = new Vector3(1, 1, 1);
        GetComponent<ExactBeer>().ApartDust();
        Seem.instance.SewSeemGarden(false);
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_AssetExact);
        loadExactSize(ApartSupply.ToString());
        RepeatExactMail();
        ExactDDAbsence.Textural.ApartShootDust();       //MUYU
        
    }
    /// <summary>
    /// 关卡新手引导
    /// </summary>
    public void EggGlueSpin()
    {
        EggGlueDown.SetActive(true);
        foreach (LevelItemData data in DeadFlu.Keys)
        {
            if ((data.px == Seem.instance.WeedySixth[0][0] && data.py == Seem.instance.WeedySixth[0][1]) 
                || (data.px == Seem.instance.WeedySixth[1][0] && data.py == Seem.instance.WeedySixth[1][1]) 
                || (data.px == Seem.instance.WeedySixth[2][0] && data.py == Seem.instance.WeedySixth[2][1]))
                {
                if (data.px == Seem.instance.WeedySixth[0][0] && data.py == Seem.instance.WeedySixth[0][1])
                {
                    GetComponent<ExactBeer>().Sack.SetActive(true);
                    GetComponent<ExactBeer>().Sack.transform.position = DeadFlu[data].transform.position;
                }
                DeadFlu[data].GetComponent<MailSuck>().WetWorth("NewUserLight",0);
            }
        }
    }
    public GameObject TieTarGlueMail(string px, string py)
    {
        foreach (LevelItemData data in DeadFlu.Keys)
        {
            if (data.px == px && data.py == py)
            {
                return DeadFlu[data];
            }
        }
        return null;
    }

    public bool TieTugRome()
    {
        bool canAuto = true;
        foreach (LevelItemData item in DeadFlu.Keys)
        {
            if (item.diff_layer != "0")
            {
                canAuto = false;
                break;
            }
        }
        return canAuto;
    }
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(nameof(loadLevelWaitTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
