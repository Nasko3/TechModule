using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"{miles* 1.60934:f2}");

            //double kilometers = miles * 1.60934;

            //Console.WriteLine($"{kilometers:f2}");
        }
    }
}
