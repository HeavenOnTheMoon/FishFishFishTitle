using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class HabitatAbsence : MonoBehaviour
{
    static public void DeadPackerGiveAt(GameObject gameObject, Vector2 targetPos, float duration, System.Action finishAction)
    {
        //gameObject.transform.DOKill();
        gameObject.transform.DOMove(targetPos, duration).SetEase(Ease.Linear).OnComplete(()=> {
            finishAction();
        });
    }

}
