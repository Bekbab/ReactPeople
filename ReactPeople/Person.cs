using System;
using System.Collections.Generic;

namespace ReactPeople
{
    public class Person
    {

        protected string preference;

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
            if (animal == "Dog")
            {
                Console.WriteLine($"{name} saw the {animal}.");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{dogReaction}");
            }
            else if (animal == "Cat")
            {
                Console.WriteLine($"{name} saw the {animal}.");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{name}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{catReaction}");
            }
            else
            {
                Console.WriteLine("That's not a cat or a dog.");
            }
        }


    }
}