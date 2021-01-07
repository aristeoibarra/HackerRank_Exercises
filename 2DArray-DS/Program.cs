using System;
using System.Linq;

namespace _2DArray_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][] {
                new int[6] {-9 ,-9, -9 , 1, 1 ,1},
                new int[6] { 0, -9,  0,  4, 3, 2},
                new int[6] {-9 ,-9, -9 , 1 ,2, 3},
                new int[6] { 0 , 0 , 8 , 6 ,6 ,0},
                new int[6] { 0 , 0 , 0 ,-2 ,0 ,0},
                new int[6] { 0,  0 , 1 , 2 ,4 ,0}};
           
            Console.WriteLine(HourglassSum(arr));
            Console.ReadKey();
        }

        private static int HourglassSum(int[][] arr)
        {
            int[,] hourglass = new int[4, 4];

            for (int i = 0; i < hourglass.GetLength(0); i++)
            {
                for (int j = 0; j < hourglass.GetLength(0); j++) 
                {
                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    sum += arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    sum += arr[i + 1][j + 1];
                    hourglass[i, j] = sum;
                }
            }
            return hourglass.Cast<int>().Max();
        }
    }
}
