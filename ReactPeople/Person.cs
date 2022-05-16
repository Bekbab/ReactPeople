using System;
using System.Collections.Generic;

namespace ReactPeople
{
    public class Person
    {

        public string preference;

        protected string dogReaction;

        protected string catReaction;

        public string wakeMessage;

        protected List<string> firstNames = new List<string>()
        {
            "Brandon",
            "Carl",
            "Betty",
            "Tina",
            "Philip",
            "Margareth"
        };

        protected List<string> LastNames = new List<string>()
        {
            "Jones",
            "Smith",
            "Mc'Donald",
            "Carlsson"
        };

        public string name;

        protected Random generator = new Random();

        public virtual void React(string animal)
        {
            if (animal == "dog" || animal == "Dog")
            {
                Console.WriteLine($"{name} saw the {animal}.");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{name}:");
                Console.WriteLine($" {dogReaction}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (animal == "cat" || animal == "Cat")
            {
                Console.WriteLine($"{name} saw the {animal}.");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{name}:");
                Console.WriteLine($" {catReaction}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("That's not a cat or a dog.");
            }
        }


    }
}