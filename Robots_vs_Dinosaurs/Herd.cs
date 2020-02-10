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
        //public Dinosaur dinosaur1;
        //public Dinosaur dinosaur2;
        //public Dinosaur dinosaur3;

        public List<Dinosaur> dinosaurs;

        // Declare the List
        // Instantiate the List in the constructor
        // Add dinosaur data type to the existing dinosaurs in the constructor
        // Add the dinosaurs to the List


        // constructor
        // OLD working constructor
        //public Herd()
        //{
        //    dinosaur1 = new Dinosaur("Tyrannosaurus", 100, 100, 100);
        //    dinosaur2 = new Dinosaur("Stegasaurus", 100, 100, 70);
        //    dinosaur3 = new Dinosaur("Velociraptor", 100, 100, 60);
        //}
        public Herd()
        {
            Dinosaur dinosaur1 = new Dinosaur("Tyrannosaurus", 100, 100, 50);
            Dinosaur dinosaur2 = new Dinosaur("Stegasaurus", 100, 100, 30);
            Dinosaur dinosaur3 = new Dinosaur("Velociraptor", 100, 100, 20);

            dinosaurs = new List<Dinosaur>() { dinosaur1, dinosaur2, dinosaur3 };
        }


        // member methods
        public void GetDinosaurs()
        {
            Console.WriteLine("These are the dinosaurs:");
            //Console.WriteLine(dinosaur1.dinoType);
            //Console.WriteLine($"D1: {dinosaurs[0].dinoType}");
            Console.WriteLine($"D1: {dinosaurs[0].dinoType} Health:{dinosaurs[0].dinoHealth} Energy:{dinosaurs[0].dinoHealth} Attack Power:{dinosaurs[0].dinoAttackPower}");
            Console.WriteLine($"D2: {dinosaurs[1].dinoType} Health:{dinosaurs[1].dinoHealth} Energy:{dinosaurs[1].dinoHealth} Attack Power:{dinosaurs[1].dinoAttackPower}");
            Console.WriteLine($"D3: {dinosaurs[2].dinoType} Health:{dinosaurs[2].dinoHealth} Energy:{dinosaurs[2].dinoHealth} Attack Power:{dinosaurs[2].dinoAttackPower}");
            //Console.WriteLine($"D2: {dinosaur2.dinoType} Health:{dinosaur2.dinoHealth} Energy:{dinosaur2.dinoHealth} Attack Power:{dinosaur2.dinoAttackPower}");
            //Console.WriteLine($"D3: {dinosaur3.dinoType} Health:{dinosaur3.dinoHealth} Energy:{dinosaur3.dinoHealth} Attack Power:{dinosaur3.dinoAttackPower}");
            //Console.WriteLine($"D1: {dinosaur1.dinoType} Health:{dinosaur1.dinoHealth} Energy:{dinosaur1.dinoHealth} Attack Power:{dinosaur1.dinoAttackPower}");
            //Console.WriteLine($"D2: {dinosaur2.dinoType} Health:{dinosaur2.dinoHealth} Energy:{dinosaur2.dinoHealth} Attack Power:{dinosaur2.dinoAttackPower}");
            //Console.WriteLine($"D3: {dinosaur3.dinoType} Health:{dinosaur3.dinoHealth} Energy:{dinosaur3.dinoHealth} Attack Power:{dinosaur3.dinoAttackPower}");


            //Console.ReadLine();
        }



    }
}
