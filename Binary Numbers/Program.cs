using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //439
            //3
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ConvertToBinary(n));
        }

        private static int ConvertToBinary(int n)
        {
            Stack<int> numberBinary = new Stack<int>();
            do
            {
                if (n % 2 == 0)
                {
                    numberBinary.Push(0);
                    n /= 2;
                }
                else
                {
                    numberBinary.Push(1);
                    n /= 2;
                }
            } while (n != 0);
            
           return ConsecutiveOnes(numberBinary);
        }

        private static int ConsecutiveOnes(Stack<int> numberBinary)
        {
            // 110110111
            int count = 0;
            List<int> groupNum = new List<int>();

            foreach (int item in numberBinary)
            {
                if(item == 1)
                    count++;
                else
                {
                    groupNum.Add(count);
                    count = 0;
                }
            }
            groupNum.Add(count);

            return groupNum.Max();
        }
    }
}
