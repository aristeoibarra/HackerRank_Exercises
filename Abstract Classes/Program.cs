using System;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Price: ");
            int price =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Book newNovel = new MyBook(title, author, price);
            newNovel.Display();
        }
    }
}
