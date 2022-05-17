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
            

            Foods.Add(new Food("Apple", 0.30m));
            
            //public string FoodList = System.IO.File.ReadAllText(@"C:\Users\romka\source\CsharpAdvanceExam\Restaurant ordering system\MenuFiles\Food.txt");
        
    }

    }
}
