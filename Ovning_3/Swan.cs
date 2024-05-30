using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Swan : Bird
    {
        public bool IsAggressive { get; set; } // Unik egenskap

        public Swan(string name, double weight, int age, double wingSpan, bool isAggressive) : base(name, weight, age, wingSpan)
        {
            IsAggressive = isAggressive;
        }
    }
}
