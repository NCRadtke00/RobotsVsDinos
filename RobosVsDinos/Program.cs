using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Fleet fleet = new Fleet();
            Herd herd = new Herd();
            
            BattleField battleField = new BattleField();
            battleField.RunGame();
        }
    }
}
