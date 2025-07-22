using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackupPistonMuteSpeedy : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("bottomWall1")]    public RectTransform UniqueMute1;
[UnityEngine.Serialization.FormerlySerializedAs("bottomWall2")]    public RectTransform UniqueMute2;
    // Start is called before the first frame update
    void Start()
    {
        UniqueMute1.anchoredPosition = new Vector2(0, UniqueMute1.anchoredPosition.y * (Screen.width / 750f));
        UniqueMute2.anchoredPosition = new Vector2(0, UniqueMute2.anchoredPosition.y * (Screen.width / 750f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
