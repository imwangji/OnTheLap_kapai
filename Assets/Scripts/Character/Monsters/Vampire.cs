using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampire : Monster
{
    public Vampire()
    {
        Health = 150;
        AttackPower = 30;
        Buffs = new List<Buff.Buff>();
    }
}
