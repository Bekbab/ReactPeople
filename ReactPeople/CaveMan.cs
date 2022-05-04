using System;

namespace ReactPeople
{
    public class CaveMan : Person
    {

        public CaveMan()
        {
            name = "Gronk";
            preference = "dog";
            name = firstNames[generator.Next(4)] + LastNames[generator.Next(3)];
            dogReaction = "Ooga booga(Hmm... Gronk like this creature, make nice coat for winter!";
            catReaction = "Ooga booga(Hmm... This creature no meat, Gronk not like.)";
            wakeMessage = $"{name} the {preference} person ooged and booged into existence!";
        }
        public override void React(string animal)
        {
            if (animal == "dog")
            {
                Console.WriteLine($"{name} walked up to the {animal} scrathing his beard.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {dogReaction}");
            }
            else if (animal == "cat")
            {
                Console.WriteLine($"{name} walked up to the {animal} scrathing his beard.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {catReaction}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Gronk not understand...");
            }
        }
    }
}