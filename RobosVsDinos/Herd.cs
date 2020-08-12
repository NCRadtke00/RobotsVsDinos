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
            DinosaurAttacks[0] = new DinoAttack("chomp", 20);
            DinosaurAttacks[1] = new DinoAttack("stomp", 30);
            DinosaurAttacks[2] = new DinoAttack("rage", 50);
            dinoType.Add(new Dinosaur("raptor",PickAttack("raptor")));
            Console.Clear();
            dinoType.Add(new Dinosaur("trex", PickAttack("trex")));
            Console.Clear();
            dinoType.Add(new Dinosaur("triceratops", PickAttack("triceratops")));
            Console.WriteLine("This is a mighty Herd built from the strongest from each tribe!");
            Console.Clear();
        }
        public DinoAttack PickAttack(string dinoName)
        {
            Console.WriteLine($"Which Attack would you like {dinoName} to use?");
            Console.WriteLine("---(1)chomp-------");
            Console.WriteLine("---(2)stomp-------");
            Console.WriteLine("---(3)rage--------");
            int userInput = int.Parse(Console.ReadLine());
            return DinosaurAttacks[userInput -1];
        } 
    }
}
