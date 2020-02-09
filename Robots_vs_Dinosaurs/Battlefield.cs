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
        Fleet theFleet = new Fleet();


        //constructor
        

        //methods
        public void StartBattle()
        {
            Console.WriteLine("Press ENTER to begin battle!");
            Console.ReadLine();
            theHerd.GetDinosaurs();
            theFleet.GetRobots();
        }
        public void GetHerd()
        {

        }
    }
}
