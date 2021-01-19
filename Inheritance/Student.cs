using System;
using System.Linq;

namespace Inheritance
{
    class Student : Person
    {
        private int[] testScores;
        public Student(string firstName, string lastName, int id,int[] scores) : base(firstName, lastName, id)
        {
            this.testScores = scores;
        }
        
        public char Calculate()
        {
            int average = testScores.Sum() / testScores.Count();
            return GradeScale(average);
        }

        private char GradeScale(int average)
        {
            char grade;

            if (average >= 90 && average <= 100)
                grade = 'O';
            else if (average >= 80 && average < 90)
                grade = 'E';
            else if (average >= 70 && average < 80)
                grade = 'A';
            else if (average >= 55 && average < 70)
                grade = 'P';
            else if (average >= 40 && average < 55)
                grade = 'D';
            else
                grade = 'T';

            return grade;
        }
    }
}
