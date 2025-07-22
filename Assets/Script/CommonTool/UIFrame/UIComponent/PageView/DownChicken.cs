using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DownChicken : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("mask")]    public RectTransform Rust;
[UnityEngine.Serialization.FormerlySerializedAs("mypageview")]    public EmitWall Photograph;
    private void Awake()
    {
        Photograph.OnEmitFaucet = Modulation;
    }

    void Modulation(int index)
    {
        if (index >= this.transform.childCount) return;
        Vector3 pos= this.transform.GetChild(index).GetComponent<RectTransform>().position;
        Rust.GetComponent<RectTransform>().position = pos;
    }
}
