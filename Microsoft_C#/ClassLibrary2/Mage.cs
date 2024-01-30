namespace ClassLibrary2
{
    public class Mage : Character
    {
        public Mage(string name, int health, int attackOpp, int defense) : base(name, health, attackOpp, defense)
        {
        }

        public void CastSpell(Character target)
        {
            // CastSpell(Character target): a method to cast a spell at a target
            int damage = Attack * 3 - target.Defense;
            if (damage > 0)
            {
                target.Health -= damage;
                Console.WriteLine($"{Name} casts a spell on {target.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{Name}'s spell has no effect on {target.Name}.");
            }
        }

        public sealed override void Defend()
        {
            Console.WriteLine($"{Name} cannot defend!");
        }
    }
}
