using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#if Old_UIFramework
public class MustUsKrill : MoteUIDrape
#elif New_UIFramework
public class MustUsKrill : BaseUI
#else
public class MustUsKrill : MonoBehaviour
#endif
{
[UnityEngine.Serialization.FormerlySerializedAs("Stars")]    public Button[] Great;
[UnityEngine.Serialization.FormerlySerializedAs("star1Sprite")]    public Sprite Gift1Vanish;
[UnityEngine.Serialization.FormerlySerializedAs("star2Sprite")]    public Sprite Gift2Vanish;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button star in Great)
        {
            star.onClick.AddListener(() =>
            {
                string indexStr = System.Text.RegularExpressions.Regex.Replace(star.gameObject.name, @"[^0-9]+", "");
                int Calve= indexStr == "" ? 0 : int.Parse(indexStr);
                SurgeAsset(Calve);
            });
        }

    }

#if Old_UIFramework
    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
#elif New_UIFramework
    public void Show()
    {
        base.Show();
#else
    public void Display()
    {
#endif
        for (int i = 0; i < 5; i++)
        {
            Great[i].gameObject.GetComponent<Image>().sprite = Gift2Vanish;
        }
    }

#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void RequestAppReview(string url);
#endif

    private void WifeMayOnGallon()
    {
        UnwarySovietAnvil config = UnwarySovietPool.Textural.UnwarySoviet;
        string appStoreUrl = config.appVersionUpdate.appStoreUrl;
#if UNITY_ANDROID || UNITY_EDITOR
        Application.OpenURL(appStoreUrl);
#elif UNITY_IOS
        RequestAppReview(appStoreUrl + "?action=write-review");
#endif
    }

    private void SurgeAsset(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            Great[i].gameObject.GetComponent<Image>().sprite = i <= index ? Gift1Vanish : Gift2Vanish;
        }
        
        if (index < 3)
        {
            StartCoroutine(StarkKrill());
        }
        else
        {
            // 跳转到应用商店
            WifeMayOnGallon();
            StartCoroutine(StarkKrill());
        }
    }

    IEnumerator StarkKrill(float waitTime = 0.5f)
    {
        yield return new WaitForSeconds(waitTime);
#if Old_UIFramework
        StarkUIWish(GetType().Name);
#elif New_UIFramework
        UIAbsence.Instance.CloseUI();
#endif
    }
}
