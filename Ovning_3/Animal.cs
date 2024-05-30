using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public abstract class Animal
    {
        //Egenskaper som alla djur bör ha
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound(); // metod

        public Animal(string name, double weight, int age) // konstruktor
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }
}
