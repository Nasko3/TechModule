using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = string.Empty;
            int price = 0;
            double pricePerPerson = 0;

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
                if (package == "Normal")
                {
                    pricePerPerson = ((price + 500) * 0.95) / groupSize;
                }
                else if (package == "Gold")
                {
                    pricePerPerson = ((price + 750) * 0.90) / groupSize;
                }
                else if (package == "Platinum")
                {
                    pricePerPerson = ((price + 1000) * 0.85) / groupSize;
                }

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
                if (package == "Normal")
                {
                    pricePerPerson = ((price + 500) * 0.95) / groupSize;
                }
                else if (package == "Gold")
                {
                    pricePerPerson = ((price + 750) * 0.90) / groupSize;
                }
                else if (package == "Platinum")
                {
                    pricePerPerson = ((price + 1000) * 0.85) / groupSize;
                }

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
                if (package == "Normal")
                {
                    pricePerPerson = ((price + 500) * 0.95) / groupSize;
                }
                else if (package == "Gold")
                {
                    pricePerPerson = ((price + 750) * 0.90) / groupSize;
                }
                else if (package == "Platinum")
                {
                    pricePerPerson = ((price + 1000) * 0.85) / groupSize;
                }
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
