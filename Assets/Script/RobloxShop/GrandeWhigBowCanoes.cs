using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandeWhigBowCanoes : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ID")]    public int ID;
[UnityEngine.Serialization.FormerlySerializedAs("Btn")]
    public Button Bow;
[UnityEngine.Serialization.FormerlySerializedAs("RefreshGameInfo")]    public Action<int> RebirthSeemTour;
    
    // Start is called before the first frame update
    void Start()
    {
        Bow.onClick.AddListener(PhotoBow);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PhotoBow()
    {
        //Debug.LogError("id == " + ID);
        //RefreshGameInfo?.Invoke(ID);
    }
    
}
