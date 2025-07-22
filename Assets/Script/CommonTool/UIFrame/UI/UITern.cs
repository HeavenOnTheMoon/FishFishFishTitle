/// <summary>
/// 窗体类型 （引用窗体的重要属性[枚举类型]）
/// </summary>
using System;
using UnityEngine;
[Serializable]
public class UITern 
{

    
    /// <summary>
    /// 是否需要清空反向切换
    /// </summary>
    [HideInInspector]
    public bool ByPeachProcessFaucet= false;
    /// <summary>
    /// ui窗体类型   
    /// </summary>
    public UIFormType UIDrape_Tern= UIFormType.Normal;
    /// <summary>
    /// ui窗体显示类型
    /// </summary>
    public UIFormShowMode UIWish_HeelSnap= UIFormShowMode.Normal;
    /// <summary>
    /// ui窗体透明度类型
    /// </summary>
    public UIFormLucenyType UIWish_ImpressTern= UIFormLucenyType.Translucence;
    /// <summary>
    /// 
    /// </summary>
    public UIFormShowAnimationType UIWish_IntensityTern= UIFormShowAnimationType.scale;
}
