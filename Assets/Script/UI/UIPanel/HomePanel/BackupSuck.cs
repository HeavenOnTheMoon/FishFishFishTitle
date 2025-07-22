using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackupSuck : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("RewardImage")]    public Image BackupMouse;
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]    public Text BackupPile;

    public void SewBackupTwig(RewardType type,double value)
    {
        string path = "";
        switch (type)
        {
            case RewardType.gold:
                path = MexicoGloss.ChicVanishTide;
                break;
            case RewardType.cash:
                path = MexicoGloss.TouchVanishTide;
                break;
            case RewardType.amazon:
                path = MexicoGloss.CarmanZVanishTide;
                break;
        }
        BackupMouse.sprite = Resources.Load<Sprite>(path);
        BackupMouse.transform.GetComponent<RectTransform>().sizeDelta = (path == MexicoGloss.CarmanZVanishTide) ? new Vector2(120, 120) : new Vector2(180,180);
        BackupPile.text = value.ToString();
    }
}
