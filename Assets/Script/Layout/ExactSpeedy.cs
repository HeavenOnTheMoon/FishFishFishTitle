using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExactSpeedy : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("BG")]    public GameObject BG;
[UnityEngine.Serialization.FormerlySerializedAs("baseWidth")]    public float GarbPosit= 1080f;
    // Start is called before the first frame update
    void Awake()
    {
        float Grama= KeaVesselTwig.KeaTextural().TieCoursePosit() / GarbPosit;
        BG.transform.localScale = BG.transform.localScale * Grama;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
