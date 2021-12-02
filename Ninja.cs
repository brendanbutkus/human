using System;

namespace AssignmentHuman
{
    public class Ninja : Human
    {

        public Ninja(string nme) : base(nme, 3, 3, 75, 100)
        {

        }
        public override void Attack(Human target)
        {
            // int newHealth = target.Health;
            int newHealth = -(dexterity*5);
            target.changeHealth(newHealth);
            // target.health -= (dexterity * 5);
            Random rand = new Random();
            if (rand.Next(1, 6) == 3)
            {
                target.changeHealth(-10);
            }

        }

        public void Steal(Human target)
        {
            // int newHealth = target.Health;
            target.changeHealth(-5);
            changeHealth(5); 
            
        }
    }





}