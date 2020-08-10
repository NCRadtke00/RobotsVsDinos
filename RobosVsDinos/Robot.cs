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
        //pick weapon, weapon list?

        public Robot(string robotName)
        {
            robotHealth = 100;
            powerLevel = 100;
            this.robotName = GetUserData("Please enter your robots name: ");
            robotWeapon = new Weapon("Blaster", 20);
        }

        public string GetUserData(string output)
        {
            Console.WriteLine(output);
            string results = Console.ReadLine();
            return results;
        }

        public void AttackDino(Dinosaur dinoToAttack)
        {
            dinoToAttack.dinoHealth -= robotWeapon.attackPower;
            powerLevel -= 10;
        }
    }
}
