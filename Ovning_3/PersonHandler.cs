using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class PersonHandler
    {
        public void SetAge (Person pers, int age) 
        { 
            try { pers.Age = age; } 
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



    }
}
