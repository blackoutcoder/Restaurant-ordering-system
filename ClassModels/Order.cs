using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ClassModels
{
    public class Order 
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; }

        public ListOfItems OrderItems { get; }

        public Order(int id, DateTime orderDate, ListOfItems orderItems)
        {
            Id = id;
            OrderDate = orderDate;
            OrderItems = orderItems;
        
        }
    }
}
