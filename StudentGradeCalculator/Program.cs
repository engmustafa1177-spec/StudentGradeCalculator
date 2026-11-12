using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeCalculator
{
    internal class Program
    {
        static double calculateAverage(int grade1, int grade2, int grade3)
        {
            return (grade1 + grade2 + grade3) / 3.0;
        }
        static void Main(string[] args)
        {
            string studentName = "Ahmad";
            int grade1 = 85;
            int grade2 = 90;
            int grade3 = 80;

            Console.WriteLine("Student: " + studentName);
            Console.WriteLine("Grade 1: " + grade1);
            Console.WriteLine("Grade 2: " + grade2);
            Console.WriteLine("Grade 3: " + grade3);
            Console.WriteLine("Average: " + calculateAverage(grade1, grade2, grade3));

    }
    }
}
