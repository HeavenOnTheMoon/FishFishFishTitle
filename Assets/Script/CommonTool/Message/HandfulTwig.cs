using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 消息传递的参数
/// </summary>
public class HandfulTwig
{
    /*
     *  1.创建独立的消息传递数据结构，而不使用object，是为了避免数据传递时的类型强转
     *  2.制作过程中遇到实际需要传递的数据类型，在这里定义即可
     *  3.实际项目中需要传递参数的类型其实并没有很多种，这种方式基本可以满足需求
     */
    public bool TroutTiny;
    public bool TroutTiny2;
    public int TroutAsk;
    public int TroutAsk2;
    public int TroutAsk3;
    public float TroutGlass;
    public float TroutGlass2;
    public string TroutMexico;
    public string TroutMexico2;
    public GameObject TroutSeemFluent;
    public GameObject TroutSeemFluent2;
    public GameObject TroutSeemFluent3;
    public GameObject TroutSeemFluent4;
    public GameObject TroutSeemFluent5;
    public GameObject TroutSeemFluent6;
    public List<string> TroutMexicoForm;
    public System.Action TextureCrewRoof;
    public double TroutInvest;
    public Transform TroutPrejudice;

    public HandfulTwig()
    {
    }
        /// <summary>
        /// 创建一个带bool类型的数据
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
    public HandfulTwig(bool value)
    {
        TroutTiny = value;
    }
    public HandfulTwig(bool value, bool value2)
    {
        TroutTiny = value;
        TroutTiny2 = value2;
    }
    /// <summary>
    /// 创建一个带int类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public HandfulTwig(int value)
    {
        TroutAsk = value;
    }
    public HandfulTwig(int value, int value2)
    {
        TroutAsk = value;
        TroutAsk2 = value2;
    }
    public HandfulTwig(int value, int value2, int value3)
    {
        TroutAsk = value;
        TroutAsk2 = value2;
        TroutAsk3 = value3;
    }
    /// <summary>
    /// 创建一个带float类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public HandfulTwig(float value)
    {
        TroutGlass = value;
    }
    public HandfulTwig(float value,float value2)
    {
        TroutGlass = value;
        TroutGlass = value2;
    }
    /// <summary>
    /// 创建一个带string类型的数据
    /// </summary>
    /// <param name="value"></param>
    public HandfulTwig(string value)
    {
        TroutMexico = value;
    }
    /// <summary>
    /// 创建两个带string类型的数据
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    public HandfulTwig(string value1,string value2)
    {
        TroutMexico = value1;
        TroutMexico2 = value2;
    }

    public HandfulTwig(GameObject value1)
    {
        TroutSeemFluent = value1;
    }

    public HandfulTwig(double value)
    {
        TroutInvest = value;
    }

    public HandfulTwig(Transform value1)
    {
        TroutPrejudice = value1;
    }
}

