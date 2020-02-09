using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Herd
    {
        // member variables



        // constructor
        Dinosaur dinosaur1 = new Dinosaur("Tyrannosaurus", 100, 100, 100);
        Dinosaur dinosaur2 = new Dinosaur("Stegasaurus", 100, 100, 70);
        Dinosaur dinosaur3 = new Dinosaur("Velociraptor", 100, 100, 60);


        // member methods
        public void GetDinosaurs()
        {
            Console.WriteLine("These are the dinosaurs:");
            //Console.WriteLine(dinosaur1.dinoType);
            Console.WriteLine($"D1: {dinosaur1.dinoType} Health:{dinosaur1.dinoHealth} Energy:{dinosaur1.dinoHealth} Attack Power:{dinosaur1.dinoAttackPower}");
            Console.WriteLine($"D2: {dinosaur2.dinoType} Health:{dinosaur2.dinoHealth} Energy:{dinosaur2.dinoHealth} Attack Power:{dinosaur2.dinoAttackPower}");
            Console.WriteLine($"D3: {dinosaur3.dinoType} Health:{dinosaur3.dinoHealth} Energy:{dinosaur3.dinoHealth} Attack Power:{dinosaur3.dinoAttackPower}");


            Console.ReadLine();
        }



    }
}
