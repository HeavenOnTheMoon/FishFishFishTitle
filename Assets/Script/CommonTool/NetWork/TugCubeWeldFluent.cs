/**
 * 
 * 网络请求的post对象
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class TugCubeWeldFluent 
{
    //post请求地址
    public string URL;
    //post的数据表单
    public WWWForm Wish;
    //post成功回调
    public Action<UnityWebRequest> WeldProdigy;
    //post失败回调
    public Action WeldDrip;
    public TugCubeWeldFluent(string url,WWWForm  form,Action<UnityWebRequest> success,Action fail)
    {
        URL = url;
        Wish = form;
        WeldProdigy = success;
        WeldDrip = fail;
    }
}
