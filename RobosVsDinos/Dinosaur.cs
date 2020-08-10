using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Dinosaur
    {
        public int dinoHealth;
        public int energy;
        public string dinoType;
        Weapon dinoWeapon;
        
        public Dinosaur(string dinoType)
        {
            this.dinoType = dinoType;
            dinoHealth = 100;
            energy = 100;
            dinoWeapon = new Weapon("Stomp", 10);
        }

        public void AttackRobot(Robot roboToAttack)
        {
            roboToAttack.robotHealth -= dinoWeapon.attackPower;
            energy -= 10;
        }
    }
}
