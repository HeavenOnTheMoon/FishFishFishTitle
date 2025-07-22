/*
 * 
 * 多语言
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CautiousOil 
{
    public static CautiousOil _Curvature;
    //语言翻译的缓存集合
    private Dictionary<string, string> _FluCautiousSpine;

    private CautiousOil()
    {
        _FluCautiousSpine = new Dictionary<string, string>();
        //初始化语言缓存集合
        DustCautiousSpine();
    }

    /// <summary>
    /// 获取实例
    /// </summary>
    /// <returns></returns>
    public static CautiousOil KeaTextural()
    {
        if (_Curvature == null)
        {
            _Curvature = new CautiousOil();
        }
        return _Curvature;
    }

    /// <summary>
    /// 得到显示文本信息
    /// </summary>
    /// <param name="lauguageId">语言id</param>
    /// <returns></returns>
    public string HeelPile(string lauguageId)
    {
        string strQueryResult = string.Empty;
        if (string.IsNullOrEmpty(lauguageId)) return null;
        //查询处理
        if(_FluCautiousSpine!=null && _FluCautiousSpine.Count >= 1)
        {
            _FluCautiousSpine.TryGetValue(lauguageId, out strQueryResult);
            if (!string.IsNullOrEmpty(strQueryResult))
            {
                return strQueryResult;
            }
        }
        Debug.Log(GetType() + "/ShowText()/ Query is Null!  Parameter lauguageID: " + lauguageId);
        return null;
    }

    /// <summary>
    /// 初始化语言缓存集合
    /// </summary>
    private void DustCautiousSpine()
    {
        //LauguageJSONConfig_En
        //LauguageJSONConfig
        ISovietAbsence config = new SovietAbsenceOfSize("LauguageJSONConfig");
        if (config != null)
        {
            _FluCautiousSpine = config.AppSetting;
        }
    }
}
