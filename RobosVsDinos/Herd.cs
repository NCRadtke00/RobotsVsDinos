using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobosVsDinos
{
    class Herd
    {
        public List<Dinosaur> dinoType;
        public DinoAttack[] DinosaurAttacks;
      
        public Herd()
        {
            dinoType = new List<Dinosaur>();
            DinosaurAttacks = new DinoAttack[3];
            DinosaurAttacks[0] = new DinoAttack("chomp", 30);
            DinosaurAttacks[1] = new DinoAttack("stomp", 20);
            DinosaurAttacks[2] = new DinoAttack("rage", 40);

   
            dinoType.Add(new Dinosaur("raptor",PickAttack()));
            dinoType.Add(new Dinosaur("trex", PickAttack()));
            dinoType.Add(new Dinosaur("triceratops", PickAttack()));
        }
        public DinoAttack PickAttack()
        {
            Console.WriteLine("Which Attack would you like to use?");
            Console.WriteLine("---(1)chomp----");
            Console.WriteLine("---(2)stomp----");
            Console.WriteLine("---(3)rage-----");
            int userInput = int.Parse(Console.ReadLine());
            return DinosaurAttacks[userInput -1];
        }
    }
}
