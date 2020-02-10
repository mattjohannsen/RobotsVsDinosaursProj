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
        public bool isAttackerRobot =  true;


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
            string chosenAttacker;
            string chosenTarget;
            //chosenAttacker = ChooseAttacker();
            //Console.WriteLine(chosenAttacker);
            //chosenAttacker = Console.WriteLine(ChooseAttacker());
            //chosenTarget = Console.WriteLine(ChooseTarget());
            Console.WriteLine(isAttackerRobot);
            Console.WriteLine(ChooseAttacker());
            Console.WriteLine(isAttackerRobot);
            Console.WriteLine(ChooseTarget());
            //Console.WriteLine($"{chosenAttacker} vs {chosenTarget}");
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
                    isAttackerRobot = true;
                    break;
                case "R2":
                    attackerChoice = "robot2";
                    isAttackerRobot = true;
                    break;
                case "R3":
                    attackerChoice = "robot3";
                    isAttackerRobot = true;
                    break;
                case "D1":
                    attackerChoice = "dinosaur1";
                    isAttackerRobot = false;
                    break;
                case "D2":
                    attackerChoice = "dinosaur2";
                    isAttackerRobot = false;
                    break;
                case "D3":
                    attackerChoice = "dinosaur3";
                    isAttackerRobot = false;
                    break;
                default:
                    Console.WriteLine("This is not a valid selection.");
                    break;
            }
            return attackerChoice;
        }
        public string ChooseTarget()
        {
            string targetChoice;
            if (isAttackerRobot == true)
            {
                {
                    Console.WriteLine("Please choose your target (D1, D2, or D3).");
                }
                targetChoice = Console.ReadLine();
                switch (targetChoice)
                {
                    case "D1":
                        targetChoice = "dinosaur1";
                        break;
                    case "D2":
                        targetChoice = "dinosaur2";
                        break;
                    case "D3":
                        targetChoice = "dinosaur3";
                        break;
                    default:
                        Console.WriteLine("This is not a valid selection.");
                        break;
                }
                return targetChoice;
            }
            else if (isAttackerRobot == false)
            {
                Console.WriteLine("Please choose your target (R1, R2, R3).");
                targetChoice = Console.ReadLine();
                switch (targetChoice)
                {
                    case "R1":
                        targetChoice = "robot1";
                        break;
                    case "R2":
                        targetChoice = "robot2";
                        break;
                    case "R3":
                        targetChoice = "robot3";
                        break;
                    default:
                        Console.WriteLine("This is not a valid selection.");
                        break;
                }
                return targetChoice;
            }
            else
            {
                return null;
            }
        }
    }
}
