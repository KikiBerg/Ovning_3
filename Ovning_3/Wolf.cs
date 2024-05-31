using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Wolf : Animal
    {
        public string PackLeader { get; set; } //unik egenskap

        public Wolf(string name, double weight, int age, string packLeader) : base(name, weight, age)
        {
            PackLeader = packLeader;
        }

        public override string Stats() //override för Stats()
        {
            StringBuilder sb = new StringBuilder(base.Stats());
            sb.AppendLine($"PackLeader: {PackLeader}");
            return sb.ToString();
        }
        public override void DoSound()
        {
            Console.WriteLine("Howling");
        }
    }
}
