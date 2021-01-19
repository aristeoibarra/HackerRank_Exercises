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
            Dictionary<string, int> contactsBook = new Dictionary<string, int>(N);

            for (int i = 0; i < N; i++)
            {
                string[] contact = Console.ReadLine().ToLower().Split(' ');
                if (contact[1].Length == 8)
                    contactsBook.Add(contact[0], int.Parse(contact[1]));
            }

            string nameContact;
            while ((nameContact = Console.ReadLine()) != null)
            {
                if (contactsBook.ContainsKey(nameContact))
                    Console.WriteLine(nameContact + "=" + contactsBook[nameContact]);
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}
