using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHGloss
{
#if UNITY_ANDROID
    public static string BASE_URL = PHAbsence.Instance.Android_BASE_URL;  // 用户登录/注册相关接口的基础URL
    public static string BASE_URL_LOG = PHAbsence.Instance.Android_BASE_URL_LOG;  // 用户登录/注册相关接口的基础URL
#elif UNITY_IOS
    // 用户登录/注册相关接口的基础URL
    public static string BASE_URL
    {
        get { return PHAbsence.Instance.IOS_BASE_URL; }
    }  
    // 用户日志相关接口的基础URL
    public static string BASE_URL_LOG
    {
        get { return PHAbsence.Instance.IOS_BASE_URL_LOG; }
    }
#endif

}
