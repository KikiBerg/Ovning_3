using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; } //unik egenskap

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override string Stats() //override för Stats()
        {
            StringBuilder sb = new StringBuilder(base.Stats());
            sb.AppendLine($"WingSpan: {WingSpan}");
            return sb.ToString();
        }
        public override void DoSound()
        {
            Console.WriteLine("Whistle");
        }
    }
}
