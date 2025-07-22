using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeerMouseAstronaut : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("imageList")]    public List<Sprite> HatchForm;
    private Image Hatch;
[UnityEngine.Serialization.FormerlySerializedAs("speen")]    public float Press;
[UnityEngine.Serialization.FormerlySerializedAs("CanvasGroup")]    public CanvasGroup CyclicAsian;
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
        StartCoroutine(nameof(HeelMouse));
    }
    private void OnDisable()
    {
        StopCoroutine(nameof(BoreAffair));
    }

    private float Trout= 0;
    float yMarginal= 0.0f;
    IEnumerator HeelMouse()
    {
        Trout = Mathf.Lerp(0.0f,3.0f,0.1f);
        CyclicAsian.alpha = Trout;
        yield return new WaitForSeconds(0.05f);
        Trout = Mathf.Lerp(Trout,3.0f,0.1f);
        CyclicAsian.alpha = Trout;
        yield return new WaitForSeconds(0.05f);
        Trout = Mathf.Lerp(Trout,3.0f,0.1f);
        CyclicAsian.alpha = Trout;
        yield return new WaitForSeconds(0.05f);
        Trout = Mathf.Lerp(Trout,3.0f,0.1f);
        CyclicAsian.alpha = Trout;
        yield return new WaitForSeconds(0.05f);
    }

    public void LoosenMouse()
    {
        if(gameObject.GetComponent<Image>().gameObject.activeSelf)
            StartCoroutine(nameof(LiraMouse));
    }
    IEnumerator LiraMouse()
    {
        Trout = Mathf.Lerp(3.0f,0.0f,0.1f);
        CyclicAsian.alpha = Trout;
        yield return new WaitForSeconds(0.05f);
        Trout = Mathf.Lerp(3.0f,Trout,0.1f);
        CyclicAsian.alpha = Trout;
        yield return new WaitForSeconds(0.05f);
        Trout = Mathf.Lerp(3.0f,Trout,0.1f);
        CyclicAsian.alpha = Trout;
        yield return new WaitForSeconds(0.05f);
        Trout = Mathf.Lerp(3.0f,Trout,0.1f);
        CyclicAsian.alpha = Trout;
        yield return new WaitForSeconds(0.05f);
        gameObject.SetActive(false);
    }
}
