namespace Ovning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Jag instansierar en Person med giltiga värden direkt:
                Person person1 = new Person(37, "Johan", "Svensson", 1.87, 75);
            }            
            catch (ArgumentException invalidInstance)
            {
                string error = invalidInstance.Message;
                Console.WriteLine($"Ett fel inträffade: {error}");
            }
        }
    }
}
