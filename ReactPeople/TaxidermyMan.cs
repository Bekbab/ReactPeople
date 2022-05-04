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
            if (animal == "dog")
            {
                Console.WriteLine($"{name} noticed the {animal} and took on his 'work gloves'.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {dogReaction}");
            }
            else if (animal == "cat")
            {
                Console.WriteLine($"{name} noticed the {animal} and took on his 'work gloves'.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" {catReaction}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" That animal is too exotic, even for me.");
            }
        }
    }
}