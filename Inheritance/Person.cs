using System;

namespace Inheritance
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"Name: {lastName},{firstName}" +
                $"\nID: {id}");
        }
    }
}
