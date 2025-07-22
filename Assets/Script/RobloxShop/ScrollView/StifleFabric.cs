using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class StifleFabric : MonoBehaviour,IDragHandler, IEndDragHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("AbsorbCause")]    public AbsorbCause AbsorbCause;//主要作用创建item
[UnityEngine.Serialization.FormerlySerializedAs("SuckChicken")]    public SuckChicken SuckChicken;//进行无限制的左右滑动
    void Start()
    {
        AbsorbCause.Dwarf(this);
        SuckChicken.Dust(this,AbsorbCause);
        //AbsorbCause.ListItem[2].OnPointerClick(null);
    }


    public void OnDrag(PointerEventData eventData)
    {
        SuckChicken.OnDrag(eventData.delta);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        SuckChicken.OutnumberCannon();
    }

    public void SuckCannon(Cause item)
    {
        SuckChicken.SuckCannon( item);
    }
}
