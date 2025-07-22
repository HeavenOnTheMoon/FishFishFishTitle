using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FareEmitSpeedy : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("scrollView")]    public RectTransform TariffWall;
[UnityEngine.Serialization.FormerlySerializedAs("topBar")]    public RectTransform RunLet;
[UnityEngine.Serialization.FormerlySerializedAs("bottomBar")]    public RectTransform UniqueLet;
    private void Awake()
    {
        TariffWall.anchoredPosition = new Vector2(0, -RunLet.sizeDelta.y);
        TariffWall.sizeDelta = new Vector2(UIAbsence.KeaTextural().PinkCyclic.GetComponent<CanvasScaler>().referenceResolution.x, UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().sizeDelta.y - RunLet.sizeDelta.y - UniqueLet.sizeDelta.y);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
