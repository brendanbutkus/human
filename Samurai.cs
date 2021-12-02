using System;

namespace AssignmentHuman
{
    public class Samurai : Human
    {

        public Samurai(string nme): base(nme, 3, 3, 3, 200)
        {
        }
        
        public override void Attack(Human target)
        {
            if(target.Health < 50){
                int newHealth = target.Health;
                target.changeHealth(newHealth * -1);
            }
            else
            {
                int newHealth = (strength*5);
                target.changeHealth(newHealth * -1);
            }
        }

        public void Meditate()
        {
            changeHealth(200);
        }
    }
}