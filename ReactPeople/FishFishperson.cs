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
            if (animal == "dog" || animal == "Dog")
            {
                Console.WriteLine($"{name} swam up to the aquarium glass and noticed the {animal}.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{name}:");
                Console.WriteLine($" {dogReaction}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (animal == "cat" || animal == "Cat")
            {
                Console.WriteLine($"{name} swam up to the aquarium glass and noticed the {animal}.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{name}:");
                Console.WriteLine($" {catReaction}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{name}:");
                Console.WriteLine(" Glub glub (try again)");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}