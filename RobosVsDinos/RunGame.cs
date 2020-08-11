using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class RunGame
    {
        public Fleet fleet;
        public Herd herd;
        public BattleField BattleField;
       
       
        public void RunGameStory()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------Welcome to the War!------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
            Console.Clear();
            fleet = new Fleet();
            //Display fleet
            Console.ReadLine();
            Console.Clear();
            herd = new Herd();
            //display herd
            Console.ReadLine();
            Console.Clear();
            BattleField = new BattleField();
            Console.WriteLine("Nick is awesome!");
            Console.ReadLine();
        }
    }
}
