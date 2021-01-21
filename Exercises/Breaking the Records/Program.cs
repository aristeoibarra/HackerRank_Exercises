using System;
using System.Linq;

namespace Breaking_the_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            int best = scores[0], worst = scores[0];
            int bestCount = 0, worstCount = 0;

            foreach (var s in scores)
            {
                if (s > best)
                {
                    bestCount++;
                    best = s;
                }
                if (s < worst)
                {
                    worstCount++;
                    worst = s;
                }
            }

            Console.WriteLine($"{bestCount} {worstCount}");

        }
    }
}
