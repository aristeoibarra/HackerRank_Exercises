using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int sumMultiples = Enumerable.Range(0, n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
                Console.WriteLine(sumMultiples);
            }
        }
    }
}
