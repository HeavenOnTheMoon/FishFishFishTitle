using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MailSuck : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("tileImage")]    public GameObject DeadMouse;
[UnityEngine.Serialization.FormerlySerializedAs("tileCash")]    public GameObject DeadSoar;
[UnityEngine.Serialization.FormerlySerializedAs("tileBlack")]    public GameObject DeadFifty;
[UnityEngine.Serialization.FormerlySerializedAs("data")]    public LevelItemData Luck;
[UnityEngine.Serialization.FormerlySerializedAs("move_speed")]    public float Weed_Lower= 15;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("isMoving")]    public bool AnNevada= false;
    Vector3 Wealth_Gel;
    Action Ethnic_Market;

    /// <summary>
    /// 设置层级
    /// </summary>
    /// <param name="layerName"></param>
    /// <param name="layerInt"></param>
    public void WetWorth(string layerName,int layerInt)
    {
        GetComponent<SpriteRenderer>().sortingLayerName = layerName;
        GetComponent<SpriteRenderer>().sortingOrder = layerInt;
        DeadMouse.GetComponent<SpriteRenderer>().sortingLayerName = layerName;
        DeadMouse.GetComponent<SpriteRenderer>().sortingOrder = layerInt + 1;
        DeadFifty.GetComponent<SpriteRenderer>().sortingLayerName = layerName;
        DeadFifty.GetComponent<SpriteRenderer>().sortingOrder = layerInt + 3;
        DeadSoar.GetComponent<SpriteRenderer>().sortingLayerName = layerName;
        DeadSoar.GetComponent<SpriteRenderer>().sortingOrder = layerInt + 2;
    }
    /// <summary>
    /// 根据对应层级显示遮罩
    /// </summary>
    /// <param name="diff_layer"></param>
    public void PrepayWoman(int diff_layer)
    {
        if (diff_layer == 0)
        {
            DeadFifty.SetActive(false);
        }
        else
        {
            DeadFifty.SetActive(true);
        }
    }
    /// <summary>
    /// 设置图片
    /// </summary>
    /// <param name="index"></param>
    public void WetMailMouse(int index)
    {
        DeadMouse.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(CSoviet.TMailBellLack + index);
    }

    public void DeadGiveAt(Vector2 targetPos,Action finish)
    {
        if (targetPos.y == transform.position.y)
        {
            Weed_Lower = 15;
        }
        else
        {
            Weed_Lower = 10;
        }
        //Debug.Log(targetPos);
        Wealth_Gel = targetPos;
        Ethnic_Market = finish;
        AnNevada = true;
    }

    void Update()
    {
        if (AnNevada)
        {
            Vector3 moveV2 = (Wealth_Gel - transform.position).normalized;
            if (Mathf.Abs((Wealth_Gel - transform.position).magnitude) < Mathf.Abs((moveV2 * Time.deltaTime * Weed_Lower).magnitude) || moveV2.magnitude == 0)
            {
                transform.position = Wealth_Gel;
                AnNevada = false;
                Ethnic_Market();
            }
            else
            {
                transform.position += moveV2 * Time.deltaTime * Weed_Lower;
                
            }
        }
    }
}
