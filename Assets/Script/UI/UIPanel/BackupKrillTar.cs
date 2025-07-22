using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackupKrillTar : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("PanelShowList")]
    public List<GameObject> KrillHeelForm;
[UnityEngine.Serialization.FormerlySerializedAs("List_RewardItem")]    public List<BackupSuck> Form_BackupSuck;

    [Header("��ť")]
[UnityEngine.Serialization.FormerlySerializedAs("ADButton")]    public Button ADInform;
[UnityEngine.Serialization.FormerlySerializedAs("ReceiveButton")]    public Button ReceiveInform;
    [Header("ת����")]
[UnityEngine.Serialization.FormerlySerializedAs("SlotBG")]    public FordAsian FordBG;
    [Header("���")]
[UnityEngine.Serialization.FormerlySerializedAs("ADText")]    public Transform ADPile;
[UnityEngine.Serialization.FormerlySerializedAs("ADImage")]    public Transform ADMouse;

    private RewardPanelData _QuartzTwig;
    GameObject BackupMouse;
    private double Quartz;   // token����
    private bool BoreBackupGrade= false;
[UnityEngine.Serialization.FormerlySerializedAs("flytrans")]    public Transform Hesitate;
    protected override void Awake()
    {
        base.Awake();
       // HandfulCannon.AddMsgListener(MexicoGloss.FlyRewardData, OnLevelCompleteData);
    }

    public override void Display()
    {
        base.Display();
        BoreBackupGrade = false;
        //RewardCount(2);
        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.reward_panel_open);
        BackupKrillHeelMat();
        ReceiveInform.enabled = true;
        ReceiveInform.gameObject.SetActive(false);
        ADInform.enabled = true;
        ADInform.gameObject.SetActive(true);
        StartCoroutine(nameof(WifeGenuInform));
        FordBG.AsiaSharp();
        OnLevelCompleteData();
;    }

    // Start is called before the first frame update
    void Start()
    {   
        ADInform.onClick.AddListener(() => {
            //bx ���λ

            StopCoroutine(nameof(WifeGenuInform));
            ADInform.enabled = false;
            BoreBackupGrade = true;
            BoreFord();
        });
        ReceiveInform.onClick.AddListener(() => 
        {
            ReceiveInform.enabled = false;
          
            //bx  �������
            StarkUIWish(GetType().Name);
            //   RewardPanelMove(2, () => { });
            //�ֽ�
            foreach (var item in _QuartzTwig.Flu_Backup)
            {
                Seem.instance.RidSoar(item.Value, Hesitate);
            }
           // BackupAbsence.GetInstance().AddMoneyToCache(_rewardData.Dic_Reward);
        });
    }

   // private void OnLevelCompleteData(KeyValuesUpdate kv)
     private void OnLevelCompleteData()
    {
        KeyValuesUpdate kv = TugTourOil.instance.Supervise;
        RewardPanelData Luck= (RewardPanelData)kv.Chilly;
        _QuartzTwig = Luck;
        StarkBackupGalaxy();
        OnSetRewardPosition(Luck.Flu_Backup.Count);
        int Calve= 0;
        foreach (var item in Luck.Flu_Backup)
        {
            Form_BackupSuck[Calve].gameObject.SetActive(true);
            Form_BackupSuck[Calve].SewBackupTwig(item.Key, item.Value);
            Calve++;
        }
    }

    IEnumerator WifeGenuInform()
    {
        yield return new WaitForSeconds(2);
        if (!AnTarGlue())
        {
            ReceiveInform.gameObject.SetActive(true);
        }
    }

    private void OnSetRewardPosition(int count)
    {
        if (count == 1)
        {
            Form_BackupSuck[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(0,95, 0);
            Form_BackupSuck[0].transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (count == 2)
        {
            Form_BackupSuck[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(-150, 270, 0);
            Form_BackupSuck[0].transform.localScale = new Vector3(1.5f, 1.5f, 1f);
            Form_BackupSuck[1].GetComponent<RectTransform>().anchoredPosition = new Vector3(150, 270, 0);
            Form_BackupSuck[1].transform.localScale = new Vector3(1.5f, 1.5f, 1f);
        }
        else
        {
            Form_BackupSuck[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 370, 0);
            Form_BackupSuck[1].GetComponent<RectTransform>().anchoredPosition = new Vector3(-150, 170, 0);
            Form_BackupSuck[2].GetComponent<RectTransform>().anchoredPosition = new Vector3(150, 170, 0);
        }
    }

    private void StarkBackupGalaxy()
    {
        for (int i = 0; i < Form_BackupSuck.Count; i++)
        {
            Form_BackupSuck[i].transform.localScale = new Vector3(1f, 1f, 1f);
            Form_BackupSuck[i].gameObject.SetActive(false);
        }
    }

    public void BackupKrillHeelMat() 
    {
        float DelayTime = 0;
        for (int i = 0; i < KrillHeelForm.Count; i++)
        {
            GameObject Suck = KrillHeelForm[i];
            Suck.transform.localScale = new Vector3(0, 0, 0);
            Suck.transform.DOScale(1, 0.3f).SetEase(Ease.OutBack).SetDelay(DelayTime);
            DelayTime += 0.1f;
        }
    }

    /*public void RewardCount(int index) 
    {
        for (int i = 0; i < RewardIndex.Count; i++)
        {
            if (i == index-1)
            {
                RewardIndex[i].SetActive(true);
            }
            else
            {
                RewardIndex[i].SetActive(false);
            }
        }
    }*/

    private bool AnTarGlue()
    {
        return !PlayerPrefs.HasKey(CSoviet.Or_NevusFord + "Bool") || TreeTwigAbsence.GetBool(CSoviet.Or_NevusFord);
    }

    private void BoreFord()
    {
        ReceiveInform.gameObject.SetActive(false);
        ADInform.gameObject.SetActive(false);
        int Calve= TieFordSharpBrace();
        FordBG.Cone(Calve, (multi) => {
            // slot������Ļص�
            // ��ֵ�仯TODO
            int Calve= 0;
            foreach (var item in _QuartzTwig.Flu_Backup)
            {
                Text rewardText = Form_BackupSuck[Calve].BackupPile;
                double rewardValue = item.Value;
                RewardType Dash= item.Key;
                AstronautAttainment.FaucetSupply(rewardValue, rewardValue * multi, 0, rewardText, "+", () =>
                {
                    rewardValue = rewardValue * multi;
                    rewardText.text = "+" + SupplyTide.InvestAtFir(rewardValue);
                    _QuartzTwig.Flu_Backup[Dash] = rewardValue;
                    ReceiveInform.gameObject.SetActive(true);
                });
                Calve++;
            }
            
            //ADButton.gameObject.SetActive(true);
        });
    }

    private int TieFordSharpBrace()
    {
        // ���û�����һ�ι̶���5��
        if (AnTarGlue())
        {
            int Calve= 0;
            foreach (SlotItem wg in TugTourOil.instance.DustTwig.slot_group)
            {
                if (wg.multi == 2)
                {
                    return Calve;
                }
                Calve++;
            }
        }
        else
        {
            int sumWeight = 0;
            foreach (SlotItem wg in TugTourOil.instance.DustTwig.slot_group)
            {
                sumWeight += wg.weight;
            }
            int r =UnityEngine.Random.Range(0, sumWeight);
            int nowWeight = 0;
            int Calve= 0;
            foreach (SlotItem wg in TugTourOil.instance.DustTwig.slot_group)
            {
                nowWeight += wg.weight;
                if (nowWeight > r)
                {
                    return Calve;
                }
                Calve++;
            }

        }
        return 0;
    }

    /// <summary>
    /// ��ȡ����
    /// </summary>
    /// <param name="index">1=��ң�2=����ѷ����3=�ֽ�</param>
    /// <param name="finish">��ɻص�</param>
    public void BackupKrillGive(int index,System.Action finish )
    {
        float delayTime = 0;
        //��ʼ��
        for (int i = 0; i < 5; i++)
        {
            int a = i;
            GameObject GoldIcon = Instantiate(BackupMouse, BackupMouse.transform.parent);
            GoldIcon.transform.position = new Vector3(0, 0, 0);
            GoldIcon.SetActive(true);
            GoldIcon.transform.DOMove(BackupMouse.transform.position, 0.6f).SetDelay(delayTime).OnComplete(() =>
            {
                if (a == 4)
                {

                    finish();
                }
                Destroy(GoldIcon);
            });
            delayTime += 0.1f;
        }

    }
}
