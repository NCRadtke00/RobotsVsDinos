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
            fleet = new Fleet();
            Console.ReadLine();
            Console.Clear();
            herd = new Herd();
            Console.ReadLine();
            Console.Clear();
            while (((fleet.robots[0].robotHealth > 0)) && ((herd.dinoType[0].dinoHealth > 0)))
            {
                Console.WriteLine("would you like to attack the herd?");
                string result = Console.ReadLine();
                if (result == "Yes" || result == "yes")
                {
                    fleet.robots[0].AttackDino(herd.dinoType[0]);

                    Console.WriteLine($"Oh no, it is retaliating!");
                    herd.dinoType[0].AttackRobot(fleet.robots[0]);
                    DisplayWinner();
                }
                else
                {
                    herd.dinoType[0].AttackRobot(fleet.robots[0]);
                    Console.WriteLine("Oh no, retaliate!!!");
                    fleet.robots[0].AttackDino(herd.dinoType[0]);
                    DisplayWinner();
                }
            }
            //if (((fleet.robots[0].robotHealth > 0)) && ((herd.dinoType[0].dinoHealth >0)));
            //{
               
            //}
        }

        public void RemoveWounded()
        {

            if (fleet.robots[0].robotHealth >= 0)
            {
                //remove Robot from list of robots
                Console.WriteLine($"{fleet.robots[0]} has been lost from the fleet! The scrap parts will build a new robot!");
            }
            else if (herd.dinoType[0].dinoHealth >= 0)
            {
                //remove dino from list of dinos
                Console.WriteLine($"{herd.dinoType[0]} has been lost from the Herd! They will not be forgotten!");
            }
        }
        public void DisplayWinner()
        {
            if (herd.dinoType[0].dinoHealth == 0 )
            {
                Console.WriteLine("The Robots have won the war! The Dinos have been extinguished!");
            }
            else if (fleet.robots[0].robotHealth == 0)
            {
                Console.WriteLine("The Heard has crush the robots! They have won the war!");
            }
        }
    }

}
