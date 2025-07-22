/***
 * 
 * 
 * 网络信息控制
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Runtime.InteropServices;
using Unity.VisualScripting.FullSerializer;
//using MoreMountains.NiceVibrations;

public class TugTourOil : MonoBehaviour
{
    public static TugTourOil instance;
[UnityEngine.Serialization.FormerlySerializedAs("NetServerData")]   
    public UnwaryTwig NetUnwaryTwig;
[UnityEngine.Serialization.FormerlySerializedAs("InitData")]    public Init DustTwig;
[UnityEngine.Serialization.FormerlySerializedAs("gameData")]    public GameData AnewTwig;
[UnityEngine.Serialization.FormerlySerializedAs("gameFlyData")]    public FlyBubble AnewTowTwig;
[UnityEngine.Serialization.FormerlySerializedAs("flyreward")]    public KeyValuesUpdate Supervise;
[UnityEngine.Serialization.FormerlySerializedAs("ConfigData")]   
    //服务器Config数据
    public UnwaryTwig SovietTwig;

    void Awake()
    {
        //PlayerPrefs.DeleteAll();
        instance = this;
        
    }
    private void Start()
    {

    }

    
    public void KeaReindeerTwig()
    {
        RootData rootData;
        
        Debug.Log("本地网络数据");
        TextAsset json = Resources.Load<TextAsset>("LocationJson/LocationData");
        rootData = JsonMapper.ToObject<RootData>(json.text);
       
        if (NetUnwaryTwig == null)
        {
            Debug.Log("使用本地数据");
            NetUnwaryTwig = rootData.data;
            DustTwig = JsonMapper.ToObject<Init>(NetUnwaryTwig.init);
            KeaSeemTwig();
        }

    }
    void KeaSeemTwig()
    {
        string Air= "LocationJson/GameData";//这里必须加后缀，不加报错
        TextAsset json  = Resources.Load<TextAsset>(Air);
        AnewTwig = JsonMapper.ToObject<GameData>(json.text);
        FlyBubbleCfg flyBubbleCfg = JsonMapper.ToObject<FlyBubbleCfg>(NetUnwaryTwig.game_data);
        AnewTowTwig = flyBubbleCfg.fly_bubble_config;
    }
   

    public static bool ByRefuge()
    {
#if UNITY_EDITOR
        return true;
#else
            return false;
#endif
    }

}
