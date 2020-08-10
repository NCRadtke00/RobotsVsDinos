using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Attack
    {
        public void Attack()
        {
            if (" " == " ")
            {
                Next.Attack();
            }
            else if (" " > " ")
            {
                Robot.health +- Dinosaur.attackPower;
            }
            else if (" " > " ")
            {
                Dinosaur.health +- Robot.attackPower;
            }
        }
    }
}
