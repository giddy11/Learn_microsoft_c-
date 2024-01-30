namespace ClassLibrary2
{
    public class Character
    {
        public Character(string name, int health, int attackOpp, int defense)
        {
            Name = name;
            Health = health;
            Attack = attackOpp;
            Defense = defense;
        }

        public void AttackOpponent(Character target)
        {
            /*calculate the amount of damage that the current character would do to the target character based on their attack and defense values. If the damage is greater than 0, it should reduce the target's health by that amount and print a message to the console. If the damage is less than or equal to 0, it should print a different message to the console.*/

            int damage = Attack - target.Defense;
            if (damage > 0)
            {
                target.Health -= damage;
                Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{Name}'s attack has no effect on {target.Name}.");
            }
        }

        public virtual void Defend()
        {
            Console.WriteLine($"{Name} Defending.....");
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

    }
}
