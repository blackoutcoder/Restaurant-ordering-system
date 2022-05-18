using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModels;
using Interfaces;

namespace Services
{
    public class OrderRepository
    {
        public List<Order> NewOrder { get; }

        public FoodRepository foodRepository = new FoodRepository();
        public DrinksRepository drinksRepository = new DrinksRepository();
        public OrderRepository()
        {
            NewOrder = new List<Order>();

        }

        public Order GenerateOrder(int Id)
        {
            var orderItems = new ListOfItems(drinksRepository.Generate(), foodRepository.Generate());
      
            var order = new Order(Id, DateTime.Now, orderItems);
            NewOrder.Add(order);
            return order;
        }
    }
}
