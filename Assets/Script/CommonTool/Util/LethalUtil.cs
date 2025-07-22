using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.InputSystem;

public class LethalUtil
{
    public static bool ByVague()
    {
        return true;
        return TugTourOil.instance.NetUnwaryTwig.apple_pie == "apple";
    }
    public static bool ByProhibit()
    {
        return true;
        bool isbgswitch = TugTourOil.instance.NetUnwaryTwig.bgswitch == "A";
        if (!isbgswitch)
        {
            PlayerPrefs.SetString(CSoviet.Oat_Douse, "aa");
        }
        return isbgswitch;
    }
    public static bool ByRefuge()
    {
#if UNITY_EDITOR
        return true;
#else
            return false;
#endif
    }

    /// <summary>
    /// 是否为竖屏
    /// </summary>
    /// <returns></returns>
    public static bool BySpectrum()
    {
        return Screen.height > Screen.width;
    }


}
