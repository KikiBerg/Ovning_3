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
        private string fName = null!;
        private string lName = null!;
        private double height;
        private double weight;

        //Jag skapade en konstruktor för att initiera objektet med giltiga värden
        public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FName = fName; 
            LName = lName; 
            Height = height;
            Weight = weight;
        }

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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Förnamn är obligatoriskt.");
                if (value.Length < 2 || value.Length > 10)
                    throw new ArgumentException("Förnamn skall vara mellan 2 och 10 tecken.");
                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Efternamn är obligatoriskt.");
                if (value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("Efternamn skall vara mellan 3 och 15 tecken.");
            }
        }

        public double Height
        {
            get { return height; }
            set 
            {
                // Jag vill validera att height är inom rimliga gränser, t.ex. mellan 50 och 250 cm
                if (value < 50 || value > 250)
                    throw new ArgumentException("Längden skall vara mellan 50 och 250 cm.");
                height = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set 
            {
                // Jag vill validera att weight är större än 0 och inom rimliga gränser, t.ex. max 300 kg
                if (value <= 0 || value > 400)
                    throw new ArgumentException("Vikten måste vara större än 0 och mindre än 400 kg.");
                weight = value;
            }
        }

    }

    

}
