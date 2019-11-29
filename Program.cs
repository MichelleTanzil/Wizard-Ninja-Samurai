using System;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Michelle = new Human("Michelle");
            Wizard Bailey = new Wizard("Bailey");
            Ninja Mark = new Ninja("Mark");
            Samurai Kevin = new Samurai("Kevin");

            while(Michelle.Health > 50)
            {
                Mark.Attack(Michelle);
            }
            Console.WriteLine($"Michelle's health is at {Michelle.Health}.");
            Bailey.Heal(Michelle);
        }
    }
}
