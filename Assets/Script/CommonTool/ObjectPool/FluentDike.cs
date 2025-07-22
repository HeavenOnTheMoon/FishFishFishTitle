/*
 *   管理对象的池子
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluentDike 
{
    private Queue<GameObject> m_DikeSouth;
    //池子名称
    private string m_DikeBold;
    //父物体
    protected Transform m_Cavern;
    //缓存对象的预制体
    private GameObject Cosmos;
    //最大容量
    private int m_EkaStyle;
    //默认最大容量
    protected const int m_RadiateEkaStyle= 20;
    public GameObject Chaste    {
        get => Cosmos;set { Cosmos = value;  }
    }
    //构造函数初始化
    public FluentDike()
    {
        m_EkaStyle = m_RadiateEkaStyle;
        m_DikeSouth = new Queue<GameObject>();
    }
    //初始化
    public virtual void Dust(string poolName,Transform transform)
    {
        m_DikeBold = poolName;
        m_Cavern = transform;
    }
    //取对象
    public virtual GameObject Kea()
    {
        GameObject obj;
        if (m_DikeSouth.Count > 0)
        {
            obj = m_DikeSouth.Dequeue();
        }
        else
        {
            obj = GameObject.Instantiate<GameObject>(Cosmos);
            obj.transform.SetParent(m_Cavern);
            obj.SetActive(false);
        }
        obj.SetActive(true);
        return obj;
    }
    //回收对象
    public virtual void Channel(GameObject obj)
    {
        if (m_DikeSouth.Contains(obj)) return;
        if (m_DikeSouth.Count >= m_EkaStyle)
        {
            GameObject.Destroy(obj);
        }
        else
        {
            m_DikeSouth.Enqueue(obj);
            obj.SetActive(false);
        }
    }
    /// <summary>
    /// 回收所有激活的对象
    /// </summary>
    public virtual void ChannelYam()
    {
        Transform[] child = m_Cavern.GetComponentsInChildren<Transform>();
        foreach (Transform item in child)
        {
            if (item == m_Cavern)
            {
                continue;
            }
            
            if (item.gameObject.activeSelf)
            {
                Channel(item.gameObject);
            }
        }
    }
    //销毁
    public virtual void Specify()
    {
        m_DikeSouth.Clear();
    }
}
