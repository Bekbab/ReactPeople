using System;

namespace ReactPeople
{
    public class CaveMan : Person
    {

        public CaveMan()
        {
            name = "Gronk";
            preference = "dog";
            name = firstNames[generator.Next(4)] + LastNames[generator.Next(3)];
            dogReaction = "Ooga booga(Gronk like this creature, make nice coat for winter!";
            catReaction = "Ooga booga(This creature no meat, Gronk not like.)";
            wakeMessage = $"{name} the {preference} person ooged and booged into existence!";
        }
    }
}