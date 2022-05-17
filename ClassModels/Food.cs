using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ClassModels
{
    public class Food : Items
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Food (string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

}
