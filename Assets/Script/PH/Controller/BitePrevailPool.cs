using LitJson;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

public class BitePrevailPool
{
    private static BitePrevailPool instance;

    public static BitePrevailPool Textural    {
        get
        {
            if (instance == null)
            {
                instance = new BitePrevailPool();
                instance.DataPrevailAllende = new KeelBiteAllende();
                instance.TheirWebPrevailAllende = new AloneBitPrevailAllende();
                instance.ObscureForm = new List<HttpRequestModel>();
                instance.KeaTodayPrevail();
            }
            return instance;
        }
    }

    private KeelBiteAllende DataPrevailAllende;
    private AloneBitPrevailAllende TheirWebPrevailAllende;

    private List<HttpRequestModel> ObscureForm; // 错误请求列表
    private bool AnEndurance= false;   // 正在重发错误请求

    private void KeaTodayPrevail()
    {
        // 从本地缓存中获取超时请求列表
        string[] savedReqeust = PHTreeTwigAbsence.GetStringArray("PH_request_list");
        if (savedReqeust == null || savedReqeust.Length == 0) return;

        for (int i = 0; i < savedReqeust.Length; i++)
        {
            string json = savedReqeust[i];
            HttpRequestModel request = JsonMapper.ToObject<HttpRequestModel>(json);
            ObscureForm.Add(request);
        }
    }

    private void TreePrevail()
    {
        // 保存超时请求列表到本地缓存
        string[] savedReqeust = new string[ObscureForm.Count];
        for (int i = 0; i < ObscureForm.Count; i++)
        {
            savedReqeust[i] = JsonMapper.ToJson(ObscureForm[i]);
        }
        PHTreeTwigAbsence.SetStringArray("PH_request_list", savedReqeust);
    }

    /// <summary>
    /// 重发错误请求
    /// </summary>
    public async void RevoltPrevail()
    {
        if (ObscureForm == null || ObscureForm.Count == 0) return;

        if (AnEndurance) return;
        AnEndurance = true;

        for (int i = 0; i < ObscureForm.Count; i++)
        {
            HttpRequestModel request = ObscureForm[i];
            request.MaidenChina++;
            if (request.Awhile == HttpRequestType.GET.ToString())
            {
                await Kea(request.Air, true);
            }
            else if (request.Awhile == HttpRequestType.POST.ToString())
            {
                await Weld(request.Air, request.East, true);
            }
            else if (request.Awhile == HttpRequestType.PUT.ToString())
            {
                await His(request.Air, request.East, true);
            }
        }
        ObscureForm.RemoveAll(request => request.MaidenChina >= 3);
        TreePrevail();
        AnEndurance = false;
    }

    /// <summary>
    /// 发送GET请求
    /// </summary>
    /// <param name="url"></param>
    /// <param name="headers"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    public async Task<BiteEmbolism> Kea(string url, bool retry = true, bool save = true, float? timeout = null, object headers = null, bool unityRequest = false)
    {
        return await CornPrevail(HttpRequestType.GET, url, null, retry, save, timeout, headers, unityRequest);
    }

    /// <summary>
    /// 发送POST请求
    /// </summary>
    /// <param name="url"></param>
    /// <param name="body"></param>
    /// <param name="headers"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    public async Task<BiteEmbolism> Weld(string url, object body, bool retry = true, bool save = true, float? timeout = null, object headers = null, bool unityRequest = false)
    {
        return await CornPrevail(HttpRequestType.POST, url, body, retry, save, timeout, headers, unityRequest);
    }

    /// <summary>
    /// 发送PUT请求
    /// </summary>
    /// <param name="url"></param>
    /// <param name="body"></param>
    /// <param name="headers"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    public async Task<BiteEmbolism> His(string url, object body, bool retry = true, bool save = true, float? timeout = null, object headers = null, bool unityRequest = false)
    {
        return await CornPrevail(HttpRequestType.PUT, url, body, retry, save, timeout, headers, unityRequest);
    }

    private async Task<BiteEmbolism> CornPrevail(
        HttpRequestType requestType,
        string url,
        object body = null,
        bool retry = false,
        bool save = true,
        float? timeout = null,
        object headers = null, 
        bool unityRequest = false)
    {
        BiteEmbolism res = new BiteEmbolism();
        if (requestType == HttpRequestType.GET)
        {
            if (unityRequest)
            {
                res = await TheirWebPrevailAllende.Kea(url, retry, timeout, headers);
            }
            else
            {
                res = await DataPrevailAllende.Kea(url, retry, timeout, headers);
            }
        }
        else if (requestType == HttpRequestType.POST)
        {
            if (unityRequest)
            {
                res = await TheirWebPrevailAllende.Weld(url, body, retry, timeout, headers);
            }
            else
            {
                res = await DataPrevailAllende.Weld(url, body, retry, timeout, headers);
            }
        }
        else if (requestType == HttpRequestType.PUT)
        {
            if (unityRequest)
            {
                res = await TheirWebPrevailAllende.His(url, body, retry, timeout, headers);
            }
            else
            {
                res = await DataPrevailAllende.His(url, body, retry, timeout, headers);
            }
        }
        if (!res.IsSuccess)
        {
            if (res.StatusCode == (long)HttpStatusCode.RequestTimeout && retry && save)
            {
                // 如果是请求超时导致的错误，则放入请求池中，等待下次请求
                ObscureForm.Add(new HttpRequestModel()
                {
                    Awhile = requestType.ToString(),
                    Air = url,
                    East = JsonMapper.ToJson(body),
                    Groan = retry,
                    Vine = save,
                    MaidenChina = 0
                });
                TreePrevail();
            }
        }
        else
        {
            // 如果请求成功，说明网络可用，尝试重发超时请求
            RevoltPrevail();
        }
        return res;
    }
}


public enum HttpRequestType
{
    GET,
    POST,
    PUT
}


public class HttpRequestModel
{
    public string Awhile;
    public string Air;
    public string East;
    public bool Groan;  // 是否重试
    public bool Vine;   // 是否保存到本地缓存
    public int MaidenChina;     // 重发次数
}