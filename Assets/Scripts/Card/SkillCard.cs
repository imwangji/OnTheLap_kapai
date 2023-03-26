using System.Collections.Generic;

namespace KapaiGame
{
    public abstract class SkillCard : Card
    {
        public int Damage;
        public int Cost;
        public List<Buff.Buff> Buffs;
        public override void Activate()
        {
            throw new System.NotImplementedException();
        }
    }
}
