using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Dog : Animal
    {
        public bool IsTrained { get; set; } //unik egenskap

        public Dog(string name, double weight, int age, bool isTrained) : base(name, weight, age)
        {
            IsTrained = isTrained;
        }

        public override string Stats() //override för Stats()
        {
            StringBuilder sb = new StringBuilder(base.Stats());
            sb.AppendLine($"Is the dog trained: {IsTrained}");
            return sb.ToString();
        }

        public override void DoSound()
        {
            Console.WriteLine("Barking");
        }
    }
}
