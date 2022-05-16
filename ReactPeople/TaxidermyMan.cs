using System;

namespace ReactPeople
{
    public class TaxidermyMan : Person
    {
        public TaxidermyMan()
        {
            name = "The Taxidermy Man";
            preference = "taxidermy";
            dogReaction = "Oh a dog, what a fine specimen for my collection.";
            catReaction = "Oh a cat, it would look great in my living room.";
            wakeMessage = $"{name} tore the fabric of reality and sewed it into a coat.";
        }
        public override void React(string animal)
        {
            if (animal == "dog" || animal == "Dog")
            {
                Console.WriteLine($"{name} noticed the {animal} and took on his 'work gloves'.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{name}:");
                Console.WriteLine($" {dogReaction}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (animal == "cat" || animal == "Cat")
            {
                Console.WriteLine($"{name} noticed the {animal} and took on his 'work gloves'.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{name}:");
                Console.WriteLine($" {catReaction}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{name}:");
                Console.WriteLine(" That animal is too exotic, even for me.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}