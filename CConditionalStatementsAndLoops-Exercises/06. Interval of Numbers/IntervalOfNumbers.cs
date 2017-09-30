using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secoundNum = int.Parse(Console.ReadLine());

            if (firstNum < secoundNum)
            {
                for (int i = firstNum; i <= secoundNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = secoundNum; i <= firstNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
