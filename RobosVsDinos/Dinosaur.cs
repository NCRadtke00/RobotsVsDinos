using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Dinosaur
    {
        int dinoHealth;
        int energy;
        string dinoType;
        Weapon dinoWeapon;
        
        public Dinosaur(string dinoType)
        {
            this.dinoType = dinoType;
            dinoHealth = 100;
            energy = 100;
            dinoWeapon = new Weapon("Stomp", 10);
        }

    }
}
