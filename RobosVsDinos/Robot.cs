using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Robot
    {
        int robotHealth;
        int powerLevel;
        string name;
        Weapon robotWeapon;

        public Robot(string name)
        {
            robotHealth = 100;
            powerLevel = 100;
            name = GetUserData("Please enter your robots name: ");
            robotWeapon = new Weapon("Blaster", 20);
        }

        public string GetUserData(string output)
        {
            Console.WriteLine(output);
            string results = Console.ReadLine();
            return results;
        }

    }
}
