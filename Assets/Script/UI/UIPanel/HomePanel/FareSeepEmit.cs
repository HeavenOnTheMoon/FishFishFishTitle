using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FareSeepEmit : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("BG")]    public GameObject BG;
[UnityEngine.Serialization.FormerlySerializedAs("content")]    public Transform Lineage;
[UnityEngine.Serialization.FormerlySerializedAs("FishShowOffset")]    public float FareHeelNephew;
[UnityEngine.Serialization.FormerlySerializedAs("FishTankItemPrefab")]    public GameObject FareSeepSuckChaste;
[UnityEngine.Serialization.FormerlySerializedAs("fishTankItemList")]    public List<FareSeepSuck> ArchSeepSuckForm;
[UnityEngine.Serialization.FormerlySerializedAs("contentLayout")]    public QuasarWallKestrelSpeedy LineageSpeedy;
    
    private void OnEnable()
    {
        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Sound_FishShopShow);
        UIAbsence.KeaTextural().DamKrill(GetType().Name);
        //换图
        //BG.GetComponent<Image>().sprite = Resources
        BG.GetComponent<Image>().material = null;
        Lineage.gameObject.SetActive(true);
        if (ArchSeepSuckForm.Count > 0)
        {
            foreach (FareSeepSuck item in ArchSeepSuckForm)
            {
                item.Arabian();
            }
        }
        TarGlueAbsence.KeaTextural().IngoingLipid(TriggerType.Quill_Inspect);
    }
    private void OnDisable()
    {
        UIAbsence.KeaTextural().WadKrill(GetType().Name);
        TarGlueAbsence.KeaTextural().IngoingLipid(TriggerType.Quill_Inspect);
    }
    public void Asia()
    {
        ArchSeepSuckForm = new List<FareSeepSuck>();
        for (int i = 0; i < TugTourOil.instance.AnewTwig.AquariumShop.Count; i++)
        {
            GameObject fishTankItem = Instantiate<GameObject>(FareSeepSuckChaste,LineageSpeedy.transform);
            AquariumShopItemData Luck= TugTourOil.instance.AnewTwig.AquariumShop[i];
            fishTankItem.name = "FishTankItem_" + i;
            fishTankItem.GetComponent<FareSeepSuck>().Asia(i);
            ArchSeepSuckForm.Add(fishTankItem.GetComponent<FareSeepSuck>());
        }
        LineageSpeedy.WetKestrelSpeedy();
        Lineage.GetComponent<CanvasGroup>().alpha = 0;
        Lineage.transform.position = new Vector3(Lineage.transform.position.x, Lineage.transform.position.y - FareHeelNephew, Lineage.transform.position.z);

        Lineage.transform.DOMoveY((Lineage.transform.position.y + FareHeelNephew), 0.4f).SetEase(Ease.OutBack);
        Lineage.GetComponent<CanvasGroup>().DOFade(1, 0.4f);
    }

    
    // Start is called before the first frame update
    void Awake()
    {
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_PackerFareSeep, (messageData) =>
        {
            //Seem.instance.gamePauseMaskAll();
            //AstronautAttainment.ScreenTransitions(BG, content.gameObject, () =>
            //{
            //    Seem.instance.canelGamePauseMaskAll();
            //    HandfulCannonForth.GetInstance().Send(CSoviet.mg_HomePanelSwitchPage, new HandfulTwig(1));

            //});

        });
        Asia();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/*public float FishTankShowOffset;
public List<GameObject> FishTank;

private void OnEnable()
{
    FishTankShow(FishTank, () => { });
}
public void FishTankShow(List<GameObject> FishTankImage, System.Action finish)
{

    int finishCount = 0;
    float delayTime = 0;
    for (int i = 0; i < FishTankImage.Count; i++)
    {
        if (i > 0)
        {
            delayTime += Random.Range(0.1f, 0.2f);
        }
        GameObject TFimage = FishTankImage[i];
        TFimage.transform.position = new Vector3(TFimage.transform.position.x, TFimage.transform.position.y - FishTankShowOffset, TFimage.transform.position.z);
        TFimage.transform.DOMoveY((TFimage.transform.position.y + FishTankShowOffset), 0.4f).SetDelay(delayTime).SetEase(Ease.OutBack);
        TFimage.GetComponent<CanvasGroup>().DOFade(1, 0.4f).OnComplete(() =>
        {
            finishCount++;
            if (finishCount == FishTankImage.Count)
            {
                finish();
            }
        });
    }
}*/