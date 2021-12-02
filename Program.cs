using System;

namespace AssignmentHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human a = new Human("Pluto");
            Human b = new Human("Dragon");
            Ninja c = new Ninja("Wilbur");
            Samurai d = new Samurai("Samurai");
            Wizard e = new Wizard("Jamie");

            a.Attack(b);
            System.Console.WriteLine(b.Health);
            c.Attack(d);
            System.Console.WriteLine(d.Health);
            e.Heal(d);
            System.Console.WriteLine(d.Health);
        }
    }
}
