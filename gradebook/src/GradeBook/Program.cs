using System;

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

            var grades = new[] {12.7, 10.3, 6.11, 4.1};
            var result = 0.0;
            foreach (var grade in grades) {
                result += grade;
            }
            Console.WriteLine($"The sum of all grades is {result}");
        }
    }
}
