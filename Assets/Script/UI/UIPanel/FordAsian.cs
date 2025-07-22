using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FordAsian : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("InitGroup")]    public GameObject DustAsian;

    private GameObject RelevantSharpFluent;
    private float GenuPosit= 120f; // 两个item的position.x之差

    // Start is called before the first frame update
    void Start()
    {
        RelevantSharpFluent = DustAsian.transform.Find("SlotCard_1").gameObject;
        float x= GenuPosit * 3;
        int multiCount = TugTourOil.instance.DustTwig.slot_group.Count;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < multiCount; j++)
            {
                GameObject fangkuai = Instantiate(RelevantSharpFluent, DustAsian.transform);
                fangkuai.transform.localPosition = new Vector3(x + GenuPosit * multiCount * i + GenuPosit * j, RelevantSharpFluent.transform.localPosition.y, 0);
                fangkuai.transform.Find("Text").GetComponent<Text>().text = "×" + TugTourOil.instance.DustTwig.slot_group[j].multi;
            }
        }
    }

    public void AsiaSharp()
    {
        DustAsian.GetComponent<RectTransform>().localPosition = new Vector3(0, -10, 0);
    }

    public void Cone(int index, Action<int> finish)
    {
        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Notch_DayBegManual);
        AstronautAttainment.BitternessQuasar(DustAsian, -(GenuPosit * 2 + GenuPosit * TugTourOil.instance.DustTwig.slot_group.Count * 3 + GenuPosit * (index + 1)), () =>
        {
            finish?.Invoke(TugTourOil.instance.DustTwig.slot_group[index].multi);
        });
    }
}
