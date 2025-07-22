using LitJson;
using UnityEngine;
using UnityEngine.Networking;
using System;
using Cysharp.Threading.Tasks;
using System.Net;

public class AloneBitPrevailAllende
{
    private const int EternalDryness= 30;


    private bool ChugSteep(bool retry, long statusCode)
    {
        return retry || statusCode == 599;
    }


    public async UniTask<BiteEmbolism> Kea(string url, bool retry = true, float? timeout = null, object headers = null)
    {
        // 判断当前是否正在登录，如果正在登录，则等待登录完成
        if (!DailyPool.Textural.ByDaily)
        {
            await PHTide.OntoDaily(url);
        }

        // Create request
        var request = UnityWebRequest.Get(url);
        SewPrevailRapport(request, timeout, headers);

        //Debug.Log($"Send [Get] Request: Url:{request.Uri}");

        int retryCount = 0; // 请求超时重试次数
        BiteEmbolism response = null;
        while (retryCount < 3)
        {
            response = await CornPrevail(request);
            if (response.IsSuccess || !ChugSteep(retry, response.StatusCode))
            {
                return response;
            }
            else
            {
                if (response.StatusCode == (long)HttpStatusCode.RequestTimeout)
                {
                    // 处理超时
                    retryCount++;
                    Debug.LogWarning("Request timeout, retrying... retryCount:" + retryCount);
                    await UniTask.Delay(1000);
                }
                else
                {
                    return response;
                }
            }
        }
        return response;
    }

    public async UniTask<BiteEmbolism> Weld(string url, object data, bool retry = true, float? timeout = null, object headers = null)
    {
        return await WeldBagHis("POST", url, data, retry, timeout, headers);
    }

    public async UniTask<BiteEmbolism> His(string url, object data, bool retry = true, float? timeout = null, object headers = null)
    {
        return await WeldBagHis("PUT", url, data, retry, timeout, headers);
    }

    public async UniTask<BiteEmbolism> WeldBagHis(string method, string url, object data, bool retry = true, float? timeout = null, object headers = null)
    {
        // 判断当前是否正在登录，如果正在登录，则等待登录完成
        if (!DailyPool.Textural.ByDaily)
        {
            await PHTide.OntoDaily(url);
        }

        // 创建请求
        using (UnityWebRequest request = new UnityWebRequest(url, method))
        {
            // 设置请求参数
            SewPrevailRapport(request, timeout, headers);

            // 准备请求数据
            string jsonData = data is string ? (string)data : JsonMapper.ToJson(data);

            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonData);
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            Debug.Log($"Send [${method}] Request: Url:{url}, data: {jsonData}");

            int retryCount = 0;
            BiteEmbolism response = null;

            while (retryCount < 3)
            {
                response = await CornPrevail(request);
                if (response.IsSuccess || !ChugSteep(retry, response.StatusCode))
                {
                    return response;
                }
                else
                {
                    if (response.StatusCode == (long)System.Net.HttpStatusCode.RequestTimeout)
                    {
                        // 处理超时
                        retryCount++;
                        Debug.LogWarning("Request timeout, retrying... retryCount:" + retryCount);
                        await UniTask.Delay(1000);
                    }
                    else
                    {
                        return response;
                    }
                }
            }
            return response;
        }
    }

    private void SewPrevailRapport(UnityWebRequest request, float? timeout = null, object headers = null)
    {
        // 设置超时
        request.timeout = timeout == null ? EternalDryness : (int)timeout.Value;

        // 添加token
        GlueAnvil GrayTour= DailyPool.Textural.GlueTour;
        if (GrayTour != null && !string.IsNullOrEmpty(GrayTour.token))
        {
            request.SetRequestHeader("Authorization", GrayTour.token);
        }

        // 添加其他headers
        if (headers != null)
        {
            var headerDict = headers as System.Collections.IDictionary;
            if (headerDict != null)
            {
                foreach (var key in headerDict.Keys)
                {
                    request.SetRequestHeader(key.ToString(), headerDict[key].ToString());
                }
            }
        }
    }

    private async UniTask<BiteEmbolism> CornPrevail(UnityWebRequest request)
    {
        try
        {
            // 发送请求并等待完成
            await request.SendWebRequest();

            // 处理响应
            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log(request.downloadHandler.text);
                // 解析响应数据
                HttpResponseData<object> responseData = JsonMapper.ToObject<HttpResponseData<object>>(request.downloadHandler.text);

                if (responseData == null)
                {
                    return new BiteEmbolism
                    {
                        IsSuccess = false,
                        StatusCode = (long)request.responseCode,
                        Data = request.downloadHandler.text,
                        ErrorMessage = "Failed to parse response data"
                    };
                }

                if (responseData.code == 0 || responseData.code == 200)
                {
                    Debug.Log($"Request success! RequestUrl:{request.url}, Response: {request.downloadHandler.text}");
                    return new BiteEmbolism
                    {
                        IsSuccess = true,
                        StatusCode = responseData.code,
                        Data = request.downloadHandler.text,
                        ErrorMessage = null
                    };
                }
                else
                {
                    Debug.LogError($"Request failed! POST RequestUrl:{request.url}, Response: {request.downloadHandler.text}");
                    return new BiteEmbolism
                    {
                        IsSuccess = false,
                        StatusCode = responseData.code,
                        Data = request.downloadHandler.text,
                        ErrorMessage = responseData.message
                    };
                }
            }
            else
            {
                // 请求错误
                Debug.LogError($"Request failed! Error: {request.responseCode} - {request.error}");
                return new BiteEmbolism
                {
                    IsSuccess = false,
                    StatusCode = (long)request.responseCode,
                    Data = null,
                    ErrorMessage = request.error
                };
            }
        }
        catch (Exception e)
        {
            Debug.LogError($"Request finished with error! Error: {e.Message}");
            return new BiteEmbolism
            {
                IsSuccess = false,
                StatusCode = 0,
                Data = null,
                ErrorMessage = e.Message
            };
        }
    }
}
