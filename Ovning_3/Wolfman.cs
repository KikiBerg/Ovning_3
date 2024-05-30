using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, string packLeader) : base(name, weight, age, packLeader)
        {
        }

        public void Talk() 
        {
            Console.WriteLine("I am a Wolfman!");
        }

    }
}
