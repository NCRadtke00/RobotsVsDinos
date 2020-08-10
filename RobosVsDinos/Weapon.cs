using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Weapon
    {
        string type;
        int attackPower;
        public Weapon(string newType, int attackPower)
        {
            this.type = newType;
            this.attackPower = attackPower;
        }
    }
}
