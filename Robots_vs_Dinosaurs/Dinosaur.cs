using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Dinosaur
    {
        //member variables
        public string dinoType;
        public int dinoHealth;
        public int  dinoEnergy;
        public int dinoAttackPower;

        //constructor SPAWNER
        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            Dinosaur Tyrannosaurus = new Dinosaur("Tyrannosaurus", 10, 10, 10);
        }
        //{
        //    Dinosaur Tyrannosaurus = new Dinosaur("Tyrannosaurus", 10, 10, 10);
        //    //Dinosaur stegasaurus = new Dinosaur("Stegasaurus", 10, 10, 7);
        //    //Dinosaur velociraptor = new Dinosaur("Velociraptor", 10, 10, 6);
        //}

        // member methods
        void ShowDinosaur()
        {
            Console.WriteLine(dinoType + " " + dinoHealth + " " + dinoEnergy + " " + dinoAttackPower);
        }


    }
}
