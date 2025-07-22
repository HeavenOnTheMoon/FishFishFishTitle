using System;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 矩形遮罩镂空
/// </summary>
public class YardBirdlike : MonoBehaviour
{
    public static YardBirdlike instance;
[UnityEngine.Serialization.FormerlySerializedAs("target")]    /// <summary>
    /// 高亮显示目标
    /// </summary>
    public Image Wealth;
[UnityEngine.Serialization.FormerlySerializedAs("ClickBtn")]
    public Button PhotoBow;
[UnityEngine.Serialization.FormerlySerializedAs("Text")]    public Text Pile;
    /// <summary>
    /// 区域范围缓存
    /// </summary>
    private Vector3[] Lineage= new Vector3[4];
    /// <summary>
    /// 镂空区域中心
    /// </summary>
    private Vector4 Fright;
    /// <summary>
    /// 最终的偏移x
    /// </summary>
    private float WealthNephewX= 0;
    /// <summary>
    /// 最终的偏移y
    /// </summary>
    private float WealthNephewY= 0;
    /// <summary>
    /// 遮罩材质
    /// </summary>
    private Material Educable;
    /// <summary>
    /// 当前的偏移x
    /// </summary>
    private float SeaportNephewX= 0f;
    /// <summary>
    /// 当前的偏移y
    /// </summary>
    private float SeaportNephewY= 0f;
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
        PhotoBow.onClick.AddListener(() =>
        {
            if (Introductory != 5)
            {
                gameObject.SetActive(false);
                GrandeOntoKrill.instance.Weedy(Introductory + 1);
            }
        });
    }
[UnityEngine.Serialization.FormerlySerializedAs("Currentindex")]
    public int Introductory;
    public void Dust(Image target, int index)
    {
        this.Wealth = target;
        Introductory = index;
        if (index == 0)
        {
            Pile.transform.parent.gameObject.SetActive(true);
            Pile.transform.parent.GetChild(1).gameObject.SetActive(true);
            Pile.transform.parent.GetChild(0).gameObject.SetActive(false);
            //Text.text = "Use diamond and gold to claim";
        }
        else if(index == 2)
        {
            Pile.transform.parent.gameObject.SetActive(true);
            Pile.transform.parent.GetChild(1).gameObject.SetActive(false);
            Pile.transform.parent.GetChild(0).gameObject.SetActive(true);
            //Text.text = "Play game and collect skin pieces";
        }
        else
        {
            Pile.transform.parent.gameObject.SetActive(false);
        }

        if (index == 1 && index == 3)
        {
            StormOffspring = GetComponent<BirdlikeLipidOffspring>();
            if (StormOffspring != null)
            { 
                StormOffspring.SewRainerMouse(target);
            }
        }
        
#if EmojiMerge
        Canvas canvas = GameObject.Find("RobloxCanvas(Clone)").GetComponent<Canvas>();
#else
        Canvas canvas = GameObject.Find("Canvas(Clone)").GetComponent<Canvas>();
#endif
        
        //Canvas canvas = /*GameController.Instance.Canvas*/null;
        //获取高亮区域的四个顶点的世界坐标
        target.rectTransform.GetWorldCorners(Lineage);
        //计算高亮显示区域在画布中的范围
        WealthNephewX = Vector2.Distance(SwellAtCyclicPer(canvas, Lineage[0]), SwellAtCyclicPer(canvas, Lineage[3])) / 2f;
        WealthNephewY = Vector2.Distance(SwellAtCyclicPer(canvas, Lineage[0]), SwellAtCyclicPer(canvas, Lineage[1])) / 2f;
        //计算高亮显示区域的中心
        float x= Lineage[0].x + ((Lineage[3].x - Lineage[0].x) / 2);
        float y= Lineage[0].y + ((Lineage[1].y - Lineage[0].y) / 2);
        Vector3 centerWorld = new Vector3(x, y, 0);
        Vector2 Fright= SwellAtCyclicPer(canvas, centerWorld);
        //设置遮罩材质中的中心变量
        Vector4 centerMat = new Vector4(Fright.x, Fright.y, 0, 0);
        Educable = GetComponent<Image>().material;
        Educable.SetVector("_Center", centerMat);
        //计算当前高亮显示区域的半径
        RectTransform canRectTransform = canvas.transform as RectTransform;
        if (canRectTransform != null)
        {
            //获取画布区域的四个顶点
            canRectTransform.GetWorldCorners(Lineage);
            //计算偏移初始值
            for (int i = 0; i < Lineage.Length; i++)
            {
                if (i % 2 == 0)
                {
                    SeaportNephewX = Mathf.Max(Vector3.Distance(SwellAtCyclicPer(canvas, Lineage[i]), Fright), SeaportNephewX);
                }
                else
                {
                    SeaportNephewY = Mathf.Max(Vector3.Distance(SwellAtCyclicPer(canvas, Lineage[i]), Fright), SeaportNephewY);
                }
            }
        }
        //设置遮罩材质中当前偏移的变量
        Educable.SetFloat("_SliderX", SeaportNephewX);
        Educable.SetFloat("_SliderY", SeaportNephewY);
    }
    /// <summary>
    /// 收缩速度
    /// </summary>
    private float PoliceMarginalX= 0f;
    private float PoliceMarginalY= 0f;
    private void Update()
    {
        //从当前偏移量到目标偏移量差值显示收缩动画
        float valueX = Mathf.SmoothDamp(SeaportNephewX, WealthNephewX, ref PoliceMarginalX, PolicePloy);
        float valueY = Mathf.SmoothDamp(SeaportNephewY, WealthNephewY, ref PoliceMarginalY, PolicePloy);
        if (!Mathf.Approximately(valueX, SeaportNephewX))
        {
            SeaportNephewX = valueX;
            Educable.SetFloat("_SliderX", SeaportNephewX);
        }
        if (!Mathf.Approximately(valueY, SeaportNephewY))
        {
            SeaportNephewY = valueY;
            Educable.SetFloat("_SliderY", SeaportNephewY);
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
