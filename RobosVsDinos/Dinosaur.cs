using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Dinosaur
    {
        public int dinoHealth;
        public int energy;
        public string dinoType;
        DinoAttack dinoAttack;
        public Dinosaur(string dinoType, DinoAttack dinoAttack)
        {
            this.dinoType = dinoType;
            dinoHealth = 100;
            energy = 100;
            this.dinoAttack = dinoAttack;
        }
        public void AttackRobot(Robot roboToAttack)
        {
            roboToAttack.robotHealth -= dinoAttack.attackPower;
            energy -= 10;
            Console.WriteLine($"The {roboToAttack} has taken {dinoAttack.attackPower} from {dinoType}.");
        }
    }
}
