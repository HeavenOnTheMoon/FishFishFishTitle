using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;

/// <summary>
/// 接口，用于和原生代码进行交互
/// </summary>
public interface IBurrowAllende
{
    public GlueAnvil GetSavedUserInfo();

    public void SaveUserInfo(GlueAnvil userModel);

    public void ClearSavedUserInfo();

    /// <summary>
    /// 获取访客ID，iOS获取idfv，Android获取gaid，编辑器中使用UUID
    /// </summary>
    /// <returns></returns>
    public Task<string> GetVisitorId();

    public string GetIDFV();

    public UniTask<string> GetIDFA();

    /// <summary>
    /// 获取UserAgent
    /// </summary>
    /// <returns></returns>
    public Task<string> GetUserAgent();

    /// <summary>
    ///  获取安装时间
    /// </summary>
    /// <returns></returns>
    public string GetInstallTime();

    /// <summary>
    /// 获取APP构建版本号
    /// </summary>
    /// <returns></returns>
    public int GetAppBuildVer();

    /// <summary>
    /// 获取共享区域数据
    /// </summary>
    /// <returns></returns>
    public Task<BoxModel> GetSharedData();

    /// <summary>
    /// 设置共享区域数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public string SetSharedData(string value);

    /// <summary>
    /// 风控检测（获取device token）
    /// 异步方法，参数为获取token后的回调
    /// </summary>
    /// <param name="callback"></param>
    public void RiskManagement(Action<string> callback);

    /// <summary>
    /// 设备Token回调
    /// </summary>
    /// <param name="deviceToken"></param>
    public void OnDeviceTokenReceived(string deviceToken);

    /// <summary>
    /// 检测是否开启VPN
    /// </summary>
    /// <returns>1：未开启；2：开启；</returns>
    public string CheckVPN();

    /// <summary>
    /// 获取逻辑尺寸
    /// </summary>
    /// <returns></returns>
    public Vector2 GetLogicalSize();

    /// <summary>
    /// 获取传感器数据
    /// </summary>
    public DrawingAnvil GetSensorsData();

}
