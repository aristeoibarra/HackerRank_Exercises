using System;
using System.Linq;

namespace Arrays_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,9,4,5};

            foreach (var item in arr.Reverse().ToArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
