using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogre : Monster
{
    public Ogre()
    {
        Health = 200;
        AttackPower = 25;
        Buffs = new List<Buff.Buff>();
    }
}
