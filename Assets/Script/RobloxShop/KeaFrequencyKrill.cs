using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeaFrequencyKrill : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ClaimBtn")]    public Button SquatBow;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]
    public Button StarkBow;
[UnityEngine.Serialization.FormerlySerializedAs("FragmentImage")]
    public Image CustomerMouse;
[UnityEngine.Serialization.FormerlySerializedAs("FragmentText")]    public Text CustomerPile;
[UnityEngine.Serialization.FormerlySerializedAs("ID")]
    public int ID;
[UnityEngine.Serialization.FormerlySerializedAs("levelImage")]    public Image ApartMouse;

    private AddIdAndValue _RidItBagAttic= new AddIdAndValue();
    
    
    // Start is called before the first frame update
    void Start()
    {
        SquatBow.onClick.AddListener(SquatADBowPhoto);
        StarkBow.onClick.AddListener(StarkBowPhoto);
        
        
        
    }

    private void OnEnable()
    {
        if(ID.ToString().StartsWith("2"))
        {
            ApartMouse.gameObject.SetActive(true);
            ApartMouse.sprite = Resources.Load<Sprite>(CSoviet.GrandeOntoGrandeExpressionlessExact + GrandeOntoTwigAbsence.instance.GrandeSuckStunt[ID].Level);
        }
        else
        {
            ApartMouse.gameObject.SetActive(false);
        }
        CustomerMouse.sprite = GrandeOntoTwigAbsence.instance.KeaVanishOfID(ID);
        _RidItBagAttic = GrandeOntoTwigAbsence.instance.KeaAttic(ID);
        CustomerPile.text = _RidItBagAttic.Trout.ToString();
        GrandeOntoKrill.instance.PitOrHeel(transform.Find("Window").gameObject, () =>
        {
            //gameObject.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SquatADBowPhoto()
    {
        //bx  广告位
        GrandeOntoKrill.instance.PitOrLira(transform.Find("Window").gameObject, () =>
        {
            gameObject.SetActive(false);
            GrandeOntoKrill.instance.BatAlbedo("+ " + _RidItBagAttic.Trout, true);
            List<AddIdAndValue> list = new List<AddIdAndValue>();
            list.Add(_RidItBagAttic);
            GrandeOntoTwigAbsence.instance.Marketplace(list);
            TreeTwigAbsence.SetString("String" + _RidItBagAttic.ID, DateTime.Now.ToString("yyyyMMddHH:mm:ss"));
            if (_RidItBagAttic.ID.ToString().StartsWith("2"))
            {
                GrandeOntoKrill.instance.RebirthProtector(_RidItBagAttic.ID);
            }
            else
            {
                GrandeOntoKrill.instance.RebirthSword(_RidItBagAttic.ID);
            }
        });
    }

    private void StarkBowPhoto()
    {
        GrandeOntoKrill.instance.PitOrLira(transform.Find("Window").gameObject, () =>
        {
            gameObject.SetActive(false);
        });
        //
    }
}
