using System;
using System.Linq;

namespace Designer_PDF_Viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "zaba";
            int iterator = 0;

            int[] arr =
                { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };

            char[] alphabet = Alphabet();
            int[] indexes = new int[word.Length];
            int[] valueByIndex = new int[word.Length];

            //GET INDEXES OF alphabet[] 
            foreach (var w in word)
            {
                foreach (var a in alphabet)
                {
                    if (w == a)
                    {
                        indexes[iterator] = Array.IndexOf(alphabet, w);
                        iterator++;
                    }
                }
            }

            //GET VALUES WITH INDEXEX
            iterator = 0;
            foreach (var item in indexes)
            {
                valueByIndex[iterator] = int.Parse(arr.GetValue(item).ToString());
                iterator++;
            }


            int value = word.Length * valueByIndex.Max();
            Console.WriteLine(value);
            Console.ReadKey();
        }

        private static char[] Alphabet()
        {
            char[] alp = new char[26];
            int cont = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                alp[cont] = i;
                cont++;
            }
            return alp;
        }
    }
}
