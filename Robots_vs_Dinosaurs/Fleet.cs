using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Fleet
    {
        // member variables
        public Weapon weapon2;
        public Weapon weapon3;

        //public Robot robot1;
        //public Robot robot2;
        //public Robot robot3;


        // Declare the List
        // Instantiate the List in the constructor
        // Add Robot data type to the existing robots in the constructor
        // Add the robots to the List

        public List<Robot> robots;

        // constructor
        public Fleet()
        {
            //Dinosaur dinosaur1 = new Dinosaur("Tyrannosaurus", 100, 100, 100);
            Robot robot1 = new Robot("Knifebot", 100, 100, new Weapon("knife", 20));
            Robot robot2 = new Robot("Sword-O-Matic", 100, 100, new Weapon("sword", 30));
            Robot robot3 = new Robot("Lasertron", 100, 100, new Weapon("laser" , 50));

            robots = new List<Robot>() { robot1, robot2, robot3 };
        }
        // member methods
        //string robotName, int robotHealth, int robotPowerLevel, int robotWeapon
        public void GetRobots()
        {
            Console.WriteLine("These are the robots:");
            //Console.WriteLine($"R1 weapon: {robot1.robotWeapon.weaponName} Attack Power: {robot1.robotWeapon.weaponAttackPower}");
            //Console.WriteLine($"R2 weapon: {robot2.robotWeapon.weaponName} Attack Power: {robot2.robotWeapon.weaponAttackPower}");
            //Console.WriteLine($"R3 weapon: {robot3.robotWeapon.weaponName} Attack Power: {robot3.robotWeapon.weaponAttackPower}");
            Console.WriteLine($"R1: {robots[0].robotName} Health:{robots[0].robotHealth} Energy:{robots[0].robotPowerLevel} Weapon: {robots[0].robotWeapon.weaponName} Attack Power: {robots[0].robotWeapon.weaponAttackPower}");
            Console.WriteLine($"R2: {robots[1].robotName} Health:{robots[1].robotHealth} Energy:{robots[1].robotPowerLevel} Weapon: {robots[1].robotWeapon.weaponName} Attack Power: {robots[1].robotWeapon.weaponAttackPower}");
            Console.WriteLine($"R3: {robots[2].robotName} Health:{robots[2].robotHealth} Energy:{robots[2].robotPowerLevel} Weapon: {robots[2].robotWeapon.weaponName} Attack Power: {robots[2].robotWeapon.weaponAttackPower}");
            //Console.WriteLine($"R2: {robot2.robotName} Health:{robot2.robotHealth} Energy:{robot2.robotPowerLevel} Weapon:{robot2.robotWeapon}");
            //Console.WriteLine($"R3: {robot3.robotName} Health:{robot3.robotHealth} Energy:{robot3.robotPowerLevel} Weapon:{robot3.robotWeapon}");


            //Console.ReadLine();
        }

    }
}
