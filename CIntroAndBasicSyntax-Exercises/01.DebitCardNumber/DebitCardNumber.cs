using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int secound = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            Console.WriteLine($"{first:d4} {secound:d4} {third:d4} {fourth:d4}");
        }
    }
}
