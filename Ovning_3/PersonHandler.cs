using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class PersonHandler
    {
        public void SetAge (Person person, int age) 
        { 
            try { person.Age = age; } 
            catch (ArgumentException invalidInstance)
            {
                string error = invalidInstance.Message;
                Console.WriteLine($"Ett fel inträffade: {error}");
            }
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight) 
        {
            try 
            {
                Person person2 = new Person(age, fName, lName, height, weight);
                return person2;
            }
            catch(ArgumentException invalidInstance) 
            {
                string error = invalidInstance.Message;
                Console.WriteLine($"Ett fel inträffade: {error}");
                return null;
            }
        }

        public void SetFName(Person person, string fName)
        {
            try { person.FName = fName; }
            catch (ArgumentException invalidInstance)
            {
                string error = invalidInstance.Message;
                Console.WriteLine($"Ett fel inträffade: {error}");
            }
        }

        public void SetLName(Person person, string lName)
        {
            try { person.LName = lName; }
            catch (ArgumentException invalidInstance)
            {
                string error = invalidInstance.Message;
                Console.WriteLine($"Ett fel inträffade: {error}");
            }
        }

        public void SetHeight(Person person, double height)
        {
            try { person.Height = height; }
            catch (ArgumentException invalidInstance)
            {
                string error = invalidInstance.Message;
                Console.WriteLine($"Ett fel inträffade: {error}");
            }
        }

        public void SetWeight(Person person, double weight)
        {
            try { person.Weight = weight; }
            catch (ArgumentException invalidInstance)
            {
                string error = invalidInstance.Message;
                Console.WriteLine($"Ett fel inträffade: {error}");
            }
        }


    }
}
