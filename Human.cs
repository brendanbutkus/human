using System;

namespace AssignmentHuman
{
    public class Human
    {
        public string name;
        public int strength;

        public int intelligence;

        public int dexterity;

        protected int health;

        public int Health
        {
            get{return health;}
        }

        public Human(string nme)
        {
            name = nme;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string nme, int str, int intel, int dex, int hlth)
        {
            name = nme;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hlth;
        }


        public virtual void Attack(Human target)
        {
            target.health -= (strength*5);
            // return target.health;
            // the return has to be within the function
        }

        public void changeHealth(int amount)
        {
            health = health + amount;
        }
        
    }


}
