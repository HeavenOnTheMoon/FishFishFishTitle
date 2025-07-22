/***
 * 
 * 音乐管理器
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThereOil : WellSweatshop<ThereOil>
{
    //音频组件管理队列的对象
    private CheepDesignSouth CheepSouth;
    // 用于播放背景音乐的音乐源
    private AudioSource m_WeThere=null;
    //播放音效的音频组件管理列表
    private List<AudioSource> BeerCheepDesignForm;
    //检查已经播放的音频组件列表中没有播放的组件的更新频率
    private float SonicRhyolite= 2f; 
    //背景音乐开关
    private bool _MyThereEurope=true;
    //音效开关
    private bool _AlbedoThereEurope= true;
    //音乐音量
    private float _MyLament=1f;
    //音效音量
    private float _AlbedoLament=1f;
    // 控制背景音乐音量大小
    public float MyLament    {
        get { 
            return MyThereEurope ? 0.7f : 0f; 
        }
        set {
            _MyLament = value;
            //背景音乐开的状态下，声音随控制调节
        }
    }

    //控制音效音量的大小
    public float AlbedoVolmue    {
        get { return _AlbedoLament; }
        set { 
            _AlbedoLament = value;
            SewYamAlbedoLament();
        }
    }
    //控制背景音乐开关
    public bool MyThereEurope    {
        get {

            _MyThereEurope = TreeTwigAbsence.GetBool("_BgMusicSwitch");
            return _MyThereEurope; 
        }
        set {
            _MyThereEurope = value;
            TreeTwigAbsence.SetBool("_BgMusicSwitch", _MyThereEurope);
            m_WeThere.volume = MyLament; 
        }
    }
    //控制音效开关
    public bool AlbedoThereEurope    {
        get {
            _AlbedoThereEurope = TreeTwigAbsence.GetBool("_EffectMusicSwitch");
            return _AlbedoThereEurope; 
        }
        set {
            _AlbedoThereEurope = value;
            TreeTwigAbsence.SetBool("_EffectMusicSwitch", _AlbedoThereEurope);
            
        }
    }
    public ThereOil()
    {
        BeerCheepDesignForm = new List<AudioSource>();      
    }
    protected override void Awake()
    {
        if (!TreeTwigAbsence.GetBool("first_music_set"))
        {
            TreeTwigAbsence.SetBool("first_music_set", true);
            TreeTwigAbsence.SetBool("_BgMusicSwitch", true);
            TreeTwigAbsence.SetBool("_EffectMusicSwitch", true);
        }
        CheepSouth = new CheepDesignSouth(this);
    }
    private void Start()
    {
        StartCoroutine(nameof(SonicBeNutCheepBotanical));
    }
    /// <summary>
    /// 定时检查没有使用的音频组件并回收
    /// </summary>
    /// <returns></returns>
    IEnumerator SonicBeNutCheepBotanical()
    {
        while (true)
        {
            //定时更新
            yield return new WaitForSeconds(SonicRhyolite);
            for (int i = 0; i < BeerCheepDesignForm.Count; i++)
            {
                //防止数据越界
                if (i < BeerCheepDesignForm.Count)
                {
                    //确保物体存在
                    if (BeerCheepDesignForm[i])
                    {
                        //音频为空或者没有播放为返回队列条件
                        if ((BeerCheepDesignForm[i].clip == null || !BeerCheepDesignForm[i].isPlaying))
                        {
                            //返回队列
                            CheepSouth.BeNutCheepBotanical(BeerCheepDesignForm[i]);
                            //从播放列表中删除
                            BeerCheepDesignForm.Remove(BeerCheepDesignForm[i]);
                        }
                    }
                    else
                    {
                        //移除在队列中被销毁但是是在list中存在的垃圾数据
                        BeerCheepDesignForm.Remove(BeerCheepDesignForm[i]);
                    }                 
                }            
               
            }
        }
    }
    /// <summary>
    /// 设置当前播放的所有音效的音量
    /// </summary>
    private void SewYamAlbedoLament()
    {
        for (int i = 0; i < BeerCheepDesignForm.Count; i++)
        {
            if (BeerCheepDesignForm[i] && BeerCheepDesignForm[i].isPlaying)
            {
                BeerCheepDesignForm[i].volume = _AlbedoThereEurope ? _AlbedoLament : 0f;
            }
        }
    }
    /// <summary>
    /// 播放背景音乐，传进一个音频剪辑的name
    /// </summary>
    /// <param name="bgName"></param>
    /// <param name="restart"></param>
    private void BeerMyMote(object bgName, bool restart = false)
    {

        
        if (m_WeThere == null)
        {
            //拿到一个音频组件  背景音乐组件在某一时间段唯一存在
            m_WeThere = CheepSouth.KeaCheepBotanical();
            //开启循环
            m_WeThere.loop = true;
            //开始播放
            m_WeThere.playOnAwake = false;
            //加入播放列表
            //PlayAudioSourceList.Add(m_bgMusic);
        }      
        //定义一个空的字符串
        string curBgName = string.Empty;
        //如果这个音乐源的音频剪辑不为空的话
        if (m_WeThere.clip != null)
        {
            //得到这个音频剪辑的name
            curBgName = m_WeThere.clip.name;
        }

        // 根据用户的音频片段名称, 找到AuioClip, 然后播放,
        //ResourcesMgr是提前定义好的查找音频剪辑对应路径的单例脚本，并动态加载出来
        AudioClip clip = ThereImitationOil.KeaTextural().Omit<AudioClip>(bgName);
        //如果找到了，不为空
        if (clip != null)
        {
            //如果这个音频剪辑已经复制给类音频源，切正在播放，那么直接跳出
            if (clip.name == curBgName && !restart)
            {
                return;
            }
            //否则，把改音频剪辑赋值给音频源，然后播放
            m_WeThere.clip = clip;
            m_WeThere.volume = MyLament;
            m_WeThere.Play();
        }
        else
        {
            //没找到直接报错
            // 异常, 调用写日志的工具类.
            //UnityEngine.Debug.Log("没有找到音频片段");
            if (m_WeThere.isPlaying)
            {
                m_WeThere.Stop();
            }
            m_WeThere.clip = null;
        }
    }
    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="defAudio"></param>
    /// <param name="volume"></param>
    private void BeerAlbedoMote(object effectName, bool defAudio = true, float volume = 1f)
    {
        if (!AlbedoThereEurope)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = CheepSouth.KeaCheepBotanical();
        if (m_effectMusic.isPlaying) {
            Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = _AlbedoLament;
        //根据查找路径加载对应的音频剪辑
        AudioClip clip =ThereImitationOil.KeaTextural().Omit<AudioClip>(effectName);
        //如果为空的画，直接报错，然后跳出
        if (clip == null)
        {
            //UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            CheepSouth.BeNutCheepBotanical(m_effectMusic);
            return;
        }
        //加入播放列表
        BeerCheepDesignForm.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }

    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void BeerMy(ThereTern.UIMusic bgName, bool restart = false)
    {
        BeerMyMote(bgName, restart);
    }

    public void BeerMy(ThereTern.SceneMusic bgName, bool restart = false)
    {
        BeerMyMote(bgName, restart);
    }

    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void BeerAlbedo(ThereTern.UIMusic effectName, bool defAudio = true, float volume = 1f)
    {
        BeerAlbedoMote(effectName, defAudio, volume);
    }

    public void BeerAlbedo(ThereTern.SceneMusic effectName, bool defAudio = true, float volume = 1f)
    {
        BeerAlbedoMote(effectName, defAudio, volume);
    }

}
