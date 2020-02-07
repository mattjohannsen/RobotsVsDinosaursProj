using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Battlefield
    {
        //member variables
        Herd theHerd = new Herd();


        //constructor
        

        //methods
        public void StartBattle()
        {
            Console.WriteLine("The battle begins!");
            Console.ReadLine();
            theHerd.GetDinosaurs();
        }
        public void GetHerd()
        {

        }
    }
}
