using System;
using System.Collections.Generic;
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
            List<Table> tables = tableState.Tables;
            Console.WriteLine(Convert.ToString(tables.Count));
            
            
        }
    }
}
