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

        public virtual string Stats() // Metoden Stats() som kan överridas i subklasserna
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Weight: {Weight}");
            sb.AppendLine($"Age: {Age}");
            
            return sb.ToString();
        }


        public Animal(string name, double weight, int age) // konstruktor
        {
            Name = name;
            Weight = weight;
            Age = age;
        }


    }
}


/* Kunskapsfrågor
 * F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
 * Svar: Vi bör lägga det nya attributet i Bird-klassen för att det är därifrån alla fåglar ärver.
 * F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
 * Svar: Vi bör lägga det nya attributet i Animal-klassen för att samtliga djur ärver ifrån Animal.
 */