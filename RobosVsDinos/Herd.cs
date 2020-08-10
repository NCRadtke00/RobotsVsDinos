using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Herd
    {
        public Herd()
        {
            List<Dinosaur> dinoType = new List<Dinosaur>();

            Dinosaur firstDino = new Dinosaur("raptor");
            Dinosaur secondDino = new Dinosaur("trex");
            Dinosaur thirdDino = new Dinosaur("triceratops");

            dinoType.Add(firstDino);
            dinoType.Add(secondDino);
            dinoType.Add(thirdDino);
        }

    }
}
