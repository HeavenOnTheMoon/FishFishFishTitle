using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 消息管理器
/// </summary>
public class HandfulCannonForth:WellSweatshop<HandfulCannonForth>
{
    //保存所有消息事件的字典
    //key使用字符串保存消息的名称
    //value使用一个带自定义参数的事件，用来调用所有注册的消息
    private Dictionary<string, Action<HandfulTwig>> StabilizerHandful;

    /// <summary>
    /// 私有构造函数
    /// </summary>
    private HandfulCannonForth()
    {
        DustTwig();
    }

    private void DustTwig()
    {
        //初始化消息字典
        StabilizerHandful = new Dictionary<string, Action<HandfulTwig>>();
    }

    /// <summary>

    /// 注册消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Computer(string key, Action<HandfulTwig> action)
    {
        if (!StabilizerHandful.ContainsKey(key))
        {
            StabilizerHandful.Add(key, null);
        }
        StabilizerHandful[key] += action;
    }



    /// <summary>
    /// 注销消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Answer(string key, Action<HandfulTwig> action)
    {
        if (StabilizerHandful.ContainsKey(key) && StabilizerHandful[key] != null)
        {
            StabilizerHandful[key] -= action;
        }
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="data">消息传递数据，可以不传</param>
    public void Corn(string key, HandfulTwig data = null)
    {
        if (StabilizerHandful.ContainsKey(key) && StabilizerHandful[key] != null)
        {
            StabilizerHandful[key](data);
        }
    }

    /// <summary>
    /// 清空所有消息
    /// </summary>
    public void Peach()
    {
        StabilizerHandful.Clear();
    }
}
