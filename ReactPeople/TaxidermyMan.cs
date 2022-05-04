using System;

namespace ReactPeople
{
    public class TaxidermyMan : Person
    {
        public TaxidermyMan()
        {
            name = "The Taxidermy Man";
            preference = "taxidermy";
            dogReaction = "Ew I hate dogs. Get away you dumb, smelly, floor shitting, mutt!";
            catReaction = "Oh I love cats! Come here kitty, kitty, kitty.";
            wakeMessage = $"{name} the {preference} person tore the fabric of spacetime and sewed it into a coat.";
        }
    }
}