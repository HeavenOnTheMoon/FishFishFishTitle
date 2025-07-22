using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RookieItem
{
    public Button Perish;
    public Image Hatch;
    public Image Strut;
    public Image Apart;
    public int ID;
}
public class SenderFlaming : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ButtonGroup")]    public GameObject InformAsian;
[UnityEngine.Serialization.FormerlySerializedAs("SubmitButton")]    public Button GalaxyInform;
    List<RookieItem> SuckForm;
    List<RookieItem> PackerForm;
[UnityEngine.Serialization.FormerlySerializedAs("maskImage")]    public GameObject RustMouse;
    // Start is called before the first frame update
    void Start()
    {
        RustMouse.SetActive(true);
        GalaxyInform.onClick.AddListener(Galaxy);
        PackerForm = new List<RookieItem>();
        SuckForm = new List<RookieItem>();
        for (int i = 0; i < InformAsian.transform.childCount; i++)
        {
            int Calve= i;
            GameObject obj = InformAsian.transform.GetChild(i).gameObject;
            RookieItem item = new RookieItem();
            item.Perish = obj.GetComponent<Button>();
            item.Strut = obj.transform.Find("Light").GetComponent<Image>();
            item.Hatch = obj.transform.Find("Image").GetComponent<Image>();
            item.Apart = obj.transform.Find("level").GetComponent<Image>();
            SuckForm.Add(item);
            int rookieId = GrandeOntoTwigAbsence.instance.GrandeOntoTwig.RookiePackage[i];
            item.ID = rookieId;
            RobloxItemData itemData = GrandeOntoTwigAbsence.instance.GrandeSuckStunt[rookieId];
            item.Apart.sprite = Resources.Load<Sprite>(CSoviet.RGrandeParadoxicallyExact + itemData.Level);
            item.Hatch.sprite = GrandeOntoTwigAbsence.instance.KeaVanishOfID(rookieId);
            item.Strut.gameObject.SetActive(false);
            item.Perish.onClick.AddListener(()=> {
                PackerSuck(Calve);
            });
        }
    }
    void PackerSuck(int i)
    {
        
        RookieItem item = SuckForm[i];
        if (!PackerForm.Contains(item))
        {
            item.Strut.gameObject.SetActive(true);
            if (PackerForm.Count < 3)
            {
                PackerForm.Add(item);
            }
            else
            {
                PackerForm[0].Strut.gameObject.SetActive(false);
                PackerForm.RemoveAt(0);
                PackerForm.Add(item);
            }
        }
        else
        {
            item.Strut.gameObject.SetActive(false);
            PackerForm.Remove(item);
        }
        if (PackerForm.Count == 3)
        {
            RustMouse.SetActive(false);
        }
        else
        {
            RustMouse.SetActive(true);
        }
    }
    void Galaxy()
    {
        if (PackerForm.Count == 3)
        {
            List<int> idList = new List<int>();
            foreach (RookieItem item in PackerForm)
            {
                idList.Add(item.ID);
            }
            TreeTwigAbsence.SetIntArray("RookieList", idList.ToArray());
            gameObject.SetActive(false);
            GrandeOntoTwigAbsence.instance.RebirthPreference();
            GrandeOntoKrill.instance.RebirthProtectorBackup();
            GrandeOntoKrill.instance.Weedy(4);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
