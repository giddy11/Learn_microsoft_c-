namespace ClassLibrary2
{
    public class Dragon : Character
    {
        public Dragon(string name, int health, int attackOpp, int defense) : base(name, health, attackOpp, defense)
        {
        }

        public void BreatheFire(Character target)
        {
            // BreatheFire(Character target): a method for the dragon to breathe fire at a target
            int damage = Attack * 4 - target.Defense;
            if (damage > 0)
            {
                target.Health -= damage;
                Console.WriteLine($"{Name} breathes fire on {target.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{Name}'s fire has no effect on {target.Name}.");
            }
        }

        public override void Defend()
        {
            // Override the Attack method to double the attack value when called.
            Defense *= 2;
            Console.WriteLine($"{Name} defends and gains {Defense} defense.");
        }
    }
}
