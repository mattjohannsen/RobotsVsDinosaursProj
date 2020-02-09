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




        // constructor
        Robot robot1 = new Robot("R2D2", 100, 100, 1);
        Robot robot2 = new Robot("Buzzbot", 100, 100, 2);
        Robot robot3 = new Robot("Lasertron", 100, 100, 3);



        // member methods
        //string robotName, int robotHealth, int robotPowerLevel, int robotWeapon
        public void GetRobots()
        {
            Console.WriteLine("These are the robots:");
            //Console.WriteLine(dinosaur1.dinoType);
            Console.WriteLine($"R1: {robot1.robotName} Health:{robot1.robotHealth} Energy:{robot1.robotPowerLevel} Weapon:{robot1.robotWeapon}");
            Console.WriteLine($"R2: {robot2.robotName} Health:{robot2.robotHealth} Energy:{robot2.robotPowerLevel} Weapon:{robot2.robotWeapon}");
            Console.WriteLine($"R3: {robot3.robotName} Health:{robot3.robotHealth} Energy:{robot3.robotPowerLevel} Weapon:{robot3.robotWeapon}");
            //Console.WriteLine($"R2: {robot2.robotName} Health:{robot2.robotHealth} Energy:{robot2.robotPowerLevel} Weapon:{robot2.robotWeapon}");
            //Console.WriteLine($"R3: {robot3.robotName} Health:{robot3.robotHealth} Energy:{robot3.robotPowerLevel} Weapon:{robot3.robotWeapon}");


            Console.ReadLine();
        }

    }
}
