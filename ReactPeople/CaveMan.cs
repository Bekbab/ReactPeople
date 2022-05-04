using System;

namespace ReactPeople
{
    public class CaveMan : Person
    {

        public CaveMan()
        {
            preference = "dog";
            name = firstNames[generator.Next(4)] + LastNames[generator.Next(3)];
            dogReaction = "Ew I hate dogs. Get away you dumb, smelly, floor shitting, mutt!";
            catReaction = "Oh I love cats! Come here kitty, kitty, kitty.";
            wakeMessage = $"{name} the {preference} person entered existence!";
        }
    }
}