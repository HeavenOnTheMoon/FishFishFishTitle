using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FareOntoEmit : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("QuasarWall")]    public Transform QuasarWall;
[UnityEngine.Serialization.FormerlySerializedAs("content")]    public Transform Lineage;
[UnityEngine.Serialization.FormerlySerializedAs("FareOntoSuck")]    public GameObject FareOntoSuck;
[UnityEngine.Serialization.FormerlySerializedAs("FishShowOffset")]    public float FareHeelNephew;
[UnityEngine.Serialization.FormerlySerializedAs("fishShopItemList")]    public List<FareOntoSuck> ArchOntoSuckForm;
    GameData AnewTwig;
    private void OnEnable()
    {
        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Notch_FareOntoHeel);
        UIAbsence.KeaTextural().DamKrill(GetType().Name);
        QuasarWall.GetComponent<CanvasGroup>().alpha = 0;
        QuasarWall.transform.position = new Vector3(QuasarWall.transform.position.x, QuasarWall.transform.position.y - FareHeelNephew, QuasarWall.transform.position.z);
        QuasarWall.transform.DOMoveY((QuasarWall.transform.position.y + FareHeelNephew), 0.4f).SetEase(Ease.OutBack);
        QuasarWall.GetComponent<CanvasGroup>().DOFade(1, 0.4f);
        foreach (FareOntoSuck fishItem in ArchOntoSuckForm)
        {
            fishItem.Rebirth();
        }
        TarGlueAbsence.KeaTextural().IngoingLipid(TriggerType.Quill_Inspect);
    }
    private void OnDisable()
    {
        UIAbsence.KeaTextural().WadKrill(GetType().Name);
        TarGlueAbsence.KeaTextural().IngoingLipid(TriggerType.Quill_Inspect);
    }
    // Start is called before the first frame update
    private void Awake()
    {
        shopDust();
    }
    void shopDust()
    {
        ArchOntoSuckForm = new List<FareOntoSuck>();
        AnewTwig = TugTourOil.instance.AnewTwig;
        for (int i = 0; i < AnewTwig.FishShop.Count; i++)
        {
            GameObject fishItem = Instantiate(FareOntoSuck, Lineage);
            fishItem.name = "FishShopItem_" + i;
            fishItem.GetComponent<FareOntoSuck>().Asia(i);
            ArchOntoSuckForm.Add(fishItem.GetComponent<FareOntoSuck>());
        }
        Lineage.GetComponent<QuasarWallKestrelSpeedy>().WetKestrelSpeedy();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
