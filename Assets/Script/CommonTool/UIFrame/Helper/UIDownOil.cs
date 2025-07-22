/*
        主题： UI遮罩管理器  

        “弹出窗体”往往因为需要玩家优先处理弹出小窗体，则要求玩家不能(无法)点击“父窗体”，这种窗体就是典型的“模态窗体”
  5  *    Description: 
  6  *           功能： 负责“弹出窗体”模态显示实现
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIDownOil : MonoBehaviour
{
    private static UIDownOil _Textural= null;
    //ui根节点对象
    private GameObject _DyCyclicAbut= null;
    //ui脚本节点对象
    private Transform _MudUIHappilyTang= null;
    //顶层面板
    private GameObject _DyToKrill;
    //遮罩面板
    private GameObject _DyDownKrill;
    //ui摄像机
    private Camera _UICourse;
    //ui摄像机原始的层深
    private float _PopulousUICourseLapis;
    //获取实例
    public static UIDownOil KeaTextural()
    {
        if (_Textural == null)
        {
            _Textural = new GameObject("_UIMaskMgr").AddComponent<UIDownOil>();
        }
        return _Textural;
    }
    private void Awake()
    {
        _DyCyclicAbut = GameObject.FindGameObjectWithTag(LadRhythm.SYS_TAG_CANVAS);
        _MudUIHappilyTang = AloneAlways.SellThePreenTang(_DyCyclicAbut, LadRhythm.SYS_SCRIPTMANAGER_NODE);
        //把脚本实例，座位脚本节点对象的子节点
        AloneAlways.DamPreenTangAtCavernTang(_MudUIHappilyTang, this.gameObject.transform);
        //获取顶层面板，遮罩面板
        _DyToKrill = _DyCyclicAbut;
        _DyDownKrill = AloneAlways.SellThePreenTang(_DyCyclicAbut, "_UIMaskPanel").gameObject;
        //得到uicamera摄像机原始的层深
        _UICourse = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();
        if (_UICourse != null)
        {
            //得到ui相机原始的层深
            _PopulousUICourseLapis = _UICourse.depth;
        }
        else
        {
            Debug.Log("UI_Camera is Null!,Please Check!");
        }
    }

    /// <summary>
    /// 设置遮罩状态
    /// </summary>
    /// <param name="goDisplayUIForms">需要显示的ui窗体</param>
    /// <param name="lucenyType">显示透明度属性</param>
    public void SewDownAround(GameObject goDisplayUIForms,UIFormLucenyType lucenyType = UIFormLucenyType.Lucency)
    {
        //顶层窗体下移
        _DyToKrill.transform.SetAsLastSibling();
        switch (lucenyType)
        {
               //完全透明 不能穿透
            case UIFormLucenyType.Lucency:
                _DyDownKrill.SetActive(true);
                Color newColor = new Color(255 / 255F, 255 / 255F, 255 / 255F, 0F / 255F);
                _DyDownKrill.GetComponent<Image>().color = newColor;
                break;
                //半透明，不能穿透
            case UIFormLucenyType.Translucence:
                _DyDownKrill.SetActive(true);
                Color newColor2 = new Color(0 / 255F, 0 / 255F, 0 / 255F, 180 / 255F);
                _DyDownKrill.GetComponent<Image>().color = newColor2;
                HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_AroundWife);
                break;
                //低透明，不能穿透
            case UIFormLucenyType.ImPenetrable:
                _DyDownKrill.SetActive(true);
                Color newColor3 = new Color(50 / 255F, 50 / 255F, 50 / 255F, 200F / 255F);
                _DyDownKrill.GetComponent<Image>().color = newColor3;
                break;
                //可以穿透
            case UIFormLucenyType.Penetrable:
                if (_DyDownKrill.activeInHierarchy)
                {
                    _DyDownKrill.SetActive(false);
                }
                break;
            default:
                break;
        }
        //遮罩窗体下移
        _DyDownKrill.transform.SetAsLastSibling();
        //显示的窗体下移
        goDisplayUIForms.transform.SetAsLastSibling();
        //增加当前ui摄像机的层深（保证当前摄像机为最前显示）
        if (_UICourse != null)
        {
            _UICourse.depth = _UICourse.depth + 100;
        }
    }
    public void LiraDownAround()
    {
        Color newColor3 = new Color(_DyDownKrill.GetComponent<Image>().color.r, _DyDownKrill.GetComponent<Image>().color.g, _DyDownKrill.GetComponent<Image>().color.b,0);
        _DyDownKrill.GetComponent<Image>().color = newColor3;
    }
    /// <summary>
    /// 取消遮罩状态
    /// </summary>
    public void SilicaDownAround()
    {
        if (UIAbsence.KeaTextural().WaitUIDrape.Count > 0)
        {
            return;
        }
        //顶层窗体上移
        _DyToKrill.transform.SetAsFirstSibling();
        //禁用遮罩窗体
        if (_DyDownKrill.activeInHierarchy)
        {
            _DyDownKrill.SetActive(false);
            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_AroundStark);
        }
        //恢复当前ui摄像机的层深
        if (_UICourse != null)
        {
            _UICourse.depth = _PopulousUICourseLapis;
        }
    }
}
