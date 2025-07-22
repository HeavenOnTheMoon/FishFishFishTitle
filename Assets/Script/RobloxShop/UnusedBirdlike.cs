using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 圆形遮罩镂空
/// </summary>
public class UnusedBirdlike : MonoBehaviour
{
    public static UnusedBirdlike instance;
[UnityEngine.Serialization.FormerlySerializedAs("target")]    /// <summary>
    /// 高亮显示目标
    /// </summary>
    public Image Wealth;
[UnityEngine.Serialization.FormerlySerializedAs("ClickBtn")]    
    public Button PhotoBow;
    //public Text Text;
    /// <summary>
    /// 区域范围缓存
    /// </summary>
    private Vector3[] Lineage= new Vector3[4];
    /// <summary>
    /// 镂空区域中心
    /// </summary>
    private Vector4 Fright;
    /// <summary>
    /// 镂空区域半径
    /// </summary>
    private float Likely;
    /// <summary>
    /// 遮罩材质
    /// </summary>
    private Material Educable;
    /// <summary>
    /// 当前高亮区域半径
    /// </summary>
    private float SeaportMantle;
    /// <summary>
    /// 高亮区域缩放的动画时间
    /// </summary>
    private float PolicePloy= 0.3f;
    /// <summary>
    /// 事件渗透组件
    /// </summary>
    private BirdlikeLipidOffspring StormOffspring;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        PhotoBow.onClick.AddListener( (() =>
        {
            GrandeOntoKrill.instance.RoofBowPhoto();
            gameObject.SetActive(false);
        }));
    }

    public void Dust(Image target)
    {
        this.Wealth = target;
        /*eventPenetrate = GetComponent<BirdlikeLipidOffspring>();
        if (eventPenetrate != null)
        {
            eventPenetrate.SetTargetImage(target);
        }*/
#if EmojiMerge
        Canvas canva = GameObject.Find("RobloxCanvas(Clone)").GetComponent<Canvas>();
#else
        Canvas canva = GameObject.Find("Canvas(Clone)").GetComponent<Canvas>();
#endif
        //Canvas canva = /*GameController.Instance.Canvas*/null;
        //获取高亮区域的四个顶点的世界坐标
        target.rectTransform.GetWorldCorners(Lineage);
        //计算最终高亮显示区域的半径
        Likely = Vector2.Distance(SwellAtCyclicPer(canva, Lineage[0]), SwellAtCyclicPer(canva, Lineage[2])) / 2;
        //计算高亮显示区域的中心
        float x= Lineage[0].x + ((Lineage[3].x - Lineage[0].x) / 2);
        float y= Lineage[0].y + ((Lineage[1].y - Lineage[0].y) / 2);
        Vector3 centerWorld = new Vector3(x, y, 0);
        Vector2 Fright= SwellAtCyclicPer(canva, centerWorld);
        //设置遮罩材质中的中心变量
        Vector4 centerMat = new Vector4(Fright.x, Fright.y, 0, 0);
        Educable = GetComponent<Image>().material;
        Educable.SetVector("_Center", centerMat);
        //计算当前高亮显示区域的半径
        RectTransform canRectTransform = canva.transform as RectTransform;
        if (canRectTransform != null)
        {
            //获取画布区域的四个顶点
            canRectTransform.GetWorldCorners(Lineage);
            //将画布顶点距离高亮区域中心最近的距离昨晚当前高亮区域半径的初始值
            foreach (var corner in Lineage)
            {
                SeaportMantle = Mathf.Max(Vector3.Distance(SwellAtCyclicPer(canva, corner), corner), SeaportMantle);
            }
        }
        Educable.SetFloat("_Slider", SeaportMantle);
    }
    /// <summary>
    /// 收缩速度
    /// </summary>
    private float PoliceMarginal= 0f;
    private void Update()
    {
        //从当前半径到目标半径差值显示收缩动画
        //float value = Mathf.SmoothDamp(currentRadius, radius, ref shrinkVelocity, shrinkTime);
        /*if (currentRadius < 150)
        {
            currentRadius = Mathf.SmoothDamp(radius, 500, ref shrinkVelocity, shrinkTime);
            currentRadius = 350;
            material.SetFloat("_Slider", currentRadius);
        }*/
        /*else
        {
            if (!Mathf.Approximately(value, currentRadius))
            {
                currentRadius = value;
                material.SetFloat("_Slider", currentRadius);
            }
        }*/
        
        //从当前半径到目标半径差值显示收缩动画
        float Trout= Mathf.SmoothDamp(SeaportMantle, Likely, ref PoliceMarginal, PolicePloy);
        if (!Mathf.Approximately(Trout, SeaportMantle))
        {
            SeaportMantle = Trout;
            Educable.SetFloat("_Slider", SeaportMantle);
            
        }
        
    }

    /// <summary>
    /// 世界坐标转换为画布坐标
    /// </summary>
    /// <param name="canvas">画布</param>
    /// <param name="world">世界坐标</param>
    /// <returns></returns>
    private Vector2 SwellAtCyclicPer(Canvas canvas, Vector3 world)
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, world, canvas.GetComponent<Camera>(), out position);
        return position;
    }
}
