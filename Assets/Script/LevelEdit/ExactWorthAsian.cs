using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using LitJson;
using System.IO;
using System.Text.RegularExpressions;
using System;
[Serializable]
public class LevelData
{
    public string x;
    public string At;
    public string y;
    public string Me;
    public string Radio;
}
[Serializable]
public class LimitItem
{
    public int x;
    public int y;
    public bool SenatorFatal;
}
[ExecuteInEditMode]
public class ExactWorthAsian : MonoBehaviour
{
    static ExactWorthAsian instance;
    float Unify_x= -0.03f;
    float Unify_y= -0.15f;
[UnityEngine.Serialization.FormerlySerializedAs("levelDic")]    public Dictionary<string, GameObject> ApartFlu;
    List<LimitItem> Reach_Mine;
[UnityEngine.Serialization.FormerlySerializedAs("full_sprite")]    public Sprite Thaw_Rennin;
[UnityEngine.Serialization.FormerlySerializedAs("empty_sprite")]    public Sprite Briny_Rennin;
[UnityEngine.Serialization.FormerlySerializedAs("oddList")]    public int[] ManForm= new int[] {0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
[UnityEngine.Serialization.FormerlySerializedAs("evenList")]    public int[] EditForm= new int[] {1, 3, 5, 7, 9, 11, 13, 15, 17, 19};
[UnityEngine.Serialization.FormerlySerializedAs("fullCount")]    public int ThawStyle= 0;
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
    private void Awake()
    {
        Debug.Log("levelLayerGroup Awake");
        instance = this;
        ApartFlu = new Dictionary<string, GameObject>();
        Briny_Rennin = Resources.Load<Sprite>(CSoviet.Fatal);
        Thaw_Rennin = Resources.Load<Sprite>(CSoviet.Drug);
    }

    public void ArabianDrugStyle()
    {
        ThawStyle = 0;
        foreach (GameObject obj in ApartFlu.Values)
        {
            if (obj.GetComponent<SpriteRenderer>().sprite == Thaw_Rennin)
            {
                ThawStyle++;
                //Debug.Log(fullCount);
            }
        }
        
    }
    public static ExactWorthAsian KeaTextural()
    {
        if (instance == null)
        {
            GameObject obj = GameObject.Find("ExactWorthAsian");
            if (!obj)
            {
                obj = new GameObject("ExactWorthAsian");
                instance = obj.AddComponent<ExactWorthAsian>();
            }
            else
            {
                instance = obj.GetComponent<ExactWorthAsian>();
            }
        }
        return instance;
    }
    public void RepeatWorth(List<LimitItem> limitList)
    {
        Reach_Mine = new List<LimitItem>(limitList);
        int childCount = transform.childCount;
        for (int i = childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }
        ApartFlu = new Dictionary<string, GameObject>();
        GameObject levelLayerPrefab = Resources.Load<GameObject>(CSoviet.ChasteExactWorth);
        GameObject tileEditItemPrefab = Resources.Load<GameObject>(CSoviet.ChasteMailOpenSuck);
        Vector2 imageSize = TieHemlockFeedThin(tileEditItemPrefab);
        int Radio= 0;
        foreach (LimitItem limit_item in limitList)
        {
            int limit_x = limit_item.x;
            int limit_y = limit_item.y;
            GameObject levelLayer = Instantiate(levelLayerPrefab, transform);
            
            levelLayer.name = "LevelLayer_" + Radio;
            levelLayer.GetComponent<ExactWorth>().Briny_Tone = limit_item.SenatorFatal;
            float all_w = Unify_x * (limit_x - 1) + imageSize.x * limit_x;
            float all_h = Unify_y * (limit_y - 1) + imageSize.y * limit_y;
            //Debug.Log(all_h);
            for (int y = 0; y < limit_y; y++)
            {
                for (int x = 0; x < limit_x; x++)
                {
                    GameObject tileEditItem = Instantiate(tileEditItemPrefab, levelLayer.transform);
                    float pos_x = -(all_w / 2f) + (Unify_x + imageSize.x) * x + imageSize.x / 2;
                    float pos_y = (all_h / 2f) - (Unify_y + imageSize.y) * y  - imageSize.y / 2;
                    tileEditItem.transform.position = new Vector2(pos_x, pos_y);
                    tileEditItem.GetComponent<SpriteRenderer>().sortingOrder = y * limit_x + x;
                    tileEditItem.GetComponent<SpriteRenderer>().sortingLayerName = (Radio + 1).ToString();
                    //Debug.Log(ColorList[layer]);
                    tileEditItem.GetComponent<SpriteRenderer>().color = BoundForm[Radio % 9];
                    string key = Radio + "_" + x + "_" + y;
                    //Debug.Log(key);
                    ApartFlu.Add(key, tileEditItem);
                }
            }
            levelLayer.transform.position = new Vector2(0, 0 /** 0.153f*/);
            Radio++;
        }
        ArabianDrugStyle();
    }
    public void RidWorth(LimitItem item)
    {
        Reach_Mine.Add(item);
        GameObject levelLayerPrefab = Resources.Load<GameObject>(CSoviet.ChasteExactWorth);
        GameObject tileEditItemPrefab = Resources.Load<GameObject>(CSoviet.ChasteMailOpenSuck);
        GameObject levelLayer = Instantiate(levelLayerPrefab, transform);
        
        Vector2 imageSize = TieHemlockFeedThin(tileEditItemPrefab);
        int Radio= (Reach_Mine.Count - 1);
        
        levelLayer.name = "LevelLayer_" + Radio;
        int limit_x = item.x;
        int limit_y = item.y;
        float all_w = Unify_x * (limit_x - 1) + imageSize.x * limit_x;
        float all_h = Unify_y * (limit_y - 1) + imageSize.y * limit_y;
        for (int y = 0; y < limit_y; y++)
        {
            for (int x = 0; x < limit_x; x++)
            {

                GameObject tileEditItem = Instantiate(tileEditItemPrefab, levelLayer.transform);
                float pos_x = -(all_w / 2f) + (Unify_x + imageSize.x) * x+ imageSize.x / 2;
                float pos_y = (all_h / 2f) - (Unify_y + imageSize.y) * y - imageSize.y / 2;
                tileEditItem.transform.position = new Vector2(pos_x, pos_y);
                tileEditItem.GetComponent<SpriteRenderer>().sortingOrder = y * limit_x + x;
                tileEditItem.GetComponent<SpriteRenderer>().sortingLayerName = (Radio + 1).ToString();
                tileEditItem.GetComponent<SpriteRenderer>().color = BoundForm[(int)Mathf.Repeat(Radio,8)];
                string key = Radio + "_" + x + "_" + y;
                ApartFlu.Add(key, tileEditItem);
            }
        }
        levelLayer.transform.position = new Vector2(0, 0);
        ArabianDrugStyle();
    }
    public void NinetyWorth()
    {
        LimitItem limit_item = Reach_Mine[Reach_Mine.Count - 1];
        int limit_x = limit_item.x;
        int limit_y = limit_item.y;
        for (int y = 0; y < limit_y; y++)
        {
            for (int x = 0; x < limit_x; x++)
            {
                ApartFlu.Remove((Reach_Mine.Count - 1) + "_" + x + "_" + y);
            }
        }
        DestroyImmediate(transform.Find("LevelLayer_" + (Reach_Mine.Count - 1)).gameObject);
        Reach_Mine.RemoveAt(Reach_Mine.Count - 1);
        ArabianDrugStyle();
    }
    public void PrepayFatalAlpha(List<LimitItem> limitList)
    {
        int count = limitList.Count > transform.childCount ? transform.childCount : limitList.Count;
        for (int i = 0; i < count; i++)
        {
            if (limitList[i].SenatorFatal != transform.GetChild(i).GetComponent<ExactWorth>().Briny_Tone)
            {
                Transform Quilt= transform.GetChild(i);
                Quilt.GetComponent<ExactWorth>().Briny_Tone = limitList[i].SenatorFatal;
                LimitItem item = Reach_Mine[i];
                item.SenatorFatal = limitList[i].SenatorFatal;
                Reach_Mine[i] = item;
                for (int Calve= 0; Calve < Quilt.childCount; Calve++)
                {
                    Transform itemTrans = Quilt.GetChild(Calve);
                    if (itemTrans.GetComponent<SpriteRenderer>().sprite == null || itemTrans.GetComponent<SpriteRenderer>().sprite == Briny_Rennin)
                    {
                        itemTrans.GetComponent<SpriteRenderer>().sprite = limitList[i].SenatorFatal ? null: Briny_Rennin;
                    }
                }
                break;
            }
        }
    }
    public Vector2 TieHemlockFeedThin(GameObject obj)
    {
        float x = obj.GetComponent<SpriteRenderer>().bounds.extents.x * 2 / obj.transform.lossyScale.x;
        float y = obj.GetComponent<SpriteRenderer>().bounds.extents.y * 2 / obj.transform.lossyScale.y;
        return new Vector2(x, y);
    }
    public void loadExactSize(string fileName)
    {


        string levelFilepath = Application.streamingAssetsPath + "/LevelJson/Level_" + fileName + ".json";
        levelFilepath = levelFilepath.Replace("StreamingAssets", "Resources");
        FileInfo levelFileInfo = new FileInfo(levelFilepath);
        if (levelFileInfo.Exists)
        {
            StreamReader reader = new StreamReader(levelFilepath);
            string jsonString = reader.ReadToEnd();

            LevelReadJsonData jsonData = JsonMapper.ToObject<LevelReadJsonData>(jsonString);
            List<LevelData> levelDataList =  new List<LevelData>(jsonData.Wealth);
            List<string> keyList = new List<string>();
            foreach(LevelData data in levelDataList)
            {
                string key = data.Radio + "_" + data.x + "_" + data.y;
                keyList.Add(key);
            }
            foreach (string key in ApartFlu.Keys)
            {
                if (!keyList.Contains(key))
                {
                    if (Reach_Mine[int.Parse(key.Split('_')[0])].SenatorFatal)
                    {
                        ApartFlu[key].GetComponent<SpriteRenderer>().sprite = null;
                    }
                    else
                    {
                        ApartFlu[key].GetComponent<SpriteRenderer>().sprite = Briny_Rennin;
                    }
                }
                else
                {
                    ApartFlu[key].GetComponent<SpriteRenderer>().sprite = Thaw_Rennin;
                }
            }
        }
        ArabianDrugStyle();
    }
    public void VineExactSize(string fileName,string figureNum)
    {
        string levelFilepath = Application.streamingAssetsPath + "/LevelJson/Level_"+ fileName+ ".json";
        string levelEditFilepath = Application.streamingAssetsPath + "/LevelEditJson/Level_Edit_"+ fileName+ ".json";
        levelEditFilepath = levelEditFilepath.Replace("StreamingAssets", "Resources");
        string levelFileResourcesPath = levelFilepath.Replace("StreamingAssets", "Resources");
        Debug.Log(levelFilepath);
        //FileInfo levelFileInfo = new FileInfo(levelFilepath);

        //if (!levelFileInfo.Exists)
        //{
            
        //    levelFileInfo.Create().Dispose();
        //    levelFileInfo.Refresh();
        //}

        FileInfo levelEditFileInfo = new FileInfo(levelEditFilepath);

        if (!levelEditFileInfo.Exists)
        {
            
            levelEditFileInfo.Create().Dispose();
            levelEditFileInfo.Refresh();
        }

        FileInfo levelFileResourcesInfo = new FileInfo(levelFileResourcesPath);

        if (!levelFileResourcesInfo.Exists)
        {
            levelFileResourcesInfo.Create().Dispose();
            levelFileResourcesInfo.Refresh();
           
        }

        


        List<LevelData> levelDataList = new List<LevelData>();
        for (int Radio= 0; Radio < Reach_Mine.Count; Radio++)
        {
            LimitItem limit_item = Reach_Mine[Radio];
            int limit_x = limit_item.x;
            int limit_y = limit_item.y;
            for (int y = 0; y < limit_y; y++)
            {
                for (int x = 0; x < limit_x; x++)
                {
                    string key = Radio + "_" + x + "_" + y;
                    if (ApartFlu[key].GetComponent<SpriteRenderer>().sprite != Briny_Rennin && ApartFlu[key].GetComponent<SpriteRenderer>().sprite != null)
                    {
                        LevelData Luck= new LevelData();
                        Luck.Radio = Radio.ToString();
                        Luck.x = x.ToString();
                        Luck.y = y.ToString();
                        if (limit_x % 2 != 0)
                        {
                            int Calve= (11 - limit_x) / 2;
                            Calve += x;
                            Luck.At = ManForm[Calve].ToString();
                        }
                        else
                        {
                            int Calve= (10 - limit_x) / 2;
                            Calve += x;
                            Luck.At = EditForm[Calve].ToString();
                        }
                        if (limit_y % 2 != 0)
                        {
                            int Calve= (11 - limit_y) / 2;
                            Calve += y;
                            Luck.Me = ManForm[Calve].ToString();
                        }
                        else
                        {
                            int Calve= (10 - limit_y) / 2;
                            Calve += y;
                            Debug.Log("index:" + Calve);
                            Luck.Me = EditForm[Calve].ToString();
                        }
                        levelDataList.Add(Luck);
                    }
                }
            }
        }
        Debug.Log(levelDataList.Count);
        List<LimitItem> levelEditDataList = new List<LimitItem>(Reach_Mine);
        string levelJsonData = JsonUtility.ToJson(new LevelJsonData(levelDataList, figureNum));
        string levelEditJsonData = SerializeList.FormAtSize<LimitItem>(levelEditDataList);
        //Debug.Log(levelJsonData);
        //Debug.Log(levelEditJsonData);
        //写入内容
        //StreamWriter levelWrite = new StreamWriter(levelFilepath);
        //levelWrite.WriteLine(levelJsonData);
        //levelWrite.Dispose();
        //levelWrite.Close();
        StreamWriter levelEditWrite = new StreamWriter(levelEditFilepath);
        levelEditWrite.WriteLine(levelEditJsonData);
        levelEditWrite.Dispose();
        levelEditWrite.Close();
        StreamWriter levelResourceWrite = new StreamWriter(levelFileResourcesPath);
        levelResourceWrite.WriteLine(levelJsonData);
        levelResourceWrite.Dispose();
        levelResourceWrite.Close();
#if UNITY_EDITOR
        //刷新文件列表
        AssetDatabase.Refresh();
#endif 
    }
}
public class SerializeList
{
    public static string FormAtSize<T>(List<T> l)
    {
        return JsonUtility.ToJson(new SerializationList<T>(l));
    }

    public static List<T> FormAeroSize<T>(string str)
    {
        return JsonUtility.FromJson<SerializationList<T>>(str).AtForm();
    }
}
[Serializable]
public class SerializationList<T>
{
    [SerializeField]
    List<T> Wealth;
    string UsefulNum;
    public List<T> AtForm() { return Wealth; }

    public SerializationList(List<T> target)
    {
        this.Wealth = target;
    }
}
[Serializable]
public class LevelJsonData
{
    [SerializeField]
    public List<LevelData> Wealth;
    [SerializeField]
    public string UsefulNum;
    
    public LevelJsonData(List<LevelData> t, string f)
    {
        this.Wealth = t;
        this.UsefulNum = f;

    }
}
public class LevelReadJsonData
{
    public List<LevelData> Wealth;
    public string UsefulNum;
}
[Serializable]
public class LevelEditMessage
{
    [SerializeField]
    public int Apart_ID;
    [SerializeField]
    public int Radio_Broad;
    [SerializeField]
    public int Dead_Broad;

    public LevelEditMessage(int id, int layer, int tile)
    {
        this.Apart_ID = id;
        this.Radio_Broad = layer;
        this.Dead_Broad = tile;

    }
}

public class LevelRemoveData
{
    public List<LevelRemoveItem> Ninety_Mine;
}
public class LevelRemoveItem
{
    public int ExactShy;
    public int Swift;
}

