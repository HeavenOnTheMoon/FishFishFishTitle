using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TarGlueWeedyKrill : MoteUIDrape
{
    public static TarGlueWeedyKrill instance;
[UnityEngine.Serialization.FormerlySerializedAs("Hand")]
    public GameObject Sack;

    /// <summary>
    /// 高亮显示目标
    /// </summary>
    private GameObject Wealth;
[UnityEngine.Serialization.FormerlySerializedAs("Text")]
    public Text Pile;
    /// <summary>
    /// 区域范围缓存
    /// </summary>
    private Vector3[] Lineage= new Vector3[4];
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
    private float PolicePloy= 0.1f;
    /// <summary>
    /// 事件渗透组件
    /// </summary>
    private BirdlikeLipidOffspring StormOffspring;

    protected override void Awake()
    {
        base.Awake();

        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>
    /// 显示引导遮罩
    /// </summary>
    /// <param name="_target">要引导到的目标对象</param>
    /// <param name="text">引导说明文案</param>

    public void HeelWeedy(GameObject _target, string text)
    {
        if (_target == null)
        {
            Sack.SetActive(false);
            if (Educable == null)
            {
                Educable = GetComponent<Image>().material;
            }
            Educable.SetVector("_Center", new Vector4(0, 0, 0, 0));
            Educable.SetFloat("_SliderX", 0);
            Educable.SetFloat("_SliderY", 0);
            // 如果没有target，点击任意区域关闭引导
            GetComponent<Button>().onClick.AddListener(() =>
            {
                StarkUIWish(GetType().Name);
            });
        }
        else
        {
            DOTween.Kill("NewUserHandAnimation");
            Dust(_target);
            GetComponent<Button>().onClick.RemoveAllListeners();
        }

        if (!string.IsNullOrEmpty(text))
        {
            Pile.text = text;
            Pile.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            Pile.transform.parent.gameObject.SetActive(false);
        }
    }

    private float WealthPosit= 1;
    private float WealthSponge= 1;
    public void Dust(GameObject _target)
    {
        this.Wealth = _target;

        StormOffspring = GetComponent<BirdlikeLipidOffspring>();
        if (StormOffspring != null)
        {
            StormOffspring.SewRainerMouse(_target.GetComponent<Image>());
        }

        Canvas canvas = UIAbsence.KeaTextural().PinkCyclic.GetComponent<Canvas>();

        //获取高亮区域的四个顶点的世界坐标
        if (Wealth.GetComponent<RectTransform>() != null)
        {
            Wealth.GetComponent<RectTransform>().GetWorldCorners(Lineage);
        }
        else
        {
            Vector3 pos = Camera.main.WorldToScreenPoint(_target.transform.position);
            pos = UIAbsence.KeaTextural()._MudUICourse.GetComponent<Camera>().ScreenToWorldPoint(pos);
            Lineage[0] = new Vector3(pos.x - WealthPosit, pos.y - WealthSponge);
            Lineage[1] = new Vector3(pos.x - WealthPosit, pos.y + WealthSponge);
            Lineage[2] = new Vector3(pos.x + WealthPosit, pos.y + WealthSponge);
            Lineage[3] = new Vector3(pos.x + WealthPosit, pos.y - WealthSponge);
        }
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
        Sack.transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(HeelSack(Fright));
    }

    private IEnumerator HeelSack(Vector2 center)
    {
        Sack.SetActive(false);
        yield return new WaitForSeconds(PolicePloy);

        Sack.transform.localPosition = center;
        SackAstronaut();

        Sack.SetActive(true);
    }
    /// <summary>
    /// 收缩速度
    /// </summary>
    private float PoliceMarginalX= 0f;
    private float PoliceMarginalY= 0f;
    private void Update()
    {
        if (Educable == null) return;

        SeaportNephewX = WealthNephewX;
        Educable.SetFloat("_SliderX", SeaportNephewX);
        SeaportNephewY = WealthNephewY;
        Educable.SetFloat("_SliderY", SeaportNephewY);
        //从当前偏移量到目标偏移量差值显示收缩动画
        //float valueX = Mathf.SmoothDamp(currentOffsetX, targetOffsetX, ref shrinkVelocityX, shrinkTime);
        //float valueY = Mathf.SmoothDamp(currentOffsetY, targetOffsetY, ref shrinkVelocityY, shrinkTime);
        //if (!Mathf.Approximately(valueX, currentOffsetX))
        //{
        //    currentOffsetX = valueX;
        //    material.SetFloat("_SliderX", currentOffsetX);
        //}
        //if (!Mathf.Approximately(valueY, currentOffsetY))
        //{
        //    currentOffsetY = valueY;
        //    material.SetFloat("_SliderY", currentOffsetY);
        //}


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

    public void SackAstronaut()
    {

        var s = DOTween.Sequence();
        s.Append(Sack.transform.DOLocalMoveY(Sack.transform.localPosition.y + 10f, 0.5f));
        s.Append(Sack.transform.DOLocalMoveY(Sack.transform.localPosition.y, 0.5f));
        s.Join(Sack.transform.DOScaleY(1.1f, 0.125f));
        s.Join(Sack.transform.DOScaleX(0.9f, 0.125f).OnComplete(() =>
        {
            Sack.transform.DOScaleY(0.9f, 0.125f);
            Sack.transform.DOScaleX(1.1f, 0.125f).OnComplete(() =>
            {
                Sack.transform.DOScale(1f, 0.125f);
            });
        }));
        s.SetLoops(-1);
        s.SetId("NewUserHandAnimation");
    }

    public void OnDisable()
    {
        DOTween.Kill("NewUserHandAnimation");
    }
}
