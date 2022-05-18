using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClassModels;

namespace Services
{
    public class FoodRepository
    {
        public List<Food> Foods;
        public void Serialize(List<Food> Foods)
        {
            string path = @"C:\Users\romka\source\CsharpAdvanceExam\Restaurant ordering system\MenuFiles\";
            
            var options = new JsonSerializerOptions { WriteIndented = true };
            string text = JsonSerializer.Serialize(Foods, options);
            File.WriteAllText(@$"{path}Food.txt", text);
        }
        public FoodRepository()
        {
            Foods = new List<Food>();
            
            Foods.Add(new Food("Fish and Chips", 2.99m));
            Foods.Add(new Food("Toasts and Egg", 1.59m));
            Foods.Add(new Food("Bacon and potatoes", 3.20m));
            Foods.Add(new Food("Baked Parmezan", 2.59m));
            Foods.Add(new Food("Rizotto", 2.89m));
            Foods.Add(new Food("Chicken nugets", 4.99m));
            Foods.Add(new Food("Vegetable Soup", 0.99m));
            Foods.Add(new Food("Daily meal", 2.10m));
            Foods.Add(new Food("Italian Pasta", 1.30m));
            Foods.Add(new Food("Cheefs Choise", 5.99m));

            //public string FoodList = System.IO.File.ReadAllText(@"C:\Users\romka\source\CsharpAdvanceExam\Restaurant ordering system\MenuFiles\Food.txt");

        }

        public Food Generate()
        {
            var random = new Random();
            int index = random.Next(Foods.Count);
            var food = Foods[index];
            return food;
        }

    }
}
