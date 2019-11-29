using System;
namespace wizard_ninja_samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            Health = 50;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            int intelligenceAttack = 5 * Intelligence;
            target.Intelligence -= intelligenceAttack;
            Health += intelligenceAttack;
            Console.WriteLine($"As a wizard, {Name} attacked {target.Name} at their intelligence for{intelligenceAttack} and healed as well.");
            return target.Health;
        }
        public void Heal(Human target)
        {
            int healAmount = Intelligence * 10;
            target.Intelligence += healAmount;
            Console.WriteLine($"The target's intelligence has been healed by {healAmount} to {target.Intelligence}.");
        }
    }
}