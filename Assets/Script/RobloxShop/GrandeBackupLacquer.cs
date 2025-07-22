using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandeBackupLacquer : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("id")]    public int ID;
[UnityEngine.Serialization.FormerlySerializedAs("ClaimBtn")]    public Button SquatBow;
[UnityEngine.Serialization.FormerlySerializedAs("IconImage")]
    public Image WhigMouse;
[UnityEngine.Serialization.FormerlySerializedAs("IconRewardText")]
    public Text WhigBackupPile;
[UnityEngine.Serialization.FormerlySerializedAs("RewardScheduleText")]
    public Text BackupPlutonicPile;
[UnityEngine.Serialization.FormerlySerializedAs("RewardScheduleImage")]
    public Image BackupPlutonicMouse;
[UnityEngine.Serialization.FormerlySerializedAs("ownRobuxData")]
    public RobuxData SawLevelTwig;
[UnityEngine.Serialization.FormerlySerializedAs("GuideImage")]
    public Image WeedyMouse;
[UnityEngine.Serialization.FormerlySerializedAs("ShowWithDrawPanel")]
    public Action<int> HeelPeckHailKrill;
[UnityEngine.Serialization.FormerlySerializedAs("ShowCoinNotEnough")]    public Action<string, bool> HeelTextGapDefine;
[UnityEngine.Serialization.FormerlySerializedAs("CompleteObj")]    public GameObject AnyplaceShy;
[UnityEngine.Serialization.FormerlySerializedAs("TaskText")]    public Text SlatPile;
[UnityEngine.Serialization.FormerlySerializedAs("TaskTwoText")]    public Text SlatEonPile;
[UnityEngine.Serialization.FormerlySerializedAs("GameImage")]
    public Image SeemMouse;
[UnityEngine.Serialization.FormerlySerializedAs("GameText")]    public Text SeemPile;
[UnityEngine.Serialization.FormerlySerializedAs("GameTwoText")]    public Text SeemEonPile;
[UnityEngine.Serialization.FormerlySerializedAs("GameThreeText")]    public Text SeemSevenPile;
[UnityEngine.Serialization.FormerlySerializedAs("GameName")]    public string SeemBold;
[UnityEngine.Serialization.FormerlySerializedAs("GameIconPath")]    public string SeemWhigTide;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        SquatBow.onClick.AddListener(SepalBowPhoto);


        /*RewardScheduleText.text =
            GrandeOntoTwigAbsence.instance.GetShopStringValue( ownRobuxData, 55555);
        RewardScheduleImage.fillAmount = GrandeOntoTwigAbsence.instance.GetShopFloatValue(ownRobuxData, 55555);*/
        //RefreshSchdule();
    }
    
    public void EuropeWomanLanguish()
    {
        TreeTwigAbsence.SetString("RobloxRewardState" + ID, "Withdraw");
        SunLoadSlat();
        /*TaskText.gameObject.SetActive(true);
        TaskText.text = GrandeOntoTwigAbsence.instance.GetRobloxTask(id).Description;*/
        WhigMouse.sprite = Resources.Load<Sprite>(GrandeOntoTwigAbsence.instance.KeaGrandeSlat(ID).PicURI);
        AnyplaceShy.SetActive(false);
        RebirthBritain();
    }
    public void EuropeWomanAnyplace()
    {
        TreeTwigAbsence.SetString("RobloxRewardState" + ID, "Complete");
        TaskItemData taskItemData = GrandeOntoTwigAbsence.instance.KeaGrandeSlat(ID);
        if (taskItemData != null)
        {
            SunLoadSlat();
            /*TaskText.gameObject.SetActive(true);
            TaskText.text = GrandeOntoTwigAbsence.instance.GetRobloxTask(id).Description;*/
            WhigMouse.sprite = Resources.Load<Sprite>(GrandeOntoTwigAbsence.instance.KeaGrandeSlat(ID).PicURI);
        }
        
        AnyplaceShy.SetActive(true);
        RebirthBritain();
    }
    public void EuropeWomanInjury()
    {
        SlatPile.gameObject.SetActive(false);
        SlatEonPile.gameObject.SetActive(false);
        AnyplaceShy.SetActive(false);
        //IconImage.sprite = Resources.Load<Sprite>("RobloxShop/RobloxImage/home_icon_rubux_210");
        RebirthBritain();
    }

    private void SunLoadSlat()
    {
        if (GrandeOntoTwigAbsence.instance.LevelTwig[SawLevelTwig.ID].TaskID == 0)
        {
            SlatPile.gameObject.SetActive(true);
            SlatEonPile.gameObject.SetActive(false);
        }
        else
        {
            SlatPile.gameObject.SetActive(false);
            SlatEonPile.gameObject.SetActive(true);
        }
    }
    private void OnEnable()
    {
        //RefreshInfo();

    }

    /// <summary>
    /// 刷新状态
    /// </summary>
    public void RebirthTour()
    {
        WhigBackupPile.text = SawLevelTwig.currencyValue.ToString();
        WhigMouse.sprite = GrandeOntoTwigAbsence.instance.KeaVanishOfID(SawLevelTwig.ID);
        SeemMouse.sprite = GrandeOntoTwigAbsence.instance.KeaVanishOfID(SeemWhigTide);
        if (SeemBold != "Coins" && SeemBold != "Diamonds")
        {
            SeemPile.gameObject.SetActive(true);
            SeemEonPile.gameObject.SetActive(false);
            SeemSevenPile.gameObject.SetActive(false);
            SeemPile.text = SeemBold;
            
        }
        else if(SeemBold == "Coins")
        {
            SeemPile.gameObject.SetActive(false);
            SeemEonPile.gameObject.SetActive(true);
            SeemSevenPile.gameObject.SetActive(false);
        }
        else
        {
            SeemPile.gameObject.SetActive(false);
            SeemEonPile.gameObject.SetActive(false);
            SeemSevenPile.gameObject.SetActive(true);
        }
        if (TreeTwigAbsence.GetString("RobloxRewardState" + ID)  == "")
        {
            EuropeWomanInjury();
        }
        else if(TreeTwigAbsence.GetString("RobloxRewardState" + ID) == "Withdraw")
        {
            EuropeWomanLanguish();
        }
        else
        {
            EuropeWomanAnyplace();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SepalBowPhoto()
    {
        //Todo 反馈 货币够了
        if (BackupPlutonicMouse.fillAmount >= 1)
        {
            Debug.Log("货币够了!");

            if (TreeTwigAbsence.GetString("RobloxRewardState" + ID) == "")
            {
                HeelPeckHailKrill?.Invoke(SawLevelTwig.ID);
            }
            else if (TreeTwigAbsence.GetString("RobloxRewardState" + ID) == "Withdraw")
            {
                GrandeOntoKrill.instance.HeelProdigyKrill();
                EuropeWomanAnyplace();
            }
            else
            {
                return;
            }
        }
        //货币不够
        else
        {
            if (TreeTwigAbsence.GetString("RobloxRewardState" + ID) == "")
            {
                if (SawLevelTwig.CostType == 1)
                    HeelTextGapDefine?.Invoke("1", false);
                else if (SawLevelTwig.CostType == 2)
                    HeelTextGapDefine?.Invoke("2", false);
                else if (SawLevelTwig.CostType == 3)
                    HeelTextGapDefine?.Invoke("3", false);
                else
                    HeelTextGapDefine?.Invoke("5", false);
                Debug.Log("货币不够!");
            }
            else if (TreeTwigAbsence.GetString("RobloxRewardState" + ID) == "Withdraw")
            {
                HeelTextGapDefine?.Invoke("4", false);
            }
            else
            {
                return;
            }
            
        }
    }

    public void RebirthBritain()
    {
        if (TreeTwigAbsence.GetString("RobloxRewardState" + ID) == "")
        {
            //Todo 这里的两个货币类型需要去获取
            if (SawLevelTwig != null && SawLevelTwig.CostType == 1)
            {
                BackupPlutonicPile.text =
                    GrandeOntoTwigAbsence.instance.KeaOntoMexicoAttic(SawLevelTwig, GrandeOntoTwigAbsence.instance.MandibleDay);
                BackupPlutonicMouse.fillAmount = GrandeOntoTwigAbsence.instance.KeaOntoGlassAttic(SawLevelTwig, GrandeOntoTwigAbsence.instance.MandibleDay);
            }
            else if (SawLevelTwig != null && SawLevelTwig.CostType == 2)
            {
                BackupPlutonicPile.text =
                    GrandeOntoTwigAbsence.instance.KeaOntoMexicoAttic(SawLevelTwig, GrandeOntoTwigAbsence.instance.MandibleEon);
                BackupPlutonicMouse.fillAmount = GrandeOntoTwigAbsence.instance.KeaOntoGlassAttic(SawLevelTwig, GrandeOntoTwigAbsence.instance.MandibleEon);
            }
            else if(SawLevelTwig != null)
            {
                BackupPlutonicPile.text =
                    GrandeOntoTwigAbsence.instance.KeaOntoMexicoAttic(SawLevelTwig, GrandeOntoTwigAbsence.instance.MandibleSeven);
                BackupPlutonicMouse.fillAmount = GrandeOntoTwigAbsence.instance.KeaOntoGlassAttic(SawLevelTwig, GrandeOntoTwigAbsence.instance.MandibleSeven);
            }
        }
        if (TreeTwigAbsence.GetString("RobloxRewardState" + ID) == "Withdraw")
        {
            BackupPlutonicPile.text = GrandeOntoTwigAbsence.instance.KeaSlatHeelAttic(ID);
            BackupPlutonicMouse.fillAmount = GrandeOntoTwigAbsence.instance.KeaSlatHeelFillManual(ID);
        }
        if (TreeTwigAbsence.GetString("RobloxRewardState" + ID) == "Complete")
        {

            TaskItemData taskItemData = GrandeOntoTwigAbsence.instance.KeaGrandeSlat(ID);
            if (taskItemData != null)
            {
                BackupPlutonicPile.text = GrandeOntoTwigAbsence.instance.KeaSlatHeelAttic(ID);
                BackupPlutonicMouse.fillAmount = GrandeOntoTwigAbsence.instance.KeaSlatHeelFillManual(ID);
            }
        }

    }
}
