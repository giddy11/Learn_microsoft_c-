namespace ClassLibrary2
{
    public class Warrior : Character
    {
        public Warrior(string name, int health, int attackOpp, int defense) : base(name, health, attackOpp, defense)
        {
        }

        public void Charge(Character target)
        {
            // a method to charge at a target
            int damage = Attack * 2 - target.Defense;
            if (damage > 0)
            {
                target.Health -= damage;
                Console.WriteLine($"{Name} charges {target.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{Name}'s charge has no effect on {target.Name}.");
            }
        }

        public override void Defend()
        {
            // Override the Defend method to add 5 to the character's defense value when called.
            Defense += 5;
            Console.WriteLine($"{Name} defends and gains 5 defense.");
        }
    }
}
