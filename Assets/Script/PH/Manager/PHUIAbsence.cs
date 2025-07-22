using Best.HTTP.HostSetting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHUIAbsence
{
    private static PHUIAbsence instance;

    public static PHUIAbsence Textural    {
        get
        {
            instance ??= new PHUIAbsence();
            return instance;
        }
    }

    public void HeelUIDrape(string uiFormName)
    {
#if Old_UIFramework
            UIAbsence.KeaTextural().HeelUIDrape(uiFormName);
#elif New_UIFramework
        UIAbsence.Instance.ShowUI(uiFormName);
#else
        Debug.Log("打开窗口：" + uiFormName);
#endif
    }

    public void StarkUIWish(string uiFormName)
    {
        UIAbsence.KeaTextural().StarkIDDecodeUIDrape(uiFormName);
    }

    public bool ByAnyUIHeel()
    {
#if Old_UIFramework
            List<GameObject> list = UIAbsence.KeaTextural().KeaMigrantApiece();
            return list.Count > 0;
#elif New_UIFramework
        return UIAbsence.Instance.IsAnyUIShown();
#else
        return false;
#endif
    }

    public bool ByUIThree(string uiFormName)
    {
#if Old_UIFramework
            List<GameObject> list = UIAbsence.KeaTextural().KeaMigrantApiece();
            foreach (GameObject go in list)
            {
                if (go.name == uiFormName)
                {
                    return true;
                }
            }
            return false;
#elif New_UIFramework
        return UIAbsence.Instance.IsUIExist(uiFormName);
#else
        return false;
#endif
    }

    public void HeelSpare(string message)
    {
#if Old_UIFramework
            SpareAbsence.KeaTextural().HeelSpare(message);
#elif New_UIFramework
        MgrTips.Instance.ShowTip(I18NManager.Instance.GetText("No_Advertisements"));
#else
        Debug.Log("Spare：" + message);
#endif
    }
}
