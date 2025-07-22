using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeemTwigAbsence : WellSweatshop<SeemTwigAbsence>
{
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    public void InitGameData()
//    {
//#if SOHOShop
//        // 提现商店初始化
//        // 提现商店中的金币、现金和amazon卡均为double类型，参数请根据具体项目自行处理
//        SOHOShopManager.instance.InitSOHOShopAction(
//            getToken,
//            getGold, 
//            getAmazon,    // amazon
//            (subToken) => { addToken(-subToken); }, 
//            (subGold) => { addGold(-subGold); }, 
//            (subAmazon) => { addAmazon(-subAmazon); });
//#endif
//    }

//    // 金币
//    public double getGold()
//    {

//        return TreeTwigAbsence.GetDouble(CSoviet.sv_GoldCoin);
//    }

//    public void addGold(double gold)
//    {
//        addGold(gold, PinkAbsence.instance.transform);
//    }

//    public void addGold(double gold, Transform startTransform)
//    {
//        double oldGold = TreeTwigAbsence.GetDouble(CSoviet.sv_GoldCoin);
//        TreeTwigAbsence.SetDouble(CSoviet.sv_GoldCoin, oldGold + gold);
//        if (gold > 0)
//        {
//            TreeTwigAbsence.SetDouble(CSoviet.sv_CumulativeGoldCoin, TreeTwigAbsence.GetDouble(CSoviet.sv_CumulativeGoldCoin) + gold);
//        }
//        HandfulTwig md = new HandfulTwig(oldGold);
//        md.valueTransform = startTransform;
//        HandfulCannonForth.GetInstance().Send(CSoviet.mg_ui_addgold, md);
//    }
    
//    // 现金
//    public double getToken()
//    {
//        return TreeTwigAbsence.GetDouble(CSoviet.sv_Token);
//    }

//    public void addToken(double token)
//    {
//        addToken(token, PinkAbsence.instance.transform);
//    }
//    public void addToken(double token, Transform startTransform)
//    {
//        double oldToken = PlayerPrefs.HasKey(CSoviet.sv_Token) ? double.Parse(TreeTwigAbsence.GetString(CSoviet.sv_Token)) : 0;
//        double newToken = oldToken + token;
//        TreeTwigAbsence.SetDouble(CSoviet.sv_Token, newToken);
//        if (token > 0)
//        {
//            double allToken = TreeTwigAbsence.GetDouble(CSoviet.sv_CumulativeToken);
//            TreeTwigAbsence.SetDouble(CSoviet.sv_CumulativeToken, allToken + token);
//        }
//#if SOHOShop
//        SOHOShopManager.instance.UpdateCash();
//#endif
//        HandfulTwig md = new HandfulTwig(oldToken);
//        md.valueTransform = startTransform;
//        HandfulCannonForth.GetInstance().Send(CSoviet.mg_ui_addtoken, md);
//    }

//    //Amazon卡
//    public double getAmazon()
//    {
//        return TreeTwigAbsence.GetDouble(CSoviet.sv_Amazon);
//    }

//    public void addAmazon(double amazon)
//    {
//        addAmazon(amazon, PinkAbsence.instance.transform);
//    }
//    public void addAmazon(double amazon, Transform startTransform)
//    {
//        double oldAmazon = PlayerPrefs.HasKey(CSoviet.sv_Amazon) ? double.Parse(TreeTwigAbsence.GetString(CSoviet.sv_Amazon)) : 0;
//        double newAmazon = oldAmazon + amazon;
//        TreeTwigAbsence.SetDouble(CSoviet.sv_Amazon, newAmazon);
//        if (amazon > 0)
//        {
//            double allAmazon = TreeTwigAbsence.GetDouble(CSoviet.sv_CumulativeAmazon);
//            TreeTwigAbsence.SetDouble(CSoviet.sv_CumulativeAmazon, allAmazon + amazon);
//        }
//        HandfulTwig md = new HandfulTwig(oldAmazon);
//        md.valueTransform = startTransform;
//        HandfulCannonForth.GetInstance().Send(CSoviet.mg_ui_addamazon, md);
//    }
}
