using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeedyKrill : MoteUIDrape
{
[UnityEngine.Serialization.FormerlySerializedAs("nextButton")]    public Button MildInform;
    // Start is called before the first frame update
    void Start()
    {
        MildInform.onClick.AddListener(() =>
        {
            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HikeKrillBeerWeedy);
            StarkUIWish(GetType().Name);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
