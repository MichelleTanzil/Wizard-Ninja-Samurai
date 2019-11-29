using System;
namespace wizard_ninja_samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            int dexterityAttack = Dexterity * 5;
            target.Dexterity -= dexterityAttack;
            Console.WriteLine($"As a Ninja, the target's Dexterity is reduced by {dexterityAttack} and reduced to {target.Dexterity}");
            Random randInt = new Random();
            if(randInt.Next(1,6) == 1)
            {
                target.Health -= 10;
                Console.WriteLine($"The 20% chance of dealing 10 additional points of damage succeeded.");
            }
            return target.Health;
        }
        public void Steal(Human target)
        {
            int stealAmount = 5;
            target.Health -= stealAmount;
            Health += stealAmount;
            Console.WriteLine($"This ninja stole 5 health and is now at {Health} health and the target is at {target.Health}");
        }
    }
}