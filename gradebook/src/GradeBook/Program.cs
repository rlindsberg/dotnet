using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0) {
                Console.WriteLine($"Hello {args[0]}!");
            } else {
                Console.WriteLine("Hello stranger!");
            }

            List<double> listOfGrades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            listOfGrades.Add(56.1);

            var result = 0.0;
            foreach (var grade in listOfGrades) {
                result += grade;
            }
            // Count how many items in the list
            result /= listOfGrades.Count;
            // Use one decimal
            Console.WriteLine($"The sum of all grades is {result:N1}");
        }
    }
}
