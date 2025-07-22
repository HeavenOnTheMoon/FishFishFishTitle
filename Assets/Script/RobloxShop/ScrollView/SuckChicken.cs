using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SuckChicken
{
    StifleFabric _PriestSlider;
    AbsorbCause _RepeatCause;

    public float Chest;//居中速度
    Coroutine _Residence;
    public void Dust(StifleFabric _customSlider, AbsorbCause _createItems)
    {
        this._PriestSlider = _customSlider;
        this._RepeatCause = _createItems;
    }

    public void OnDrag(Vector2 v)
    {
        Avoid(v.x);
    }

    //左右滑动
    private void Avoid(float x)
    {
        List<Cause> list = _RepeatCause.FormSuck;
        foreach (Cause it in list)
        {
            Transform t = it.transform;
            Vector2 v = t.localPosition;
            v.x += x;
            it.transform.localPosition = v;
        }
        RodOfPigeonGrandeur(list);
    }
 
    //越界处理
    private void RodOfPigeonGrandeur(List<Cause> list)
    {
        List<Cause> l = new List<Cause>();//x坐标低于左边界的item，临时记录到这里
        List<Cause> r = new List<Cause>();//x坐标低于右边界的item，临时记录到这里

        foreach (Cause lt in list)
        {
            if (SuckCoconutX(lt) < _RepeatCause.TillPigeon)
            {
                l.Add(lt);
            }
            else if (SuckCoconutX(lt) > _RepeatCause.MatchPigeon)
            {
                r.Add(lt);
            }
        }


        ///一下代码对左右越界item 进行处理
        if (l.Count >= 1)
        {
            ValueFend(list, 0, list.Count - 1);
            ValueFend(l, 0, l.Count - 1);

            Cause maxItem = list[list.Count - 1];
            float distance = _RepeatCause.Rhyolite + _RepeatCause.SuckThin.x;
            for (int i = 0; i < l.Count; i++)
            {
                Vector2 v = maxItem.transform.localPosition;
                v.x += distance * (i + 1);
                l[i].transform.localPosition = v;
            }
        }
        else if (r.Count >= 1)
        {
            ValueFend(list, 0, list.Count - 1);
            ValueFend(r, 0, r.Count - 1);

            Cause mixItem = list[0];
            float distance = _RepeatCause.Rhyolite + _RepeatCause.SuckThin.x;
            for (int i = r.Count-1,j=0; i >=0 ; i--,j++)
            {
                Vector2 v = mixItem.transform.localPosition;
                v.x -= distance * (j+1);
                r[i].transform.localPosition = v;
            }
        }
    }

    //利用快排将list中item 进行从小到大排序
    private void ValueFend(List<Cause> list, int left, int right)
    {
        int l = left;
        int r = right;
        float pivot = SuckCoconutX(list, (left + right) / 2);
        Cause temp = null;
        while (l < r)
        {
            while (SuckCoconutX(list, l) < pivot)
            {
                l += 1;
            }
            while (SuckCoconutX(list, r) > pivot)
            {
                r -= 1;
            }

            if (l >= r)
            {
                break;
            }
            temp =list[l];

            list[l] = list[r];
            list[r] = temp;

            if (SuckCoconutX(list, l) == pivot)
            {
                r -= 1;
            }
            if (SuckCoconutX(list, r) == pivot)
            {
                l += 1;
            }
        }
        if (l == r)
        {
            l += 1;
            r -= 1;
        }

        if (left < r)
        {
            ValueFend(list, left, r);
        }

        if (right > l)
        {
            ValueFend(list, l, right);
        }
    }

    private float SuckCoconutX(List<Cause> list, int index)
    {
        return list[index].transform.localPosition.x;
    }

    private float SuckCoconutX(Cause item)
    {
        return item.transform.localPosition.x;
    }

    ///滑动完毕自动居中
    public void OutnumberCannon() {
        List<Cause> list = _RepeatCause.FormSuck;
        ValueFend(list, 0, list.Count - 1);
        Cause CentreItem = list[list.Count / 2];
        if (_Residence != null)
        {
            _PriestSlider.StopCoroutine(_Residence);
        }
        _Residence = _PriestSlider.StartCoroutine(CannonRoad(CentreItem));
    }

 
    //点击某个item,让其滚动到居中位置
    public void SuckCannon(Cause item) {
        if (_Residence != null) {
            _PriestSlider.StopCoroutine(_Residence);
        }

        _Residence = _PriestSlider.StartCoroutine(CannonRoad(item));
        
    }


    IEnumerator CannonRoad(Cause item) {
      float x=  item.transform.localPosition.x;
       x= -x / Chest;
        for (int i = 0; i < Chest; i++) {
            Avoid(x);
            yield return null;
        }
    }
 
}
