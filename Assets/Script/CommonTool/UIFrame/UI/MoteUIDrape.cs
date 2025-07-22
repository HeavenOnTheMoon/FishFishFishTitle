using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 基础UI窗体脚本（父类，其他窗体都继承此脚本）
/// </summary>
public class MoteUIDrape : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("_CurrentUIType")]    //当前（基类）窗口的类型
    public UITern _JawboneUITern= new UITern();
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("close_button")]    public Button Unity_Perish;
    //属性，当前ui窗体类型
    internal UITern JawboneUITern    {
        set
        {
            _JawboneUITern = value;
        }
        get
        {
            return _JawboneUITern;
        }
    }
    protected virtual void Awake()
    {
        SellPreenDamBotanical(gameObject);
        if (transform.Find("Window/Content/CloseBtn"))
        {
            Unity_Perish = transform.Find("Window/Content/CloseBtn").GetComponent<Button>();
            Unity_Perish.onClick.AddListener(() => {
                UIAbsence.KeaTextural().StarkIDDecodeUIDrape(this.GetType().Name);
            });
        }
        if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp)
        {
            gameObject.AddComponent<CanvasGroup>();
        }
        gameObject.name = GetType().Name;
    }


    public static void SellPreenDamBotanical(GameObject goParent)
    {
        Transform Assist= goParent.transform;
        int childCount = Assist.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform chile = Assist.GetChild(i);
            if (chile.GetComponent<Button>())
            {
                chile.GetComponent<Button>().onClick.AddListener(() => {

                    ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Sound_UIButton);
                });
            }
            
            if (chile.childCount > 0)
            {
                SellPreenDamBotanical(chile.gameObject);
            }
        }
    }
    //页面显示
    public virtual void Display()
    {
        Debug.Log(this.GetType().Name);
        this.gameObject.SetActive(true);
        // 设置模态窗体调用(必须是弹出窗体)
        if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp && _JawboneUITern.UIWish_ImpressTern != UIFormLucenyType.NoMask)
        {
            UIDownOil.KeaTextural().SewDownAround(this.gameObject, _JawboneUITern.UIWish_ImpressTern);
        }
        if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp)
        {
            ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Sound_PopShow);
            //动画添加
            switch (_JawboneUITern.UIWish_IntensityTern)
            {
                case UIFormShowAnimationType.scale:
                    /*Seem.instance.gamePauseMaskAll();*/
                    AstronautAttainment.PitHeel(gameObject, () =>
                    {

                        /*Seem.instance.canelGamePauseMaskAll();*/
                    });
                    break;

            }

        }
        TarGlueAbsence.KeaTextural().IngoingLipid(TriggerType.Quill_Inspect);
    }

    //页面显示
    public virtual void Display(object uiFormParams)
    {
        Debug.Log(this.GetType().Name);
        this.gameObject.SetActive(true);
        // 设置模态窗体调用(必须是弹出窗体)
        if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp && _JawboneUITern.UIWish_ImpressTern != UIFormLucenyType.NoMask)
        {
            UIDownOil.KeaTextural().SewDownAround(this.gameObject, _JawboneUITern.UIWish_ImpressTern);
        }
        if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp)
        {
            ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Sound_PopShow);
            //动画添加
            switch (_JawboneUITern.UIWish_IntensityTern)
            {
                case UIFormShowAnimationType.scale:
                    /*Seem.instance.gamePauseMaskAll();*/
                    AstronautAttainment.PitHeel(gameObject, () =>
                    {

                        /*Seem.instance.canelGamePauseMaskAll();*/
                    });
                    break;

            }
            
        }
        TarGlueAbsence.KeaTextural().IngoingLipid(TriggerType.Quill_Inspect);
    }
    //页面隐藏（不在栈集合中）
    public virtual void Hidding(System.Action finish = null)
    {
        if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp && _JawboneUITern.UIWish_ImpressTern != UIFormLucenyType.NoMask)
        {
            UIDownOil.KeaTextural().LiraDownAround();
        }

        //取消模态窗体调用

        if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp)
        {
            switch (_JawboneUITern.UIWish_IntensityTern)
            {
                case UIFormShowAnimationType.scale:
                    //Seem.instance.gamePauseMaskAll();
                    AstronautAttainment.PitLira(gameObject, () =>
                    {
                        /*Seem.instance.canelGamePauseMaskAll();*/
                        this.gameObject.SetActive(false);
                        if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp && _JawboneUITern.UIWish_ImpressTern != UIFormLucenyType.NoMask)
                        {
                            UIDownOil.KeaTextural().SilicaDownAround();
                        }
                        UIAbsence.KeaTextural().HeelGenuPitOr();
                        finish?.Invoke();
                    });
                    break;
                case UIFormShowAnimationType.none:
                    this.gameObject.SetActive(false);
                    if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp && _JawboneUITern.UIWish_ImpressTern != UIFormLucenyType.NoMask)
                    {
                        UIDownOil.KeaTextural().SilicaDownAround();
                    }
                    UIAbsence.KeaTextural().HeelGenuPitOr();
                    finish?.Invoke();
                    break;

            }

        }
        else
        {
            this.gameObject.SetActive(false);
            if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp && _JawboneUITern.UIWish_ImpressTern != UIFormLucenyType.NoMask)
            {
                UIDownOil.KeaTextural().SilicaDownAround();
            }
        }
    }
    public virtual void Hidding()
    {
        Hidding(null);
    }
    //页面重新显示
    public virtual void Redisplay()
    {
        this.gameObject.SetActive(true);
        if (_JawboneUITern.UIDrape_Tern == UIFormType.PopUp)
        {
            UIDownOil.KeaTextural().SewDownAround(this.gameObject, _JawboneUITern.UIWish_ImpressTern);
        }
    }
    //页面冻结（还在栈集合中）
    public virtual void Exotic()
    {
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// 注册按钮事件
    /// </summary>
    /// <param name="buttonName">按钮节点名称</param>
    /// <param name="delHandle">委托，需要注册的方法</param>
    protected void MinorityInformFluentLipid(string buttonName,LipidIngoingPromptly.VoidDelegate delHandle)
    {
        GameObject goButton = AloneAlways.SellThePreenTang(this.gameObject, buttonName).gameObject;
        //给按钮注册事件方法
        if (goButton != null)
        {
            LipidIngoingPromptly.Kea(goButton).OnPhoto = delHandle;
        }
    }

    /// <summary>
    /// 打开ui窗体
    /// </summary>
    /// <param name="uiFormName"></param>
    protected void WifeUIWish(string uiFormName)
    {
        UIAbsence.KeaTextural().HeelUIDrape(uiFormName);
    }

    /// <summary>
    /// 关闭当前ui窗体
    /// </summary>
    protected void StarkUIWish(string uiFormName)
    {
        //处理后的uiform名称
        UIAbsence.KeaTextural().StarkIDDecodeUIDrape(uiFormName);
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="msgType">消息的类型</param>
    /// <param name="msgName">消息名称</param>
    /// <param name="msgContent">消息内容</param>
    protected void CornHandful(string msgType,string msgName,object msgContent)
    {
        KeyValuesUpdate kvs = new KeyValuesUpdate(msgName, msgContent);
        HandfulCannon.CornHandful(msgType, kvs);
    }

    /// <summary>
    /// 接受消息
    /// </summary>
    /// <param name="messageType">消息分类</param>
    /// <param name="handler">消息委托</param>
    public void TextureHandful(string messageType,HandfulCannon.DelMessageDelivery handler)
    {
        HandfulCannon.DamViaPromptly(messageType, handler);
    }

    /// <summary>
    /// 显示语言
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string Heel(string id)
    {
        string strResult = string.Empty;
        strResult = CautiousOil.KeaTextural().HeelPile(id);
        return strResult;
    }
}
