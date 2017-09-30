using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;


            if (mounth == "May")
            {
                studioPrice = nights * 50;
                doublePrice = nights * 65;
                suitePrice = nights * 75;
                if (nights > 7)
                {
                    studioPrice = nights * (50 * 0.95);
                }
            }
            else if (mounth == "October")
            {
                studioPrice = nights * 50;
                doublePrice = nights * 65;
                suitePrice = nights * 75;
                if (nights > 7)
                {
                    nights--;
                    studioPrice = nights * (50 * 0.95);
                }
            }
            else if (mounth == "June")
            {
                studioPrice = nights * 60;
                doublePrice = nights * 72;
                suitePrice = nights * 82;
                if (nights > 14)
                {
                    doublePrice = nights * (72 * 0.90);
                }
            }
            else if (mounth == "September")
            {
                studioPrice = nights * 60;
                doublePrice = nights * 72;
               suitePrice = nights * 82;
                if (nights > 7)
                {
                    nights--;
                    studioPrice = nights * 60;
                }
                if (nights > 14)
                {
                    doublePrice = nights * (72 * 0.90);
                }
            }
            else if (mounth == "July" || mounth == "August" || mounth == "December")
            {
                studioPrice = nights * 68;
                doublePrice = nights * 77;
                suitePrice = nights * 89;
                if (nights > 14)
                {
                    suitePrice = nights * (89 * 0.85);
                }
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
