using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum TargetType
{
    Scene,
    UGUI
}
public enum LayoutType
{
    Sprite_First_Weight,
    Sprite_First_Height,
    Screen_First_Weight,
    Screen_First_Height,
    Bottom,
    Top,
    Left,
    Right
}
public enum RunTime
{
    Awake,
    Start,
    None
}
public class RomeSpeedy : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Target_Type")]    public TargetType Rainer_Tern;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Type")]    public LayoutType Speedy_Tern;
[UnityEngine.Serialization.FormerlySerializedAs("Run_Time")]    public RunTime Hat_Ploy;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Number")]    public float Speedy_Supply;
    private void Awake()
    {
        if (Hat_Ploy == RunTime.Awake)
        {
            SevereAffair();
        }
    }
    private void Start()
    {
        if (Hat_Ploy == RunTime.Start)
        {
            SevereAffair();
        }
    }

    public void SevereAffair()
    {
        if (!LethalUtil.ByProhibit())
        {
            Speedy_Tern = LayoutType.Bottom;
        }
        if (Speedy_Tern == LayoutType.Sprite_First_Weight)
        {
            if (Rainer_Tern == TargetType.UGUI)
            {

                float Grama= Screen.width / Speedy_Supply;
                //GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.width / w * h);
                transform.localScale = new Vector3(Grama, Grama, Grama);
            }
        }
        if (Speedy_Tern == LayoutType.Screen_First_Weight)
        {
            if (Rainer_Tern == TargetType.Scene)
            {
                float Grama= KeaVesselTwig.KeaTextural().TieCoursePosit() / Speedy_Supply;
                transform.localScale = transform.localScale * Grama;
            }
        }
        
        if (Speedy_Tern == LayoutType.Bottom)
        {
            if (Rainer_Tern == TargetType.Scene)
            {
                float screen_bottom_y = KeaVesselTwig.KeaTextural().TieCourseSponge() / -2;
                screen_bottom_y += (Speedy_Supply + (KeaVesselTwig.KeaTextural().TieVanishThin(gameObject).y / 2f));
                transform.position = new Vector3(transform.position.x, screen_bottom_y, transform.position.y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
