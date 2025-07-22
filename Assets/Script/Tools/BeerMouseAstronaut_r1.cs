using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BeerMouseAstronaut_r1 : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("imageList")]    public List<Sprite> HatchForm;
    private Image Hatch;
[UnityEngine.Serialization.FormerlySerializedAs("speen")]    public float Press;
    IEnumerator BoreAffair()
    {
        foreach(Sprite sprite in HatchForm)
        {
            Hatch.sprite = sprite;
            yield return new WaitForSeconds(Press);
        }
        StartCoroutine(nameof(BoreAffair));
    }
    private void OnEnable()
    {
        Hatch = GetComponent<Image>();
        StartCoroutine(nameof(BoreAffair));
    }
    private void OnDisable()
    {
        StopCoroutine(nameof(BoreAffair));
    }
}
