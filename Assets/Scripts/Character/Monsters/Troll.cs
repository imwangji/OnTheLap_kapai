using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll : Monster
{
    public Troll()
    {
        Health = 100;
        AttackPower = 15;
        Buffs = new List<Buff.Buff>();
    }
}