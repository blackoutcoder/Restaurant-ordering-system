using System;
using System.Collections.Generic;
using System.Threading;
using ClassModels;
using Services;

namespace Restaurant_ordering_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TablesState tableState = new TablesState();
            FoodRepository foodRepository = new FoodRepository();
            foodRepository.Serialize(foodRepository.Foods);
            DrinksRepository drinksRepository = new DrinksRepository();
            OrderRepository orderRepository = new OrderRepository();
            List<Table> tables = tableState.Tables;
            Console.WriteLine(Convert.ToString(tables.Count));
            Console.WriteLine(drinksRepository.Generate().Name);
            var order1 = orderRepository.GenerateOrder(1);
            Console.WriteLine($"{order1.Id}, {order1.OrderDate}, {order1.OrderItems.Food.Name}, {order1.OrderItems.Drinks.Name}");
            //var state1 = tableState.GetTableState();
            Console.WriteLine(tableState.GetTableState(1));
            string h = "Restaurant System Terminal";

            while (true)
            {
                for (int i = 0; i < 70; i++)
                {

                    
                    Console.WriteLine(h);
                    Console.WriteLine(Convert.ToString(tables.Count));
                    Console.WriteLine(drinksRepository.Generate().Name);
                    Console.WriteLine($"{order1.Id}, {order1.OrderDate}, {order1.OrderItems.Food.Name}, {order1.OrderItems.Drinks.Name}");
                    Console.WriteLine(tableState.GetTableState(1));
                    Thread.Sleep(100);
                   
                    Console.Clear();
                    Console.SetCursorPosition(i, 0);
                }
            }

        }
    }
}
