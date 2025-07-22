/**
 * 
 * 左右滑动的页面视图
 * 
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class EmitWall : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("rect")]    //scrollview
    public ScrollRect Crew;
    //求出每页的临界角，页索引从0开始
    List<float> GelForm= new List<float>();
[UnityEngine.Serialization.FormerlySerializedAs("isDrag")]    //是否拖拽结束
    public bool AnPose= false;
    bool StemGive= true;
    //滑动的起始坐标  
    float WealthBitterness= 0;
    float XenonPoseBitterness;
    float XenonPloy= 0f;
[UnityEngine.Serialization.FormerlySerializedAs("smooting")]    //滑动速度  
    public float Enormous= 1f;
[UnityEngine.Serialization.FormerlySerializedAs("sensitivity")]    public float Nonetheless= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("OnPageChange")]    //页面改变
    public Action<int> OnEmitFaucet;
    //当前页面下标
    int SeaportEmitBrace= -1;
    void Start()
    {
        Crew = this.GetComponent<ScrollRect>();
        float horizontalLength = Crew.content.rect.width - this.GetComponent<RectTransform>().rect.width;
        GelForm.Add(0);
        for(int i = 1; i < Crew.content.childCount - 1; i++)
        {
            GelForm.Add(GetComponent<RectTransform>().rect.width * i / horizontalLength);
        }
        GelForm.Add(1);
    }

    
    void Update()
    {
        if(!AnPose && !StemGive)
        {
            XenonPloy += Time.deltaTime;
            float t = XenonPloy * Enormous;
            Crew.horizontalNormalizedPosition = Mathf.Lerp(Crew.horizontalNormalizedPosition, WealthBitterness, t);
            if (t >= 1)
            {
                StemGive = true;
            }
        }
        
    }
    /// <summary>
    /// 设置页面的index下标
    /// </summary>
    /// <param name="index"></param>
    void SewEmitBrace(int index)
    {
        if (SeaportEmitBrace != index)
        {
            SeaportEmitBrace = index;
            if (OnEmitFaucet != null)
            {
                OnEmitFaucet(index);
            }
        }
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        AnPose = true;
        XenonPoseBitterness = Crew.horizontalNormalizedPosition;
    }
    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        float posX = Crew.horizontalNormalizedPosition;
        posX += ((posX - XenonPoseBitterness) * Nonetheless);
        posX = posX < 1 ? posX : 1;
        posX = posX > 0 ? posX : 0;
        int Calve= 0;
        float offset = Mathf.Abs(GelForm[Calve] - posX);
        for(int i = 0; i < GelForm.Count; i++)
        {
            float temp = Mathf.Abs(GelForm[i] - posX);
            if (temp < offset)
            {
                Calve = i;
                offset = temp;
            }
        }
        SewEmitBrace(Calve);
        WealthBitterness = GelForm[Calve];
        AnPose = false;
        XenonPloy = 0f;
        StemGive = false;
    }
}
