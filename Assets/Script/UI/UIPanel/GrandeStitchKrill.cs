using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class GrandeStitchKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("ItemList")]    
    public List<GameObject> SuckForm;
[UnityEngine.Serialization.FormerlySerializedAs("CardSetDealy")]    public float JazzSewDance;
[UnityEngine.Serialization.FormerlySerializedAs("adButton")]    public Button OrInform;
    List<AddIdAndValue> TroutForm;


    // Start is called before the first frame update
    void Start()
    {

        OrInform.onClick.AddListener(() =>
        {
            OrInformAffair();
        });
    }
    void Asia()
    {
        TroutForm = new List<AddIdAndValue>();
        foreach (GameObject obj in SuckForm)
        {
            Transform Icon = obj.transform.Find("Image");
            Transform Pile= obj.transform.Find("Text");
            AddIdAndValue Trout= GrandeOntoTwigAbsence.instance.KeaGrandeBackup();
            TroutForm.Add(Trout);
            Pile.GetComponent<Text>().text = "+" + Trout.Trout;
            Icon.GetComponent<Image>().sprite = GrandeOntoTwigAbsence.instance.KeaVanishOfID(Trout.ID);
        }
    }
    void OrInformAffair()       //[TODO]动效、音效
    {
        //bx 广告位
        GrandeOntoTwigAbsence.instance.Marketplace(TroutForm);
        /*HandfulCannonForth.GetInstance().Send(CSoviet.mg_HomePanelAddPuzzle);*/

        JazzWhig(() => { Xenon(); });
        StarkUIWish(GetType().Name);
    }

    public void JazzAsian(System.Action finish) 
    {
        
        float delaytime = 0;
        int count = 0;
        for (int i = 0; i < SuckForm.Count; i++) 
        {
            GameObject Card = SuckForm[i];
             
            
            StartCoroutine(Moccasin(() => 
            {
                JazzHeel(Card,1,()=> {
                    count++;
                    if (count == SuckForm.Count)
                    {
                        Seem.instance.ValidSeemAdultDownYam();
                    }
                });
            }, delaytime));
            delaytime += JazzSewDance;
            if (i == SuckForm.Count - 1) 
            {
                finish();
                
            }
        }
    }

    public void JazzWhig(System.Action finish) 
    {

        for (int i = 0; i < SuckForm.Count; i++) 
        {
            
            JazzHeel(SuckForm[i], 2);
            SuckForm[i].SetActive(false);
            if (i == SuckForm.Count - 1) 
            {
                finish();
            }
        }
    }

    IEnumerator Moccasin(System.Action finish, float delaytime)
    {
        yield return new WaitForSeconds(delaytime);
        finish();
    }
    public void JazzHeel(GameObject CardItem, int i, System.Action finish = null)
    {
        
        HandfulTwig Luck= new HandfulTwig();
        Sequence Card = DOTween.Sequence();
        Sequence Hint = DOTween.Sequence();
        Hint.SetId("cardanimtaionHint");
        Card.SetId("cardanimtaion");
        CardItem.transform.eulerAngles = new Vector3(0, 0, 0);
        Vector3 StartTransformPS = CardItem.transform.position;
        Vector3 StartTransformRT = CardItem.transform.eulerAngles;
        Vector3 StartTransformSC = CardItem.transform.localScale;
        if (i == 1)
        {

            Card.Append(CardItem.transform.DORotate(new Vector3(0, 90, 15), 0.2f));
            Card.Insert(0, CardItem.transform.DOScale(CardItem.transform.localScale * 1.1f, 0.2f));
            Card.Insert(0, CardItem.transform.DOMoveY(CardItem .transform.position.y+ 0.2f, 0.1f));
            Card.Append(CardItem.transform.DORotate(new Vector3(0, 180, 0), 0.2f).OnComplete(() =>
            {
                CardItem.GetComponent<Transform>().Find("Fx_Rotate_Light06").gameObject.SetActive(true);
            }));
            Card.Insert(0.4f, CardItem.transform.DOMoveY(StartTransformPS.y, 0.1f));
            Card.Append(CardItem.transform.DOScale(StartTransformSC, 0.2f).SetEase(Ease.OutBack).OnComplete(() =>
            {
                CardItem.GetComponent<Transform>().Find("").gameObject.SetActive(true);
                finish();
            }));
        }
        else if (i==2)
        {
            /*Debug.Log("puzzle位置" + data.valueGameObject5.transform.position.y);*/
            CardItem.transform.eulerAngles = new Vector3(0, 180, 0);
            GameObject cardcopy = Instantiate(CardItem, UIAbsence.KeaTextural().PinkCyclic.transform);
            
            /*CardItem.transform.DOScale(0, 0.01f);*/
            cardcopy.transform.position = new Vector3(CardItem.transform.position.x, CardItem.transform.position.y, -2);
            Hint.Append(cardcopy.transform.DORotate(new Vector3(0, 90, 10), 0.3f).OnComplete(() =>
            {
                CardItem.GetComponent<Transform>().Find("Fx_Rotate_Light06").gameObject.SetActive(false);
            }));
            Hint.Insert(0, cardcopy.transform.DOScale(StartTransformSC * 0.7f, 0.3f).SetEase(Ease.OutBack));
            Hint.Append(cardcopy.transform.DORotate(new Vector3(0, 0, 0), 0.5f));
            Hint.Insert(0.3f, cardcopy.transform.DOScale(StartTransformSC * 0.4f, 0.3f)).OnComplete(() =>
            {
                Destroy(cardcopy);
                Hint.Kill();
            });
        }
        
    }
    public void Xenon()
    {
        for (int i = 0; i < SuckForm.Count; i++) 
        {
            SuckForm[i].transform.eulerAngles = new Vector3(0, 0, 0);
            

            /*StartCoroutine(setdelay(() =>
            {
                ItemList[i].SetActive(true);
            }, 1f));*/
            
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        DOTween.Kill("cardanimtaion");
        foreach (GameObject obj in SuckForm)
        {
            Transform LightImage = obj.transform.Find("Light");
            LightImage.DOKill();
        }
    }
    public override void Display()
    {
        base.Display();
        Seem.instance.AnewAdultDownYam();
        for (int i = 0; i < SuckForm.Count; i++)
        {

            SuckForm[i].SetActive(true);
        }
        
        StartCoroutine(Moccasin(() =>
        {
            JazzAsian(()=> { });
        },0.5f));
        
        //foreach (GameObject obj in ItemList)
        //{
        //    Transform LightImage = obj.transform.Find("Light");
        //    LightImage.DOLocalRotate(new Vector3(0, 0, -360), 4f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        //}
        Asia();
    }

    // Update is called once per frame

    void Update()
    {

    }
}
