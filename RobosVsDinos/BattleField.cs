using System;
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
        public void RunGame()
        {
            fleet = new Fleet();
            herd = new Herd();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------Welcome to the War!------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
            RunBattleField();
        }
        public void RunBattleField()
        {
            fleet.robots[0].AttackDino(herd.dinoType[0]);
            herd.dinoType[0].AttackRobot(fleet.robots[0]);
            //Who attacks first ?
            if ((fleet.robots[0].robotHealth > 0)) //&& /*(herd.dinosaur[0].dinoHealth >0)*/)
            {
                Console.WriteLine("would you like to attack the herd?");
                string result = Console.ReadLine();
                if (result == "Yes" || result == "yes")
                {
                    fleet.robots[0].AttackDino(herd.dinoType[0]);
                    RemoveWounded();
                    DisplayWinner();
                    Console.WriteLine($"Oh no, {Dinosaur} is retaliating!");
                    herd.dinoType[0].AttackRobot(fleet.robots[0]);
                    RemoveWounded();
                    DisplayWinner();
                }
                else
                {
                    herd.dinoType[0].AttackRobot(fleet.robots[0]);
                    RemoveWounded();
                    DisplayWinner();
                    Console.WriteLine("Oh no, retaliate!!!");
                    fleet.robots[0].AttackDino(herd.dinoType[0]);
                    RemoveWounded();
                    DisplayWinner();
                }
            }
        }

        public void RemoveWounded()
        {

            if (Robot.robotHealth >= 0)
            {
                //remove Robot from list of robots
                Console.WriteLine($"{Robot} has been lost from the fleet! The scrap parts will build a new robot!");
            }
            else if (Dinosaur.dinoHealth >= 0)
            {
                //remove dino from list of dinos
                Console.WriteLine($"{Dino} has been lost from the Herd! They will not be forgotten!");
            }
        }
        public void DisplayWinner()
        {
            if (List < Dinosaur > dinosaur == [0])
            {
                Console.WriteLine("The Robots have won the war! The Dinos have been extinguished!");
            }
            else if (List < Robot > robot += [0])
            {
                Console.WriteLine("The Heard has crush the robots! They have won the war!");
            }
        }
    }

}
