using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class DinoAttack
    {
        public string attackType;
        public int attackPower;
   
        public DinoAttack(string newType, int attackPower)
        {
            this.attackType = newType;
            this.attackPower = attackPower;
        }
    }
}
