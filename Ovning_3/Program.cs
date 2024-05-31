namespace Ovning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1();
            //Task2();
            //Task3();

        }

        private static void Task3() 
        { 
            List<Animal> animals = new List<Animal>();
            
            animals.Add(new Horse ("Thunder", 500, 5, 60));
            animals.Add(new Dog("Rex", 30, 3, true));
            animals.Add(new Hedgehog("Spike", 1, 2, 5000));
            animals.Add(new Worm("Wormie", 0.1, 1, false));
            animals.Add(new Bird("Tweety", 0.5, 1, 0.5));
            animals.Add(new Wolf("Alpha", 70, 4, "Alpha"));

            foreach (Animal animal in animals) 
            { 
                Console.WriteLine($"Animal: {animal.GetType().Name}");
                animal.DoSound();

                if (animal is IPerson person) 
                { 
                    person.Talk();
                }                
            }
            
            // Försöker lägga till en häst i hundlistan
            //List<Dog> dogs = new List<Dog>();
            
            //Horse horse = new Horse("Thunder", 500, 5, 60);
            //dogs.Add(horse);
            /*
             * F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
             * Svar: Det går inte att lägga till en häst i en lista av hundar eftersom en häst inte är en hund.
             * Listan är typspecifik och kan endast innehålla objekt av typen Dog eller dess subklasser.
             * 
             * F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
             * Svar: För att alla djurklasser ska kunna lagras tillsammans i en lista, måste listan vara av typen List<Animal>.
             * Eftersom alla djurklasser ärver från Animal, kan en List<Animal> innehålla objekt av alla djurklasser.
             * 
             */

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            /* Kunskapsfrågor
             * F: Skriv ut samtliga Animals Stats() genom en foreach loop.
             * Testa och se så det fungerar.
             * Förklara vad det är som händer.
             * Svar: När vi skriver ut animal.Stats() i foreach-loopen, anropas den överridna versionen av Stats()-metoden
             * för respektive djurklass. 
             */

            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
            }

            foreach (Animal animal in animals)
            {
                if (animal is Dog dog) // kontrollerar om animal-objektet är en instans av Dog-klassen
                {
                    Console.WriteLine(dog.GetDogInfo());
                }
            }


        }

        private static void Task2() 
        {
            List<UserError> errors = new List<UserError>
            {
                new NumericInputError(), 
                new TextInputError()
            };

            // Skriver ut samtliga UserErrors UEMessage() genom en foreach loop
            foreach (var error in errors) 
            {
                Console.WriteLine(error.UEMessage());
            }

            // Skapa tre egna klasser med tre egna definitioner på UEMessage()
            errors.Add(new CustomError1());
            errors.Add(new CustomError2());
            errors.Add(new CustomError3());

            // Skriver ut meddelandena från de nya klasserna
            foreach (var error in errors) 
            { 
                Console.WriteLine(error.UEMessage());
            }
        }

        private static void Task1()
        {
            /* Iom att hanteringen av ArgumentException flyttades 
             * till metoderna i PersonHandler
             * så använder jag if-satser istället, för att 
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
                personHandler1.SetWeight(person2, 80);

                Console.WriteLine($"Uppdaterade personuppgifter: {person2.FName} {person2.LName} {person2.Age} år gammal, {person2.Height} m lång {person2.Weight} kg");
            }
        }
    }
}
