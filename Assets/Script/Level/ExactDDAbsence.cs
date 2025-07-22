using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ExactDDAbsence
{
    DateTime ApartAssetPloy;        //关卡开始时间
    int ApartBeerPloy;              //关卡已使用时间
    int China3AudioPloy;            //每次消除进行一次时间补偿
    public int ApartShoot;          //关卡的实时评分
    public levelDD GrayExactDD;     //用户的实时难度等级计算
    public enum levelDD
    {
        master = 0,
        hard = -1,
        mid = -2,
        easy = -3
    }

    public static ExactDDAbsence instance;
    public static ExactDDAbsence Textural    {
        get
        {
            if(null == instance)
            {
                instance = new ExactDDAbsence();
            }
            return instance;
        }
    }

    private ExactDDAbsence()
    {

    }

    
    public void ApartShootDust()
    {
        ApartAssetPloy = DateTime.Now;
        ApartBeerPloy = 0;
        China3AudioPloy = 0;
    }

    public void ApartShootPoor()
    {
        China3AudioPloy += 1;
        ApartBeerPloy += KeaVesselTwig.KeaTextural().SetLeakYard(ApartAssetPloy.ToString(), DateTime.Now);
        ApartAssetPloy = DateTime.Now;
        ApartShoot = ApartBeerPloy - China3AudioPloy;
        if (ApartShoot <= 60)
        {
            GrayExactDD = levelDD.master;
        }
        else if (ApartShoot > 60 && ApartShoot <= 150)
        {
            GrayExactDD = levelDD.hard;
        }
        else if (ApartShoot > 150 && ApartShoot <= 240)
        {
            GrayExactDD = levelDD.mid;
        }
        else
        {
            GrayExactDD = levelDD.easy;
        }
        //Debug.Log("Level: " + TreeTwigAbsence.GetInt(CSoviet.sv_Level_Id) + ", levelScore: " + levelScore + ", userLevelDD: " + userLevelDD);
    }

}
