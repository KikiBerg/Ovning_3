namespace Ovning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Jag instansierar en PersonHandler:
                PersonHandler personHandler1 = new PersonHandler();

                // Jag instansierar en Person med giltiga värden direkt:
                Person person1 = new Person(37, "Johan", "Svensson", 1.87, 75);

                // Jag använder PersonHandler för att ändra åldern på person1:
                personHandler1.SetAge(person1, 45);
            }            
            catch (ArgumentException invalidInstance)
            {
                string error = invalidInstance.Message;
                Console.WriteLine($"Ett fel inträffade: {error}");
            }
        }
    }
}
