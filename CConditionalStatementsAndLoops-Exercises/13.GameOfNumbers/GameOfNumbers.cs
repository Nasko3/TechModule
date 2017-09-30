using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;
            int magicSum = 0;
            int tempI = 0;
            int tempJ = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    sum = i + j;
                    if (sum == magicalNumber)
                    {
                        magicSum = sum;
                        tempI = i;
                        tempJ = j;
                    }

                }
            }
            if (magicSum == magicalNumber)
            {
                Console.WriteLine($"Number found! {tempI} + {tempJ} = {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
        }
    }
}
