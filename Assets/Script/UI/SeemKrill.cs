using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeemKrill : MoteUIDrape
{
//    public Button SettingButton;
//    public Button LevelCompleteButton;
//#if SOHOShop
//    public Button SOHOShopButton;
//    public Button GoldButton;
//    public Button AmazonButton;
//    public Button PuzzleShopButton;
//#endif

//    public Image GoldImage;
//    public Text GoldNumberText;
//    public Image TokenImage;
//    public Text TokenNumberText;
//    public Image AmazonImage;
//    public Text AmazonNumberText;

//    public Button AdTestButton;
//    public Button AdjustTestButton;

//    public Button AddCashPreConditionButton;
//    public Button AddCashTaskValueButton;


//    // Start is called before the first frame update
//    void Start()
//    {
//        SettingButton.onClick.AddListener(() =>
//        {
//            UIAbsence.GetInstance().ShowUIForms("RapportKrill");
//        });

//        LevelCompleteButton.onClick.AddListener(() =>
//        {
//            UIAbsence.GetInstance().ShowUIForms("ExactAnyplaceKrill");
//        });

//#if SOHOShop
//        SOHOShopButton.onClick.AddListener(() => {
//            SOHOShopManager.instance.ShowRedeemPanel();
//        });

//        GoldButton.onClick.AddListener(() => {
//            if (!LethalUtil.IsApple())
//            {
//                SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
//            }
//        });
//        AmazonButton.onClick.AddListener(() => {
//            if (!LethalUtil.IsApple())
//            {
//                SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
//            }
//        });
//        PuzzleShopButton.onClick.AddListener(() => {
//            SOHOShopManager.instance.ShowRedeemGiftPanel();
//        });
//#endif

//        AdTestButton.onClick.AddListener(() => {
//            UIAbsence.GetInstance().ShowUIForms("AdManagerTestPanel");
//        });

//        AdjustTestButton.onClick.AddListener(() => {
//            UIAbsence.GetInstance().ShowUIForms("AdjustTestPanel");
//        });

//        // 处理消息
//        HandfulCannonForth.GetInstance().Register(CSoviet.mg_ui_addgold, (messageData) =>
//        {
//            goldAddAnimation(messageData.valueTransform, messageData.valueDouble);
//        });
//        HandfulCannonForth.GetInstance().Register(CSoviet.mg_ui_addtoken, (messageData) =>
//        {
//            tokenAddAnimation(messageData.valueTransform, messageData.valueDouble);
//        });
//        HandfulCannonForth.GetInstance().Register(CSoviet.mg_ui_addamazon, (messageData) =>
//        {
//            amazonAddAnimation(messageData.valueTransform, messageData.valueDouble);
//        });

//        AddCashPreConditionButton.onClick.AddListener(() => {
//            SOHOShopManager.instance.AddCashoutPreCondition("condition1", 1);
//        });

//        AddCashTaskValueButton.onClick.AddListener(() => {
//            SOHOShopManager.instance.AddTaskValue("customTask1", 1);
//        });

//    }

//    public override void Display()
//    {
//        base.Display();

//        GoldNumberText.text = SupplyTide.DoubleToStr(SeemTwigAbsence.GetInstance().getGold());
//        TokenNumberText.text = SupplyTide.DoubleToStr(SeemTwigAbsence.GetInstance().getToken());
//        AmazonNumberText.text = SupplyTide.DoubleToStr(SeemTwigAbsence.GetInstance().getAmazon());
//    }

//    public void goldAddAnimation(Transform startTransform, double num)
//    {
//        Transform endTransform = UIAbsence.GetInstance().MainCanvas.GetComponent<RectTransform>().Find("Normal/SeemKrill/TopBar/GoldBar/GoldImage");
//        addAnimation(startTransform, endTransform, GoldImage.gameObject, GoldNumberText, SeemTwigAbsence.GetInstance().getGold(), num);
//    }
//    public void tokenAddAnimation(Transform startTransform, double num)
//    {
//        Transform endTransform = UIAbsence.GetInstance().MainCanvas.GetComponent<RectTransform>().Find("Normal/SeemKrill/TopBar/TokenBar/TokenImage");
//        addAnimation(startTransform, endTransform, TokenImage.gameObject, TokenNumberText, SeemTwigAbsence.GetInstance().getToken(), num);
//    }
//    public void amazonAddAnimation(Transform startTransform, double num)
//    {
//        Transform endTransform = UIAbsence.GetInstance().MainCanvas.GetComponent<RectTransform>().Find("Normal/SeemKrill/TopBar/AmazonBar/AmazonImage");
//        addAnimation(startTransform, endTransform, AmazonImage.gameObject, AmazonNumberText, SeemTwigAbsence.GetInstance().getAmazon(), num);
//    }
//    private void addAnimation(Transform startTransform, Transform endTransform, GameObject icon, Text text, double textValue, double num)
//    {
//        if (startTransform != null)
//        {
//            AstronautAttainment.GoldMoveBest(icon, Mathf.Max((int)num, 1), startTransform, endTransform, () =>
//            {
//                AstronautAttainment.ChangeNumber(double.Parse(text.text), textValue, 0.1f, text, () =>
//                {
//                    text.text = SupplyTide.DoubleToStr(textValue);
//                });
//            });
//        }
//        else
//        {
//            AstronautAttainment.ChangeNumber(double.Parse(text.text), textValue, 0.1f, text, () => {
//                text.text = SupplyTide.DoubleToStr(textValue);
//            });
//        }
//    }
}
