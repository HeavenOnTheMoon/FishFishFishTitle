using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("test")]    public GameObject Lead;
    private void Awake()
    {
        //GameObject can= Resources.Load("Prefabs/Canvas") as GameObject;
       
    }
    // Start is called before the first frame update
    void Start()
    {       
        UIAbsence.KeaTextural().HeelUIDrape("TestPanel");
        Transform Lead= AloneAlways.SellThePreenTang(this.gameObject, "test3");
        Debug.Log("yyyyyyyyy"+Lead.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
