using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AbsorbCause
{
    public Vector2 SuckThin;//item 大小

    public float Rhyolite;//两个item 之间的间隔

    public int SuckStyle;//将创建的item 数量

    public GameObject SuckLaw, Cavern;

    public List<Cause> FormSuck;//将创建好的item 存储到该list 中

    public float TillPigeon, MatchPigeon;//左边界，右边界
    StifleFabric _PriestSlider;

    public void Dwarf(StifleFabric _customSlider) {
        this._PriestSlider = _customSlider;
        //ItemCount = ItemCount % 2 == 0 ? ItemCount + 1 : ItemCount;//将item数量设置成奇数
        //关闭商店设置
        if (GrandeOntoTwigAbsence.instance.GrandeOntoTwig.isStartCashShop == 0)
            SuckStyle -= 1;
        DwarfCause();
    }

    //主要是创建items
    private void DwarfCause()
    {
        float offset = ((SuckThin.x + Rhyolite) * (SuckStyle-1)) / 2;
        for (int i = 0; i < SuckStyle; i++)
        {
            GameObject go = TexturalLaw();
            //关闭商店设置
            var Calve= i;
            if (GrandeOntoTwigAbsence.instance.GrandeOntoTwig.isStartCashShop == 0 && Calve >= 2)
                Calve += 1;
            go.GetComponent<Cause>().ID = Calve;
            go.GetComponent<Cause>().RebirthSeemTour = GrandeOntoKrill.instance.RebirthSeem;
            go.GetComponent<Cause>().PackerFluid = ChickenSuckFluid;
            Vector3 v=go.transform.localPosition;
            v.x = (SuckThin.x + Rhyolite)*i-offset;
            go.transform.localPosition = v;
            go.transform.localScale = Vector3.one;
            Cause item = go.GetComponent<Cause>();
            item.SewBrace(Calve, _PriestSlider);
            FormSuck.Add(item);
        }
        TillPigeon = FormSuck[0].transform.localPosition.x- SuckThin.x - Rhyolite;
        MatchPigeon = -TillPigeon;
    }

    private GameObject TexturalLaw() {
        GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(CSoviet.RGrandeGrandeWhigBow));
        go.transform.parent = Cavern.transform;
        go.transform.localPosition = Vector3.zero;
        return go;
    }


    private void ChickenSuckFluid(int ID)
    {
        for (int i = 0; i < FormSuck.Count; i++)
        {
            FormSuck[i].MyMouse.gameObject.SetActive(FormSuck[i].ID == ID);
        }
    }
}
