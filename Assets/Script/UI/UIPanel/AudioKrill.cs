using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("AdButton")]    public Button WeInform;
[UnityEngine.Serialization.FormerlySerializedAs("GetButton")]    public Button KeaInform;
[UnityEngine.Serialization.FormerlySerializedAs("RewardImage")]    public Image BackupMouse;
[UnityEngine.Serialization.FormerlySerializedAs("RewardPuzzleImage")]    public Image BackupStitchMouse;
[UnityEngine.Serialization.FormerlySerializedAs("RewardValue")]    public Text BackupAttic;

    private TileReward Quartz;

    // Start is called before the first frame update
    void Start()
    {
        KeaInform.onClick.AddListener(() =>
        {
            WePool.Textural.BeerContributionWe(10009, (success) =>
            {
                if (success)
                {
                    
                }
            });

            // 播放成功逻辑处理
            RidBackup();
            Seem.instance.resetWayBackupPloy();
            StarkUIWish(GetType().Name);
        });

        WeInform.onClick.AddListener(() =>
        {
            WePool.Textural.BeerBackupWe(10004, (success) =>
            {
                if (success)
                {
                    //bx 广告位
                    KeaInform.gameObject.SetActive(false);
                    WeInform.gameObject.SetActive(false);
                    WeInform.enabled = false;
                    AstronautAttainment.FaucetSupply(Quartz.rewardValue, Quartz.rewardValue * 2, 0.1f, BackupAttic, "+", () => {
                        Quartz.rewardValue *= 2;
                        BackupAttic.text = "+" + SupplyTide.InvestAtFir(Quartz.rewardValue);
                        RidBackup();
                        Seem.instance.resetWayBackupPloy();
                        StarkUIWish(GetType().Name);
                        //GetButton.enabled = true;
                        //GetButton.gameObject.SetActive(true);
                    });
                }
            });
           
            
        });
    }

    public override void Display()
    {
        base.Display();

        KeaInform.gameObject.SetActive(true);
        WeInform.gameObject.SetActive(true);
        KeaInform.enabled = true;
        WeInform.enabled = true;

        Quartz = Seem.instance.WayBackup;
        if (Quartz == null)
        {
            StarkUIWish(GetType().Name);
        }

        if (Quartz.rewardType == RewardType.gold)
        {
            BackupMouse.gameObject.SetActive(true);
            BackupStitchMouse.gameObject.SetActive(false);
            BackupMouse.sprite = Resources.Load<Sprite>(CSoviet.ASo_Audio_Chic);
        } 
        else if(Quartz.rewardType == RewardType.cash)
        {
            BackupMouse.gameObject.SetActive(true);
            BackupStitchMouse.gameObject.SetActive(false);
            BackupMouse.sprite = Resources.Load<Sprite>(CSoviet.ASo_Audio_Soar);
        } 
        else if(Quartz.rewardType == RewardType.amazon)
        {
            BackupMouse.gameObject.SetActive(true);
            BackupStitchMouse.gameObject.SetActive(false);
            BackupMouse.sprite = Resources.Load<Sprite>(CSoviet.ASo_Audio_Carman);
        } 
        //else if(reward.rewardType == RewardType.puzzle)
        //{
        //    RewardImage.gameObject.SetActive(false);
        //    RewardPuzzleImage.gameObject.SetActive(true);
        //    Puzzle puzzle = reward.puzzle;
        //    RewardPuzzleImage.sprite = Resources.Load<Sprite>(puzzle.puzzle_img);
        //}

        BackupAttic.text = "+" + SupplyTide.InvestAtFir(Quartz.rewardValue);
    }

    private void RidBackup()
    {
        if (Quartz.rewardType == RewardType.gold)
        {
            Transform P= UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().Find("Normal/ExactKrill/GoldBar/GoldIcon");
            Transform A = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>();
            A.position = new Vector3(0, 0, 0);
            AstronautAttainment.ChicGiveKeel(P.gameObject,15, A, P,()=> 
            {
                Seem.instance.RidChic(Quartz.rewardValue); 
            });
            
        }
        else if (Quartz.rewardType == RewardType.cash)
        {
            Transform P = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().Find("Normal/ExactKrill/CashBar/CashIcon");
            Transform A = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>();
            A.position = new Vector3(0, 0, 0);
            AstronautAttainment.ChicGiveKeel(P.gameObject, 15, A,P, () =>
            {
                Seem.instance.RidSoar(Quartz.rewardValue);
            });
        }
        else if (Quartz.rewardType == RewardType.amazon)
        {
            Transform P = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>().Find("Normal/ExactKrill/AmazonBar/AmazonIcon");
            Transform A = UIAbsence.KeaTextural().PinkCyclic.GetComponent<RectTransform>();
            A.position = new Vector3(0, 0, 0);
            AstronautAttainment.ChicGiveKeel(P.gameObject, 15, A, P, () =>
            {
                Seem.instance.RidCarman(Quartz.rewardValue);
            });
            
        }
        else if (Quartz.rewardType == RewardType.puzzle)
        {
        //    SOHOShopManager.instance.AddRewardPuzzle(reward.puzzle);
        }
    }
}
