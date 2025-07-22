/**
 * 
 * 支持上下滑动的scroll view
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuasarWall : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("itemCell")]    //预支单体
    public Suck GenuCell;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    //scrollview
    public ScrollRect TariffYard;
[UnityEngine.Serialization.FormerlySerializedAs("content")]
    //content
    public RectTransform Lineage;
[UnityEngine.Serialization.FormerlySerializedAs("spacing")]    //间隔
    public float Pacific= 10;
[UnityEngine.Serialization.FormerlySerializedAs("totalWidth")]    //总的宽
    public float StatePosit;
[UnityEngine.Serialization.FormerlySerializedAs("totalHeight")]    //总的高
    public float StateSponge;
[UnityEngine.Serialization.FormerlySerializedAs("visibleCount")]    //可见的数量
    public int GraniteStyle;
[UnityEngine.Serialization.FormerlySerializedAs("isClac")]    //初始数据完成是否检测计算
    public bool AnFoot= false;
[UnityEngine.Serialization.FormerlySerializedAs("startIndex")]    //开始的索引
    public int XenonBrace;
[UnityEngine.Serialization.FormerlySerializedAs("lastIndex")]    //结尾的索引
    public int WandBrace;
[UnityEngine.Serialization.FormerlySerializedAs("itemHeight")]    //item的高
    public float GenuSponge= 50;
[UnityEngine.Serialization.FormerlySerializedAs("itemList")]
    //缓存的itemlist
    public List<Suck> GenuForm;
[UnityEngine.Serialization.FormerlySerializedAs("visibleList")]    //可见的itemList
    public List<Suck> GraniteForm;
[UnityEngine.Serialization.FormerlySerializedAs("allList")]    //总共的dataList
    public List<int> RobForm;

    void Start()
    {
        StateSponge = this.GetComponent<RectTransform>().sizeDelta.y;
        StatePosit = this.GetComponent<RectTransform>().sizeDelta.x;
        Lineage = TariffYard.content;
        DustTwig();

    }
    //初始化
    public void DustTwig()
    {
        GraniteStyle = Mathf.CeilToInt(StateSponge / RareSponge) + 1;
        for (int i = 0; i < GraniteStyle; i++)
        {
            this.DamSuck();
        }
        XenonBrace = 0;
        WandBrace = 0;
        List<int> numberList = new List<int>();
        //数据长度
        int dataLength = 20;
        for (int i = 0; i < dataLength; i++)
        {
            numberList.Add(i);
        }
        SewTwig(numberList);
    }
    //设置数据
    void SewTwig(List<int> list)
    {
        RobForm = list;
        XenonBrace = 0;
        if (TwigStyle <= GraniteStyle)
        {
            WandBrace = TwigStyle;
        }
        else
        {
            WandBrace = GraniteStyle - 1;
        }
        //Debug.Log("ooooooooo"+lastIndex);
        for (int i = XenonBrace; i < WandBrace; i++)
        {
            Suck obj = PitSuck();
            if (obj == null)
            {
                Debug.Log("获取item为空");
            }
            else
            {
                obj.gameObject.name = i.ToString();

                obj.gameObject.SetActive(true);
                obj.transform.localPosition = new Vector3(0, -i * RareSponge, 0);
                GraniteForm.Add(obj);
                RejoinSuck(i, obj);
            }

        }
        Lineage.sizeDelta = new Vector2(StatePosit, TwigStyle * RareSponge - Pacific);
        AnFoot = true;
    }
    //更新item
    public void RejoinSuck(int index, Suck obj)
    {
        int d = RobForm[index];
        string str = d.ToString();
        obj.name = str;
        //更新数据 todo
    }
    //从itemlist中取出item
    public Suck PitSuck()
    {
        Suck obj = null;
        if (GenuForm.Count > 0)
        {
            obj = GenuForm[0];
            obj.gameObject.SetActive(true);
            GenuForm.RemoveAt(0);
        }
        else
        {
            Debug.Log("从缓存中取出的是空");
        }
        return obj;
    }
    //item进入itemlist
    public void WoodSuck(Suck obj)
    {
        GenuForm.Add(obj);
        obj.gameObject.SetActive(false);
    }
    public int TwigStyle    {
        get
        {
            return RobForm.Count;
        }
    }
    //每一行的高
    public float RareSponge    {
        get
        {
            return GenuSponge + Pacific;
        }
    }
    //添加item到缓存列表中
    public void DamSuck()
    {
        GameObject obj = Instantiate(GenuCell.gameObject);
        obj.transform.SetParent(Lineage);
        RectTransform Crew= obj.GetComponent<RectTransform>();
        Crew.anchorMin = new Vector2(0.5f, 1);
        Crew.anchorMax = new Vector2(0.5f, 1);
        Crew.pivot = new Vector2(0.5f, 1);
        obj.SetActive(false);
        obj.transform.localScale = Vector3.one;
        Suck o = obj.GetComponent<Suck>();
        GenuForm.Add(o);
    }



    void Update()
    {
        if (AnFoot)
        {
            Quasar();
        }
    }
    /// <summary>
    /// 计算滑动支持上下滑动
    /// </summary>
    void Quasar()
    {
        float vy = Lineage.anchoredPosition.y;
        float rollUpTop = (XenonBrace + 1) * RareSponge;
        float rollUnderTop = XenonBrace * RareSponge;

        if (vy > rollUpTop && WandBrace < TwigStyle)
        {
            //上边界移除
            if (GraniteForm.Count > 0)
            {
                Suck obj = GraniteForm[0];
                GraniteForm.RemoveAt(0);
                WoodSuck(obj);
            }
            XenonBrace++;
        }
        float rollUpBottom = (WandBrace - 1) * RareSponge - Pacific;
        if (vy < rollUpBottom - StateSponge && XenonBrace > 0)
        {
            //下边界减少
            WandBrace--;
            if (GraniteForm.Count > 0)
            {
                Suck obj = GraniteForm[GraniteForm.Count - 1];
                GraniteForm.RemoveAt(GraniteForm.Count - 1);
                WoodSuck(obj);
            }

        }
        float rollUnderBottom = WandBrace * RareSponge - Pacific;
        if (vy > rollUnderBottom - StateSponge && WandBrace < TwigStyle)
        {
            //Debug.Log("下边界增加"+vy);
            //下边界增加
            Suck go = PitSuck();
            GraniteForm.Add(go);
            go.transform.localPosition = new Vector3(0, -WandBrace * RareSponge);
            RejoinSuck(WandBrace, go);
            WandBrace++;
        }


        if (vy < rollUnderTop && XenonBrace > 0)
        {
            //Debug.Log("上边界增加"+vy);
            //上边界增加
            XenonBrace--;
            Suck go = PitSuck();
            GraniteForm.Insert(0, go);
            RejoinSuck(XenonBrace, go);
            go.transform.localPosition = new Vector3(0, -XenonBrace * RareSponge);
        }

    }
}
