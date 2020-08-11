using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Robot
    {
        public int robotHealth;
        public int powerLevel;
        public string robotName;
        Weapon robotWeapon;
        public Robot(string robotName, Weapon weapon)
        {
            robotHealth = 100;
            powerLevel = 100;
            this.robotName = robotName;
            robotWeapon = weapon;
        }
        public void AttackDino(Dinosaur dinoToAttack)
        {
            dinoToAttack.dinoHealth -= robotWeapon.attackPower;
            powerLevel -= 10;
            // Console.WriteLine($"The {dinoType} has taken {robotWeapon.attackPower} from {robotName}.");
        }
    }
}
