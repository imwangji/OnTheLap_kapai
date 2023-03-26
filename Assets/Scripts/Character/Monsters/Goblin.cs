using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Monster
{
    public Goblin()
    {
        Health = 50;
        AttackPower = 10;
        Buffs = new List<Buff.Buff>();
    }
}
