using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackupAbsence : WellSweatshop<BackupAbsence>
{
    public void WifeExactAnyplaceKrill(RewardPanelData data)
    {
        KeyValuesUpdate keyValues = new KeyValuesUpdate(MexicoGloss.TowBackupTwig, data);
        TugTourOil.instance.Supervise = keyValues;
        UIAbsence.KeaTextural().HeelUIDrape(nameof(BackupKrillTar));
        HandfulCannon.CornHandful(MexicoGloss.TowBackupTwig, keyValues);
    }

    /// <summary>
    /// �ѻ������ӵ�������
    /// </summary>
    /// <param name="Dic_Reward"></param>
    public void DamTouchAtSpine(Dictionary<RewardType, double> Dic_Reward)
    {
        foreach (var item in Dic_Reward)
        {
            if (item.Key == RewardType.gold)
            {
                //���
                Seem.instance.RidChic(item.Value);
            }
            else if (item.Key == RewardType.cash)
            {
                //�ֽ�
                Seem.instance.RidSoar(item.Value);
            }
            else if (item.Key == RewardType.amazon)
            {
                ////����ѷ
                //SeemTwigAbsence.GetInstance().addAmazon(item.Value);
                //SendScoreUpdate(Dic_Reward);
            }
            //else if (item.Key == RewardType.rocket)
            //{
            //    //SkillManager.GetInstance().SetRocketNumber((int)item.Value);
            //}
            //else if (item.Key == RewardType.universal)
            //{
                //SkillManager.GetInstance().SetOmnipotentNumber((int)item.Value);
            //}
           // else if (item.Key == RewardType.laser)
            //{
               // SkillManager.GetInstance().SetLaserNumber((int)item.Value);
           // }
        }
    }

    /// <summary>
    /// ���ӻ���
    /// </summary>
    /// <param name="score"></param>
    public void DamShoot(int index, double score)
    {
        Dictionary<RewardType, double> Flu_Backup= new();
        if (index == 10)
        {

            Seem.instance.RidChic(score);
            //���
            //SeemTwigAbsence.GetInstance().addGold(score);
            //Dic_Reward.Add(RewardType.gold, score);
        }
        else if (index == 11)
        {
            //����ѷ
            Seem.instance.RidCarman(score);
           // Dic_Reward.Add(RewardType.amazon, score);
        }
        else if (index == 12)
        {
            //�ֽ�
            Seem.instance.RidSoar(score);
          //  Dic_Reward.Add(RewardType.cash, score);
        }
     //   SendScoreUpdate(null);
        //SendScoreUpdate(Dic_Reward);
    }

    public void CornShootRejoin(Dictionary<RewardType, double> Dic_Reward)
    {
        //KeyValuesUpdate key = new KeyValuesUpdate(MexicoGloss.SendScoreUpdate, Dic_Reward);
        //HandfulCannon.SendMessage(MexicoGloss.SendScoreUpdate, key);
    }
}


public class RewardPanelData
{
    /// <summary>
    /// С��Ϸ����
    /// </summary>
    public string SoftTern;
    public Dictionary<RewardType, double> Flu_Backup;

    public RewardPanelData()
    {
        Flu_Backup = new();
    }
}
