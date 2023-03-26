using System.Collections.Generic;
using Buff;

namespace Card.SkillCards
{
    public class FireballCard:SkillCard
    {
        public FireballCard()
        {
            Name = "Fireball";
            Damage = 15;
            Buffs = new List<Buff.Buff> { new BurnBuff(3) };
        }

        public override void Activate()
        {
            // 在这里实现火球技能的逻辑
        }
    }
}
