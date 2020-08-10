using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Weapon
    {
        public string type;
        public int attackPower;
        //weapons list?
        public Weapon(string newType, int attackPower)
        {
            this.type = newType;
            this.attackPower = attackPower;
        }
    }
}
