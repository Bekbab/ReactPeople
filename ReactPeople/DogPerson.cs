using System;

namespace ReactPeople
{
    public class DogPerson : Person
    {
        public DogPerson()
        {
            preference = "dog";
            name = firstNames[generator.Next(3, 6)] + " " + lastNames[generator.Next(2, 4)];
            dogReaction = "Oh I love dogs! Who's a good boy?!";
            catReaction = "Ew I hate cats. Get away you butthole licking, carpet puking, creature!";
            wakeMessage = $"{name} the {preference} person entered existence!";
        }

    }
}