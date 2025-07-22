using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandeRageKrill : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("CLoseBtn")]    public Button CVoleBow;
    // Start is called before the first frame update
    void Start()
    {
        CVoleBow.onClick.AddListener(StarkBowPhoto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StarkBowPhoto()
    {
        gameObject.SetActive(false);
    }
}
