using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ClassModels
{
    public class Drinks : Items
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Drinks(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
