﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Horse : Animal
    {
        public double Speed { get; set; } //unik egenskap

        public Horse(string name, double weight, int age, double speed) : base(name, weight, age) 
        { 
            Speed = speed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Neighing");
        }
    }
}
