using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 广告管理
/// </summary>
public class WeAbsence : MonoBehaviour
{
    public static WeAbsence Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 游戏前后台切换，自动播放广告
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            WePool.Textural.DamAdultChina();
        }
    }

    private bool OrOweSecond= false;

    /// <summary>
    /// 开始广告管理
    /// </summary>
    public void AssetWe()
    {
        if (OrOweSecond) return;
        
        OrOweSecond = true;
        WePool.Textural.DustWe();
        // 更新用户在线时长，自动播放广告
        InvokeRepeating(nameof(DamAthensEmotive), 1, 1);
    }

    public void DamAthensEmotive()
    {
        WePool.Textural.DamAthensEmotive();
    }
}
