using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FareGive : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("fishIndex")]    public int ArchBrace;
[UnityEngine.Serialization.FormerlySerializedAs("direction")]    public int Physician= 1;
[UnityEngine.Serialization.FormerlySerializedAs("speed")]    public float Lower;
[UnityEngine.Serialization.FormerlySerializedAs("maxY")]    public float RotY;
[UnityEngine.Serialization.FormerlySerializedAs("minY")]    public float CryY;
    float Military;
    Sequence Pry;
    Dictionary<string, string> AmateurFlu;
    float QuartzRainerX;
[UnityEngine.Serialization.FormerlySerializedAs("collisionList")]    public List<GameObject> FascinateForm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    private void OnEnable()
    {
        FascinateForm = new List<GameObject>();
        Military = 0;
        rotateAffair();
    }
    private void OnDisable()
    {
        Pry.Kill();
    }
    public void FascinatePiston(GameObject gameObject)
    {
        FascinateForm.Add(gameObject);
    }
    void rotateAffair()
    {
        Pry.Kill();
        Pry = DOTween.Sequence();
        if (Military == 0)
        {
            Military = Random.Range(-FareAbsence.instance.Twig.EkaSpecimen, FareAbsence.instance.Twig.EkaSpecimen);
        } else if (Military > 0)
        {
            Military = Random.Range(-FareAbsence.instance.Twig.EkaSpecimen, 0);
        }
        else
        {
            Military = Random.Range(0, FareAbsence.instance.Twig.EkaSpecimen);
        }

        float rotateTime = Random.Range(FareAbsence.instance.Twig.WalrusPloy.Cry, FareAbsence.instance.Twig.WalrusPloy.Cry);
        float limitTime = Random.Range(FareAbsence.instance.Twig.WalrusLower.Cry, FareAbsence.instance.Twig.WalrusLower.Rot);
        Pry.AppendInterval(limitTime);
        Pry.Append(transform.DORotate(new Vector3(0,0,Military), rotateTime));
        Pry.AppendCallback(() => {
            rotateAffair();
        });
        Pry.Play();
    }
    void StampDecodeRoof()
    {
        if (transform.localScale.x < 0)
        {
            if (transform.position.y >= RotY - 0.1f && Military > 0)
            {
                rotateAffair();
            }
            if (transform.position.y <= CryY + 0.1f && Military < 0)
            {
                rotateAffair();
            }
        } 
        else
        {
            if (transform.position.y >= RotY - 0.1f && Military < 0)
            {
                rotateAffair();
            }
            if (transform.position.y <= CryY + 0.1f && Military > 0)
            {
                rotateAffair();
            }
        }
        
    }
    public void WetOvertax(Dictionary<string,string> dic)
    {
        AmateurFlu = dic;
        QuartzRainerX = Random.Range(-1f, 1f);
    }
    public void RepeatBackup()
    {
        ThereOil.KeaTextural().BeerAlbedo(ThereTern.UIMusic.Notch_FareBackupHeel);
        FareAbsence.instance.FareMakeBackup(gameObject,AmateurFlu);
        AmateurFlu = null;
        QuartzRainerX = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M)) 
        {
            TreeTwigAbsence.SetInt(CSoviet.Or_StitchBackupStyle, TreeTwigAbsence.GetInt(CSoviet.Or_StitchBackupStyle) + 3);
        }
        transform.position += Physician * transform.right * Time.deltaTime * Lower;
        //if (missionDic != null)
        //{
        //    if (missionDic["type"] == "Shell" && missionDic["num"] == "1")
        //    {
        //        if (transform.position.y <= 0.8f)
        //        {
        //            createReward();
        //        }
        //    }
        //    else
        //    {
        //        if (transform.position.x - rewardTargetX <= 0.1f && transform.position.x - rewardTargetX >= -0.1f && missionDic != null)
        //        {
        //            createReward();
        //        }

        //    }
        //}

        StampDecodeRoof();
        if (transform.position.x < FareAbsence.instance.Perch_Yolk.position.x || transform.position.x > FareAbsence.instance.Perch_Pluto.position.x)
        {
            gameObject.SetActive(false);
            FareAbsence.instance.StemFareForm.Add(gameObject);
            FareAbsence.instance.StemFareBraceForm.Add(ArchBrace);
        }
    }
}
