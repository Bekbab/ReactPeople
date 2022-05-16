using System;

namespace ReactPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            ReactionWizard wiz = new ReactionWizard();
            bool gameIsRunning = true;

            while (gameIsRunning)
            {
                wiz.Update();
            }
        }
    }
}
