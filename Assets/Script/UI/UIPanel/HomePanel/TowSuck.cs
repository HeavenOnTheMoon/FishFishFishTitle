using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TowSuck : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("FlyButton")]    public Button TowInform;
[UnityEngine.Serialization.FormerlySerializedAs("CashValue")]    public Text SoarAttic;

    private Sequence _Low1;
    private Sequence _Low2;

    private double _WhimShy;

    private void Awake()
    {
        TowInform.onClick.AddListener(() => {

            //if (NewbieManager.GetInstance().IsOpenNewbie) { return; }
            //if (BubbleManager.GetInstance().IsWinGame()) { return; }
            TowAbsence.Instance.AnWifeTow = true;
            TowAbsence.Instance.WifeIETow();
            KeaBackup();
            SpecifyTowSuck();
        });
        GunBikeMethyl();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("-----------------------------------------");
    }

    public void TowBeer()
    {
        transform.DOPlay();
        _Low1.Play();
        _Low2.Play();
    }

    public void TowAdult()
    {
        transform.DOPause();
        _Low1.Pause();
        _Low2.Pause();
    }

    public void TowArid()
    {
        _Low1.Kill();
        _Low2.Kill();
        transform.DOKill();
    }

    private void KeaBackup()
    {
        RewardPanelData Luck= new RewardPanelData();
        Luck.SoftTern = "Fly";
        Luck.Flu_Backup.Add(RewardType.cash, _WhimShy);
        BackupAbsence.KeaTextural().WifeExactAnyplaceKrill(Luck);
    }

    private void GunBikeMethyl()
    {
        _WhimShy = TugTourOil.instance.AnewTowTwig.multi * Seem.instance.TieSoarSharp();
        _WhimShy = Mathf.Ceil((float)_WhimShy);
        SoarAttic.text = "$" + _WhimShy;
        _Low1 = DOTween.Sequence();
        _Low2 = DOTween.Sequence();
        /*int leftOrRight = Random.Range(0, 2);
        if (leftOrRight == 0)
        {*/
            TillTow();
        /*}
        else
        {
            RigthFly();
        }*/
    }

    private void TillTow()
    {
        transform.localPosition = new Vector3(-450f, 0, 0);
        _Low1 = DOTween.Sequence();
        _Low2 = DOTween.Sequence();
        _Low1.Append(transform.DOLocalMoveY(-150f - Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
        _Low1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
        _Low1.SetLoops(-1);
        _Low1.Play();

       // _Via2.Append(transform.DOScale(0.75f, 0.5f).SetEase(Ease.Linear));
       // _Via2.Append(transform.DOScale(0.7f, 0.5f).SetEase(Ease.Linear));
        _Low2.SetLoops(-1);
        _Low2.Play();
        transform.DOLocalMoveX(450, 10f).SetEase(Ease.Linear).OnComplete(() =>
        {
            if (TowAbsence.Instance.AnWifeTow)
            {
                SpecifyTowSuck();
            }
            else
            {
                TowArid();
                StartCoroutine(BeamTow(() => { EtherTow(); }));
            }

        });
    }

    private void EtherTow()
    {
        transform.localPosition = new Vector3(450, 0, 0);
        _Low1 = DOTween.Sequence();
        _Low2 = DOTween.Sequence();
        _Low1.Append(transform.DOLocalMoveY(-150f - Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
        _Low1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
        _Low1.SetLoops(-1);
        _Low1.Play();

       // _Via2.Append(transform.DOScale(0.75f, 0.5f).SetEase(Ease.Linear));
       // _Via2.Append(transform.DOScale(0.7f, 0.5f).SetEase(Ease.Linear));
        _Low2.SetLoops(-1);
        _Low2.Play();
        transform.DOLocalMoveX(-450, 10f).SetEase(Ease.Linear).OnComplete(() =>
        {
            if (TowAbsence.Instance.AnWifeTow)
            {
                SpecifyTowSuck();
            }
            else
            {
                TowArid();
                StartCoroutine(BeamTow(() => { TillTow(); }));
            }

        });
    }

    IEnumerator BeamTow(Action action)
    {
        yield return new WaitForSeconds(5f);
        action?.Invoke();
    }

    public void SpecifyTowSuck()
    {
        TowArid();
        GetComponent<RectTransform>().DOKill();
        Destroy(gameObject);
    }

}
