using System;
using System.Collections.Generic;
using System.Text;
using LitJson;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GrandeOntoTwigAbsence : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("test")]    public GameObject Lead;
    public static GrandeOntoTwigAbsence instance;
[UnityEngine.Serialization.FormerlySerializedAs("RobloxShopData")]
    public RobloxShopDataConfig GrandeOntoTwig;
[UnityEngine.Serialization.FormerlySerializedAs("CountryData")]    public CountryInfo SeventyTwig;
[UnityEngine.Serialization.FormerlySerializedAs("RobuxData")]    
    public Dictionary<int, RobuxData> LevelTwig= new Dictionary<int, RobuxData>();
[UnityEngine.Serialization.FormerlySerializedAs("RobloxItemDatas")]    public Dictionary<int, RobloxItemData> GrandeSuckStunt= new Dictionary<int, RobloxItemData>();
[UnityEngine.Serialization.FormerlySerializedAs("RobloxItemTwoDatas")]    public Dictionary<int, RobloxItemTwoData> GrandeSuckEonStunt= new Dictionary<int, RobloxItemTwoData>();
[UnityEngine.Serialization.FormerlySerializedAs("CurrentId")]    public int JawboneIt;
[UnityEngine.Serialization.FormerlySerializedAs("AddValue")]    public int DamAttic;
[UnityEngine.Serialization.FormerlySerializedAs("MinID")]    public int PinID;
[UnityEngine.Serialization.FormerlySerializedAs("RefreshValue")]    public Action<int, int> RebirthAttic;
[UnityEngine.Serialization.FormerlySerializedAs("nowWithdraw")]    public int HayLanguish;
[UnityEngine.Serialization.FormerlySerializedAs("currentGame")]    public int SeaportSeem;
[UnityEngine.Serialization.FormerlySerializedAs("CountryInfo")]    public string SeventyTour= "";
    private CountryData _SeaportSeventy;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        DustGrandeOntoTwig();
        DustTwigLiterally();
        //SetCountryInfo("");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    /// <summary>
    /// 初始化商店数据
    /// </summary>
    private void DustGrandeOntoTwig()
    {
        TextAsset json = Resources.Load<TextAsset>(CSoviet.RGrandeSizeGrandeTwig);
        //Debug.LogError("json == " + json);
        GrandeOntoTwig = JsonMapper.ToObject<RobloxShopDataConfig>(json.text);
        RebirthPreference();

        
        TextAsset Countryjson = Resources.Load<TextAsset>(CSoviet.RGrandeSizeSeventyTwig);
        //Debug.LogError("json == " + Countryjson);
        SeventyTwig = JsonMapper.ToObject<CountryInfo>(Countryjson.text);
        if(Application.platform == RuntimePlatform.Android)
            GrandeOntoTwig.isStartCashShop = 1;
        else if(Application.platform == RuntimePlatform.IPhonePlayer)
            GrandeOntoTwig.isStartCashShop = 0;
    }


    public void RebirthPreference()
    {
        List<int> idList = new List<int>(TreeTwigAbsence.GetIntArray("RookieList"));
        if (idList.Count == 3)
        {
            List<RobloxItemData> list = new List<RobloxItemData>(GrandeOntoTwig.Characters_list);
            foreach (RobloxItemData data in list)
            {
                if (idList.Contains(data.ID))
                {
                    RobloxItemData moveItem = data;
                    GrandeOntoTwig.Characters_list.Remove(data);
                    GrandeOntoTwig.Characters_list.Insert(0, moveItem);
                }
            }
        }
    }
    /// <summary>
    /// 字典存储数据
    /// </summary>
    private void DustTwigLiterally()
    {
        /*for (int i = 0; i < RobloxShopData.Shop_list.Count; i++)
        {
            if (!RobuxData.ContainsKey(RobloxShopData.Shop_list[i].ID))
            {
                RobuxData.Add(RobloxShopData.Shop_list[i].ID,RobloxShopData.Shop_list[i]);
            }
        }*/

        for (int i = 0; i < GrandeOntoTwig.Shop_class.Count; i++)
        {
            for (int j = 0; j < GrandeOntoTwig.Shop_class[i].Shop_list.Count; j++)
            {
                if (!LevelTwig.ContainsKey(GrandeOntoTwig.Shop_class[i].Shop_list[j].ID))
                {
                    LevelTwig.Add(GrandeOntoTwig.Shop_class[i].Shop_list[j].ID,GrandeOntoTwig.Shop_class[i].Shop_list[j]);
                }
            }
        }
        
        for (int i = 0; i < GrandeOntoTwig.Characters_list.Count; i++)
        {
            if (!GrandeSuckStunt.ContainsKey(GrandeOntoTwig.Characters_list[i].ID))
            {
                GrandeSuckStunt.Add(GrandeOntoTwig.Characters_list[i].ID,GrandeOntoTwig.Characters_list[i]);
            }
        }
        
        for (int i = 0; i < GrandeOntoTwig.Props_list.Count; i++)
        {
            if (!GrandeSuckEonStunt.ContainsKey(GrandeOntoTwig.Props_list[i].ID))
            {
                GrandeSuckEonStunt.Add(GrandeOntoTwig.Props_list[i].ID,GrandeOntoTwig.Props_list[i]);
            }
        }

        
    }

    /// <summary>
    /// 获取地区信息
    /// </summary>
    /// <param name="str"></param>
    public void SewSeventyTour(string str)
    {
        SeventyTour = str;

        for (int i = 0; i < SeventyTwig.Country_Info.Count; i++)
        {
            if(SeventyTour == SeventyTwig.Country_Info[i].countryName)
                _SeaportSeventy = SeventyTwig.Country_Info[i];
        }
    }
    
    public string KeaCohesive()
    {
        if (Application.isEditor)
        {
            //Debug.LogError("systemLanguage:" + Application.systemLanguage.ToString());
            return Application.systemLanguage.ToString();
        }
        //获得系统语言
        AndroidJavaClass unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject _unityContext = unityClass.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject locale = _unityContext.Call<AndroidJavaObject>("getResources").Call<AndroidJavaObject>("getConfiguration").Get<AndroidJavaObject>("locale");
        string systemLanguage = locale.Call<string>("getLanguage");

        Debug.LogError("systemLanguage:" + systemLanguage);
        return systemLanguage;
    }

    ///根据国家刷新不同信息
    public void RebirthSeventyTour()
    {
        //打开商店才有用
        if (GrandeOntoTwig.isStartCashShop == 1 && _SeaportSeventy != null)
        {
            for (int i = 0; i < GrandeOntoTwig.Shop_class[2].Shop_list.Count; i++)
            {
                GrandeOntoTwig.Shop_class[2].Shop_list[i].currencyValue = _SeaportSeventy.GetValue[i];
            }
            GrandeOntoTwig.Shop_class[2].unitName = _SeaportSeventy.currencyName;
            GrandeOntoTwig.Shop_class[2].iconPath = _SeaportSeventy.iconPath;
        }
    }

    /// <summary>
    /// 根据ID获取对应图片位置
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string KeaWhigTideOfID(int id)
    {
        if (id.ToString().StartsWith("1"))
        {
            return LevelTwig[id].iconPath;
        }
        else if(id.ToString().StartsWith("2"))
        {
            return GrandeSuckStunt[id].Img;
        }
        else
        {
            return GrandeSuckEonStunt[id].Img;
        }
        
    }

    /// <summary>
    /// 根据ID获取对应图片资源
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Sprite KeaVanishOfID(int id)
    {
        string path = KeaWhigTideOfID(id);

        Sprite sprite = Resources.Load<Sprite>(path);

        return sprite;
    }

    /// <summary>
    /// 根据路径获取对应图片资源
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Sprite KeaVanishOfID(string str)
    {
        Sprite sprite = Resources.Load<Sprite>(str);
        return sprite;
    }

    /// <summary>
    /// 根据ID获取对应图片资源
    /// </summary>
    /// <param name="id"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public Sprite KeaVanishOfID(int id, int type)
    {
        foreach (var VARIABLE in LevelTwig)
        {
            if (VARIABLE.Value.CostType == type)
            {
                string path = VARIABLE.Value.iconPath;
                Sprite sprite = Resources.Load<Sprite>(path);
                return sprite;
            }
        }

        return null;
    }

    /// <summary>
    /// 根据ID获取对应兑换资源的消耗值
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int KeaInedibleOnstageAtticOfID(int id)
    {
        if (id.ToString().StartsWith("1"))
        {
            return LevelTwig[id].CostValue;
        }
        else if(id.ToString().StartsWith("2"))
        {
            return GrandeSuckStunt[id].CostValue;
        }
        else
        {
            return GrandeSuckEonStunt[id].CostValue;
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("CurrenctOne")]
    /// <summary>
    /// 根据ID获取对应兑换的资源类型
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /*public int GetExchangeTypeByID(int id)
    {
        if (id.ToString().StartsWith("1"))
        {
            return RobuxData[id].CostType;
        }
        else if(id.ToString().StartsWith("2"))
        {
            return RobloxItemDatas[id].CostType;
        }
        else
        {
            return RobloxItemTwoDatas[id].CostType;
        }
    }*/

    public int MandibleDay;
[UnityEngine.Serialization.FormerlySerializedAs("CurrenctTwo")]    public int MandibleEon;
[UnityEngine.Serialization.FormerlySerializedAs("CurrenctThree")]    public int MandibleSeven;
    private Action<MinTypeAndValue> Meanwhile;
    /// <summary>
    /// 初始化数据
    /// </summary>
    /// <param name="value"></param>
    /// <param name="valueTwo"></param>
    public void DustCMandible(int value, int valueTwo, int valueThree, Action<MinTypeAndValue> action)
    {
        MandibleDay = value;
        MandibleEon = valueTwo;
        MandibleSeven = valueThree;
        RebirthAttic?.Invoke(value,valueTwo);
        Meanwhile = action;
    }
    /// <summary>
    /// 提现成功减去对应货币
    /// </summary>
    /// <param name="robuxData"></param>
    public void PinAdequate(int id)
    {
        HayLanguish = id;
        MinTypeAndValue minTypeAndValue = new MinTypeAndValue();
        minTypeAndValue.Dash = LevelTwig[id].CostType;
        minTypeAndValue.Attic = LevelTwig[id].CostValue;
        if (LevelTwig[id].CostType == 1)
        {
            MandibleDay -= LevelTwig[id].CostValue;
        }
        else if(LevelTwig[id].CostType == 2)
        {
            MandibleEon -= LevelTwig[id].CostValue;
        }
        else
        {
            MandibleSeven -= LevelTwig[id].CostValue;
        }
        Meanwhile?.Invoke(minTypeAndValue);
        RebirthAttic?.Invoke(MandibleDay,MandibleEon);
        //提现成功恭喜弹窗
        GrandeOntoKrill.instance.HeelSlatKrill();
    }

   


    public string LeadKeaAttic()
    {
        StringBuilder str = new StringBuilder ();
        for (int i = 0; i < GrandeOntoTwig.Characters_list.Count; i++)
        {
            str.AppendFormat("ID == {0}   Value == {1}    Sum == {2}\n", GrandeOntoTwig.Characters_list[i].ID,TreeTwigAbsence.GetInt(GrandeOntoTwig.Characters_list[i].ID.ToString()),GrandeOntoTwig.Characters_list[i].CostValue);
        }

        for (int i = 0; i < GrandeOntoTwig.Props_list.Count; i++)
        {
            str.AppendFormat("ID == {0}   Value == {1}    Sum == {2}\n", GrandeOntoTwig.Props_list[i].ID,TreeTwigAbsence.GetInt(GrandeOntoTwig.Props_list[i].ID.ToString()),GrandeOntoTwig.Props_list[i].CostValue);
        }

        return str.ToString();
    }

    /// <summary>
    /// ID为key，给定Item添加进度
    /// </summary>
    /// <param name="id"></param>
    public void Marketplace(List<AddIdAndValue> value)
    {
        TreeTwigAbsence.SetInt("RobloxPuzzleCount", TreeTwigAbsence.GetInt("RobloxPuzzleCount") +1);
        foreach (AddIdAndValue data in value)
        {
            int ID= data.ID;
            int DamAttic= data.Trout;
            int num = TreeTwigAbsence.GetInt(ID.ToString());
            num += DamAttic;
            TreeTwigAbsence.SetInt(ID.ToString(), num);
        }
        //Debug.LogError("id == " + id + "     onceValue == " +  AddValue + "       AddCharacterschedule == " + TreeTwigAbsence.GetInt(id.ToString()));
        //Debug.LogError("path == " + GetIconPathByID(id));
    }


    /// <summary>
    /// 从角色碎片和装饰物碎片中随机获取奖励
    /// </summary>
    /// <returns></returns>
    public AddIdAndValue KeaGrandeBackup()
    {
        AddIdAndValue addIdAndValue = new AddIdAndValue();
        int RandomInt = Random.Range(0, 999);
        float rate = 0;
        int sum = GrandeOntoTwig.ChipWeight_CA[0] + GrandeOntoTwig.ChipWeight_CA[1];
        rate +=(float) GrandeOntoTwig.ChipWeight_CA[0] / sum;
        
        if (RandomInt <= rate * 1000)
        {
            addIdAndValue = KeaProtectorBackup();
        }
        else
        {
            addIdAndValue = KeaSwordBackup();
        }

        return addIdAndValue;
    }
    /// <summary>
    /// 获取roblox提现任务
    /// </summary>
    /// <returns></returns>
    public TaskItemData KeaGrandeSlat(int id)
    {
        int taskID = LevelTwig[id].TaskID;
        if (taskID >= 0)
        {
            return GrandeOntoTwig.Task[taskID];
        }
        return null;
    }
    /// <summary>
    /// 统计任务计数
    /// </summary>
    /// <param name="type"></param>
    /// <param name="num"></param>
    public void SewSlatAttic(int type,int num)
    {
        foreach (var game in GrandeOntoTwig.Shop_class)
        {
            foreach (RobuxData data in game.Shop_list)
            {
                if (TreeTwigAbsence.GetString("RobloxRewardState" + data.ID) == "Withdraw" && type == KeaGrandeSlat(data.ID).Type)
                {
                    TreeTwigAbsence.SetInt("RobloxTask_" + data.ID, num + TreeTwigAbsence.GetInt("RobloxTask_" + data.ID));
                }
            }
        }
        /*foreach(RobuxData data in RobloxShopData.Shop_class[currentGame].Shop_list)
        {
            if (TreeTwigAbsence.GetString("RobloxRewardState" + data.ID) == "Withdraw" && type == GetRobloxTask(data.ID).Type)
            {
                TreeTwigAbsence.SetInt("RobloxTask_" + data.ID, num + TreeTwigAbsence.GetInt("RobloxTask_" + data.ID));
            }
        }*/
    }
    /// <summary>
    /// 获取奖励当前任务完成数
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int KeaSlatAttic(int id)
    {
        return TreeTwigAbsence.GetInt("RobloxTask_" + id);
    }
    /// <summary>
    /// 获取当前奖励显示任务完成数
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string KeaSlatHeelAttic(int id)
    {
        return TreeTwigAbsence.GetInt("RobloxTask_" + id) + "/" + KeaGrandeSlat(id).Value;
    }
    /// <summary>
    /// 获取当前奖励显示任务完成进度
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public float KeaSlatHeelFillManual(int id)
    {
        return TreeTwigAbsence.GetInt("RobloxTask_" + id) / (float)KeaGrandeSlat(id).Value;
    }
    #region Shop

    //获取商店指定进度
    public string KeaOntoMexicoAttic(RobuxData robuxData, int userValue)
    {
        return userValue.ToString() + '/' + robuxData.CostValue;
        
    }

    public float KeaOntoGlassAttic(RobuxData robuxData, int userValue)
    {
        return (float) userValue / robuxData.CostValue;
    }

    public string KeaProtectorMexicoAttic(RobloxItemData robloxItemData)
    {
        return TreeTwigAbsence.GetInt(robloxItemData.ID.ToString()).ToString() + '/' + robloxItemData.CostValue;
    }
    
    public float KeaProtectorGlassAttic(RobloxItemData robloxItemData)
    {
        return (float) TreeTwigAbsence.GetInt(robloxItemData.ID.ToString()) / robloxItemData.CostValue;
    }
    
    public string KeaSwordMexicoAttic(RobloxItemTwoData robloxItemTwoData)
    {
        return TreeTwigAbsence.GetInt(robloxItemTwoData.ID.ToString()).ToString() + '/' + robloxItemTwoData.CostValue;
    }
    
    public float KeaSwordGlassAttic(RobloxItemTwoData robloxItemTwoData)
    {
        return (float) TreeTwigAbsence.GetInt(robloxItemTwoData.ID.ToString()) / robloxItemTwoData.CostValue;
    }

    public AddIdAndValue KeaAttic(int id)
    {
        AddIdAndValue addIdAndValue = new AddIdAndValue();
        
        if(id.ToString().StartsWith("2"))
        {
            addIdAndValue = KeaProtectorBackup(id);
            return addIdAndValue;
        }
        else
        {
            addIdAndValue = KeaSwordBackup(id);
            return addIdAndValue;
        }
    }



    /// <summary>
    /// 商店物品能否提现
    /// </summary>
    /// <param name="id"></param>
    /// <param name="type"></param>
    /// <param name="userValue"></param>
    /// <returns></returns>
    public bool KeaProlifically(RobuxData robuxData, int type, int userValue)
    {
        
        /*for (int i = 0; i < RobloxShopData.Shop_list.Count; i++)
        {
            if (RobloxShopData.Shop_list[i].ID == id)
            {
                if (userValue >= RobloxShopData.Shop_list[i].CostValue)
                    return true;
                else
                    return false;
            }
        }*/
        return false;
    }



    /// <summary>
    /// 获取指定商店Icon位置
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string KeaOntoDepredation(int id, int game)
    {
        for (int i = 0; i < GrandeOntoTwig.Shop_class[game].Shop_list.Count; i++)
        {
            if (GrandeOntoTwig.Shop_class[game].Shop_list[i].ID == id)
                return GrandeOntoTwig.Shop_class[game].Shop_list[i].iconPath;
        }

        return null;
    }

    public string KeaGrandeOntoPlutonic()
    {
        return null;
    }


    #endregion



    

    #region CharacterReward

    /// <summary>
    /// 从总的角色奖励中获取角色碎片奖励
    /// </summary>
    /// <returns></returns>
    public AddIdAndValue KeaProtectorBackup()
    {
        KeaBootPreferenceBeg();
        int random = Random.Range(0, 999);
        float rate = 0;
        AddIdAndValue addIdAndValue = new AddIdAndValue();
        if (Varicolored != 0)
        {
            Debug.Log("总权重:" + Varicolored);
            for (int i = 0; i < GrandeOntoTwig.Characters_list.Count; i++)
            {

                List<int> RookieList = new List<int>(TreeTwigAbsence.GetIntArray("RookieList"));
                float weight = (float)SaddenProtectorForm[i];
                //if (TreeTwigAbsence.GetInt("RobloxPuzzleCount") <= RobloxShopData.RookiePackageCount)
                //{
                //    if (RookieList.Contains(RobloxShopData.Characters_list[i].ID))
                //    {
                //        weight = weight * RobloxShopData.RookiePackageMulti;
                //    }
                //}
                Debug.Log("单项权重:" + weight+",--"+ GrandeOntoTwig.Characters_list[i].Name);
                rate += weight /  Varicolored;
                
                //Debug.LogError("random == " + random + "      charatersum == " + charatersum + "      rate == " + rate);
                if (random <= rate * 1000)
                {
                    int addValue = KeaDamAttic(GrandeOntoTwig.Characters_list[i].ID,true);
                    JawboneIt = GrandeOntoTwig.Characters_list[i].ID;
                    DamAttic = addValue;
                    addIdAndValue.ID = GrandeOntoTwig.Characters_list[i].ID;
                    addIdAndValue.Trout = addValue;
                    //Debug.LogError("id == " + RobloxShopData.Characters_list[i].ID + "     value == " + addValue);
                    return addIdAndValue;
                }
            }
        }
        else
        {
            random = Random.Range(0, GrandeOntoTwig.Characters_list.Count);
            int addValue = KeaDamAttic(GrandeOntoTwig.Characters_list[random].ID,true);
            JawboneIt = GrandeOntoTwig.Characters_list[random].ID;
            DamAttic = addValue;
            addIdAndValue.ID = GrandeOntoTwig.Characters_list[random].ID;
            addIdAndValue.Trout = addValue;
            return addIdAndValue;
        }
        
        return addIdAndValue;
    }

    /// <summary>
    /// 获取指定ID的角色碎片奖励
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public AddIdAndValue KeaProtectorBackup(int id)
    {
        AddIdAndValue addIdAndValue = new AddIdAndValue();
        for (int i = 0; i < GrandeOntoTwig.Characters_list.Count; i++)
        {
            if (id == GrandeOntoTwig.Characters_list[i].ID)
            {
                int addValue = KeaDamAttic(id,true);
                JawboneIt = id;
                DamAttic = addValue;
                addIdAndValue.ID = id;
                addIdAndValue.Trout = addValue;
                return addIdAndValue;
            }
        }
        return addIdAndValue;
    }
    
    /// <summary>
    /// 获取指定角色皮肤iD的碎片进度
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    private float KeaElectrocardiogram(int id)
    {
        for (int i = 0; i < GrandeOntoTwig.Characters_list.Count; i++)
        {
            if (GrandeOntoTwig.Characters_list[i].ID == id)
            {
                return (float) TreeTwigAbsence.GetInt(id.ToString()) / GrandeOntoTwig.Characters_list[i].CostValue;
            }
        }
        return 0;
    }

    private int Varicolored= 0;
    private List<int> SaddenProtectorForm= new List<int>();
    /// <summary>
    /// 计算当前角色碎片比重下的总和
    /// </summary>
    private void KeaBootPreferenceBeg()
    {
        
        Varicolored = 0;
        SaddenProtectorForm.Clear();
        for (int i = 0; i < GrandeOntoTwig.Characters_list.Count; i++)
        {
            List<int> RookieList = new List<int>(TreeTwigAbsence.GetIntArray("RookieList"));
            int weight = KeaPreferenceCanoes(GrandeOntoTwig.Characters_list[i].ID, i);
            if (TreeTwigAbsence.GetInt("RobloxPuzzleCount") <= GrandeOntoTwig.RookiePackageCount)
            {
                if (RookieList.Contains(GrandeOntoTwig.Characters_list[i].ID))
                {
                    weight = weight * GrandeOntoTwig.RookiePackageMulti;
                }
            }
            Varicolored += weight;
            //Debug.LogError("GetOnceSum == " + charatersum + "      weight == " + weight);
            SaddenProtectorForm.Add(weight);
        }
        
    }

    /// <summary>
    /// 获得角色比重
    /// </summary>
    /// <param name="id"></param>
    /// <param name="Charactersid"></param>
    /// <returns></returns>
    private int KeaPreferenceCanoes(int id, int Charactersid)
    {
        float schedule = KeaElectrocardiogram(id) * 100;
        
        //Debug.LogError("GetWeight == " + schedule + "     id == " + id);
        for (int i = 0; i < GrandeOntoTwig.ChipWeight_group.Count; i++)
        {
            if (i == 0 && schedule <= GrandeOntoTwig.ChipWeight_group[i])
            {
                return int.Parse(GrandeOntoTwig.Characters_list[Charactersid].Weight[i]);
            }
            else if(i != GrandeOntoTwig.ChipWeight_group.Count - 1 && i != 0 && schedule > GrandeOntoTwig.ChipWeight_group[i - 1] && schedule < GrandeOntoTwig.ChipWeight_group[i])
            {
                return int.Parse(GrandeOntoTwig.Characters_list[Charactersid].Weight[i]);
            }
            else if(i == GrandeOntoTwig.ChipWeight_group.Count - 1 && schedule <= GrandeOntoTwig.ChipWeight_group[i])
            {
                return int.Parse(GrandeOntoTwig.Characters_list[Charactersid].Weight[i]);
            }
            else if(i == GrandeOntoTwig.ChipWeight_group.Count - 1 && schedule > GrandeOntoTwig.ChipWeight_group[i])
            {
                return 0;
            }
        }
        
        return 0;
    }

    #endregion


    #region PropsReward

    private int Airborne= 0;
    private List<int> SaddenSwordForm= new List<int>();

    /// <summary>
    /// 从总的装饰物奖励中获取角色碎片奖励
    /// </summary>
    /// <returns></returns>
    public AddIdAndValue KeaSwordBackup()
    {
        KeaBootSwordBeg();
        int random = Random.Range(0, 999);
        float rate = 0;
        AddIdAndValue addIdAndValue = new AddIdAndValue();
        if (Airborne == 0)
        {
            for (int i = 0; i < GrandeOntoTwig.Props_list.Count; i++)
            {
                rate += (float) SaddenSwordForm[i] /  Airborne;
                //Debug.LogError("random == " + random + "      charatersum == " + charatersum + "      rate == " + rate);
                if (random <= rate * 1000)
                {
                 
                    int addValue = KeaDamAttic(GrandeOntoTwig.Props_list[i].ID,false);
                    JawboneIt = GrandeOntoTwig.Props_list[i].ID;
                    DamAttic = addValue;
                    addIdAndValue.ID = GrandeOntoTwig.Props_list[i].ID;
                    addIdAndValue.Trout = addValue;
                    //Debug.LogError("id == " + RobloxShopData.Props_list[i].ID + "     value == " + addValue);
                    return addIdAndValue;
                }
            }
        }
        else
        {
            random = Random.Range(0, GrandeOntoTwig.Props_list.Count);
            int addValue = KeaDamAttic(GrandeOntoTwig.Props_list[random].ID,false);
            JawboneIt = GrandeOntoTwig.Props_list[random].ID;
            DamAttic = addValue;
            addIdAndValue.ID = GrandeOntoTwig.Props_list[random].ID;
            addIdAndValue.Trout = addValue;
            return addIdAndValue;
        }
        return addIdAndValue;
    }

    /// <summary>
    /// 获取指定ID的装饰物碎片奖励
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public AddIdAndValue KeaSwordBackup(int id)
    {
        AddIdAndValue addIdAndValue = new AddIdAndValue();
        for (int i = 0; i < GrandeOntoTwig.Props_list.Count; i++)
        {
            if (id == GrandeOntoTwig.Props_list[i].ID)
            {
                int addValue = KeaDamAttic(id,false);
                JawboneIt = id;
                DamAttic = addValue;
                addIdAndValue.ID = id;
                addIdAndValue.Trout = addValue;
                return addIdAndValue;
            }
        }
        return addIdAndValue;
    }
    
    /// <summary>
    /// 获取指定装饰物Id的碎片进度
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    private float KeaMisinterprete(int id)
    {
        for (int i = 0; i < GrandeOntoTwig.Props_list.Count; i++)
        {
            if (GrandeOntoTwig.Props_list[i].ID == id)
            {
                return (float) TreeTwigAbsence.GetInt(id.ToString()) / GrandeOntoTwig.Props_list[i].CostValue;
            }
        }
        return 0;
    }
    
    /// <summary>
    /// 计算当前装饰物碎片比重下的总和
    /// </summary>
    private void KeaBootSwordBeg()
    {
        Airborne = 0;
        SaddenSwordForm.Clear();
        for (int i = 0; i < GrandeOntoTwig.Props_list.Count; i++)
        {
            int weight = KeaSwordCanoes(GrandeOntoTwig.Props_list[i].ID, i);
            Airborne += weight;
            SaddenSwordForm.Add(weight);
        }
        
    }

    /// <summary>
    /// 获得装饰物比重
    /// </summary>
    /// <param name="id"></param>
    /// <param name="Charactersid"></param>
    /// <returns></returns>
    private int KeaSwordCanoes(int id, int Propsid)
    {
        float schedule = KeaMisinterprete(id) * 100;
        
        //Debug.LogError("GetWeight == " + schedule + "     id == " + id);
        for (int i = 0; i < GrandeOntoTwig.ChipWeight_group.Count; i++)
        {
            if (i == 0 && schedule <= GrandeOntoTwig.ChipWeight_group[i])
            {
                return int.Parse(GrandeOntoTwig.Props_list[Propsid].Weight[i]);
            }
            else if(i != GrandeOntoTwig.ChipWeight_group.Count - 1 && i != 0 && schedule > GrandeOntoTwig.ChipWeight_group[i - 1] && schedule < GrandeOntoTwig.ChipWeight_group[i])
            {
                return int.Parse(GrandeOntoTwig.Props_list[Propsid].Weight[i]);
            }
            else if(i == GrandeOntoTwig.ChipWeight_group.Count - 1 && schedule <= GrandeOntoTwig.ChipWeight_group[i])
            {
                return int.Parse(GrandeOntoTwig.Props_list[Propsid].Weight[i]);
            }
            else if(i == GrandeOntoTwig.ChipWeight_group.Count - 1 && schedule > GrandeOntoTwig.ChipWeight_group[i])
            {
                return 0;
            }
        }
        
        return 0;
    }

    #endregion
    


    /// <summary>
    /// 获取增加值
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    private int KeaDamAttic(int id, bool isCharacter)
    {
        float schedule;
        if(isCharacter)
            schedule = KeaElectrocardiogram(id) * 100;
        else
            schedule = KeaMisinterprete(id) * 100;
        for (int i = 1; i < 12; i++)
        {
            if (schedule <= i * 10)
            {
                //Debug.LogError("schedule == " + schedule + "    i == "  + i + "    sum == "/* + sum*/);
                int sum = 0;
                List<int> weightList = new List<int>();
                for (int j = 0; j < GrandeOntoTwig.ChipGetValue_group[i - 1].Count; j++)
                {
                    sum += GrandeOntoTwig.ChipGetValue_group[i - 1][j];
                    
                }
                
                int random = Random.Range(0, 999);
                float rate = 0;
                for (int j = 0; j < GrandeOntoTwig.ChipGetValue_group[i - 1].Count; j++)
                {
                    rate +=(float) GrandeOntoTwig.ChipGetValue_group[i - 1][j] / sum;
                    if (random <= rate * 1000)
                    {
                        return 10 - j;
                    }
                }
            }
        }

        return 0;
    }

#if EmojiMerge
    public void ShowRobloxShopPanel()
    {
        UIAbsence.GetInstance().RobloxCanvas.transform.Find("GrandeOntoKrill").gameObject.SetActive(true);
    }
#endif
    
    
    
}

public struct AddIdAndValue
{
    public int ID;
    public int Trout;
}

public struct MinTypeAndValue
{
    public int Dash;
    public int Attic;
}
