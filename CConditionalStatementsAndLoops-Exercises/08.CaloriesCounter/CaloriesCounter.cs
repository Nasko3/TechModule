using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var totalCalories = 0;

            for (int i = 0; i < count; i++)
            {
                var ingredients = Console.ReadLine().ToLower();

                if (ingredients == "cheese")
                {
                    totalCalories += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if (ingredients == "salami")
                {
                    totalCalories += 600;
                }
                else if (ingredients == "pepper")
                {
                    totalCalories += 50;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
