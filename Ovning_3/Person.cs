using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ovning_3
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Åldern ska vara större än 0.");
                age = value;
            }
        }

        public string FName
        {
            get { return fName; }
            set 
            {
                if (value.Length < 2 || value.Length > 10)
                    throw new ArgumentException("Förnamn måste vara mellan 2 och 10 tecken.");
                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set 
            {

            }
        }

        public double Height
        {
            get { return height; }
            set { }
        }

        public double Weight
        {
            get { return weight; }
            set { }
        }

    }

    

}
