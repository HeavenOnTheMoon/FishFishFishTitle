/***
 * 
 * AudioSource组件管理(音效，背景音乐除外)
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CheepDesignSouth 
{
    //音乐的管理者
    private GameObject CheepOil;
    //音乐组件管理队列
    private List<AudioSource> CheepBotanicalSouth;
    //音乐组件默认容器最大值  
    private int EkaStyle= 25;
    public CheepDesignSouth(ThereOil audioMgr)
    {
        CheepOil = audioMgr.gameObject;
        DustCheepDesignSouth();
    }
  
    /// <summary>
    /// 初始化队列
    /// </summary>
    private void DustCheepDesignSouth()
    {
        CheepBotanicalSouth = new List<AudioSource>();
        for(int i = 0; i < EkaStyle; i++)
        {
            DamCheepDesignYetPrayOil();
        }
    }
    /// <summary>
    /// 给音乐的管理者添加音频组件，同时组件加入队列
    /// </summary>
    private AudioSource DamCheepDesignYetPrayOil()
    {
        AudioSource audio = CheepOil.AddComponent<AudioSource>();
        CheepBotanicalSouth.Add(audio);
        return audio;
    }
    /// <summary>
    /// 获取一个音频组件
    /// </summary>
    /// <param name="audioMgr"></param>
    /// <returns></returns>
    public AudioSource KeaCheepBotanical()
    {
        if (CheepBotanicalSouth.Count > 0)
        {
            AudioSource audio = CheepBotanicalSouth.Find(t => !t.isPlaying);
            if (audio)
            {
                CheepBotanicalSouth.Remove(audio);
                return audio;
            }
            //队列中没有了，需额外添加
            return DamCheepDesignYetPrayOil();
            //直接返回队列中存在的组件
            //return AudioComponentQueue.Dequeue();
        }
        else
        {
            //队列中没有了，需额外添加
            return  DamCheepDesignYetPrayOil();
        }
    }
    /// <summary>
    /// 没有被使用的音频组件返回给队列
    /// </summary>
    /// <param name="audio"></param>
    public void BeNutCheepBotanical(AudioSource audio)
    {
        if (CheepBotanicalSouth.Contains(audio)) return;
        if (CheepBotanicalSouth.Count >= EkaStyle)
        {
            GameObject.Destroy(audio);
            //Debug.Log("删除组件");
        }
        else
        {
            audio.clip = null;
            CheepBotanicalSouth.Add(audio);
        }

        //Debug.Log("队列长度是" + AudioComponentQueue.Count);
    }
    
}
