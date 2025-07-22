using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpareAbsence : WellSweatshop<SpareAbsence>
{
    public string Tour;

    public void HeelSpare(string info)
    {
        Tour = info;
        UIAbsence.KeaTextural().HeelUIDrape(nameof(Spare));
    }
}
