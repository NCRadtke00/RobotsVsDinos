using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Fleet
    {
        public List<Robot> robots;
        public List<Weapon> robotWeapons;
        public Fleet()
        {
            robots = new List<Robot>();
            robotWeapons = new List<Weapon>();
            robotWeapons.Add(new Weapon("Blaster", 35));
            robotWeapons.Add(new Weapon("LazerSword", 25));
            robotWeapons.Add(new Weapon("Cannon", 50));
            robots.Add(new Robot(GetUserData(), ReturnWeapon()));
            robots.Add(new Robot(GetUserData(), ReturnWeapon()));
            robots.Add(new Robot(GetUserData(), ReturnWeapon()));
        }
        public string GetUserData()
        {
            Console.WriteLine("What is your robots name? ");
            string results = Console.ReadLine();
            return results;
        }
        public Weapon ReturnWeapon()
        {
            Console.WriteLine("Pick a weapon");
            Console.WriteLine("---(1)Blaster------");
            Console.WriteLine("---(2)Sword--------");
            Console.WriteLine("---(3)Cannon-------");
            int userInput = int.Parse(Console.ReadLine());
            return robotWeapons[userInput - 1];
        }
    }
}
