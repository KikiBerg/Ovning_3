using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Flamingo : Bird
    {
        public int StandingLegCount { get; set; } // Unik egenskap

        public Flamingo(string name, double weight, int age, double wingSpan, int standingLegCount) : base(name, weight, age, wingSpan)
        {
            StandingLegCount = standingLegCount;
        }

        public override string Stats() //override för Stats()
        {
            StringBuilder sb = new StringBuilder(base.Stats());
            sb.AppendLine($"Does the pelican stand on one or two legs? {StandingLegCount}");
            return sb.ToString();
        }
    }
}
