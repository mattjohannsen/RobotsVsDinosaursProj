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
        Herd theHerd;
        Fleet theFleet;


        //constructor
        public Battlefield()
        {
            theHerd = new Herd();
            theFleet = new Fleet();
        }

        //methods
        public void StartBattle()
        {
            Console.WriteLine("Press ENTER to begin battle!");
            Console.ReadLine();
            theHerd.GetDinosaurs();
            theFleet.GetRobots();
            Console.WriteLine(ChooseAttacker());
            Console.ReadLine();
        }
        public string ChooseAttacker()
        {
            string attackerChoice;
            Console.WriteLine("Please choose your attacker (R1, R2, R3, D1, D2, or D3).");
            attackerChoice = Console.ReadLine();
            switch (attackerChoice)
            {
                case "R1":
                    attackerChoice = "robot1";
                    break;
                case "R2":
                    attackerChoice = "robot2";
                    break;
                case "R3":
                    attackerChoice = "robot3";
                    break;
                case "D1":
                    attackerChoice = "dinosaur1";
                    break;
                case "D2":
                    attackerChoice = "dinosaur2";
                    break;
                case "D3":
                    attackerChoice = "dinosaur3";
                    break;
                default:
                    Console.WriteLine("This is not a valid selection.");
                    break;
            }
            return attackerChoice;
        }
    }
}
