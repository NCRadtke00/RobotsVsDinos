﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class BattleField
    {
        public Fleet fleet;
        public Herd herd;

        public BattleField()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------Welcome to the War!----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------Please name the rest of your robot fleet!------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
            Console.Clear();
            fleet = new Fleet();
            //display list<fleet>
            Console.ReadLine();
            Console.Clear();
            herd = new Herd();
            //display List<herd>
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now that the Fleet is here we can finally set an attack on the Herd!");
            Console.ReadLine();
            Console.WriteLine("OH NO!!");
            Console.WriteLine("The Alarms are going off!!");
            Console.WriteLine("The heard is rapidly approaching our location!");
            Console.ReadLine();
            Console.Clear();
            RunBattleField();
            DisplayWinner();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------The War Is Over!-------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------Thank you for playing! ------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------NR");
            Console.ReadLine();
            Console.WriteLine("Nick is awesome!");
            Console.WriteLine("Make sure to give him the best grades!!!");
            Console.ReadLine();
        }
        public void RunBattleField()
        {
            while (((fleet.robots.Count > 0)) && ((herd.dinoType.Count > 0)))
            {
                Console.WriteLine("would you like to attack the herd?");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("---------   Yes   ----------------");
                Console.WriteLine("-----------    No   --------------");
                Console.WriteLine("----------------------------------");
                string result = Console.ReadLine();
                if (result == "Yes" || result == "yes")
                {
                    fleet.robots[0].AttackDino(herd.dinoType[0]);
                    Console.WriteLine("Oh no, it is attacking back!");
                    herd.dinoType[0].AttackRobot(fleet.robots[0]);
                    if (herd.dinoType[0].dinoHealth <= 0)
                    {
                        herd.dinoType.Remove(herd.dinoType[0]);
                        //Console.WriteLine($"The {dinoType} has been lost from the Herd! They will not be forgotten!");
                        Console.WriteLine("The dino has been lost from the Herd! They will not be forgotten!");
                        Console.ReadLine();
                    }
                    else if (fleet.robots[0].robotHealth <= 0)
                    {
                        fleet.robots.Remove(fleet.robots[0]);
                        //Console.WriteLine($"The {robotName} has been lost from the Herd! They will not be forgotten!");
                        Console.WriteLine("The robot has been lost from the fleet! The parts will be recycled!");
                        Console.ReadLine();
                    }
                    Console.ReadLine();
                }
                else if (result == "No" || result == "no")
                {
                    herd.dinoType[0].AttackRobot(fleet.robots[0]);
                    Console.WriteLine("Oh no, retaliate!!!");
                    fleet.robots[0].AttackDino(herd.dinoType[0]);
                    if (herd.dinoType[0].dinoHealth <= 0)
                    {
                        herd.dinoType.Remove(herd.dinoType[0]);
                        //Console.WriteLine($"The {dinoType} has been lost from the Herd! They will not be forgotten!");
                        Console.WriteLine("The dino has been lost from the Herd! They will not be forgotten!");
                        Console.ReadLine();
                    }
                    else if (fleet.robots[0].robotHealth <= 0)
                    {
                        fleet.robots.Remove(fleet.robots[0]);
                        //Console.WriteLine($"The {robotName} has been lost from the Herd! They will not be forgotten!");
                        Console.WriteLine("The robot has been lost from the fleet! The parts will be recycled!");
                        Console.ReadLine();
                    }
                    Console.ReadLine();
                }
            }
        }
        public void DisplayWinner()
        {
            if (fleet.robots.Count == 0)
            {
                Console.WriteLine("The Herd has won!");
                Console.ReadLine();
            }
            else if (herd.dinoType.Count == 0)
            {
                Console.WriteLine("The Fleet has Won!");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}






