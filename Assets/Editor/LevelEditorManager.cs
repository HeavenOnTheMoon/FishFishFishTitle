﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//自定义Tset脚本
[CustomEditor(typeof(ExactWorth))]
public class LevelEditorManager : Editor
{
    public Transform lastTrans = null;
    
    void OnSceneGUI()
    {
        //Debug.Log("OnScene");


        ExactWorth levelLayer = (ExactWorth)target;
        HandleUtility.AddDefaultControl(GUIUtility.GetControlID(FocusType.Passive));
        if (Event.current.type == EventType.MouseDown)
        {
            lastTrans = null;
        }
        if (Event.current.type == EventType.MouseDrag || Event.current.type == EventType.MouseDown)
        {
            RaycastHit2D[] rayHits = Physics2D.RaycastAll(Camera.current.ScreenToWorldPoint(GetMousePos()), Vector2.zero);
            RaycastHit2D rayHit = new RaycastHit2D();
            foreach(RaycastHit2D r in rayHits)
            {
                if (r.transform.parent == levelLayer.transform)
                {
                    rayHit = r;
                }
            }
            //Debug.Log(lastTrans + "," + rayHit.transform);
            if (rayHit.transform && lastTrans != rayHit.transform)
            {
                if (rayHit.transform.GetComponent<SpriteRenderer>().sprite == ExactWorthAsian.KeaTextural().Thaw_Rennin)
                {
                    //Debug.Log("full_sprite");
                    if (!levelLayer.Briny_Tone)
                    {
                        rayHit.transform.GetComponent<SpriteRenderer>().sprite = ExactWorthAsian.KeaTextural().Briny_Rennin; 
                    }
                    else
                    {
                        rayHit.transform.GetComponent<SpriteRenderer>().sprite = null;
                    }
                }
                else
                {
                    rayHit.transform.GetComponent<SpriteRenderer>().sprite = ExactWorthAsian.KeaTextural().Thaw_Rennin;
                }
            }
            
            ExactWorthAsian.KeaTextural().ArabianDrugStyle();
            lastTrans = rayHit.transform;
        }
        foreach (string key in ExactWorthAsian.KeaTextural().ApartFlu.Keys)
        {
            //Debug.Log(key.Split('_')[0] + "," + levelLayer.gameObject.name.Split('_')[1]);
            if (key.Split('_')[0] == levelLayer.gameObject.name.Split('_')[1])
            {
                GameObject obj = ExactWorthAsian.KeaTextural().ApartFlu[key];
                if (obj.GetComponent<SpriteRenderer>().sprite == ExactWorthAsian.KeaTextural().Thaw_Rennin)
                {
                    //Debug.Log(key.Split('_')[0]);
                    Handles.Label(obj.transform.position + new Vector3(-0.16f,0.2f,0), key.Split('_')[0]);
                }
            }
        }


    }
    private Vector2 GetMousePos()
    {
        var mousePos = Event.current.mousePosition;
        mousePos.y = Camera.current.pixelHeight - mousePos.y;
        return mousePos;
    }

}
