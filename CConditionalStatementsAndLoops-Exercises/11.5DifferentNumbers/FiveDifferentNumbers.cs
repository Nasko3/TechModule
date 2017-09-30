using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5DifferentNumbers
{
    class FiveDifferentNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a-b) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = a + 1; j <= b; j++)
                    {
                        for (int k = a; k <= b; k++)
                        {
                            for (int l = a; l <= b; l++)
                            {
                                for (int m = a; m <= b; m++)
                                {
                                    if (j <=i || k <= j || l <= k || m <= l)
                                    {
                                        continue;
                                    }
                                    else
                                    //if (i < j && j < k && k < l && l < m)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
