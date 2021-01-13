using System;
using System.Linq;
using System.Collections.Generic;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> openWith = new Dictionary<string, int>(N);

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                openWith.Add(s[0], int.Parse(s[1]));
            }

            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                if (openWith.ContainsKey(s))
                {
                    Console.WriteLine(s + "=" + openWith[s]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
