using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;
public class TriggerType
{
    public static string Apart_Xenon= "level_start";
    public static string Quill_Inspect= "panel_display";
    public static string Arch_Behind= "fish_unlock";
    public static string Tie_Dead= "get_tile";
    public static string Anew_Asia= "game_init";
}
public class ConditionType
{
    public static string Quill= "panel";
    public static string Arch_Lay= "fish_num";
    public static string Tutelage_Lay= "aquarium_num";
    public static string Apart_Xenon_Lay= "level_start_num";
    public static string Dead_Lay= "tile_num";
    public static string Behind_Arch_Lay= "unlock_fish_num";

}
public class TarGlueAbsence : WellSweatshop<TarGlueAbsence>
{
    public GameObject Down;
    public GameObject Down2;
    public GameObject SackChaste;
    public GameObject KestrelPile;
    public GameObject Aside;
    Button FoulInform;
    List<Button> FoulInformForm;
    List<GameObject> FoulRainerForm;
    List<int> FoulBraceForm;
    System.Action TearRoof;
    protected override void Awake()
    {
        base.Awake();
        FoulBraceForm = new List<int>();
        FoulInformForm = new List<Button>();
        FoulRainerForm = new List<GameObject>();
        Down.GetComponent<Canvas>().sortingLayerName = "NewUserMask";
        Down.GetComponent<Canvas>().sortingOrder = 1;
    }

    public void HeelDown(bool showMask, bool showHand, Vector3 handPosition, GameObject obj)
    {
        Down.SetActive(true);
        Down.GetComponent<Image>().enabled = showMask;
        Down.transform.Find("Hand").gameObject.SetActive(showHand);
        if (showMask)
        {
            Down.transform.Find("Hand").GetComponent<RectTransform>().localPosition = handPosition;
            Canvas canvas = obj.AddComponent<Canvas>();
            if (canvas != null)
            {
                canvas.overrideSorting = true;
                canvas.sortingLayerName = "NewUserMask";
                canvas.sortingOrder = 2;
                obj.AddComponent<GraphicRaycaster>();
            }
            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_AroundWife);
        }
    }

    public void LiraDown(GameObject obj, bool hideCanvas = false)
    {
        Down.SetActive(false);
        if (hideCanvas)
        {
            Destroy(obj.GetComponent<GraphicRaycaster>());
            Destroy(obj.GetComponent<Canvas>());
        }
        HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_AroundStark);
    }

    public void IngoingLipid(string type)
    {
        //string triggerType = type;
        //foreach (NewUserGuideItemData itemData in TugTourOil.instance.gameData.NewUserGuide)
        //{
        //    if (!TreeTwigAbsence.GetBool(CSoviet.sv_NewUserStep + itemData.ID))
        //    {
        //        //Debug.Log("bool1:"+CheckCondition(itemData.Condition[0]));
        //        //Debug.Log("bool2:"+(itemData.Trigger == triggerType));
        //        //Debug.Log("id:"+ itemData.ID);
        //        if (itemData.Trigger == triggerType && CheckCondition(itemData.Condition[0]))
        //        {
        //            ShowStep(itemData);
        //            break;
        //        }
        //    }
        //}
    }
    public bool SonicCardboard(Dictionary<string,string> condition)
    {
        //List<string> keyList = new List<string>(condition.Keys);
        //bool isReady = true;
        //foreach (string key in keyList)
        //{
        //    if (key == ConditionType.panel)
        //    {
        //        if (condition[key] != UIAbsence.GetInstance().PanelName)
        //        {
        //            isReady = false;
        //        }
        //    }
        //    if (key == ConditionType.fish_num)
        //    {
        //        if (LethalUtil.IsApple() && int.Parse(condition[key]) != 7)
        //        {
        //            if (int.Parse(condition[key]) != Seem.instance.getHaveFishCount() + 1)
        //            {
        //                isReady = false;
        //            }
        //        }
        //        else
        //        {
        //            if (int.Parse(condition[key]) != Seem.instance.getHaveFishCount())
        //            {
        //                isReady = false;
        //            }
        //        }
        //    }
        //    if (key == ConditionType.aquarium_num)
        //    {
        //        if (int.Parse(condition[key]) != TreeTwigAbsence.GetIntArray(CSoviet.sv_UnlockFishTankList).Length)
        //        {
        //            isReady = false;
        //        }
        //    }
        //    if (key == ConditionType.level_start_num)
        //    {
        //        if (TreeTwigAbsence.GetInt(CSoviet.sv_Level_Id) != int.Parse(condition[key]))
        //        {
        //            isReady = false;
        //        }
        //    }
        //    if (key == ConditionType.tile_num)
        //    {
        //        if(Seem.instance.levelCreate.GetComponent<ExactBeer>().getCount != int.Parse(condition[key]))
        //        {
        //            isReady = false;
        //        }
        //    }
        //    if (key == ConditionType.unlock_fish_num)
        //    {
        //        if (Seem.instance.getNextUnlockFishData() != int.Parse(condition[key]))
        //        {
        //            isReady = false;
        //        }
        //    }
        //}
        //return isReady;
        return true;
    }
    public void HeelSpin(NewUserGuideItemData data)
    {
        //Arrow.SetActive(false);
        //stepIndexList.Add(data.ID);
        //if (data.TargetPanel == "Tile")
        //{
        //    TileNewUserGuide(data);
        //}
        //else
        //{
        //    Mask.GetComponent<Image>().color = new Color(0, 0, 0, (float)data.MaskAlpha);
        //    Mask.SetActive(true);
        //    Seem.instance.gamePauseMaskAll();
        //    StartCoroutine(setTargetWaitTime(data));
        //}

    }
    IEnumerator WetRainerOntoPloy(NewUserGuideItemData data)
    {
        yield return new WaitForSeconds(0.5f);
        //Debug.Log(data.TargetPath);
        //Transform target = UIAbsence.GetInstance().MainCanvas.transform.Find(data.TargetPath);
        //if (target)
        //{
        //    //oldParent = target.transform.parent;
        //    Canvas targetCanvas = target.gameObject.AddComponent<Canvas>();
        //    target.gameObject.AddComponent<GraphicRaycaster>();
        //    if (data.Trigger == TriggerType.get_tile)
        //    {
        //        target.Find("LockImage").gameObject.SetActive(false);
        //    }
        //    targetCanvas.overrideSorting = true;
        //    targetCanvas.sortingLayerName = "NewUserLight";
            
        //    targetCanvas.sortingOrder = 1;
        //    if (data.Content.Length > 0)
        //    {
        //        if (data.ID != 1 ) 
        //        {
        //            ContentText.GetComponent<Transform>().Find("ContentText").GetComponent<Text>().fontSize = 40;
        //        }
        //        ContentText.SetActive(true);
        //        ContentText.GetComponent<RectTransform>().anchoredPosition = new Vector2((float)data.ContentPos_X, (float)data.ContentPos_Y-1);
        //        ContentText.GetComponent<Transform>().Find("ContentText").GetComponent<Text>().text = I2.Loc.LocalizationManager.GetTranslation("guide/"+data.Content);
        //    }
        //    else
        //    {
        //        ContentText.SetActive(false);
        //    }

        //    GameObject Hand = Instantiate(HandPrefab, target);
        //    Hand.GetComponent<RectTransform>().anchoredPosition = new Vector2((float)data.HandOffset_X , (float)data.HandOffset_Y );
        //    Hand.SetActive(true);
        //    FindButton(target.gameObject);
        //    if (stepButton)
        //    {
        //        stepButton.onClick.AddListener(finishNewUserStep);
        //        stepButtonList.Add(stepButton);
        //    }
        //    stepTargetList.Add(target.gameObject);
        //}
        //else
        //{
        //    Debug.LogError("找不到引导路径");
        //}
    }

    public void EthnicTarGlueSpin()
    {
        //ContentText.SetActive(false);
        //int stepIndex = stepIndexList[0];
        //stepIndexList.RemoveAt(0);
        //if (getTriggerWithID(stepIndex) != TriggerType.level_start)
        //{
        //    Button step_button = stepButtonList[0];
        //    GameObject target = stepTargetList[0];
        //    step_button.onClick.RemoveListener(finishNewUserStep);
        //    Destroy(target.GetComponent<GraphicRaycaster>());
        //    Destroy(target.GetComponent<Canvas>());
        //    Destroy(target.transform.Find("Hand(Clone)").gameObject);
        //    stepButtonList.Remove(step_button);
        //    stepTargetList.Remove(target);
        //    Seem.instance.canelGamePauseMaskAll();
        //}
        //if (stepIndexList.Count == 0)
        //{
        //    Mask.SetActive(false);
        //}
        //TreeTwigAbsence.SetBool(CSoviet.sv_NewUserStep + stepIndex, true);
    }

    public void ToneDownSackKestrel(Vector2 content_pos,string content_str,Vector2 handpos,bool needHand,GameObject target,bool targetCanTouch,System.Action cb)
    {

        //Mask.GetComponent<Image>().color = new Color(0, 0, 0, 0.5f);
        //Mask.SetActive(true);
        //if (target)
        //{
        //    Canvas targetCanvas = target.gameObject.AddComponent<Canvas>();
        //    if (targetCanTouch)
        //    {
        //        target.gameObject.AddComponent<GraphicRaycaster>();
        //        FindButton(target);
        //        callBack = cb;
        //        stepButton.onClick.AddListener(callBackAction);
        //    }
        //    targetCanvas.overrideSorting = true;
        //    targetCanvas.sortingLayerName = "NewUserLight";
        //    targetCanvas.sortingOrder = 1;
        //    stepTargetList.Add(target);
        //}
        //if (content_str.Length > 0)
        //{
        //    //ContentText.GetComponent<Transform>().Find("ContentText").GetComponent<Text>().fontSize = 42;
        //    Arrow.SetActive(true);
        //    ContentText.SetActive(true);
        //    ContentText.GetComponent<RectTransform>().anchoredPosition = content_pos;/*new Vector2(content_pos.x, content_pos.y * (Screen.height / 1334f));*/
        //    ContentText.GetComponent<Transform>().Find("ContentText").GetComponent<Text>().text = I2.Loc.LocalizationManager.GetTranslation("guide/" + content_str);
        //}
        //else
        //{
        //    ContentText.SetActive(false);
        //}
        //if (needHand)
        //{
        //    GameObject Hand = Instantiate(HandPrefab, target.transform);
        //    Hand.GetComponent<RectTransform>().anchoredPosition = handpos;
        //    Hand.SetActive(true);
        //}
        
    }
    void TearRoofAffair()
    {

        //Mask.SetActive(false);
        //GameObject target = stepTargetList[0];
        //if (!target.name.Contains("Bubble"))
        //{
        //    Destroy(target.GetComponent<GraphicRaycaster>());
        //    Destroy(target.GetComponent<Canvas>());
        //}
        //Destroy(target.transform.Find("Hand(Clone)").gameObject);
        //stepTargetList.Remove(target);
        //callBack();
        //callBack = null;

        //stepButton.onClick.RemoveListener(callBackAction);
    }
    public void SellInform(GameObject goParent)
    {
        //Transform parent = goParent.transform;
        //if (parent.GetComponent<Button>())
        //{
        //    stepButton = parent.GetComponent<Button>();
        //    return;
        //}
        //int childCount = parent.childCount;
        //for (int i = 0; i < childCount; i++)
        //{
        //    Transform chile = parent.GetChild(i);
        //    if (chile.GetComponent<Button>())
        //    {
        //        stepButton = chile.GetComponent<Button>();
        //        return;
        //    }
        //    if (chile.childCount > 0)
        //    {
        //        FindButton(chile.gameObject);
        //    }
        //}
    }
    void MailTarGlueWeedy(NewUserGuideItemData data)
    {
        KestrelPile.GetComponent<Transform>().Find("ContentText").GetComponent<Text>().fontSize = 35;
        Down.GetComponent<Image>().color = new Color(0, 0, 0, 0f);
        Down.SetActive(true);
        if (data.Content.Length > 0)
        {
            KestrelPile.SetActive(true);
            KestrelPile.GetComponent<RectTransform>().anchoredPosition = new Vector2((float)data.ContentPos_X, (float)data.ContentPos_Y);
            KestrelPile.GetComponent<Transform>().Find("ContentText").GetComponent<Text>().text = I2.Loc.LocalizationManager.GetTranslation("guide/"+data.Content);
        }
        Seem.instance.ApartAbsorb.EggGlueSpin();
    }
    public void MailTarGlueWeedyGarden()
    {
        KestrelPile.SetActive(false);

    }
    public string TieIngoingPeckID(int id)
    {
        foreach (NewUserGuideItemData data in TugTourOil.instance.AnewTwig.NewUserGuide)
        {
            if (id == data.ID)
            {
                return data.Trigger;
            }
        }
        return "";
    }
    public List<int> TieIDFormPeckIngoing(string type)
    {
        List<int> id_list = new List<int>();
        foreach (NewUserGuideItemData data in TugTourOil.instance.AnewTwig.NewUserGuide)
        {
            if (type == data.Trigger)
            {
                id_list.Add(data.ID);
            }
        }
        return id_list;
    }
    static public List<int> TieIDFormPeckIngoingFaunal(string type)
    {
        List<int> id_list = new List<int>();
        foreach (NewUserGuideItemData data in TugTourOil.instance.AnewTwig.NewUserGuide)
        {
            if (type == data.Trigger)
            {
                id_list.Add(data.ID);
            }
        }
        return id_list;
    }
    //public void step
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
