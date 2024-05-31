using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Pelican : Bird
    {
        public double GularPouchVolume { get; set; } // Unik egenskap

        public Pelican(string name, double weight, int age, double wingSpan, double gularPouchVolume) : base(name, weight, age, wingSpan)
        {
            GularPouchVolume = gularPouchVolume;
        }

        public override string Stats() //override för Stats()
        {
            StringBuilder sb = new StringBuilder(base.Stats());
            sb.AppendLine($"The volume of gular pouch: {GularPouchVolume}");
            return sb.ToString();
        }
    }
}
