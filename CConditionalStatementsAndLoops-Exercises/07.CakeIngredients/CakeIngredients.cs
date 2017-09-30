using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int counter = 0;
            do
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
                ingredient = Console.ReadLine();
            } while (ingredient != "Bake!");
            
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
            
        }
    }
}
