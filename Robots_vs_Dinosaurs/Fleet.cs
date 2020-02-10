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
        Weapon weapon2;
        Weapon weapon3;

        Robot robot1;
        Robot robot2;
        Robot robot3;

        // constructor
        public Fleet()
        {
            robot1 = new Robot("Knifebot", 100, 100, new Weapon("knife", 5));
            robot2 = new Robot("Sword-O-Matic", 100, 100, new Weapon("sword", 10));
            robot3 = new Robot("Lasertron", 100, 100, new Weapon("laser" , 20));
        }
        // member methods
        //string robotName, int robotHealth, int robotPowerLevel, int robotWeapon
        public void GetRobots()
        {
            Console.WriteLine("These are the robots:");
            //Console.WriteLine($"R1 weapon: {robot1.robotWeapon.weaponName} Attack Power: {robot1.robotWeapon.weaponAttackPower}");
            //Console.WriteLine($"R2 weapon: {robot2.robotWeapon.weaponName} Attack Power: {robot2.robotWeapon.weaponAttackPower}");
            //Console.WriteLine($"R3 weapon: {robot3.robotWeapon.weaponName} Attack Power: {robot3.robotWeapon.weaponAttackPower}");
            Console.WriteLine($"R1: {robot1.robotName} Health:{robot1.robotHealth} Energy:{robot1.robotPowerLevel} Weapon: {robot1.robotWeapon.weaponName} Attack Power: {robot1.robotWeapon.weaponAttackPower}");
            Console.WriteLine($"R2: {robot2.robotName} Health:{robot2.robotHealth} Energy:{robot2.robotPowerLevel} Weapon: {robot2.robotWeapon.weaponName} Attack Power: {robot2.robotWeapon.weaponAttackPower}");
            Console.WriteLine($"R3: {robot3.robotName} Health:{robot3.robotHealth} Energy:{robot3.robotPowerLevel} Weapon: {robot3.robotWeapon.weaponName} Attack Power: {robot3.robotWeapon.weaponAttackPower}");
            //Console.WriteLine($"R2: {robot2.robotName} Health:{robot2.robotHealth} Energy:{robot2.robotPowerLevel} Weapon:{robot2.robotWeapon}");
            //Console.WriteLine($"R3: {robot3.robotName} Health:{robot3.robotHealth} Energy:{robot3.robotPowerLevel} Weapon:{robot3.robotWeapon}");


            Console.ReadLine();
        }

    }
}
