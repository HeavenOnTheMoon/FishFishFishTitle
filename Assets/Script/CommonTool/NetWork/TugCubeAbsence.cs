/**
 * 
 * 网络请求管理器
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TugCubeAbsence : WellSweatshop<TugCubeAbsence>
{
    //get请求列表
    private List<TugCubeKeaFluent> TugWorkKeaForm;
    //post请求列表
    private List<TugCubeWeldFluent> TugCubeWeldForm;
    public TugCubeAbsence()
    {
        //初始化
        TugWorkKeaForm = new List<TugCubeKeaFluent>();
        TugCubeWeldForm = new List<TugCubeWeldFluent>();
    }

    /// <summary>
    /// 获取当前Get请求列表中请求的个数
    /// </summary>
    public int KeaTugCubeKeaFormStyle{
        get { return TugWorkKeaForm.Count; }
    }

    /// <summary>
    /// 获取当前Post请求列表中请求的个数
    /// </summary>
    public int KeaTugCubeWeldFormStyle    {
        get { return TugCubeWeldForm.Count; }
    }

    /// <summary>
    /// Get请求
    /// </summary>
    /// <param name="url">Get请求的URL</param>
    /// <param name="success">Get请求成功的回调</param>
    /// <param name="fail">Get请求失败的回调</param>
    public void BiteKea(string url,Action<UnityWebRequest> success,Action fail)
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.Log("HttpGet请求URL地址不能为空");
            return;
        }
        TugCubeKeaFluent o = new TugCubeKeaFluent(url, success, fail);
        //添加到管理列表中
        TugWorkKeaForm.Add(o);
        //开始请求
       StartCoroutine(nameof(Kea), o);
    }

    /// <summary>
    /// Post请求
    /// </summary>
    /// <param name="url">Post请求的URL</param>
    /// <param name="form">Post请求的表单数据</param>
    /// <param name="success">Post请求成功的回调</param>
    /// <param name="fail">Post请求失败的回调</param>
    public void BiteWeld(string url,WWWForm form, Action<UnityWebRequest> success,Action fail)
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.Log("HttpPost请求URL地址不能为空");
            return;
        }
        TugCubeWeldFluent o = new TugCubeWeldFluent(url, form, success, fail);
        //添加到post请求管理列表中
        TugCubeWeldForm.Add(o);
        //开始请求
        StartCoroutine(nameof(Weld), o);
    }

    /// <summary>
    /// Get请求的协程
    /// </summary>
    /// <param name="obj">Get请求对象</param>
    /// <returns></returns>
    IEnumerator Kea(TugCubeKeaFluent obj)
    {
        using UnityWebRequest webRequest = UnityWebRequest.Get(obj.Gem);
        webRequest.SendWebRequest();
        while (!webRequest.isDone)
        {
            yield return 1;
        }
        if (webRequest.isDone)
        {
            //从管理列表中移除
            if (TugWorkKeaForm.Contains(obj))
            {
                TugWorkKeaForm.Remove(obj);
            }
        }
        //yield return webRequest.SendWebRequest();
        //异常处理,请求失败
        if (webRequest.isHttpError || webRequest.isNetworkError)
        {
            Debug.Log("请求"+ obj.Gem+"失败，错误："+webRequest.error);
            obj.KeaDrip();
        }else
        {
            //Debug.Log(webRequest.downloadHandler.text);
            obj.KeaProdigy(webRequest);
        }      
        //终止本次协程
        yield break;
    }



    /// <summary>
    /// Post协程
    /// </summary>
    /// <returns></returns>
    IEnumerator Weld(TugCubeWeldFluent obj)
    {
        //WWWForm form = new WWWForm();
        ////键值对
        //form.AddField("key", "value");
        //form.AddField("name", "mafanwei");
        //form.AddField("blog", "qwe25878");

        using UnityWebRequest webRequest = UnityWebRequest.Post(obj.URL, obj.Wish);

        yield return webRequest.SendWebRequest();
        //异常处理
        if (webRequest.isHttpError || webRequest.isNetworkError)
        {
            Debug.Log("Post请求"+obj.URL+"失败，错误："+webRequest.error);
            obj.WeldDrip();
        } else
        {
            obj.WeldProdigy(webRequest);
            //Debug.Log(webRequest.downloadHandler.text);
        }

        //从管理列表中移除
        if (TugCubeWeldForm.Contains(obj))
        {
            TugCubeWeldForm.Remove(obj);
        }
        //终止本次协程
        yield break;
    }
}
