using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; } //unik egenskap

        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override string Stats() //override för Stats()
        {
            StringBuilder sb = new StringBuilder(base.Stats());
            sb.AppendLine($"IsPoisonous: {IsPoisonous}");
            return sb.ToString();
        }
        public override void DoSound()
        {
            Console.WriteLine("...");
        }
    }
}
