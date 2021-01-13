using System;
using System.Linq;

namespace ReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kangaroo(28, 8, 96, 2).ToString());
            Console.ReadKey();


            //28 8 96 2
        }

        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            // X1: 1928 V1: 4306  X2: 5763 V2: 4301

            if ((x1 >= 0 && x1 <= 10000) && (x2 >= 0 && x2 <= 10000) && (x2 > x1))
            {
                if ((v1 >= 1 && v1 <= 10000) && (v2 >= 1 && v2 <= 10000) && (v1 > v2))
                {
                    while ((x1 + v1) != (x2 + v2))
                    {
                        x1 += v1;
                        x2 += v2;
                    }
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
            else
            {
                return "NO";
            }
        }
    }
}
