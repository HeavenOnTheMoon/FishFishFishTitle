using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#if Old_UIFramework
public class RejoinKrill : MoteUIDrape
#elif New_UIFramework
public class RejoinKrill : BaseUI
#else
public class RejoinKrill : MonoBehaviour
#endif
{
[UnityEngine.Serialization.FormerlySerializedAs("UpdateBtn")]    public Button RejoinBow;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button StarkBow;
[UnityEngine.Serialization.FormerlySerializedAs("ContentText")]    public Text KestrelPile;

    private string CorridorGem;

    // Start is called before the first frame update
    void Start()
    {
        RejoinBow.onClick.AddListener(() =>
        {
            AtRejoin();
        });

        StarkBow.onClick.AddListener(() => {
#if Old_UIFramework
            StarkUIWish(GetType().Name);
#elif New_UIFramework
            UIAbsence.Instance.CloseUI();
#endif
        });
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

        UnwarySovietAnvil config = UnwarySovietPool.Textural.UnwarySoviet;
        StarkBow.gameObject.SetActive(config.appVersionUpdate.updateType == 0);
        if (!string.IsNullOrEmpty(config.appVersionUpdate.updateDesc))
        {
            KestrelPile.text = config.appVersionUpdate.updateDesc;
        }
        CorridorGem = config.appVersionUpdate.appStoreUrl;
    }

#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void openUrl(string url);
#endif

    public void AtRejoin()
    {
#if UNITY_ANDROID || UNITY_EDITOR
        Application.OpenURL(CorridorGem);
#elif UNITY_IOS
        openUrl(downloadUrl);
#endif
    }
}
