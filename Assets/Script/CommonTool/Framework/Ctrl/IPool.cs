﻿using LitJson;
using System.Collections;
using System.Collections.Generic;

public interface IPool
{
    /// <summary>
    /// 初始化存档数据
    /// </summary>
    /// <param name="data"></param>
    public void Dust(JsonData data);

    /// <summary>
    /// 序列化需要存档的数据
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, object> KeaResonanceTwig();
}
