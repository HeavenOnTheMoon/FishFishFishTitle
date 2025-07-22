using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 事件渗透
/// </summary>
public class BirdlikeLipidOffspring : MonoBehaviour, ICanvasRaycastFilter
{
    private Image WealthMouse;
    public void SewRainerMouse(Image target)
    {
        WealthMouse = target;
    }
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        if (WealthMouse == null)
        {
            return true;
        }
        return !RectTransformUtility.RectangleContainsScreenPoint(WealthMouse.rectTransform, sp, eventCamera);
    }
}