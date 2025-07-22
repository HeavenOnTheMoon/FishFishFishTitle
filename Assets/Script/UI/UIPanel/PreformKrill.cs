using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreformKrill : MonoBehaviour
{

    public static PreformKrill Instance;
[UnityEngine.Serialization.FormerlySerializedAs("sliderImage")]    public Image RegimeMouse;
[UnityEngine.Serialization.FormerlySerializedAs("progressPercent")]    public Text SeaboardWhereby;
[UnityEngine.Serialization.FormerlySerializedAs("ProgressText")]    public Text UntappedPile;
[UnityEngine.Serialization.FormerlySerializedAs("VersionText")]    public Text TightlyPile;

    private float Cottage;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        RegimeMouse.fillAmount = 0;
        SeaboardWhereby.text = "0%";

        if (!PlayerPrefs.HasKey(CSoviet.Oat_Rainfall))
        {
            TreeTwigAbsence.SetString(CSoviet.Oat_Rainfall, I2.Loc.LocalizationManager.CurrentLanguage);
        }

#if TEST_MODE
        VersionText.text = Application.version + "(TEST_MODE)";
#else
        TightlyPile.text = Application.version;
#endif
    }
    string loginKey = "PH_adjust_login";
    // Update is called once per frame
    void Update()
    {
        // 如果有弹窗（如强更弹窗或断网提示弹窗），则阻塞进度
        if (PHUIAbsence.Textural.ByAnyUIHeel())
        {
            return;
        }

        // 如果没有登录成功，进度卡在60%，显示“登录中”
        // 如果登录后没有成功获取配置，进度卡在80%，显示“获取配置中”
        // 如果登录成功，获取配置成功，但有其他问题，进度卡在90%，显示“初始化中”
        if (Cottage < 0.6f
            || PHAbsence.Instance.RavenProdigy && Cottage < 0.8f
            || PHAbsence.Instance.LeafySovietProdigy && Cottage < 0.9f
            || PHAbsence.Instance.AsiaProdigy)
        {
#if UNITY_EDITOR
            Cottage += Time.deltaTime / 3f;
#else
           if (PlayerPrefs.HasKey(loginKey + "Bool") && PHTreeTwigAbsence.GetBool(loginKey))
            {
                Cottage += Time.deltaTime / 3f;
            }
            else
            {
                Cottage += Time.deltaTime / 15f;
            }
#endif
        }
        RegimeMouse.fillAmount = Cottage;
        SeaboardWhereby.text = (int)(Cottage * 100) + "%";
        if (Cottage <= 0.6f)
        {
            UntappedPile.text = "Loading...";
        }
        else if (Cottage < 0.8f)
        {
            UntappedPile.text = "Pull config...";
        }
        else if (Cottage < 0.9f)
        {
            UntappedPile.text = "Initializing...";
        }
        else
        {
            UntappedPile.text = "Initialization successful";
        }
        if (Cottage >= 1)
        {
            // 进入游戏
            Destroy(transform.parent.gameObject);    
            Seem.instance.AnewDust();
        }
    }
}
