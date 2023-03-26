namespace Buff
{
    public abstract class Buff 
    {
        public string Name;
        public int Duration;
        public string Description;
        public abstract void Apply(Character target);
        public abstract void Remove(Character target);
    }
}
