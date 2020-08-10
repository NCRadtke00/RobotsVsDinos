using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class BattleField
    {
        public void RunGame()
        {

            if(Robot.health == 0 || Dinosaur.health == 0)
            {
                Console.WriteLine("The Dinosaur heard has over run the robots!");
            }
            else
            {
                Console.WriteLine("The Robot fleet has slaughtered the Dinosaurs!");
            }
        }
    }
}
