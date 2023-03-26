namespace Buff
{
    public class BleedingBuff : Buff
    {
        public int DamagePerTurn;

        public BleedingBuff(int damagePerTurn)
        {
            DamagePerTurn = damagePerTurn;
        }
        public override void Apply(Character target)
        {
            target.Health-=DamagePerTurn;
        }

        public override void Remove(Character target)
        {
            throw new System.NotImplementedException();
        }
    }
}
