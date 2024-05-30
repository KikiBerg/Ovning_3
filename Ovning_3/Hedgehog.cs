using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; } //unik egenskap

        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Grunting");
        }
    }
}
