using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wraith : Monster
{
    public Wraith()
    {
        Health = 75;
        AttackPower = 20;
        Buffs = new List<Buff.Buff>();
    }
}
