using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Herd
    {
        // member variables



        // constructor
        Dinosaur tyrannosaurus = new Dinosaur("Tyrannosaurus", 10, 10, 10);
        Dinosaur stegasaurus = new Dinosaur("Stegasaurus", 10, 10, 7);
        Dinosaur velociraptor = new Dinosaur("Velociraptor", 10, 10, 6);


        // member methods
        public void GetDinosaurs()
        {
            Console.WriteLine("These are the dinosaurs:");
            Console.WriteLine(tyrannosaurus.dinoType);
            Console.ReadLine();
        }



    }
}
