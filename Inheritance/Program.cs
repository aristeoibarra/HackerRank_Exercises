using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce your name: ");
            string firstName = Console.ReadLine();
            Console.Write("Introduce your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Num. Scores: ");
            int[] scores = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Score[{i+1}]: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }

            Student student = new Student(firstName, lastName, id,scores);

            Console.WriteLine();
            student.PrintPerson();
            Console.WriteLine($"Grade: {student.Calculate()}\n");
        }
    }
}
