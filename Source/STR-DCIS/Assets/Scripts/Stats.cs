using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    public int dmg = Random.Range(0, 11);

    public int getDmg()
    {
        return dmg;
    }
}
