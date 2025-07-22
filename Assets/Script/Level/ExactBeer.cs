using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using Lofelt.NiceVibrations;
public class ExactBeer : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("selectTileGroup")]    public GameObject ScriptMailAsian;
[UnityEngine.Serialization.FormerlySerializedAs("selectTileList")]    public List<GameObject> ScriptMailForm;
[UnityEngine.Serialization.FormerlySerializedAs("waitRemoveList")]    public List<GameObject> VineAnswerForm;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("canTouch")]    public bool AnyStump= true;
    DateTime XenonPloy;
    bool ErrorTreePloy;
[UnityEngine.Serialization.FormerlySerializedAs("selectTileObj")]    public GameObject ScriptMailShy;
[UnityEngine.Serialization.FormerlySerializedAs("Hand")]    public GameObject Sack;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("getCount")]    public int TieStyle= 0;
    bool AnHolding= false;
    // Start is called before the first frame update
    private void OnEnable()
    {

        ErrorTreePloy = false;
        XenonPloy = DateTime.Now;
    }
    private void OnDisable()
    {
        if (!ErrorTreePloy)
        {
            int sec = KeaVesselTwig.KeaTextural().SetLeakYard(XenonPloy.ToString(), DateTime.Now);
            Debug.Log("sec:" + sec);
            TreeTwigAbsence.SetInt(CSoviet.Or_ExactYamPloy, sec + TreeTwigAbsence.GetInt(CSoviet.Or_ExactYamPloy));
        }
    }
    void Start()
    {
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_Push,(messageData)=> {

            EtchSightAffair();
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_Cute, (messageData)=> {

            WhigSightAffair();
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_Imagist, (messageData)=> {

            SurplusSightAffair();
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_Rescue, (messageData) => {

            MonroeSightAffair();
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_AroundWife, (messageData) => {
            AnyStump = false;
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_AroundStark, (messageData) => {
            AnyStump = true;
        });
    }
    /// <summary>
    /// 关卡初始化
    /// </summary>
    public void ApartDust()
    {
        TieStyle = 0;
        ScriptMailForm = new List<GameObject>();
        VineAnswerForm = new List<GameObject>();
        AnHolding = false;
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_OfferingRomeInform);
        
    }
    /// <summary>
    /// 获取点击方块
    /// </summary>
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.P))
        //{
        //    if (!readySaveTime)
        //    {
        //        levelComplete();
        //        print("MUYU:levelComplete");
        //    }
                
            
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    AutoMatch();
        //}

        if (Input.GetMouseButtonDown(0) && AnyStump)
        {
            
            if (ScriptMailForm.Count < 7 || StampFrom())
            {
                RaycastHit2D[] rayHits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                foreach (RaycastHit2D ray in rayHits)
                {
                    if (ray.transform.GetComponent<MailSuck>() != null && int.Parse(ray.transform.GetComponent<MailSuck>().Luck.diff_layer) == 0)
                    {
                        if (!StampTarGlue())
                        {
                            ray.transform.DOScale(1.2f, 0.1f);
                            ray.transform.GetComponent<MailSuck>().WetWorth("18", 1000);
                            ScriptMailShy = ray.transform.gameObject;
                        }
                        else
                        {
                            if (StampTarGlueTugPacker(ray.transform.GetComponent<MailSuck>().Luck))
                            {
                                ray.transform.DOScale(1.2f, 0.1f);
                                ScriptMailShy = ray.transform.gameObject;
                            }
                        }
                            
                        break;
                    }
                }
            }
        }
        if (Input.GetMouseButtonUp(0) && AnyStump)
        {
            if (ScriptMailForm.Count < 7 || StampFrom())
            {
                RaycastHit2D[] rayHits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                foreach (RaycastHit2D ray in rayHits)
                {
                    if (ray.transform.GetComponent<MailSuck>() != null && int.Parse(ray.transform.GetComponent<MailSuck>().Luck.diff_layer) == 0 && ScriptMailShy == ray.transform.gameObject)
                    {
                        if (!StampTarGlue())
                        {
                            ray.transform.DOScale(1f, 0.1f);
                            ScriptMailShy = null;
                            ScriptMail(ray.transform);
                        }
                        else
                        {
                            if (StampTarGlueTugPacker(ray.transform.GetComponent<MailSuck>().Luck))
                            {
                                ray.transform.DOScale(1f, 0.1f);
                                ScriptMailShy = null;
                                ScriptMail(ray.transform);
                            }
                        }
                        break;
                    }
                }
                if (ScriptMailShy != null)
                {
                    if (!StampTarGlue())
                    {
                        ScriptMailShy.GetComponent<MailSuck>().WetWorth(ScriptMailShy.GetComponent<MailSuck>().Luck.layer_name, ScriptMailShy.GetComponent<MailSuck>().Luck.layer_order);
                    }
                    ScriptMailShy.transform.DOScale(1f, 0.1f);
                }
            }
        }
    }
    /// <summary>
    /// 点击方块
    /// </summary>
    /// <param name="tile"></param>
    void ScriptMail(Transform tile,Action finish = null)
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.Selection);
        TieStyle++;
        if (!AnHolding)
        {
            //ADManager.Instance.autoInterTouch();
        }
        if (StampTarGlue())
        {
            if (TieStyle == 1)
            {
                Sack.transform.position = GetComponent<ExactOmitAbsorb>().TieTarGlueMail(Seem.instance.WeedySixth[1][0], Seem.instance.WeedySixth[1][1]).transform.position;
            }
            if (TieStyle == 2)
            {
                Sack.transform.position = GetComponent<ExactOmitAbsorb>().TieTarGlueMail(Seem.instance.WeedySixth[2][0], Seem.instance.WeedySixth[2][1]).transform.position;
            }
            if (TieStyle == 3)
            {
                Sack.SetActive(false);
                GetComponent<ExactOmitAbsorb>().EggGlueDown.SetActive(false);
                TreeTwigAbsence.SetInt(CSoviet.Or_TarGlueSpin, 1);
            }
        }

        ThereOil.KeaTextural().BeerAlbedo(ThereTern.SceneMusic.Notch_StumpLack);

        GetComponent<ExactOmitAbsorb>().ScriptMailRebirth(tile.GetComponent<MailSuck>().Luck);
        tile.GetComponent<MailSuck>().Luck.diff_layer = "-1";
        string select_img_name = tile.GetComponent<MailSuck>().Luck.img_name;
        bool isInsert = false; ;
        for (int i = ScriptMailForm.Count - 1; i >= 0; i--)
        {
            GameObject obj = ScriptMailForm[i];
            if (obj.GetComponent<MailSuck>().Luck.img_name == select_img_name)
            {
                if (i > 1 && ScriptMailForm[i - 2].GetComponent<MailSuck>().Luck.img_name == select_img_name)
                {
                    ScriptMailForm.Add(tile.gameObject);
                    isInsert = true;
                }
                else
                {
                    ScriptMailForm.Insert(i + 1, tile.gameObject);
                    isInsert = true;
                }
                break;
            }
        }
        if (!isInsert)
        {
            ScriptMailForm.Add(tile.gameObject);

            //新手引导:收取tile记录
            if (TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) <= 4)
            {
                HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HeelSightWeedy, new HandfulTwig(Seem.instance.ApartAbsorb.ApartSupply));
            }
        }
        RebirthPackerAsian();
        if (!AnHolding)
        {
            if (GetComponent<ExactOmitAbsorb>().TieTugRome())
            {
                //HandfulCannonForth.GetInstance().Send(CSoviet.mg_ShowAutoButton);
                // 自动开启自动合并
                RomeWheat();
                LipidSowPool.Textural.CornBackupLipid(1406, "game_auto_1406");
            }
        }
    }

    int NinetyBrace= 0;
    /// <summary>
    /// 移除手牌区相同方块
    /// </summary>
    /// <param name="list"></param>
    void NinetyFromMail(List<GameObject> list)
    {
        NinetyBrace++;
        List<TileAnimationData> anmList = new List<TileAnimationData>();
        for (int j = 0; j < 3; j++)
        {
            TileAnimationData anmData = list[j].GetComponent<MailSuck>().Luck.anmData;
            //list[j].GetComponent<MailSuck>().data.isRemoving = true;
            anmList.Add(anmData);
            VineAnswerForm.Add(list[j]);
            
        }
        if (NinetyBrace >= 3)
        {
            LipidSowPool.Textural.CornBackupLipid(1404, "game_clear_up_3_1404");
            NinetyBrace = 0;
        }
        ThereOil.KeaTextural().BeerAlbedo(ThereTern.SceneMusic.Notch_PulseAnalysis);
        //动画:消除
        AstronautAttainment.LackPulseMat(anmList,()=> {
            Transform position = list[0].transform;
            for (int j = 0; j < 3; j++)
            {
                //动画:消除
                VineAnswerForm.Remove(list[0]);
                ScriptMailForm.Remove(list[0]);
                Destroy(list[0]);
                list.RemoveAt(0);
            }
            int count1 = VineAnswerForm.Count;
            for(int i = count1 - 1; i >= 0; i--)
            {
                if (VineAnswerForm[i] == null)
                {
                    VineAnswerForm.RemoveAt(i);
                }
            }
            int count2 = ScriptMailForm.Count;
            for (int i = count2 - 1; i >= 0; i--)
            {
                if (ScriptMailForm[i] == null)
                {
                    ScriptMailForm.RemoveAt(i);
                }
            }
            //MUYU
            ExactDDAbsence.Textural.ApartShootPoor();
 
            RebirthPackerAsian();
            if (ScriptMailForm.Count == 0 && GetComponent<ExactOmitAbsorb>().ClipTwig.target.Count == 0)
            {
                ApartAnyplace();
            }

            // 是否触发大额奖励
            TileReward tileReward = GameUtil.KeaTextural().getBigReward();
            if (tileReward != null && tileReward.rewardValue > 0 && !AnHolding)
            {
                // 大奖弹框
                Seem.instance.WayBackup = tileReward;
                UIAbsence.KeaTextural().HeelUIDrape(nameof(AudioKrill));
            }
            else
            {
                // 是否触发小额奖励
                tileReward = GameUtil.KeaTextural().getSmallReward();
                if (tileReward != null && tileReward.rewardValue > 0)
                {
                    if (tileReward.rewardType == RewardType.cash)
                    {
                        // 现金奖励
                        Seem.instance.RidSoar(tileReward.rewardValue, position);
                    }
                    else if (tileReward.rewardType == RewardType.gold)
                    {
                        // 金币奖励
                        Seem.instance.RidChic(tileReward.rewardValue, position);
                    }
                }
            }
        });
    }
    /// <summary>
    /// 过关成功
    /// </summary>
    void ApartAnyplace()
    {
        Seem.instance.SewSeemGarden(true);
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_RustExact);
        TreeTwigAbsence.SetInt(CSoviet.Or_Exact_It, TreeTwigAbsence.GetInt(CSoviet.Or_Exact_It) + 1);
        double cashNumber = Seem.instance.TieExactRustSoar();
        int expNumber = 1;
        Seem.instance.RidBut(expNumber);
        Seem.instance.DamPeruNetBut();
        UIAbsence.KeaTextural().HeelUIDrape(nameof(ExactAnyplaceKrill));
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_ExactAnyplaceKrill_Backup, new HandfulTwig((int)cashNumber, expNumber));
        int sec = KeaVesselTwig.KeaTextural().SetLeakYard(XenonPloy.ToString(), DateTime.Now);
        TreeTwigAbsence.SetInt(CSoviet.Or_ExactYamPloy, sec + TreeTwigAbsence.GetInt(CSoviet.Or_ExactYamPloy));
        ErrorTreePloy = true;
        Seem.instance.StemWayBackupPloy();

    }
    /// <summary>
    /// 刷新手牌区位置
    /// </summary>
    void RebirthPackerAsian(Action finish = null)
    {
        Dictionary<string, List<GameObject>> dic = new Dictionary<string, List<GameObject>>();
        for (int i = 0; i < ScriptMailForm.Count; i++)
        {
            float tileW = (KeaVesselTwig.KeaTextural().TieVanishThin(ScriptMailAsian).x - 0.15f * ScriptMailAsian.transform.localScale.x * 2) / 7;
            float width = tileW * 7;
            float x= -width / 2f + tileW * i + tileW / 2;
            GameObject obj = ScriptMailForm[i];
            if (!StampTarGlue())
            {
                obj.GetComponent<MailSuck>().WetWorth("18", 1000+i);
            }
            string name = obj.GetComponent<MailSuck>().Luck.img_name;
            if (!obj.GetComponent<MailSuck>().Luck.isRemoving)
            {

                if (dic.ContainsKey(name) && dic[name].Count > 0)
                {
                    dic[name].Add(obj);
                }
                else
                {
                    dic.Add(name, new List<GameObject>());
                    dic[name].Add(obj);
                }
            }

            obj.GetComponent<MailSuck>().DeadGiveAt(new Vector2(x, ScriptMailAsian.transform.position.y), () =>
            {
                

                if (dic.ContainsKey(obj.GetComponent<MailSuck>().Luck.img_name) && dic[obj.GetComponent<MailSuck>().Luck.img_name].Count >= 3)
                {
                    
                    bool allStop = true;
                    for (int j = 0; j < 3; j++)
                    {
                        if (dic[obj.GetComponent<MailSuck>().Luck.img_name][j].GetComponent<MailSuck>().AnNevada)
                        {
                            allStop = false;
                        }
                    }
                    if (allStop)
                    {
                        NinetyFromMail(dic[obj.GetComponent<MailSuck>().Luck.img_name]);
                    }

                }
                else
                {
                    if (ScriptMailForm.Count >= 7)
                    {
                        if (!StampFrom())
                        {
                            bool allStop = true;
                            foreach (GameObject tile_obj in ScriptMailForm)
                            {
                                if (tile_obj.GetComponent<MailSuck>().AnNevada)
                                {
                                    allStop = false;
                                    break;
                                }
                            }
                            if (allStop)
                            {
                                UIAbsence.KeaTextural().HeelUIDrape(nameof(MonroeKrill));
                            }
                        }
                    }
                }

            });
            
        }

    }
    bool StampFrom()
    {
        bool haveSame = false;
        Dictionary<string, int> sameDic = new Dictionary<string, int>();
        foreach (GameObject tile in ScriptMailForm)
        {
            string img = tile.GetComponent<MailSuck>().Luck.img_name;
            if (sameDic.ContainsKey(img))
            {
                sameDic[img] += 1;
            }
            else
            {
                sameDic.Add(img, 1);
            }
        }
        int allCount = ScriptMailForm.Count;
        foreach (int count in sameDic.Values)
        {
            if (count >= 3)
            {
                allCount -= 3;
            }
        }
        if (allCount < 7)
        {
            haveSame = true;
        }
        return haveSame;
    }
    /// <summary>
    /// 撤销技能
    /// </summary>
    void EtchSightAffair()
    {
        if (ScriptMailForm.Count > VineAnswerForm.Count)
        {
            
            GameObject undo_tile = null;
            for (int i = ScriptMailForm.Count - 1; i >= 0; i--)
            {
                if (!VineAnswerForm.Contains(ScriptMailForm[i]))
                {
                    undo_tile = ScriptMailForm[i];
                    break;
                }
            }
            LevelItemData Luck= undo_tile.GetComponent<MailSuck>().Luck;
            undo_tile.GetComponent<MailSuck>().DeadGiveAt(Luck.pos, () => { });
            undo_tile.GetComponent<MailSuck>().WetWorth(Luck.layer_name, Luck.layer_order);
            GetComponent<ExactOmitAbsorb>().PushSightRebirth(Luck, undo_tile);
            ScriptMailForm.Remove(undo_tile);
            RebirthPackerAsian();
        }
    }
    /// <summary>
    /// 提示技能
    /// </summary>
    void WhigSightAffair()
    {
        int needCount = 0;
        string imgName = "";
        if (ScriptMailForm.Count > 0)
        {
            if (ScriptMailForm.Count > 1)
            {
                MailSuck item1 = ScriptMailForm[0].GetComponent<MailSuck>();
                MailSuck item2 = ScriptMailForm[1].GetComponent<MailSuck>();
                imgName = item1.Luck.img_name;
                if (item1.Luck.img_name == item2.Luck.img_name)
                {
                    needCount = 1;
                }
                else
                {
                    needCount = 2;
                }
            }
            else
            {
                imgName = ScriptMailForm[0].GetComponent<MailSuck>().Luck.img_name;
                needCount = 2;
            }
        }
        else
        {
            needCount = 3;
            imgName = GetComponent<ExactOmitAbsorb>().ClipTwig.target[0].img_name;
        }

        List<LevelItemData> levelDataList = new List<LevelItemData>(GetComponent<ExactOmitAbsorb>().ClipTwig.target);
        foreach(LevelItemData data in levelDataList)
        {
            if (data.img_name == imgName)
            {
                GetComponent<ExactOmitAbsorb>().DeadFlu[data].GetComponent<MailSuck>().PrepayWoman(0);
                ScriptMail(GetComponent<ExactOmitAbsorb>().DeadFlu[data].transform);
                needCount--;
            }
            if (needCount == 0)
            {
                break;
            }    
        }

    }
    /// <summary>
    /// 洗牌技能
    /// </summary>
    void SurplusSightAffair()
    {
        AnyStump = false;
        UIAbsence.KeaTextural().HeelUIDrape(nameof(BackupKrill));
        GetComponent<ExactOmitAbsorb>().LiraMailAstronaut(() =>
        {
            GetComponent<ExactOmitAbsorb>().FrontRebirthMouse(ScriptMailForm);
            GetComponent<ExactOmitAbsorb>().HeelMailAstronaut(()=> {
                AnyStump = true;
                UIAbsence.KeaTextural().StarkIDDecodeUIDrape("BackupKrill");
            });
        });
        
    }
    /// <summary>
    /// 
    /// </summary>
    public void RomeWheat()
    {
        UIAbsence.KeaTextural().HeelUIDrape(nameof(BarbKrill));
        //ThereOil.GetInstance().PlayEffect(ThereTern.UIMusic.Sound_AutoMerge);
        //Time.timeScale = 2f;
        AnHolding = true;
        Seem.instance.AnewAdultDownYam();
        List<LevelItemData> allTileDataList = new List<LevelItemData>(GetComponent<ExactOmitAbsorb>().DeadFlu.Keys);
        List<GameObject> autoList = new List<GameObject>();
        if (ScriptMailForm.Count > 0)
        {
            int listCount = ScriptMailForm.Count;
            Dictionary<string, int> selectTileDic = new Dictionary<string, int>();
            foreach (GameObject tile in ScriptMailForm)
            {
                if (selectTileDic.ContainsKey(tile.GetComponent<MailSuck>().Luck.img_name))
                {
                    selectTileDic[tile.GetComponent<MailSuck>().Luck.img_name] += 1;
                } 
                else
                {
                    selectTileDic.Add(tile.GetComponent<MailSuck>().Luck.img_name, 1);
                }
            }
            foreach (string key in selectTileDic.Keys)
            {
                int addCount = 0;
                int i = 0;
                while (addCount != 3 - selectTileDic[key] && i != allTileDataList.Count)
                {
                    LevelItemData Luck= allTileDataList[i];
                    if (Luck.img_name == key)
                    {
                        if (!autoList.Contains(GetComponent<ExactOmitAbsorb>().DeadFlu[Luck]))
                        {
                            autoList.Add(GetComponent<ExactOmitAbsorb>().DeadFlu[Luck]);
                            addCount++;
                        }
                    }
                    i++;
                }
            }
        }
        List<string> imageNameList = new List<string>();
        foreach (LevelItemData data in allTileDataList)
        {
            if (!imageNameList.Contains(data.img_name))
            {
                imageNameList.Add(data.img_name);
            }
        }
        foreach (string imageName in imageNameList)
        {
            foreach (LevelItemData data in allTileDataList)
            {
                if (data.img_name == imageName && !autoList.Contains(GetComponent<ExactOmitAbsorb>().DeadFlu[data]))
                {
                    autoList.Add(GetComponent<ExactOmitAbsorb>().DeadFlu[data]);
                }
            }
        }

        StartCoroutine(RomePacker(autoList));
        //AutoSelect(autoList,0);
    }
    //void AutoSelect(List<GameObject> autoList,int i)
    //{
    //    GameObject tile = autoList[i];
    //    selectTile(tile.transform,()=> {
    //        i++;
    //        if (i < autoList.Count)
    //        {
    //            AutoSelect(autoList, i);
    //        }
    //    });
    //}
    IEnumerator RomePacker(List<GameObject> autoList)
    {
        foreach (GameObject tile in autoList)
        {
            ScriptMail(tile.transform);
            yield return new WaitForSeconds(0.2f);
        }
        //Time.timeScale = 1f;
        Seem.instance.ValidSeemAdultDownYam();
    }
    /// <summary>
    /// 复活
    /// </summary>
    void MonroeSightAffair()
    {
        AnyStump = false;
        UIAbsence.KeaTextural().HeelUIDrape(nameof(BackupKrill));
        Dictionary<string,int> imgList = new Dictionary<string, int>();
        List<GameObject> surplusList = new List<GameObject>();
        for (int i = 0; i < 4; i++)
        {
            if (!imgList.ContainsKey(ScriptMailForm[i].GetComponent<MailSuck>().Luck.img_name))
            {
                if (i != 3)
                {
                    imgList.Add(ScriptMailForm[i].GetComponent<MailSuck>().Luck.img_name,2);
                }
            }
            else
            {
                imgList[ScriptMailForm[i].GetComponent<MailSuck>().Luck.img_name] -= 1;
            }
        }
        for (int i = 3; i < 7; i++)
        {
            if (!imgList.ContainsKey(ScriptMailForm[i].GetComponent<MailSuck>().Luck.img_name))
            {
                surplusList.Add(ScriptMailForm[i]);
            }
        }
        foreach (string key in imgList.Keys)
        {
            int needCount = imgList[key];
            string imgName = key;
            List<LevelItemData> levelDataList = new List<LevelItemData>(GetComponent<ExactOmitAbsorb>().ClipTwig.target);
            foreach (LevelItemData data in levelDataList)
            {
                if (data.img_name == imgName)
                {
                    GetComponent<ExactOmitAbsorb>().DeadFlu[data].GetComponent<MailSuck>().PrepayWoman(0);
                    ScriptMail(GetComponent<ExactOmitAbsorb>().DeadFlu[data].transform);
                    needCount--;
                }
                if (needCount == 0)
                {
                    break;
                }
            }
        }

        //洗牌动画
        GetComponent<ExactOmitAbsorb>().LiraMailAstronaut(() =>
        {
            GetComponent<ExactOmitAbsorb>().FrontRebirthMouse(surplusList);
            GetComponent<ExactOmitAbsorb>().HeelMailAstronaut(()=> {

                AnyStump = true;
                UIAbsence.KeaTextural().StarkIDDecodeUIDrape("BackupKrill");
            });
        });

    }

    bool StampTarGlue()
    {
        return TreeTwigAbsence.GetInt(CSoviet.Or_TarGlueSpin) == 0;
    }
    bool StampTarGlueTugPacker(LevelItemData data)
    {
        List<int> id_list = TarGlueAbsence.KeaTextural().TieIDFormPeckIngoing(TriggerType.Apart_Xenon);
        if (TreeTwigAbsence.GetBool(CSoviet.Or_TarGlueSpin + id_list[0]))
        {
            return true;
        } 
        else
        {
            if ((data.px == Seem.instance.WeedySixth[0][0] && data.py == Seem.instance.WeedySixth[0][1]) && TieStyle == 0)
            {
                return true;
            }
            if ((data.px == Seem.instance.WeedySixth[1][0] && data.py == Seem.instance.WeedySixth[1][1]) && TieStyle == 1)
            {
                return true;
            }
            if ((data.px == Seem.instance.WeedySixth[2][0] && data.py == Seem.instance.WeedySixth[2][1]) && TieStyle == 2)
            {
                return true;
            }
        }
        return false;
    }
}
