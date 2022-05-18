using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
    public class ListOfItems
    {
        public Drinks Drinks { get; set; }

        public Food Food  { get; set; }

        public ListOfItems (Drinks drinks, Food food)
        {
            Drinks = drinks;
            Food = food;
        }
    }
}
