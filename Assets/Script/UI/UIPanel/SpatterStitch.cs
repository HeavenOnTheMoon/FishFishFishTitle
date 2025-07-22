using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SpatterStitch : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("PuzzleImage")]    public GameObject StitchMouse;  //��ƤͼƬ
[UnityEngine.Serialization.FormerlySerializedAs("PuzzleGroup")]    public GameObject StitchAsian;  //�Աߵ���ʾ��
[UnityEngine.Serialization.FormerlySerializedAs("P")]    public Transform P;             //��ʾ���ĳ�ʼλ��
[UnityEngine.Serialization.FormerlySerializedAs("Value")]    public Text Attic;              //��Ƭ������

    
    /// <summary>
    /// ��Ƭ�ռ�����
    /// </summary>
    public void StitchAstronaut()
    {
        //��ʼ��
        Hydroponically();
        //��������
        var A = DOTween.Sequence();
        //��ƬͼƬ�Ŵ�
        A.Append(StitchMouse.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack));
        //�Աߵ���ʾ������
        A.Append(StitchAsian.transform.DOMoveX(StitchAsian.transform.position.x - 1.5f, 0.3f));
        //��Ƭλ�Ƶ���ʾ��
        A.Join(StitchMouse.GetComponent<RectTransform>().DOMove(new Vector3(StitchAsian.GetComponent<Transform>().Find("PuzzleIcon").position.x-1.5f, StitchAsian.transform.position.y, StitchAsian.transform.position.z), 0.5f).SetEase(Ease.InQuad).SetDelay(0.6f).OnComplete(()=> 
        {
            //λ�Ƶ�������ɵ�
            StitchMouse.SetActive(false);
            //�����޸���Ƭ������
            

        }));
        //�޸���Ƭ��С
        A.Join(StitchMouse.GetComponent<RectTransform>().DOScale(0.5f, 0.3f).SetEase(Ease.OutBack));
        //��ʾ����ʧ
        A.Append(StitchAsian.transform.DOMoveX(P.position.x, 0.5f)); 
        //��ɻص�
        A.AppendCallback(() =>
        {
            A.Kill();
            gameObject.SetActive(false);
        });
    }
    /// <summary>
    /// ��ʼ����Ƭλ��
    /// </summary>
    public void Hydroponically()
    {
        gameObject.SetActive(true);
        StitchMouse.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
        StitchMouse.GetComponent<RectTransform>().position = new Vector3(0, 0, 0);
        StitchAsian.GetComponent<RectTransform>().Find("PuzzleIcon").GetComponent<Image>().sprite = StitchMouse.GetComponent<Image>().sprite;
        StitchMouse.SetActive(true);
    }
    void Start()
    {
        P = StitchAsian.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
