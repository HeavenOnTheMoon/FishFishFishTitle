using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spare : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("ToastText")]    public Text SparePile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Display()
    {
        base.Display();

        SparePile.text = SpareAbsence.KeaTextural().Tour;
        StartCoroutine(nameof(ItemStarkSpare));
    }

    private IEnumerator ItemStarkSpare()
    {
        yield return new WaitForSeconds(2);
        StarkUIWish(GetType().Name);
    }

}
