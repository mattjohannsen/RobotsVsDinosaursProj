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
        public Weapon robotWeapon;

        // constructor SPAWNER
        public Robot(string robotName, int robotHealth, int robotPowerLevel, Weapon weaponName)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotWeapon = weaponName;

        }


        // member methods

        public void GetWeaponType(string robotName)
        {
            //If robotWeapon = weaponName then robot inherits the weaponAttackPower of that weapon
        }
    }
}
