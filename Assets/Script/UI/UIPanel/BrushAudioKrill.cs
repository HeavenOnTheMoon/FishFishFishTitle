using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BrushAudioKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("GetButton")]    public Button KeaInform;
[UnityEngine.Serialization.FormerlySerializedAs("ADGetButton")]    public Button ADKeaInform;
[UnityEngine.Serialization.FormerlySerializedAs("DailyBounsItemList")]    public List<GameObject> BrushSedgeSuckForm;
    void Start()
    {
        KeaInform.onClick.AddListener(() =>
        {
            KeaBackup(BrushSedgeSuckForm[TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle)]);
        });
        ADKeaInform.onClick.AddListener(() =>
        {
            // bx 广告位
            KeaBackup(BrushSedgeSuckForm[TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle)], true);
        });
    }
    public override void Display()
    {
        base.Display();

        for (int i = 0; i < TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle); i++)
        {
            GameObject item = BrushSedgeSuckForm[i];
            TinyBrushBackup(3, i == 6 ? 1 : 0, item);
        }
        for (int i = TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle) + 1; i < TugTourOil.instance.AnewTwig.DailyBonus.Count; i++)
        {
            GameObject item = BrushSedgeSuckForm[i];
            TinyBrushBackup(1, i == 6 ? 1 : 0, item);
        }
        if (Seem.instance.BrushSedgeKeaBrace() != 8)
        {
            GameObject item = BrushSedgeSuckForm[TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle)];
            TinyBrushBackup(2, TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle) == 6 ? 1 : 0, item);
        }
        else
        {
            GameObject item = BrushSedgeSuckForm[TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle)];
            TinyBrushBackup(3, TreeTwigAbsence.GetInt(CSoviet.Or_BrushSedgeKeaStyle) == 6 ? 1 : 0, item);
        }
        if (Seem.instance.BrushSedgeKeaBrace() != 8)
        {
            KeaInform.gameObject.SetActive(true);
        }
        else
        {
            KeaInform.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// 判断领取  如果i=1 奖励未领取； 如果i=2  奖励可领取；如果i=3 奖励已领取；
    /// </summary>
    /// <param name="i"> i是判断 未领取/可领取/已领取 </param>
    /// <param name="j"> j是判断 j=0 是第一天到第六天 j>0 是第七天 * 因为第七天的背景图不一样 * </param>
    /// <param name="Day">day1-7的gameobject</param>
    public void TinyBrushBackup(int i,int j,GameObject Day) 
    {
        if (i == 1)
        {
            if (j > 0)
            {
                Day.GetComponent<Transform>().Find("DayBG").GetComponent<Image>().sprite = Resources.Load<Sprite>(CSoviet.SurmiseBrushBackup7);

            }
            else 
            {
                Day.GetComponent<Transform>().Find("DayBG").GetComponent<Image>().sprite = Resources.Load<Sprite>(CSoviet.SurmiseBrushBackup);
                Day.GetComponent<Transform>().Find("DuiHao").gameObject.SetActive(false);
                Day.GetComponent<Transform>().Find("Fx_RewardBG").gameObject.SetActive(false);
            }
        }
        else if (i == 2)
        {
            if (j > 0)
            {
                Day.GetComponent<Transform>().Find("DayBG").GetComponent<Image>().sprite = Resources.Load<Sprite>(CSoviet.SurmiseBrushBackup7Wife);
            }
            else
            {
                Day.GetComponent<Transform>().Find("DayBG").GetComponent<Image>().sprite = Resources.Load<Sprite>(CSoviet.SurmiseBrushWife);
            }
        }
        else if (i == 3) 
        {
            if (j > 0)
            {
                Day.GetComponent<Transform>().Find("Mask").gameObject.SetActive(true);
                Day.GetComponent<Transform>().Find("DuiHao").gameObject.SetActive(true);
                Day.GetComponent<Transform>().Find("Fx_RewardBG").gameObject.SetActive(false);
            }
            else 
            {
                Day.GetComponent<Transform>().Find("Mask").gameObject.SetActive(true);
                Day.GetComponent<Transform>().Find("Fx_RewardBG").gameObject.SetActive(false);
                Day.GetComponent<Transform>().Find("DuiHao").gameObject.SetActive(true);
            }
        }
    }




    /// <summary>
    /// 点击get按钮 获取奖励
    /// </summary>
    /// <param name="RewardImage">奖励图片</param>
    public void KeaBackup(GameObject day, bool isAD = false) 
    {
        AstronautAttainment.BrushAudioMat(day.GetComponent<Transform>().Find("Gift").gameObject, day.GetComponent<Transform>().Find("Fx_RewardBG").gameObject, ()=> 
        {
            Seem.instance.BrushAudioKeaBackup(isAD);
            //关闭弹窗 回到主页给奖励
            StarkUIWish(GetType().Name);
            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HikeKrill_DamSoar);
        });
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
