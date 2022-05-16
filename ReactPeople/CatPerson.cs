using System;

namespace ReactPeople
{
    public class CatPerson : Person
    {
        public CatPerson()
        {
            preference = "cat";
            name = firstNames[generator.Next(3)] + " " + LastNames[generator.Next(2)];
            dogReaction = "Ew I hate dogs. Get away you dumb, smelly, floor shitting, mutt!";
            catReaction = "Oh I love cats! Come here kitty, kitty, kitty.";
            wakeMessage = $"{name} the {preference} person entered existence!";
        }


    }
}