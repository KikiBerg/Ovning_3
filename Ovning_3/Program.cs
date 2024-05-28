namespace Ovning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person1 = new Person();
                person1.Age = 37;
                person1.FName = "Johan";
                person1.LName = "Svensson";
                person1.Height = 1.87;
                person1.Weight = 75;

                //Kommentar om att det inte går att komma åt variablerna pga de är privata...???

            }
            
            catch 
            { 

            }
        }
    }
}
