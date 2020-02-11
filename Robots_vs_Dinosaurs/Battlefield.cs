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
        public bool continueGame;



        //constructor
        public Battlefield()
        {
            theHerd = new Herd();
            theFleet = new Fleet();
        }

        //methods
        public void StartBattle()
        {
            //Console.WriteLine("Press ENTER to begin battle!");
            //Console.ReadLine();
            continueGame = true;

            do
            {
                theHerd.GetDinosaurs();
                theFleet.GetRobots();
                Console.WriteLine(ChooseAttacker());
                Console.WriteLine(ChooseTarget());
                if (isAttackerRobot == true)
                {
                    RobotAttack(attackerVariable, targetVariable);
                    continueGame = IsGameOver(continueGame);
                }
                else if (isAttackerRobot == false)
                {
                    DinoAttack(attackerVariable, targetVariable);
                    continueGame = IsGameOver(continueGame);
                }
                else
                {

                }

            }
            while (continueGame == true);
 
            //Console.WriteLine($"{chosenAttacker} vs {chosenTarget}");
            Console.ReadLine();
        }

        public bool IsGameOver(bool continueGame)
        {
            //Console.WriteLine($"Continue GAme: {continueGame}");
            if ((theHerd.dinosaurs[0].dinoHealth <= 0))
            //if ((theHerd.dinosaurs[0].dinoHealth <= 0) && (theHerd.dinosaurs[0].dinoHealth <= 0) && (theHerd.dinosaurs[0].dinoHealth <= 0))
            {
                //Console.WriteLine($"D1 is dead. Continue game : {continueGame}");
                if ((theHerd.dinosaurs[1].dinoHealth <= 0))
                {
                    //Console.WriteLine($"D2 is dead. Continue game : {continueGame}");
                    if ((theHerd.dinosaurs[2].dinoHealth <= 0))
                    {
                        continueGame = false;
                        //Console.WriteLine($"All dinosaurs are dead. GAME OVER: {continueGame}");
                        Console.WriteLine($"All dinosaurs are dead. GAME OVER");
                    }
                }
            }
            if ((theFleet.robots[0].robotHealth <= 0))
            //if ((theHerd.dinosaurs[0].dinoHealth <= 0) && (theHerd.dinosaurs[0].dinoHealth <= 0) && (theHerd.dinosaurs[0].dinoHealth <= 0))
            {
                //Console.WriteLine($"D1 is dead. Continue game : {continueGame}");
                if ((theFleet.robots[1].robotHealth <= 0))
                {
                    //Console.WriteLine($"D2 is dead. Continue game : {continueGame}");
                    if ((theFleet.robots[2].robotHealth <= 0))
                    {
                        continueGame = false;
                        Console.WriteLine($"All robots are dead. GAME OVER");
                        //Console.WriteLine($"All robots are dead. GAME OVER: {continueGame}");
                    }
                }
            }
            return continueGame;
            //if ((theFleet.robots[0].robotHealth <= 0) && (theFleet.robots[1].robotHealth <= 0) && (theFleet.robots[2].robotHealth<= 0))
            //{
            //    continueGame = false;
            //}
        }

        public void RobotAttack(string attackerVariable, string targetVariable)
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
            // Robot fights Dinosaur and loses. robotHealth is decreased by dinoAttackPower
            if (theFleet.robots[attackerIndex].robotWeapon.weaponAttackPower < theHerd.dinosaurs[targetIndex].dinoAttackPower)
                {
                Console.WriteLine($"{theFleet.robots[attackerIndex].robotName} loses!");
                theFleet.robots[attackerIndex].robotHealth = (theFleet.robots[attackerIndex].robotHealth - theHerd.dinosaurs[targetIndex].dinoAttackPower);
                Console.WriteLine($"{theFleet.robots[attackerIndex].robotHealth}");
                }
            // Robot fights Dinosaur and wins.  dinoHealth is decreased by weaponAttackPower
            else if (theFleet.robots[attackerIndex].robotWeapon.weaponAttackPower > theHerd.dinosaurs[targetIndex].dinoAttackPower)
            {
                Console.WriteLine($"{theFleet.robots[attackerIndex].robotName} wins!");
                //Console.WriteLine( $"|{theHerd.dinosaurs[targetIndex].dinoHealth}|");
                //Console.WriteLine($"{theHerd.dinosaurs[targetIndex].dinoHealth} - {theFleet.robots[attackerIndex].robotWeapon.weaponAttackPower}");
                
                theHerd.dinosaurs[targetIndex].dinoHealth = (theHerd.dinosaurs[targetIndex].dinoHealth) - (theFleet.robots[attackerIndex].robotWeapon.weaponAttackPower);
                //Console.WriteLine($"|{theHerd.dinosaurs[targetIndex].dinoHealth}|");
                if (theHerd.dinosaurs[targetIndex].dinoHealth <= 0)
                {
                    theHerd.dinosaurs[targetIndex].isdinoAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Tie!");
            }
           //Console.WriteLine($"{theFleet.robots[attackerIndex].robotHealth}");
        }
        //public void DinoAttack()
        //{
        //    //This is the old dinoAttack method code


        //    //Console.WriteLine("Dinosaur Attack");
        //    //Console.WriteLine(attackerVariable + " vs. " + targetVariable);

        //    //Console.WriteLine($"{theFleet.robots[0].robotName} Attack Power: {theFleet.robots[0].robotWeapon.weaponAttackPower}");
        //    //Console.WriteLine($"{theHerd.dinosaurs[0].dinoType} Attack Power: {theHerd.dinosaurs[0].dinoAttackPower}");

        //}
        public void DinoAttack(string attackerVariable, string targetVariable)
        {
            //Start of the attacker Index Code
            int attackerIndex;
            attackerIndex = 0;

            if (attackerVariable == "dinosaur1")
            {
                attackerIndex = 0;
            }
            if (attackerVariable == "dinosaur2")
            {
                attackerIndex = 1;
            }
            if (attackerVariable == "dinosaur3")
            {
                attackerIndex = 2;
            }

            //Start of the target Index Code
            int targetIndex;
            targetIndex = 0;

            if (targetVariable == "robot1")
            {
                targetIndex = 0;
            }
            if (targetVariable == "robot2")
            {
                targetIndex = 1;
            }
            if (targetVariable == "robot3")
            {
                targetIndex = 2;
            }
            Console.WriteLine($"{attackerVariable} vs {targetVariable}");
            Console.WriteLine($"{theHerd.dinosaurs[attackerIndex].dinoType} attacks {theFleet.robots[targetIndex].robotName}");
            Console.WriteLine($"{theHerd.dinosaurs[attackerIndex].dinoType} Attack Power: {theHerd.dinosaurs[attackerIndex].dinoAttackPower}");
            Console.WriteLine($"{theFleet.robots[targetIndex].robotName} Attack Power: {theFleet.robots[targetIndex].robotWeapon.weaponAttackPower}");
            // Dinosaur fights Robot and loses. dinsosaur Health is decreased by weaponAttackPower
            if (theHerd.dinosaurs[attackerIndex].dinoAttackPower  < theFleet.robots[targetIndex].robotWeapon.weaponAttackPower)
            {
                Console.WriteLine($"{theHerd.dinosaurs[attackerIndex].dinoType}  loses!");
                theHerd.dinosaurs[attackerIndex].dinoHealth = (theHerd.dinosaurs[attackerIndex].dinoHealth - theFleet.robots[targetIndex].robotWeapon.weaponAttackPower);
                Console.WriteLine($"{theHerd.dinosaurs[attackerIndex].dinoHealth}");
            }
            // Dinosaur fights Robot and wins.  Robot Health is decreased by dinoAttackPower
            else if (theHerd.dinosaurs[attackerIndex].dinoAttackPower > theFleet.robots[targetIndex].robotWeapon.weaponAttackPower)
            {
                Console.WriteLine($"{theHerd.dinosaurs[attackerIndex].dinoType}  wins!");
                //Console.WriteLine($"|{theHerd.dinosaurs[attackerIndex].dinoHealth}|");
                //Console.WriteLine($"{theHerd.dinosaurs[attackerIndex].dinoHealth} - {theFleet.robots[targetIndex].robotWeapon.weaponAttackPower}");

                theFleet.robots[targetIndex].robotHealth = theFleet.robots[targetIndex].robotHealth - (theHerd.dinosaurs[attackerIndex].dinoAttackPower);
                //Console.WriteLine($"|{theHerd.dinosaurs[attackerIndex].dinoHealth}|");
                if (theFleet.robots[targetIndex].robotHealth <= 0)
                {
                    theFleet.robots[targetIndex].isRobotAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Tie!");
            }
            //Console.WriteLine($"{theFleet.robots[attackerIndex].robotHealth}");
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
