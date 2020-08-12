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

        public BattleField()
        {
            fleet = new Fleet();
            Console.ReadLine();
            Console.Clear();
            herd = new Herd();
            Console.ReadLine();
            Console.Clear();
            RunBattleField();
        } 
        public void RunBattleField()
        {
            //while (fleet.robots.Count > 0 && herd.dinoType.Count > 0)
            //    fleet.robots[0].AttackDino(herd.dinoType[0]);
            //if (herd.dinoType[0].dinoHealth <= 0)
            //{
            //    herd.dinoType.Remove(herd.dinoType[0]);
            //}
            //if (fleet.robots[0].robotHealth <= 0)
            //{
            //    fleet.robots.Remove(0);
            //}
            //if (fleet.robots.Count > 0)
            //{
            //    Console.WriteLine("Robots Win");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Dinosaurs Win");
            //    Console.ReadLine();
            //}
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
                        Console.WriteLine("The dino has been lost from the Herd! They will not be forgotten!");
                        if (fleet.robots.Count <= 0)
                        {
                            Console.WriteLine("The Herd has won!");
                            Console.ReadLine();
                        }
                    }
                    else if (herd.dinoType.Count <= 0)
                    {
                        Console.WriteLine("The Fleet has won!");
                        Console.ReadLine();
                    }
                    Console.ReadLine();
                    
                }
                else if (result == "No" || result == "no")
                {
                    herd.dinoType[0].AttackRobot(fleet.robots[0]);
                    Console.WriteLine("Oh no, retaliate!!!");
                    fleet.robots[0].AttackDino(herd.dinoType[0]);
                    if (fleet.robots.Count <= 0)
                    {
                        Console.WriteLine("The Herd has won!");
                        Console.ReadLine();
                    }
                    else if (herd.dinoType.Count <= 0)
                    {
                        Console.WriteLine("The Fleet has won!");
                        Console.ReadLine();
                    }
                    Console.ReadLine();
                   
                }
                //else if (fleet.robots[0].robotHealth <= 0)
                //{
                //    fleet.robots.Remove(fleet.robots[0]);
                //    Console.WriteLine($"{fleet.robots[0]} has been lost from the fleet! The scrap parts will build a new robot!");

                //    Console.ReadLine();
                //    Console.Clear();
                //}
                //else if (herd.dinoType[0].dinoHealth >= 0)
                //{
                //    herd.dinoType.Remove(herd.dinoType[0]);
                //    Console.WriteLine($"{herd.dinoType[0]} has been lost from the Herd! They will not be forgotten!");

                //    Console.ReadLine();
                //    Console.Clear();
                //}
                //else if (fleet.robots.Count < 0)
                //{
                //    Console.WriteLine("The Herd has won!");
                //    Console.ReadLine();
                //    Console.Clear();
                //}
                //else if (herd.dinoType.Count < 0)
                //{
                //    Console.WriteLine("The Fleet has won!");
                //    Console.ReadLine();
                //    Console.Clear();
                //}
                //if (((fleet.robots.Count > 0)) && ((herd.dinoType.Count > 0)))
                //{
                //    Console.WriteLine("would you like to attack the herd?");
                //    Console.WriteLine("----------------------------------");
                //    Console.WriteLine("---------   Yes   ----------------");
                //    Console.WriteLine("-----------    No   --------------");
                //    Console.WriteLine("----------------------------------");
                //    result = Console.ReadLine();
                //    if (result == "Yes" || result == "yes")
                //    {
                //        fleet.robots[0].AttackDino(herd.dinoType[0]);
                //        Console.WriteLine("Oh no, it is attacking back!");
                //        herd.dinoType[0].AttackRobot(fleet.robots[0]);
                       
                //        Console.ReadLine();
                //        Console.Clear();
                //    }
                //    else if (result == "No" || result == "no")
                //    {
                //        herd.dinoType[0].AttackRobot(fleet.robots[0]);
                //        Console.WriteLine("Oh no, retaliate!!!");
                //        fleet.robots[0].AttackDino(herd.dinoType[0]);
                        
                //        Console.ReadLine();
                //        Console.Clear();
                //    }
                //    else if (fleet.robots[0].robotHealth <= 0)
                //    {
                //        fleet.robots.Remove(fleet.robots[0]);
                //        Console.WriteLine($"{fleet.robots[0]} has been lost from the fleet! The scrap parts will build a new robot!");
                        
                //        Console.ReadLine();
                //        Console.Clear();
                //    }
                //    else if (herd.dinoType[0].dinoHealth >= 0)
                //    {
                //        herd.dinoType.Remove(herd.dinoType[0]);
                //        Console.WriteLine($"{herd.dinoType[0]} has been lost from the Herd! They will not be forgotten!");
                        
                //        Console.ReadLine();
                //        Console.Clear();
                //    }
                //    else if (fleet.robots.Count < 0)
                //    {
                //        DisplayWinner();
                //        Console.ReadLine();
                //        Console.Clear();
                //    }
                //    else if (herd.dinoType.Count < 0)
                //    {
                //        DisplayWinner();
                //        Console.ReadLine();
                //        Console.Clear();
                //    }
                }

                //Console.WriteLine("No victory, no surrender!!");

                //if (fleet.robots[0].robotHealth <= 0)
                //{
                //    fleet.robots.Remove(fleet.);
                //}
            }


        }
        //public void DisplayWinner()
        //{
        //    if (herd.dinoType[0].dinoHealth == 0)
        //    {
        //        Console.WriteLine("The Robots have won the war! The Dinos have been extinguished!");
        //    }
        //    else if (fleet.robots[0].robotHealth == 0)
        //    {
        //        Console.WriteLine("The Heard has crush the robots! They have won the war!");
        //    }
        //}
        //if (((fleet.robots[0].robotHealth > 0)) && ((herd.dinoType[0].dinoHealth >0)));
        //{

        //}
    }






