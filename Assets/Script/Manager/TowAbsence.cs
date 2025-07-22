using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowAbsence : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("TowSuck")]    public GameObject TowSuck;
    public static TowAbsence Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isOpenFly")]
    public bool AnWifeTow;
[UnityEngine.Serialization.FormerlySerializedAs("leftOrRight")]    public int YolkOrMatch;

    private int _XenonWifePloy;
    private int _SkiAddPloy;

    private void Awake()
    {
        Instance = this;
        _SkiAddPloy = 0;
        AnWifeTow = true;
        _XenonWifePloy = TugTourOil.instance.AnewTowTwig.cold_down;
        //_startOpenTime = 0;
        YolkOrMatch = 0;
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_RustExact, (messageData) =>
        {
            BaboonTowSuck();
        });
        HandfulCannonForth.KeaTextural().Computer(CSoviet.Of_AssetExact, (messageData) =>
        {
            AsiaTow();
        });
    }

    private void OnEnable()
    {
        //OpenIEFly();
    }

    public void WifeIETow()
    {
        StopCoroutine(nameof(WifeTowPiston));
        StartCoroutine(nameof(WifeTowPiston));
    }

    public void AsiaTow()
    {
        _SkiAddPloy = TugTourOil.instance.AnewTowTwig.cold_down;
        StopCoroutine(nameof(WifeTowPiston));
        StartCoroutine(nameof(WifeTowPiston));
    }
    IEnumerator WifeTowPiston()
    {
        while (AnWifeTow)
        {
            if (_SkiAddPloy >= _XenonWifePloy)
            {
                AbsorbTowSuck();
            }
            _SkiAddPloy++;
            yield return new WaitForSeconds(1);
        }
    }

    public void BaboonTowSuck()
    {
        if (transform.childCount > 0)
        {
            transform.GetChild(0).GetComponent<TowSuck>().SpecifyTowSuck();
            AnWifeTow = true;
            _SkiAddPloy = 0;
        }
    }

    public void AbsorbTowSuck()
    {
        if (LethalUtil.ByVague())
        {
            return;
        }
        else
        {

        }
        if (!AnWifeTow) { return; }
        if (Seem.instance.KeaSeemGarden()) { return; }
        if (Seem.instance.TieGlueExact() > 1 && !LethalUtil.ByVague())
        {
            AnWifeTow = false;
            _SkiAddPloy = 0;
            GameObject obj = Instantiate(TowSuck.gameObject);
            obj.transform.SetParent(transform);
            obj.transform.localScale = new Vector3(0.75f,0.75f,0.75f);
            obj.transform.localPosition = YolkOrMatch == 0 ? new Vector3(-450, 0, 0) : new Vector3(450, 0, 0);
        }
    }
}
