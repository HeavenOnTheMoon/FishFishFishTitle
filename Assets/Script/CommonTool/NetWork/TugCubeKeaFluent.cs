/***
 * 
 * 网络请求的get对象
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class TugCubeKeaFluent 
{
    //get的url
    public string Gem;
    //get成功的回调
    public Action<UnityWebRequest> KeaProdigy;
    //get失败的回调
    public Action KeaDrip;
    public TugCubeKeaFluent(string url,Action<UnityWebRequest> success,Action fail)
    {
        Gem = url;
        KeaProdigy = success;
        KeaDrip = fail;
    }
   
}
