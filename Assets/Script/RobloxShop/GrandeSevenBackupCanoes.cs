using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandeSevenBackupCanoes : MonoBehaviour
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
[UnityEngine.Serialization.FormerlySerializedAs("ownRobloxItemTwoData")]
    public RobloxItemTwoData SawGrandeSuckEonTwig;
[UnityEngine.Serialization.FormerlySerializedAs("CLaimBtnText")]
    public Text CLaimBowPile;
[UnityEngine.Serialization.FormerlySerializedAs("ShowGetFragmentPanel")]    
    public Action<int> HeelKeaCustomerKrill;
    // Start is called before the first frame update
    void Start()
    {
        SquatBow.onClick.AddListener(SquatBowCHint);
        
        WhigMouse.sprite = GrandeOntoTwigAbsence.instance.KeaVanishOfID(SawGrandeSuckEonTwig.ID);
        WhigDisseminatePile.text = SawGrandeSuckEonTwig.Name;

        BackupPlutonicPile.text = GrandeOntoTwigAbsence.instance.KeaSwordMexicoAttic(SawGrandeSuckEonTwig);

        BackupPlutonicMouse.fillAmount = GrandeOntoTwigAbsence.instance.KeaSwordGlassAttic(SawGrandeSuckEonTwig);
    }

    // Update is called once per frame
    void Update()
    {
        RebirthSquatFluid();
    }
    
    public void RebirthBritain()
    {
        //这里的两个货币类型需要去获取
        /*RewardScheduleText.text =
            GrandeOntoTwigAbsence.instance.GetShopStringValue( ownRobloxItemTwoData, 55555);
        RewardScheduleImage.fillAmount = GrandeOntoTwigAbsence.instance.GetShopFloatValue(ownRobloxItemTwoData, 55555);*/
        BackupPlutonicPile.text = GrandeOntoTwigAbsence.instance.KeaSwordMexicoAttic(SawGrandeSuckEonTwig);

        BackupPlutonicMouse.fillAmount = GrandeOntoTwigAbsence.instance.KeaSwordGlassAttic(SawGrandeSuckEonTwig);
    }
    
    public void SquatBowCHint()
    {
        HeelKeaCustomerKrill?.Invoke(SawGrandeSuckEonTwig.ID);
    }
    
    
    private void RebirthSquatFluid()
    {
        if (TreeTwigAbsence.GetString("String" + SawGrandeSuckEonTwig.ID) != "")
        {
            DateTime Luck= DateTime.ParseExact(TreeTwigAbsence.GetString("String" + SawGrandeSuckEonTwig.ID),"yyyyMMddHH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan span = DateTime.Now - Luck;
            TimeSpan timeSpan = TimeSpan.FromSeconds(int.Parse(GrandeOntoTwigAbsence.instance.GrandeOntoTwig.ChipGetAds_CD)) - span;

            string timestr = string.Format("{0:D2}m {1:D2}s", timeSpan.Minutes, timeSpan.Seconds);

            CLaimBowPile.text = timestr;
            SquatBow.enabled = false;
            if (timeSpan.TotalSeconds <= 0)
            {
                TreeTwigAbsence.SetString("String" + SawGrandeSuckEonTwig.ID,"");
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
