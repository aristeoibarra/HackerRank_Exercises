using System;
using System.Linq;

namespace HackerRank_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] words = new string[N];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < words[i].Length; j+=2)
                {
                    Console.Write(words[i][j]);
                }
                Console.Write(" ");

                for (int j = 1; j < words[i].Length; j += 2)
                {
                    Console.Write(words[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
