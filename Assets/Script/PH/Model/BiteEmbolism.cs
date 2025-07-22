using LitJson;

/// <summary>
/// HTTP响应封装类
/// </summary>
public class BiteEmbolism
{
    public long StatusCode { get; set; }
    public string ErrorMessage { get; set; }
    public string Data { get; set; }
    public bool IsSuccess { get; set; }

    public T GetData<T>() where T : class
    {
        //Debug.Log($"BiteEmbolism Data: {Data}");
        if (string.IsNullOrEmpty(Data)) return null;
        try
        {
            return JsonMapper.ToObject<T>(Data);
        }
        catch
        {
            return null;
        }
    }
}

public class HttpResponseData<T>
{
    public int code;
    public string message;
    public T data;
    public string timestamp;
}

public class RewardEventLogModel
{
    public string eventCode;    // 事件编码
    public string recordCode;   // UUID
    public string signature;    // 签名

    public RewardEventLogModel(string eventCode)
    {
        this.eventCode = eventCode;
        this.recordCode = PHTide.KeaUUID().Replace("-", "");
        string sourceStr = DailyPool.Textural.GlueTour.pre + eventCode + recordCode + "gamebox";
        this.signature = PHTide.InnovatorMD5(sourceStr);
    }
}

public class RewardEventLogResponseData
{
    public int coin;
    public int coinOld;
}