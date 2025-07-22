using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackupPistonFlavin : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("getButton")]    public Button TieInform;
    Dictionary<string, string> AmateurFlu;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        GetComponent<Collider2D>().enabled = false;
        GetComponent<RectTransform>().sizeDelta = new Vector2(110f, 82f);
        float Grama= Screen.width / 750f;
        transform.localScale = transform.localScale * Grama;
    }
    public void Asia(Dictionary<string,string> dic)
    {
        AmateurFlu = dic;
        

        if (TreeTwigAbsence.GetBool(CSoviet.Or_TarGlueSpin + "1-2"))
        {
            GetComponent<Collider2D>().enabled = true;
            float force = Random.Range(1f, 1.5f);
            float x= Random.Range(0.5f, 1f) * (Random.Range(0, 2) == 0 ? -1 : 1);
            float y= Random.Range(0.5f, 1f) * (Random.Range(0, 2) == 0 ? -1 : 1);
            GetComponent<Rigidbody2D>().velocity = new Vector2(x, y).normalized * 0.1f;
        }
        else
        {
            Seem.instance.ValidSeemAdultDownYam();
            transform.SetParent(UIAbsence.KeaTextural().PinkCyclic.transform);
            TreeTwigAbsence.SetBool(CSoviet.Or_TarGlueSpin + "1-2", true);
            TarGlueAbsence.KeaTextural().ToneDownSackKestrel(Vector2.zero, "", Vector2.zero, true, gameObject, true, () => {
                HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HikeKrillGrandeWeedy);
            });
        }
        TieInform.onClick.AddListener(() =>
        {
            
            GetComponent<Collider2D>().enabled = false;
            
            if (AmateurFlu["type"] == "Gold")
            {
                //Destroy(getButton.gameObject);
                ThereOil.KeaTextural().BeerAlbedo(ThereTern.SceneMusic.Notch_HikeChic);
                List<int> FishGoldList = new List<int>(TreeTwigAbsence.GetIntArray(CSoviet.Or_FarePastChicTreat));
                Seem.instance.RidChic(FishGoldList[0]);
                FishGoldList.RemoveAt(0);
                TreeTwigAbsence.SetIntArray(CSoviet.Or_FarePastChicTreat, FishGoldList.ToArray());
                Destroy(TieInform.gameObject);
            }
            else if (AmateurFlu["type"] == "Cash")
            {
                //Destroy(getButton.gameObject);
                ThereOil.KeaTextural().BeerAlbedo(ThereTern.SceneMusic.Notch_HikeChic);
                List<float> FishCashList = new List<float>(TreeTwigAbsence.GetFloatArray(CSoviet.Or_FarePastSoarTreat));
                Seem.instance.RidSoar(FishCashList[0]);
                FishCashList.RemoveAt(0);
                TreeTwigAbsence.SetFloatArray(CSoviet.Or_FarePastSoarTreat, FishCashList.ToArray());
                Destroy(TieInform.gameObject);
            }
            else if (AmateurFlu["type"] == "Puzzle")
            {
                int havePuzzle = TreeTwigAbsence.GetInt(CSoviet.Or_StitchPastStyle);
                havePuzzle--;
                TreeTwigAbsence.SetInt(CSoviet.Or_StitchPastStyle, havePuzzle);
                int rewardPuzzle = TreeTwigAbsence.GetInt(CSoviet.Or_StitchBackupStyle);
                rewardPuzzle--;
                TreeTwigAbsence.SetInt(CSoviet.Or_StitchBackupStyle, rewardPuzzle);
                UIAbsence.KeaTextural().HeelUIDrape(nameof(GrandeStitchKrill));
            }
            else
            {
                int ShellRewardCount = TreeTwigAbsence.GetInt(CSoviet.Or_TenetBackupStyle);
                ShellRewardCount--;
                TreeTwigAbsence.SetInt(CSoviet.Or_TenetBackupStyle, ShellRewardCount);
                int ShellHaveCount = TreeTwigAbsence.GetInt(CSoviet.Or_TenetPastStyle);
                ShellHaveCount--;
                TreeTwigAbsence.SetInt(CSoviet.Or_TenetPastStyle, ShellHaveCount);
                if (TreeTwigAbsence.GetBool(CSoviet.Or_TarGlueSpin + "1-3"))
                {
                    UIAbsence.KeaTextural().HeelUIDrape("FishShellPanel");
                    TieInform.onClick.RemoveAllListeners();
                    Destroy(gameObject);
                    return;
                }
                else
                {
                    TreeTwigAbsence.SetBool(CSoviet.Or_TarGlueSpin + "1-3", true);
                }
            }
            HandfulTwig Luck= new HandfulTwig();
            Luck.TroutMexico = AmateurFlu["type"];
            Luck.TroutSeemFluent = gameObject;
            HandfulCannonForth.KeaTextural().Corn(CSoviet.Of_HikeKrillKeaFareBackup, Luck);
            TieInform.onClick.RemoveAllListeners();
            Destroy(gameObject);
        });
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Wall"))
        {
            GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * 0.1f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.GetComponent<FareGive>().FascinateForm.Contains(gameObject))
        {
            Vector2 v2 = transform.position - collision.transform.position;
            GetComponent<Rigidbody2D>().velocity = v2.normalized;
            GetComponent<Rigidbody2D>().drag = 0.5f;
            collision.gameObject.GetComponent<FareGive>().FascinatePiston(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody2D>().drag > 0 && GetComponent<Rigidbody2D>().velocity.magnitude < 0.1f)
        {
            GetComponent<Rigidbody2D>().drag = 0;
            GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * 0.1f;
        }
    }
}
