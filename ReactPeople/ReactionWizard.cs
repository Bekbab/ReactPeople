using System;
using System.Collections.Generic;
namespace ReactPeople
{
    public class ReactionWizard
    {
        Random wizGen = new Random();

        int personID;

        string pickedID;

        bool isPersonPicked;

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

            choosing = true;
        }

        public void PickPerson()
        {
            personID = wizGen.Next(0, 100);
            isPersonPicked = true;
            Console.WriteLine("You successfully picked this person:");
            Console.WriteLine($"ID: {personID}, Name: {people[personID].name}, Preference: {people[personID].preference}");
            Console.WriteLine(people[personID].wakeMessage);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }
        public void PickSpecific()
        {
            Console.WriteLine("Press enter to see your options, then type the ID of the person you want to pick.");
            Console.ReadLine();
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"ID:{i}, Name:{people[i].name}, Preference: {people[i].preference}");
            }
            Console.WriteLine("Type your persons ID.");
            pickedID = Console.ReadLine();
            bool isNumeric = int.TryParse(pickedID, out personID);

            if (isNumeric && (0 <= personID && personID <= 99))
            {
                Console.WriteLine("You successfully picked this person:");
                Console.WriteLine($"ID: {personID}, Name: {people[personID].name}, Preference: {people[personID].preference}");
                Console.WriteLine(people[personID].wakeMessage);
                isPersonPicked = true;
            }
            else
            {
                Console.WriteLine("Something went wrong, try again.");
                choosing = true;
            }

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

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

            isPersonPicked = false;
            Console.WriteLine("You reset the list.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        public void FirstChoice()
        {
            if (choosing)
            {
                isPersonPicked = false;
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
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                choosing = true;
            }
        }
        public void SecondChoice()
        {
            if (choosing)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("I: Inroduce your person to an animal.");
                Console.WriteLine("R: Reset the character list.");
                Console.WriteLine("RP: Reset your choice of person.");
                doString = Console.ReadLine();
                choosing = false;
            }

            if (doString == "I" || doString == "i")
            {
                Introduce();
                choosing = true;
            }
            else if (doString == "R" || doString == "r")
            {
                ResetList();
                choosing = false;
            }
            else if (doString == "RP" || doString == "rp")
            {
                isPersonPicked = false;
                choosing = false;
                Console.WriteLine("You reset your choice of person.");
            }
            else
            {
                Console.WriteLine("Something went wrong, try again.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                choosing = true;
            }
        }

        public void Introduce()
        {
            Console.WriteLine($"Introduce {people[personID].name} to an animal.");
            Console.WriteLine("Cat or dog?");
            people[personID].React(Console.ReadLine());
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        public void Update()
        {
            if (isPersonPicked)
            {
                choosing = true;
                SecondChoice();
            }
            else if (!isPersonPicked)
            {
                choosing = true;
                FirstChoice();
            }
        }


    }
}