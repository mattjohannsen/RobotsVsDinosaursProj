using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Robot
    {
        //member variables
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public int robotWeapon;

        // constructor SPAWNER
        public Robot(string robotName, int robotHealth, int robotPowerLevel, int robotWeapon)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotWeapon = robotWeapon;

        }
        Weapon weapon1 = new Weapon("Buzz Saw", 30);
        Weapon weapon2 = new Weapon("Electroshock Probe", 5);
        Weapon weapon3 = new Weapon("Laser", 10);

        // member methods
    }
}
