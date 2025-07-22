using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Cause : MonoBehaviour,IPointerClickHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("ID")]    public int ID;
[UnityEngine.Serialization.FormerlySerializedAs("itemImage")]    public Image itemMouse;
[UnityEngine.Serialization.FormerlySerializedAs("BgImage")]    public Image MyMouse;
    StifleFabric _PriestSlider;
[UnityEngine.Serialization.FormerlySerializedAs("RefreshGameInfo")]    public Action<int> RebirthSeemTour;
[UnityEngine.Serialization.FormerlySerializedAs("SelectStage")]    public Action<int> PackerFluid;
    
    public void SewBrace(int _index, StifleFabric _customSlider) {
        ID = _index;
        this._PriestSlider = _customSlider;
        itemMouse.sprite = GrandeOntoTwigAbsence.instance.KeaVanishOfID(GrandeOntoTwigAbsence.instance.GrandeOntoTwig.Shop_class[ID].logoPath);
        if(ID == 3 && GrandeOntoTwigAbsence.instance.GrandeOntoTwig.isStartCashShop == 0 )
        {
            MyMouse.gameObject.SetActive(true);
        }
        if(ID == 2)
            MyMouse.gameObject.SetActive(true);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_PriestSlider != null) {
            _PriestSlider.SuckCannon(this);
            PackerFluid?.Invoke(ID);
            RebirthSeemTour?.Invoke(ID);
        }
    }

}
