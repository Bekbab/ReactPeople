using System;

namespace ReactPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            ReactionWizard wiz = new ReactionWizard();
            bool gameIsRunning = true;

            Console.WriteLine("Welcome to React People!");
            Console.WriteLine("A super simple game where you introduce people to cats and dogs.");
            Console.WriteLine("Press enter to start.");
            Console.ReadLine();

            while (gameIsRunning)
            {
                wiz.Update();
            }
        }
    }
}
