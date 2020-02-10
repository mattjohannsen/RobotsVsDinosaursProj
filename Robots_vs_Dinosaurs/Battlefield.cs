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
        string attackerVariable;
        string targetVariable;


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
            //string chosenAttacker;
            //string chosenTarget;
            //chosenAttacker = ChooseAttacker();
            //Console.WriteLine(chosenAttacker);
            //chosenAttacker = Console.WriteLine(ChooseAttacker());
            //chosenTarget = Console.WriteLine(ChooseTarget());
            //Console.WriteLine(isAttackerRobot);
            Console.WriteLine(ChooseAttacker());
            //Console.WriteLine(isAttackerRobot);
            Console.WriteLine(ChooseTarget());
            if (isAttackerRobot == true)
            {
                robotAttack(attackerVariable, targetVariable);
            }
            else if (isAttackerRobot == false)
            {
                dinoAttack();
            }
            else
            {

            }
            //Console.WriteLine($"{chosenAttacker} vs {chosenTarget}");
            Console.ReadLine();
        }
        public void robotAttack(string attackerVariable, string targetVariable)
        {
            //Start of the attacker Index Code
            int attackerIndex;
            attackerIndex = 0;

            if (attackerVariable == "robot1")
            {
                attackerIndex = 0;
            }
            if (attackerVariable == "robot2")
            {
                attackerIndex = 1;
            }
            if (attackerVariable == "robot3")
            {
                attackerIndex = 2;
            }

            //Start of the target Index Code
            int targetIndex;
            targetIndex = 0;

            if (targetVariable == "dinosaur1")
            {
                targetIndex = 0;
            }
            if (targetVariable == "dinosaur2")
            {
                targetIndex = 1;
            }
            if (targetVariable == "dinosaur3")
            {
                targetIndex = 2;
            }
            Console.WriteLine($"{attackerVariable} vs {targetVariable}");
            Console.WriteLine($"{theFleet.robots[attackerIndex].robotName}  attacks {theHerd.dinosaurs[targetIndex].dinoType}");
            Console.WriteLine($"{theFleet.robots[attackerIndex].robotName} Attack Power: {theFleet.robots[attackerIndex].robotWeapon.weaponAttackPower}");
            Console.WriteLine($"{theHerd.dinosaurs[targetIndex].dinoType} Attack Power: {theHerd.dinosaurs[targetIndex].dinoAttackPower}");
            if (theFleet.robots[attackerIndex].robotWeapon.weaponAttackPower < theHerd.dinosaurs[targetIndex].dinoAttackPower)
                {
                Console.WriteLine($"{theFleet.robots[attackerIndex].robotName} loses!");
                theFleet.robots[0].robotHealth = (theFleet.robots[attackerIndex].robotHealth - theHerd.dinosaurs[targetIndex].dinoAttackPower);
                }
            else if (theFleet.robots[attackerIndex].robotWeapon.weaponAttackPower > theHerd.dinosaurs[targetIndex].dinoAttackPower)
            {
                Console.WriteLine($"{theFleet.robots[attackerIndex].robotName} wins!");
                Console.WriteLine( $"|{theHerd.dinosaurs[targetIndex].dinoHealth}|");
                Console.WriteLine($"{theHerd.dinosaurs[targetIndex].dinoHealth} - {theFleet.robots[attackerIndex].robotWeapon.weaponAttackPower}");
                
                theHerd.dinosaurs[0].dinoHealth = (theHerd.dinosaurs[targetIndex].dinoHealth) - (theFleet.robots[attackerIndex].robotWeapon.weaponAttackPower);
                Console.WriteLine($"{theHerd.dinosaurs[targetIndex].dinoHealth}");
            }
            else
            {
                Console.WriteLine("Tie!");
            }
            Console.WriteLine($"{theFleet.robots[attackerIndex].robotHealth}");
        }
        public void dinoAttack()
        {
            //This is the old dinoAttack method code


            //Console.WriteLine("Dinosaur Attack");
            //Console.WriteLine(attackerVariable + " vs. " + targetVariable);

            //Console.WriteLine($"{theFleet.robots[0].robotName} Attack Power: {theFleet.robots[0].robotWeapon.weaponAttackPower}");
            //Console.WriteLine($"{theHerd.dinosaurs[0].dinoType} Attack Power: {theHerd.dinosaurs[0].dinoAttackPower}");

        }

        public string ChooseAttacker()
        {
            //string attackerChoice;
            Console.WriteLine("Please choose your attacker (R1, R2, R3, D1, D2, or D3).");
            attackerVariable = Console.ReadLine();
            switch (attackerVariable)
            {
                case "R1":
                    attackerVariable = "robot1";
                    isAttackerRobot = true;
                    break;
                case "R2":
                    attackerVariable = "robot2";
                    isAttackerRobot = true;
                    break;
                case "R3":
                    attackerVariable = "robot3";
                    isAttackerRobot = true;
                    break;
                case "D1":
                    attackerVariable = "dinosaur1";
                    isAttackerRobot = false;
                    break;
                case "D2":
                    attackerVariable = "dinosaur2";
                    isAttackerRobot = false;
                    break;
                case "D3":
                    attackerVariable = "dinosaur3";
                    isAttackerRobot = false;
                    break;
                default:
                    Console.WriteLine("This is not a valid selection.");
                    break;
            }
            return attackerVariable;
        }
        public string ChooseTarget()
        {
            string targetChoice;
            if (isAttackerRobot == true)
            {
                {
                    Console.WriteLine("Please choose your target (D1, D2, or D3).");
                }
                targetVariable = Console.ReadLine();
                switch (targetVariable)
                {
                    case "D1":
                        targetVariable = "dinosaur1";
                        break;
                    case "D2":
                        targetVariable = "dinosaur2";
                        break;
                    case "D3":
                        targetVariable = "dinosaur3";
                        break;
                    default:
                        Console.WriteLine("This is not a valid selection.");
                        break;
                }
                return targetVariable;
            }
            else if (isAttackerRobot == false)
            {
                Console.WriteLine("Please choose your target (R1, R2, R3).");
                targetVariable = Console.ReadLine();
                switch (targetVariable)
                {
                    case "R1":
                        targetVariable = "robot1";
                        break;
                    case "R2":
                        targetVariable = "robot2";
                        break;
                    case "R3":
                        targetVariable = "robot3";
                        break;
                    default:
                        Console.WriteLine("This is not a valid selection.");
                        break;
                }
                return targetVariable;
            }
            else
            {
                return null;
            }
        }
    }
}
