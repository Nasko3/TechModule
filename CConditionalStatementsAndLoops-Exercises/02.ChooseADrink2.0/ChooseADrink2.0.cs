using System;

namespace _02.ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                Console.WriteLine($"The {profession} has to pay {quantity * 0.70:f2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine($"The {profession} has to pay {quantity * 1.00:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine($"The {profession} has to pay {quantity * 1.70:f2}.");
            }
            else
            {
                Console.WriteLine($"The {profession} has to pay {quantity * 1.20:f2}.");
            }
        }
    }
}
