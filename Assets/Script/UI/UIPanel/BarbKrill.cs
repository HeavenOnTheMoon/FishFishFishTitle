using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class BarbKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("TipsBG")]    public GameObject BarbBG;
[UnityEngine.Serialization.FormerlySerializedAs("Text")]    public GameObject Pile;
    // Start is called before the first frame update
    public override void Display()
    {

        base.Display();
        ToneBarb();
    }

    void ToneBarb()
    {
        BarbBG.transform.position = new Vector3(0, -1f, 0);
        var q = DOTween.Sequence();
        q.Append(BarbBG.GetComponent<CanvasGroup>().DOFade(0.9f, 0.2f));
        q.Insert(0,BarbBG.transform.DOMoveY(0, 1f).SetEase(Ease.OutQuart));
        q.Insert(2f,BarbBG.GetComponent<CanvasGroup>().DOFade(0, 0.2f).OnComplete(() =>
        {
            StarkUIWish(GetType().Name);
            q.Kill();
        }));
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
