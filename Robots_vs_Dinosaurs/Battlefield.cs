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
                robotAttack();
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
        public void robotAttack()
        {
            Console.WriteLine($"{theFleet.robots[0].robotName}  attacks {theHerd.dinosaurs[0].dinoType}");

            Console.WriteLine($"{theFleet.robots[0].robotName} Attack Power: {theFleet.robots[0].robotWeapon.weaponAttackPower}");
            Console.WriteLine($"{theHerd.dinosaurs[0].dinoType} Attack Power: {theHerd.dinosaurs[0].dinoAttackPower}");
            if (theFleet.robots[0].robotWeapon.weaponAttackPower < theHerd.dinosaurs[0].dinoAttackPower)
            {
                Console.WriteLine($"{theFleet.robots[0].robotName} loses!");
                theFleet.robots[0].robotHealth = (theFleet.robots[0].robotHealth - theHerd.dinosaurs[0].dinoAttackPower);

                }
            Console.WriteLine($"{theFleet.robots[0].robotHealth}");

            //if (attackerVariable.ToString == "robot1" || "robot2" || "robot3")
            //{
            //    Console.WriteLine("test");
            //    //Console.WriteLine($"R1: {robots[0].robotName} Health:{robots[0].robotHealth} Energy:{robots[0].robotPowerLevel} Weapon: {robots[0].robotWeapon.weaponName} Attack Power: {robots[0].robotWeapon.weaponAttackPower}");
            //}
            //else
            //{

            //}
        }
        public void dinoAttack()
        {
            Console.WriteLine("Dinosaur Attack");
            Console.WriteLine(attackerVariable + " vs. " + targetVariable);

            Console.WriteLine($"{theFleet.robots[0].robotName} Attack Power: {theFleet.robots[0].robotWeapon.weaponAttackPower}");
            Console.WriteLine($"{theHerd.dinosaurs[0].dinoType} Attack Power: {theHerd.dinosaurs[0].dinoAttackPower}");

            //if (attackerVariable.ToString == "robot1" || "robot2" || "robot3")
            //{
            //    Console.WriteLine("test");
            //    //Console.WriteLine($"R1: {robots[0].robotName} Health:{robots[0].robotHealth} Energy:{robots[0].robotPowerLevel} Weapon: {robots[0].robotWeapon.weaponName} Attack Power: {robots[0].robotWeapon.weaponAttackPower}");
            //}
            //else
            //{

            //}
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
