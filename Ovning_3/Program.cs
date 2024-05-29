namespace Ovning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Iom att hanteringen av ArgumentException flyttades 
             * till metoderna i PersonHandler
             * så använder jag if-satser istället för att 
             * kontrollera om CreatePerson metoden returnerar 
             * en giltig Person-instans.
             */

            // Här kommenterar jag bort den tidigare instansen av Person:
            //try
            //{
            //    // Jag instansierar en PersonHandler:
            //    PersonHandler personHandler1 = new PersonHandler();                

            //    // Jag instansierar en Person med giltiga värden direkt:        
            //    // Person person1 = new Person(37, "Johan", "Svensson", 1.87, 75);

            //    // Jag använder PersonHandler för att ändra åldern på person1:            
            //    // personHandler1.SetAge(person1, 45);
            //}
            //catch (ArgumentException invalidInstance)
            //{
            //    string error = invalidInstance.Message;
            //    Console.WriteLine($"Ett fel inträffade: {error}");
            //}

            
            // Jag instansierar en PersonHandler:
            PersonHandler personHandler1 = new PersonHandler();

            // Här skapar jag en ny Person instans:
            Person person1 = personHandler1.CreatePerson(37, "Johan", "Svensson", 1.87, 75);
            if (person1 != null) 
            {
                Console.WriteLine($"En ny person skapats: {person1.FName} {person1.LName} {person1.Age} år gammal, {person1.Height} m lång {person1.Weight} kg");

                // Här ändrar jag egenskaper för person1:
                personHandler1.SetAge(person1, 45);
                personHandler1.SetFName(person1, "Katinka");
                personHandler1.SetHeight(person1, 1.75);

                Console.WriteLine($"Uppdaterade personuppgifter: {person1.FName} {person1.LName} {person1.Age} år gammal, {person1.Height} m lång {person1.Weight} kg");
            }

            // Här skapar jag ytterligare en ny Person instans:
            Person person2 = personHandler1.CreatePerson(67, "Amanda", "Bergman", 1.70, 65);
            if (person2 != null) 
            {
                Console.WriteLine($"En ny person skapats: {person2.FName} {person2.LName} {person2.Age} år gammal, {person2.Height} m lång {person2.Weight} kg");
                // Här ändrar jag egenskaper för person2:
                personHandler1.SetAge(person2, 23);
                personHandler1.SetFName(person2, "Kalle");
                personHandler1.SetWeight(person2, 450); // Försöker framkalla fel här

                Console.WriteLine($"Uppdaterade personuppgifter: {person2.FName} {person2.LName} {person2.Age} år gammal, {person2.Height} m lång {person2.Weight} kg");
            }

        }
    }
}
