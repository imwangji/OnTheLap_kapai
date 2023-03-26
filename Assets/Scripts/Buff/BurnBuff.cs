    namespace Buff
    {
        public class BurnBuff:Buff
        {
            public int DamagePerTurn;

            public BurnBuff(int damagePerTurn)
            {
                DamagePerTurn = damagePerTurn;
            }
            public override void Apply(Character target)
            {
                throw new System.NotImplementedException();
            }

            public override void Remove(Character target)
            {
                throw new System.NotImplementedException();
            }
        }
    }
