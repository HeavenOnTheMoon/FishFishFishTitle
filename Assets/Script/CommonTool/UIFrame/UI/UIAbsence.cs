/*
*
*   功能：整个UI框架的核心，用户程序通过调用本类，来调用本框架的大多数功能。  
*           功能1：关于入“栈”与出“栈”的UI窗体4个状态的定义逻辑
*                 入栈状态：
*                     Freeze();   （上一个UI窗体）冻结
*                     Display();  （本UI窗体）显示
*                 出栈状态： 
*                     Hiding();    (本UI窗体) 隐藏
*                     Redisplay(); (上一个UI窗体) 重新显示
*          功能2：增加“非栈”缓存集合。 
* 
* 
* ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
/// <summary>
/// UI窗体管理器脚本（框架核心脚本）
/// 主要负责UI窗体的加载、缓存、以及对于“UI窗体基类”的各种生命周期的操作（显示、隐藏、重新显示、冻结）。
/// </summary>
public class UIAbsence : MonoBehaviour
{
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("MainCanvas")]   
    public Canvas PinkCyclic;
    private static UIAbsence _Textural= null;
    //ui窗体预设路径（参数1，窗体预设名称，2，表示窗体预设路径）
    private Dictionary<string, string> _FluDrapeForay;
    //缓存所有的ui窗体
    private Dictionary<string, MoteUIDrape> _FluALLUIDrape;
    //栈结构标识当前ui窗体的集合
    private Stack<MoteUIDrape> _DyeJawboneUIDrape;
    //当前显示的ui窗体
    private Dictionary<string, MoteUIDrape> _FluJawboneHeelUIDrape;
    //临时关闭窗口
    private List<string> _WaitUIDrape;
    //ui根节点
    private Transform _MudCyclicTiredness= null;
    //全屏幕显示的节点
    private Transform _MudInjury= null;
    //固定显示的节点
    private Transform _MudNoise= null;
    //弹出节点
    private Transform _MudPopOr= null;
    //ui特效节点
    private Transform _Lap= null;
    //ui管理脚本的节点
    private Transform _MudUIHappily= null;
[UnityEngine.Serialization.FormerlySerializedAs("_TraUICamera")]    public Transform _MudUICourse= null;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("PanelName")]    public string KrillBold;
    List<string> KrillBoldForm;
    public List<string> WaitUIDrape    {
        get
        {
            return _WaitUIDrape;
        }
    }
    //得到实例
    public static UIAbsence KeaTextural()
    {
        if (_Textural == null)
        {
            _Textural = new GameObject("_UIManager").AddComponent<UIAbsence>();
        }
        return _Textural;
    }
    //初始化核心数据，加载ui窗体路径到集合中
    public void Awake()
    {
        KrillBoldForm = new List<string>();
        //字段初始化
        _FluALLUIDrape = new Dictionary<string, MoteUIDrape>();
        _FluJawboneHeelUIDrape = new Dictionary<string, MoteUIDrape>();
        _WaitUIDrape = new List<string>();
        _FluDrapeForay = new Dictionary<string, string>();
        _DyeJawboneUIDrape = new Stack<MoteUIDrape>();
        //初始化加载（根ui窗体）canvas预设
        DustAbutCyclicPreform();
        //得到UI根节点，全屏节点，固定节点，弹出节点
        //Debug.Log("this.gameobject" + this.gameObject.name);
        _MudCyclicTiredness = GameObject.FindGameObjectWithTag(LadRhythm.SYS_TAG_CANVAS).transform;
        _MudInjury = AloneAlways.SellThePreenTang(_MudCyclicTiredness.gameObject,LadRhythm.SYS_NORMAL_NODE);
        _MudNoise = AloneAlways.SellThePreenTang(_MudCyclicTiredness.gameObject, LadRhythm.SYS_FIXED_NODE);
        _MudPopOr = AloneAlways.SellThePreenTang(_MudCyclicTiredness.gameObject,LadRhythm.SYS_POPUP_NODE);
        _Lap = AloneAlways.SellThePreenTang(_MudCyclicTiredness.gameObject, LadRhythm.SYS_TOP_NODE);
        _MudUIHappily = AloneAlways.SellThePreenTang(_MudCyclicTiredness.gameObject,LadRhythm.SYS_SCRIPTMANAGER_NODE);
        _MudUICourse = AloneAlways.SellThePreenTang(_MudCyclicTiredness.gameObject, LadRhythm.SYS_UICAMERA_NODE);
        //把本脚本作为“根ui窗体”的子节点
        AloneAlways.DamPreenTangAtCavernTang(_MudUIHappily, this.gameObject.transform);
        //根UI窗体在场景转换的时候，不允许销毁
        DontDestroyOnLoad(_MudCyclicTiredness);
        //初始化ui窗体预设路径数据
        DustUIDrapeForayTwig();
        //初始化UI相机参数，主要是解决URP管线下UI相机的问题
        DustCourse();
    }
    public void DamKrill(string name)
    {
        if (!KrillBoldForm.Contains(name))
        {
            KrillBoldForm.Add(name);
            KrillBold = name;
        }
    }
    public void WadKrill(string name)
    {
        if (KrillBoldForm.Contains(name))
        {
            KrillBoldForm.Remove(name);
        }
        if (KrillBoldForm.Count == 0)
        {
            KrillBold = "";
        }
        else
        {
            KrillBold = KrillBoldForm[0];
        }
    }
    //初始化加载（根ui窗体）canvas预设
    private void DustAbutCyclicPreform()
    {
        PinkCyclic = ImitationOil.KeaTextural().OmitCloth(LadRhythm.SYS_PATH_CANVAS, false).GetComponent<Canvas>();

    }
    /// <summary>
    /// 显示ui窗体
    /// 功能：1根据ui窗体的名称，加载到所有ui窗体缓存集合中
    /// 2,根据不同的ui窗体的显示模式，分别做不同的加载处理
    /// </summary>
    /// <param name="uiFormName">ui窗体预设的名称</param>
    public GameObject HeelUIDrape(string uiFormName)
    {
        //参数的检查
        if (string.IsNullOrEmpty(uiFormName)) return null;
        //根据ui窗体的名称，把加载到所有ui窗体缓存集合中
        //ui窗体的基类
        MoteUIDrape baseUIForms = OmitDrapeAtALLUIDrapeWiden(uiFormName);
        if (baseUIForms == null) return null;

        DamKrill(uiFormName);
        
        //判断是否清空“栈”结构体集合
        if (baseUIForms.JawboneUITern.ByPeachProcessFaucet)
        {
            PeachGessoTreat();
        }
        //根据不同的ui窗体的显示模式，分别做不同的加载处理
        switch (baseUIForms.JawboneUITern.UIWish_HeelSnap)
        {
            case UIFormShowMode.Normal:
                RadarUIDrapeSpine(uiFormName);
                break;
            case UIFormShowMode.ReverseChange:
                WoodUIDrape(uiFormName);
                break;
            case UIFormShowMode.HideOther:
                RadarUIGentleAtSpineLiraOther(uiFormName);
                break;
            case UIFormShowMode.Wait:
                RadarUIDrapeSpineOntoStark(uiFormName);
                break;
            default:
                break;
        }
        return baseUIForms.gameObject;
    }

    /// <summary>
    /// 关闭或返回上一个ui窗体（关闭当前ui窗体）
    /// </summary>
    /// <param name="strUIFormsName"></param>
    public void StarkIDDecodeUIDrape(string strUIFormsName)
    {
        WadKrill(strUIFormsName);
        //Debug.Log("关闭窗体的名字是" + strUIFormsName);
        //ui窗体的基类
        MoteUIDrape baseUIForms = null;
        if (string.IsNullOrEmpty(strUIFormsName)) return;
        _FluALLUIDrape.TryGetValue(strUIFormsName,out baseUIForms);
        //所有窗体缓存中没有记录，则直接返回
        if (baseUIForms == null) return;
        //判断不同的窗体显示模式，分别处理
        switch (baseUIForms.JawboneUITern.UIWish_HeelSnap)
        {
            case UIFormShowMode.Normal:
                HopeUIDrapeSpine(strUIFormsName);
                break;
            
            case UIFormShowMode.ReverseChange:
                PitUIDrape();
                break;
            case UIFormShowMode.HideOther:
                HopeUIDrapeAeroSpineBagHeelBriny(strUIFormsName);
                break;
            case UIFormShowMode.Wait:
                HopeUIDrapeSpine(strUIFormsName);
                break;
            default:
                break;
        }
        
    }
    /// <summary>
    /// 显示下一个弹窗如果有的话
    /// </summary>
    public void HeelGenuPitOr()
    {
        if (_WaitUIDrape.Count > 0)
        {
            HeelUIDrape(_WaitUIDrape[0]);
            _WaitUIDrape.RemoveAt(0);
        }
    }

    /// <summary>
    /// 清空当前等待中的UI
    /// </summary>
    public void PeachOntoUIDrape()
    {
        if (_WaitUIDrape.Count > 0)
        {
            _WaitUIDrape = new List<string>();
        }
    }
     /// <summary>
     /// 根据UI窗体的名称，加载到“所有UI窗体”缓存集合中
      /// 功能： 检查“所有UI窗体”集合中，是否已经加载过，否则才加载。
      /// </summary>
      /// <param name="uiFormsName">UI窗体（预设）的名称</param>
      /// <returns></returns>
    private MoteUIDrape OmitDrapeAtALLUIDrapeWiden(string uiFormName)
    {
        //加载的返回ui窗体基类
        MoteUIDrape baseUIResult = null;
        _FluALLUIDrape.TryGetValue(uiFormName, out baseUIResult);
        if (baseUIResult == null)
        {
            //加载指定名称ui窗体
            baseUIResult = OmitUIWish(uiFormName);

        }
        return baseUIResult;
    }
    /// <summary>
    /// 加载指定名称的“UI窗体”
    /// 功能：
    ///    1：根据“UI窗体名称”，加载预设克隆体。
    ///    2：根据不同预设克隆体中带的脚本中不同的“位置信息”，加载到“根窗体”下不同的节点。
    ///    3：隐藏刚创建的UI克隆体。
    ///    4：把克隆体，加入到“所有UI窗体”（缓存）集合中。
    /// 
    /// </summary>
    /// <param name="uiFormName">UI窗体名称</param>
    private MoteUIDrape OmitUIWish(string uiFormName)
    {
        string strUIFormPaths = null;
        GameObject goCloneUIPrefabs = null;
        MoteUIDrape baseUIForm = null;
        //根据ui窗体名称，得到对应的加载路径
        _FluDrapeForay.TryGetValue(uiFormName, out strUIFormPaths);
        if (!string.IsNullOrEmpty(strUIFormPaths))
        {
            //加载预制体
           goCloneUIPrefabs= ImitationOil.KeaTextural().OmitCloth(strUIFormPaths, false);
        }
        //设置ui克隆体的父节点（根据克隆体中带的脚本中不同的信息位置信息）
        if(_MudCyclicTiredness!=null && goCloneUIPrefabs != null)
        {
            baseUIForm = goCloneUIPrefabs.GetComponent<MoteUIDrape>();
            if (baseUIForm == null)
            {
                Debug.Log("baseUiForm==null! ,请先确认窗体预设对象上是否加载了baseUIForm的子类脚本！ 参数 uiFormName="+uiFormName);
                return null;
            }
            switch (baseUIForm.JawboneUITern.UIDrape_Tern)
            {
                case UIFormType.Normal:
                    goCloneUIPrefabs.transform.SetParent(_MudInjury, false);
                    break;
                case UIFormType.Fixed:
                    goCloneUIPrefabs.transform.SetParent(_MudNoise, false);
                    break;
                case UIFormType.PopUp:
                    goCloneUIPrefabs.transform.SetParent(_MudPopOr, false);
                    break;
                case UIFormType.Top:
                    goCloneUIPrefabs.transform.SetParent(_Lap, false);
                    break;
                default:
                    break;
            }
            //设置隐藏
            goCloneUIPrefabs.SetActive(false);
            //把克隆体，加入到所有ui窗体缓存集合中
            _FluALLUIDrape.Add(uiFormName, baseUIForm);
            return baseUIForm;
        }
        else
        {
            Debug.Log("_TraCanvasTransfrom==null Or goCloneUIPrefabs==null!! ,Plese Check!, 参数uiFormName=" + uiFormName);
        }
        Debug.Log("出现不可以预估的错误，请检查，参数 uiFormName=" + uiFormName);
        return null;
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="uiFormName">窗体预设的名字</param>
    private void RadarUIDrapeSpine(string uiFormName)
    {
        //ui窗体基类
        MoteUIDrape baseUIForm;
        //从所有窗体集合中得到的窗体
        MoteUIDrape baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _FluJawboneHeelUIDrape.TryGetValue(uiFormName, out baseUIForm);
        if (baseUIForm != null) return;
        //把当前窗体，加载到正在显示集合中
        _FluALLUIDrape.TryGetValue(uiFormName, out baseUIFormFromAllCache);
        if (baseUIFormFromAllCache != null)
        {
            _FluJawboneHeelUIDrape.Add(uiFormName, baseUIFormFromAllCache);
            //显示当前窗体
            baseUIFormFromAllCache.Display();
            
        }
    }

    /// <summary>
    /// 卸载ui窗体从当前显示的集合缓存中
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void HopeUIDrapeSpine(string strUIFormsName)
    {
        //ui窗体基类
        MoteUIDrape baseUIForms;
        //正在显示ui窗体缓存集合没有记录，则直接返回
        _FluJawboneHeelUIDrape.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体，运行隐藏，且从正在显示ui窗体缓存集合中移除
        baseUIForms.Hidding();
        _FluJawboneHeelUIDrape.Remove(strUIFormsName);
    }

    /// <summary>
    /// 加载ui窗体到当前显示窗体集合，且，隐藏其他正在显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void RadarUIGentleAtSpineLiraOther(string strUIFormsName)
    {
        //窗体基类
        MoteUIDrape baseUIForms;
        //所有窗体集合中的窗体基类
        MoteUIDrape baseUIFormsFromAllCache;
        _FluJawboneHeelUIDrape.TryGetValue(strUIFormsName, out baseUIForms);
        //正在显示ui窗体缓存集合里有记录，直接返回
        if (baseUIForms != null) return;
        Debug.Log("关闭其他窗体");
        //正在显示ui窗体缓存 与栈缓存集合里所有的窗体进行隐藏处理
        List<MoteUIDrape> ShowUIFormsList = new List<MoteUIDrape>(_FluJawboneHeelUIDrape.Values);
        foreach (MoteUIDrape baseUIFormsItem in ShowUIFormsList)
        {
            //Debug.Log("_DicCurrentShowUIForms---------" + baseUIFormsItem.transform.name);
            if (baseUIFormsItem.JawboneUITern.UIDrape_Tern == UIFormType.PopUp)
            {
                //baseUIFormsItem.Hidding();
                HopeUIDrapeAeroSpineBagHeelBriny(baseUIFormsItem.GetType().Name);
            }
        }
        List<MoteUIDrape> CurrentUIFormsList = new List<MoteUIDrape>(_DyeJawboneUIDrape);
        foreach (MoteUIDrape baseUIFormsItem in CurrentUIFormsList)
        {
            //Debug.Log("_StaCurrentUIForms---------"+baseUIFormsItem.transform.name);
            //baseUIFormsItem.Hidding();
            HopeUIDrapeAeroSpineBagHeelBriny(baseUIFormsItem.GetType().Name);
        }
        //把当前窗体，加载到正在显示ui窗体缓存集合中 
        _FluALLUIDrape.TryGetValue(strUIFormsName, out baseUIFormsFromAllCache);
        if (baseUIFormsFromAllCache != null)
        {
            _FluJawboneHeelUIDrape.Add(strUIFormsName, baseUIFormsFromAllCache);
            baseUIFormsFromAllCache.Display();
        }
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="uiFormName">窗体预设的名字</param>
    private void RadarUIDrapeSpineOntoStark(string uiFormName)
    {
        //ui窗体基类
        MoteUIDrape baseUIForm;
        //从所有窗体集合中得到的窗体
        MoteUIDrape baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _FluJawboneHeelUIDrape.TryGetValue(uiFormName, out baseUIForm);
        if (baseUIForm != null) return;
        bool havePopUp = false;
        foreach (MoteUIDrape uiforms in _FluJawboneHeelUIDrape.Values)
        {
            if (uiforms.JawboneUITern.UIDrape_Tern == UIFormType.PopUp)
            {
                havePopUp = true;
                break;
            }
        }
        if (!havePopUp)
        {
            //把当前窗体，加载到正在显示集合中
            _FluALLUIDrape.TryGetValue(uiFormName, out baseUIFormFromAllCache);
            if (baseUIFormFromAllCache != null)
            {
                _FluJawboneHeelUIDrape.Add(uiFormName, baseUIFormFromAllCache);
                //显示当前窗体
                baseUIFormFromAllCache.Display();

            }
        }
        else
        {
            _WaitUIDrape.Add(uiFormName);
        }
        
    }
    /// <summary>
    /// 卸载ui窗体从当前显示窗体集合缓存中，且显示其他原本需要显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void HopeUIDrapeAeroSpineBagHeelBriny(string strUIFormsName)
    {
        //ui窗体基类
        MoteUIDrape baseUIForms;
        _FluJawboneHeelUIDrape.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体 ，运行隐藏状态，且从正在显示ui窗体缓存集合中删除
        baseUIForms.Hidding();
        _FluJawboneHeelUIDrape.Remove(strUIFormsName);
        //正在显示ui窗体缓存与栈缓存集合里素有窗体进行再次显示
        //foreach (MoteUIDrape baseUIFormsItem in _DicCurrentShowUIForms.Values)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
        //foreach (MoteUIDrape baseUIFormsItem in _StaCurrentUIForms)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
    }
    /// <summary>
    /// ui窗体入栈
    /// 功能：1判断栈里是否已经有窗体，有则冻结
    ///   2先判断ui预设缓存集合是否有指定的ui窗体，有则处理
    ///   3指定ui窗体入栈
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void WoodUIDrape(string strUIFormsName)
    {
        //ui预设窗体
        MoteUIDrape baseUI;
        //判断栈里是否已经有窗体,有则冻结
        if (_DyeJawboneUIDrape.Count > 0)
        {
            MoteUIDrape topUIForms = _DyeJawboneUIDrape.Peek();
            topUIForms.Exotic();
            //Debug.Log("topUIForms是" + topUIForms.name);
        }
        //先判断ui预设缓存集合是否有指定ui窗体，有则处理
        _FluALLUIDrape.TryGetValue(strUIFormsName, out baseUI);
        if (baseUI != null)
        {
            baseUI.Display();
        }
        else
        {
            Debug.Log(string.Format("/PushUIForms()/ baseUI==null! 核心错误，请检查 strUIFormsName={0} ", strUIFormsName));
        }
        //指定ui窗体入栈
        _DyeJawboneUIDrape.Push(baseUI);
       
    }

    /// <summary>
    /// ui窗体出栈逻辑
    /// </summary>
    private void PitUIDrape()
    {

        if (_DyeJawboneUIDrape.Count >= 2)
        {
            //出栈逻辑
            MoteUIDrape topUIForms = _DyeJawboneUIDrape.Pop();
            //出栈的窗体进行隐藏
            topUIForms.Hidding(() => {
                //出栈窗体的下一个窗体逻辑
                MoteUIDrape nextUIForms = _DyeJawboneUIDrape.Peek();
                //下一个窗体重新显示处理
                nextUIForms.Redisplay();
            });
        }
        else if (_DyeJawboneUIDrape.Count == 1)
        {
            MoteUIDrape topUIForms = _DyeJawboneUIDrape.Pop();
            //出栈的窗体进行隐藏处理
            topUIForms.Hidding();
        }
    }


    /// <summary>
    /// 初始化ui窗体预设路径数据
    /// </summary>
    private void DustUIDrapeForayTwig()
    {
        ISovietAbsence configMgr = new SovietAbsenceOfSize(LadRhythm.SYS_PATH_UIFORMS_CONFIG_INFO);
        if (_FluDrapeForay != null)
        {
            _FluDrapeForay = configMgr.AppSetting;
        }
    }

    /// <summary>
    /// 初始化UI相机参数
    /// </summary>
    private void DustCourse()
    {
        //当渲染管线为URP时，将UI相机的渲染方式改为Overlay，并加入主相机堆栈
        RenderPipelineAsset currentPipeline = GraphicsSettings.renderPipelineAsset;
        if (currentPipeline != null && currentPipeline.name == "UniversalRenderPipelineAsset")
        {
            Camera UICamera = _MudUICourse.GetComponent<Camera>();
            UICamera.GetUniversalAdditionalCameraData().renderType = CameraRenderType.Overlay;
            Camera.main.GetUniversalAdditionalCameraData().cameraStack.Add(_MudUICourse.GetComponent<Camera>());
        }
    }

    /// <summary>
    /// 清空栈结构体集合
    /// </summary>
    /// <returns></returns>
    private bool PeachGessoTreat()
    {
        if(_DyeJawboneUIDrape!=null && _DyeJawboneUIDrape.Count >= 1)
        {
            _DyeJawboneUIDrape.Clear();
            return true;
        }
        return false;
    }
    /// <summary>
    /// 获取当前弹框ui的栈
    /// </summary>
    /// <returns></returns>
    public Stack<MoteUIDrape> KeaJawboneWishGesso()
    {
        return _DyeJawboneUIDrape;
    }


    /// <summary>
    /// 根据panel名称获取panel gameObject
    /// </summary>
    /// <param name="uiFormName"></param>
    /// <returns></returns>
    public GameObject KeaKrillOfBold(string uiFormName)
    {
        //ui窗体基类
        MoteUIDrape baseUIForm;
        //如果正在显示的集合中存在该窗体，直接返回
        _FluALLUIDrape.TryGetValue(uiFormName, out baseUIForm);
        return baseUIForm?.gameObject;
    }

    /// <summary>
    /// 获取所有打开的panel（不包括Normal）
    /// </summary>
    /// <returns></returns>
    public List<GameObject> KeaMigrantApiece(bool containNormal = false)
    {
        List<GameObject> openingPanels = new List<GameObject>();
        List<MoteUIDrape> allUIFormsList = new List<MoteUIDrape>(_FluALLUIDrape.Values);
        foreach(MoteUIDrape panel in allUIFormsList)
        {
            if (panel.gameObject.activeInHierarchy)
            {
                if (containNormal || panel._JawboneUITern.UIDrape_Tern != UIFormType.Normal)
                {
                    openingPanels.Add(panel.gameObject);
                }
            }
        }

        return openingPanels;
    }
}
