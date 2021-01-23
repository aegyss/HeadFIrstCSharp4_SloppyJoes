using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFIrstCSharp4_SloppyJoes
{
    class MenuItem
    {
        public Random Randomizer = new Random();
        public string[] Proteins = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] Condiments = { "Yellow Mustard", "Brown Mustard", "Honey Mustard", "Mayo", "Relish", "French Dressing", };
        public string[] Breads = { "Rye", "White", "Wheat", "Pumpernickel", "A Roll" };

        public string GenerateMenuItem()
        {
            string RandomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string RandomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string RandomBread = Breads[Randomizer.Next(Breads.Length)];
            return $"{RandomProtein} with {RandomCondiment} on {RandomBread}.";
        }

        public string RandomPrice()
        {
            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * .01M);
            return price.ToString("c");
        }
    }

    
}
