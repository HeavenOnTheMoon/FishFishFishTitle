/*
 * 
 *  管理多个对象池的管理类
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class FluentDikeAbsence : WellSweatshop<FluentDikeAbsence>
{
    //管理objectpool的字典
    private Dictionary<string, FluentDike> m_DikeFlu;
    private Transform m_AbutPrejudice=null;
    //构造函数
    public FluentDikeAbsence()
    {
        m_DikeFlu = new Dictionary<string, FluentDike>();      
    }
    
    //创建一个新的对象池
    public T AbsorbFluentDike<T>(string poolName) where T : FluentDike, new()
    {
        if (m_DikeFlu.ContainsKey(poolName))
        {
            return m_DikeFlu[poolName] as T;
        }
        if (m_AbutPrejudice == null)
        {
            m_AbutPrejudice = this.transform;
        }      
        GameObject obj = new GameObject(poolName);
        obj.transform.SetParent(m_AbutPrejudice);
        T pool = new T();
        pool.Dust(poolName, obj.transform);
        m_DikeFlu.Add(poolName, pool);
        return pool;
    }
    //取对象
    public GameObject KeaSeemFluent(string poolName)
    {
        if (m_DikeFlu.ContainsKey(poolName))
        {
            return m_DikeFlu[poolName].Kea();
        }
        return null;
    }
    //回收对象
    public void ChannelSeemFluent(string poolName,GameObject go)
    {
        if (m_DikeFlu.ContainsKey(poolName))
        {
            m_DikeFlu[poolName].Channel(go);
        }
    }
    //销毁所有的对象池
    public void OnDestroy()
    {
        m_DikeFlu.Clear();
        GameObject.Destroy(m_AbutPrejudice);
    }
    /// <summary>
    /// 查询是否有该对象池
    /// </summary>
    /// <param name="poolName"></param>
    /// <returns></returns>
    public bool QueryDike(string poolName)
    {
        return m_DikeFlu.ContainsKey(poolName) ? true : false;
    }
}
