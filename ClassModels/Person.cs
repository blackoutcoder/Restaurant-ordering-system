using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
    internal class Person
    {
        public int Id { get; set; }
        public int Cash { get; set; }
        

        public Person (int id, int cash)
        {
            Id = id;
            Cash = cash;
        }
    }
}
