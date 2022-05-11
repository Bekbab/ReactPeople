using System;

namespace ReactPeople
{
    public class FishFishperson : DogPerson
    {
        public FishFishperson()
        {
            name = "Fish Fishperson";
            dogReaction = "*pleased bubbling*";
            catReaction = "*agitated bubbling*";
            wakeMessage = $"{name} the {preference} fishperson swam into existence!";
        }
        

        public override void React(string animal)
        {
            if (animal == "dog")
            {
                Console.WriteLine($"{name} swam up to the aquarium glass and noticed the {animal}.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {dogReaction}");
            }
            else if (animal == "cat")
            {
                Console.WriteLine($"{name} swam up to the aquarium glass and noticed the {animal}.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {catReaction}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Glub glub (try again)");
            }
        }
    }
}