using System;

namespace ReactPeople
{
    public class CaveMan : Person
    {

        public CaveMan()
        {
            name = "Gronk";
            preference = "dog";
            dogReaction = "Ooga booga (Hmm... Gronk like this creature, make nice coat for winter!)";
            catReaction = "Ooga booga (Hmm... This creature no meat, Gronk not like.)";
            wakeMessage = $"{name} the {preference} person ooged and booged into existence!";
        }
        public override void React(string animal)
        {
            if (animal == "dog" || animal == "Dog")
            {
                Console.WriteLine($"{name} walked up to the {animal} scrathing his beard.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{name}:");
                Console.WriteLine($" {dogReaction}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (animal == "cat" || animal == "Cat")
            {
                Console.WriteLine($"{name} walked up to the {animal} scrathing his beard.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{name}:");
                Console.WriteLine($" {catReaction}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{name}:");
                Console.WriteLine(" Gronk not understand...");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}