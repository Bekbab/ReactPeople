using System;

namespace ReactPeople
{
    public class DogPerson : Person
    {
        public DogPerson()
        {
            preference = "dog";
            name = firstNames[generator.Next(4, 7)] + LastNames[generator.Next(3, 5)];
            dogReaction = "Oh I love dogs! Who's a good boy?!";
            catReaction = "Ew I hate cats. Get away you butthole licking, carpet puking, creature!";
            wakeMessage = $"{name} the {preference} person entered existence!";
        }

    }
}