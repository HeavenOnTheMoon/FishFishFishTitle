using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandeEonBackupCanoes : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ClaimBtn")]    public Button SquatBow;
[UnityEngine.Serialization.FormerlySerializedAs("IconImage")]
    public Image WhigMouse;
[UnityEngine.Serialization.FormerlySerializedAs("IconDexcriptionText")]
    public Text WhigDisseminatePile;
[UnityEngine.Serialization.FormerlySerializedAs("RewardScheduleText")]
    public Text BackupPlutonicPile;
[UnityEngine.Serialization.FormerlySerializedAs("RewardScheduleImage")]
    public Image BackupPlutonicMouse;
[UnityEngine.Serialization.FormerlySerializedAs("GuideImage")]
    public Image WeedyMouse;
[UnityEngine.Serialization.FormerlySerializedAs("ownRobloxItemData")]
    public RobloxItemData SawGrandeSuckTwig;
[UnityEngine.Serialization.FormerlySerializedAs("ShowGetFragmentPanel")]    public Action<int> HeelKeaCustomerKrill;
[UnityEngine.Serialization.FormerlySerializedAs("CLaimBtnText")]
    public Text CLaimBowPile;
[UnityEngine.Serialization.FormerlySerializedAs("isCanGetReward")]    public bool AnTugKeaBackup= false;
[UnityEngine.Serialization.FormerlySerializedAs("LevelImage")]    public Image ExactMouse;
[UnityEngine.Serialization.FormerlySerializedAs("UpImage")]    public Image OrMouse;
    // Start is called before the first frame update
    void Start()
    {
        SquatBow.onClick.AddListener(SquatBowCHint);
        Arabian();

    }
    public void Arabian()
    {
        List<int> idList = new List<int>(TreeTwigAbsence.GetIntArray("RookieList"));
        if (idList.Contains(SawGrandeSuckTwig.ID))
        {
            OrMouse.gameObject.SetActive(true);
        }
        else
        {
            OrMouse.gameObject.SetActive(false);
        } 
        WhigMouse.sprite = GrandeOntoTwigAbsence.instance.KeaVanishOfID(SawGrandeSuckTwig.ID);
        ExactMouse.sprite = Resources.Load<Sprite>(CSoviet.RGrandeParadoxicallyExact + SawGrandeSuckTwig.Level);
        WhigDisseminatePile.text = SawGrandeSuckTwig.Name;

        BackupPlutonicPile.text = GrandeOntoTwigAbsence.instance.KeaProtectorMexicoAttic(SawGrandeSuckTwig);

        BackupPlutonicMouse.fillAmount = GrandeOntoTwigAbsence.instance.KeaProtectorGlassAttic(SawGrandeSuckTwig);
    }
    // Update is called once per frame
    void Update()
    {
        RebirthSquatFluid();
    }
    
    public void RebirthBritain()
    {
        /*//这里的两个货币类型需要去获取
        RewardScheduleText.text =
            GrandeOntoTwigAbsence.instance.GetShopStringValue( ownRobuxData, 55555);
        RewardScheduleImage.fillAmount = GrandeOntoTwigAbsence.instance.GetShopFloatValue(ownRobuxData, 55555);*/
        BackupPlutonicPile.text = GrandeOntoTwigAbsence.instance.KeaProtectorMexicoAttic(SawGrandeSuckTwig);
        BackupPlutonicMouse.fillAmount = GrandeOntoTwigAbsence.instance.KeaProtectorGlassAttic(SawGrandeSuckTwig);
    }

    public void SquatBowCHint()
    {
        HeelKeaCustomerKrill?.Invoke(SawGrandeSuckTwig.ID);
    }

    private void RebirthSquatFluid()
    {
        if (TreeTwigAbsence.GetString("String" + SawGrandeSuckTwig.ID) != "")
        {
            DateTime Luck= DateTime.ParseExact(TreeTwigAbsence.GetString("String" + SawGrandeSuckTwig.ID),"yyyyMMddHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan span = DateTime.Now - Luck;
            TimeSpan timeSpan = TimeSpan.FromSeconds(int.Parse(GrandeOntoTwigAbsence.instance.GrandeOntoTwig.ChipGetAds_CD)) - span;

            string timestr = string.Format("{0:D2}m {1:D2}s", timeSpan.Minutes, timeSpan.Seconds);

            CLaimBowPile.text = timestr;
            SquatBow.enabled = false;
            if (timeSpan.TotalSeconds <= 0)
            {
                TreeTwigAbsence.SetString("String" + SawGrandeSuckTwig.ID,"");
                CLaimBowPile.text = "Claim";
                SquatBow.enabled = true;
            }
        }
        else
        {
            SquatBow.enabled = true;
        }
    }
    
    
}
