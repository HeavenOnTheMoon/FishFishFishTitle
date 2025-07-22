using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MustByAbsence : MonoBehaviour
{
    public static MustByAbsence instance;
[UnityEngine.Serialization.FormerlySerializedAs("appid")]
    public string Alter;

    private void Awake()
    {
        instance = this;
    }

    //获取IOS函数声明
#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void openRateUsUrl(string appId);
#endif

    public void WifeAPHerGallon()
    {
#if UNITY_ANDROID || UNITY_EDITOR
        Application.OpenURL("market://details?id=" + Alter);
#elif UNITY_IOS
        openRateUsUrl(appid);
#endif
    }
}
