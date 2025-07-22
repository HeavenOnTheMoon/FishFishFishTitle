using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentKrill : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ClimeBtn")]    public Button CrestBow;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button StarkBow;
[UnityEngine.Serialization.FormerlySerializedAs("OneInputField")]
    public InputField DayChalkTwain;
[UnityEngine.Serialization.FormerlySerializedAs("TwoInputField")]
    public InputField EonChalkTwain;
    
    
    // Start is called before the first frame update
    void Start()
    {
        CrestBow.onClick.AddListener(CrestBowPhoto);
        StarkBow.onClick.AddListener(StarkBowPhoto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        
    }

    private void CrestBowPhoto()
    {
        if (DayChalkTwain.textComponent.text != "" &&
            DayChalkTwain.textComponent.text == EonChalkTwain.textComponent.text)
        {
            //能提现，减去对应的Value
            Debug.Log("能提现，减去对应的Value");
            //获取需要减去的数值
            
            GrandeOntoTwigAbsence.instance.PinAdequate(GrandeOntoTwigAbsence.instance.PinID);
            gameObject.SetActive(false);
        }
        else
        {
            GrandeOntoKrill.instance.BatAlbedo("0");
            //输入错误，给反馈
            Debug.Log("输入错误，给反馈");
        }
    }

    public void StarkBowPhoto()
    {
        gameObject.SetActive(false);
    }
    
}
