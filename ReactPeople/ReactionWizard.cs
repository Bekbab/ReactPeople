using System;
using System.Collections.Generic;
namespace ReactPeople
{
    public class ReactionWizard
    {
        Random wizGen = new Random();

        int personID;

        bool isPersonSpawned;

        string doString;

        bool choosing;

        List<Person> people = new List<Person>();

        public ReactionWizard()
        {
            for (int i = 0; i < 35; i++)
            {
                people.Add(new CatPerson());
            }
            for (int i = 0; i < 35; i++)
            {
                people.Add(new DogPerson());
            }
            for (int i = 0; i < 15; i++)
            {
                people.Add(new FishFishperson());
            }
            for (int i = 0; i < 10; i++)
            {
                people.Add(new CaveMan());
            }
            for (int i = 0; i < 5; i++)
            {
                people.Add(new TaxidermyMan());
            }
        }

        public void PickPerson()
        {
            personID = wizGen.Next(1, 101);
            isPersonSpawned = true;
            Console.WriteLine(people[personID].wakeMessage);

        }
        public void PickSpecific()
        {
            Console.WriteLine("Press enter to see your options, then type the number of the person you want to pick.");
            Console.ReadLine();
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{i}: {people[i].name}, Preference: {people[i].preference}");
            }
            //lös av
        }


        public void ResetList()
        {
            people.Clear();

            for (int i = 0; i < 35; i++)
            {
                people.Add(new CatPerson());
            }
            for (int i = 0; i < 35; i++)
            {
                people.Add(new DogPerson());
            }
            for (int i = 0; i < 15; i++)
            {
                people.Add(new FishFishperson());
            }
            for (int i = 0; i < 10; i++)
            {
                people.Add(new CaveMan());
            }
            for (int i = 0; i < 5; i++)
            {
                people.Add(new TaxidermyMan());
            }
            Console.WriteLine("You reset the list.");
        }

        public void Choose()
        {

            if (choosing == true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("S: Pick a random character");
                Console.WriteLine("R: Reset the character list");
                Console.WriteLine("SP: Pick a specific character");
                doString = Console.ReadLine();
                choosing = false;
            }

            if (doString == "S" || doString == "s")
            {
                PickPerson();
            }
            else if (doString == "R" || doString == "r")
            {
                ResetList();
                choosing = true;
            }
            else if (doString == "SP" || doString == "sp")
            {
                PickSpecific();
            }
            else
            {
                Console.WriteLine("Something went wrong, try again.");
                choosing = true;
            }
        }

        public void Introduce()
        {
            Console.WriteLine("Introduce ")
        }


    }
}