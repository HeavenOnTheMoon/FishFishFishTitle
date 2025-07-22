using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class MustKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("lightSprite")]
#if UNITY_IOS
    string Alter= "1637039085";
#endif
#if UNITY_ANDROID
    string appid = "com.tilefungame.tileaquarium";
#endif
    public Sprite StrutVanish;
[UnityEngine.Serialization.FormerlySerializedAs("blackSprite")]    public Sprite ThighVanish;
[UnityEngine.Serialization.FormerlySerializedAs("buttonList")]    public List<Button> PerishForm;
[UnityEngine.Serialization.FormerlySerializedAs("content")]    public GameObject Lineage;
    // Start is called before the first frame update
    private void OnEnable()
    {
    }
    void Start()
    {
        PerishForm[0].onClick.AddListener(() => {
            NewsAffair(0 + 1);
        });
        PerishForm[1].onClick.AddListener(() => {
            NewsAffair(1 + 1);
        });
        PerishForm[2].onClick.AddListener(() => {
            NewsAffair(2 + 1);
        });
        PerishForm[3].onClick.AddListener(() => {
            NewsAffair(3 + 1);
        });
        PerishForm[4].onClick.AddListener(() => {
            NewsAffair(4 + 1);

        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewsAffair(int index)
    {
        for (int i = 0; i < PerishForm.Count; i++)
        {
            if (i < index)
            {
                PerishForm[i].GetComponent<Image>().sprite = StrutVanish;
            }
            else
            {
                PerishForm[i].GetComponent<Image>().sprite = ThighVanish;
            }
        }
        if ((index <= 3 && LethalUtil.ByVague()) || index > 3)
        {
            WetPeru();
        }
        TreeTwigAbsence.SetBool(CSoviet.Or_Error_News, true);
        StarkUIWish(GetType().Name);
    }

    /// <summary>
    /// 发邮件
    /// </summary>
    public void LikeEmail()
    {
        //Debug.Log("发邮件");
        Uri uri = new Uri(string.Format("mailto:{0}?subject={1}", @"luckygoapp@gmail.com", Application.productName));//第二个参数是邮件的标题
        Application.OpenURL(uri.AbsoluteUri);
    }
    /// <summary>
    /// 去gp
    /// </summary>
    public void WetPeru()
    {
        LikeAPHerGallon();
    }
    private void LikeAPHerGallon()
    {
#if UNITY_ANDROID
        Application.OpenURL("market://details?id=" + appid);
#endif
#if UNITY_IOS
        var Air= string.Format(
            "itms-apps://itunes.apple.com/cn/app/id{0}?mt=8&action=write-review",
            Alter);
        Application.OpenURL(Air);
#endif
    }
}
