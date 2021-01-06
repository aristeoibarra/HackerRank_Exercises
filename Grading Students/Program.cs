using System;
using System.Linq;
using System.Collections.Generic;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 73, 67, 38, 33 };
            List<int> grades = new List<int> ();

            foreach (var item in list)
            {
                int round = RoundUp(item) - item;
                
                if(round < 3 && item >= 38)
                    grades.Add(RoundUp(item));
                else
                    grades.Add(item);                            
            }

            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static int RoundUp(int num)
        {
            if (num % 5 == 0)
                return num;
            return (5 - (num % 5)) + num;
        }

    }
}
