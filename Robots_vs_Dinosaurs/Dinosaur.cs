﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Dinosaur
    {
        //member variables
        public string dinoType;
        public int dinoHealth;
        public int  dinoEnergy;
        public int dinoAttackPower;
        public bool isdinoAlive;

        //constructor SPAWNER
        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, int dinoAttackPower, bool dinoAlive)
        {
            this.dinoType = dinoType;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;
            this.isdinoAlive = isdinoAlive;
            //this.dinoAlive = dinoAlive;

        }


        // member methods
        void ShowDinosaur()
        {
            Console.WriteLine("These are the dinosaurs.");
        }


    }
}
