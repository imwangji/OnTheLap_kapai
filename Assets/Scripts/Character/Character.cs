using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string Name;
    public int Health;
    public int AttackPower;
    public int Speed;
    public List<Buff.Buff> Buffs;
}
