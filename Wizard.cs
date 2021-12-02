using System;

namespace AssignmentHuman
{
    public class Wizard : Human
    {

        public Wizard(string nme): base(nme, 3, 25, 3, 50)
        {
        
        }
        public override void Attack(Human target)
            {
                target.changeHealth((intelligence*5) *-1);
            }
        public void Heal(Human target)
        {
            target.changeHealth(intelligence*10);
        }
    }

}