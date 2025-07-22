using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BellGrandeBackup : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("deleteBtn")]    public Button FabricBow;
[UnityEngine.Serialization.FormerlySerializedAs("GetChildBtn")]    public Button KeaPreenBow;
[UnityEngine.Serialization.FormerlySerializedAs("AddChildBtn")]
    public Button DamPreenBow;
[UnityEngine.Serialization.FormerlySerializedAs("GetPropsBtn")]
    public Button KeaSwordBow;
[UnityEngine.Serialization.FormerlySerializedAs("AddPropsBtn")]
    public Button DamSwordBow;
[UnityEngine.Serialization.FormerlySerializedAs("Textl")]
    public Text Forge;
    // Start is called before the first frame update
    void Start()
    {
        FabricBow.onClick.AddListener(FabricBowPhoto);
        KeaPreenBow.onClick.AddListener(KeaPreenBowPhoto);
        DamPreenBow.onClick.AddListener(DamPreenBowCHint);
        KeaSwordBow.onClick.AddListener(KeaSwordBowPhoto);
        DamSwordBow.onClick.AddListener(DamSwordBowPhoto);
        Forge.text = GrandeOntoTwigAbsence.instance.LeadKeaAttic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FabricBowPhoto()
    {
        PlayerPrefs.DeleteAll();
        Forge.text = GrandeOntoTwigAbsence.instance.LeadKeaAttic();
    }

    private void KeaPreenBowPhoto()
    {
        GrandeOntoTwigAbsence.instance.KeaProtectorBackup();
        Forge.text = GrandeOntoTwigAbsence.instance.LeadKeaAttic();
    }

    private void DamPreenBowCHint()
    {
        //GrandeOntoTwigAbsence.instance.Addschedule(GrandeOntoTwigAbsence.instance.CurrentId, GrandeOntoTwigAbsence.instance.AddValue);
        Forge.text = GrandeOntoTwigAbsence.instance.LeadKeaAttic();
    }

    private void KeaSwordBowPhoto()
    {
        GrandeOntoTwigAbsence.instance.KeaSwordBackup();
        Forge.text = GrandeOntoTwigAbsence.instance.LeadKeaAttic();
        
    }

    private void DamSwordBowPhoto()
    {
        //GrandeOntoTwigAbsence.instance.Addschedule(GrandeOntoTwigAbsence.instance.CurrentId, GrandeOntoTwigAbsence.instance.AddValue);
        Forge.text = GrandeOntoTwigAbsence.instance.LeadKeaAttic();
    }


}
