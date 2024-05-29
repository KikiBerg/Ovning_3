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
                    throw new ArgumentException("Förnamn måste vara mellan 2 och 10 tecken.");
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
                    throw new ArgumentException("Efternamn måste vara mellan 3 och 15 tecken.");
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
