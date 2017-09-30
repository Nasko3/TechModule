using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            double energyInProd = (volume * energy) / 100;
            double sugarInProd = (volume * sugar) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyInProd}kcal, {sugarInProd}g sugars");
        }
    }
}
