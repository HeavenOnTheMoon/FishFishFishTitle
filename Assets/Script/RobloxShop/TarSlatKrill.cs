using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TarSlatKrill : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("TaskContentText")]    public Text SlatKestrelPile;
[UnityEngine.Serialization.FormerlySerializedAs("TaskTwoContentText")]    public Text SlatEonKestrelPile;
[UnityEngine.Serialization.FormerlySerializedAs("Button")]    public Button Inform;
    // Start is called before the first frame update
    private void OnEnable()
    {

        if (GrandeOntoTwigAbsence.instance.LevelTwig[GrandeOntoTwigAbsence.instance.HayLanguish].TaskID == 0)
        {
            SlatKestrelPile.gameObject.SetActive(true);
            SlatEonKestrelPile.gameObject.SetActive(false);
        }
        else
        {
            SlatKestrelPile.gameObject.SetActive(false);
            SlatEonKestrelPile.gameObject.SetActive(true);
        }
    }
    void Start()
    {
        Inform.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            GrandeOntoKrill.instance.SewGrandeBackupLanguish(GrandeOntoTwigAbsence.instance.HayLanguish);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
