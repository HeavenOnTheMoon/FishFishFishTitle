using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MustByAbsence : MonoBehaviour
{
    public static MustByAbsence instance;
[UnityEngine.Serialization.FormerlySerializedAs("appid")]
    public string Alter;

    private void Awake()
    {
        instance = this;
    }

}
