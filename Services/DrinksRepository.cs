using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModels;

namespace Services
{
    public class DrinksRepository
    {
        public List<Drinks> Drinks;

        public DrinksRepository()
        {
            Drinks = new List<Drinks>();

            Drinks.Add(new Drinks("Coca-cola", 0.99m));
            Drinks.Add(new Drinks("Fanta", 0.99m));
            Drinks.Add(new Drinks("Sprite", 0.99m));
            Drinks.Add(new Drinks("Coffee", 1.99m));
            Drinks.Add(new Drinks("Black Tea", 1.45m));
            Drinks.Add(new Drinks("Milk Coctail", 1.99m));
            Drinks.Add(new Drinks("Water", 0.00m));
            Drinks.Add(new Drinks("Vodka", 4.99m));
            Drinks.Add(new Drinks("Wisky", 5.99m));
            Drinks.Add(new Drinks("Vine", 6.99m));

        }

        public Drinks Generate()
        {
            var random = new Random();
            int index = random.Next(Drinks.Count);
            var drink = Drinks[index];
            return drink;
        }
    }
}
