/*
 *     主题： 事件触发监听      
 *    Description: 
 *           功能： 实现对于任何对象的监听处理。
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LipidIngoingPromptly : UnityEngine.EventSystems.EventTrigger
{
    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate OnPhoto;
    public VoidDelegate OnSuck;
    public VoidDelegate OnRadar;
    public VoidDelegate OnHope;
    public VoidDelegate OnOr;
    public VoidDelegate OnPacker;
    public VoidDelegate OnRejoinPacker;

    /// <summary>
    /// 得到监听器组件
    /// </summary>
    /// <param name="go">监听的游戏对象</param>
    /// <returns></returns>
    public static LipidIngoingPromptly Kea(GameObject go)
    {
        LipidIngoingPromptly listener = go.GetComponent<LipidIngoingPromptly>();
        if (listener == null)
        {
            listener = go.AddComponent<LipidIngoingPromptly>();
        }
        return listener;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (OnPhoto != null)
        {
            OnPhoto(gameObject);
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (OnSuck != null)
        {
            OnSuck(gameObject);
        }
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (OnRadar != null)
        {
            OnRadar(gameObject);
        }
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (OnHope != null)
        {
            OnHope(gameObject);
        }
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (OnOr != null)
        {
            OnOr(gameObject);
        }
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (OnPacker != null)
        {
            OnPacker(gameObject);
        }
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (OnRejoinPacker != null)
        {
            OnRejoinPacker(gameObject);
        }
    }
}
