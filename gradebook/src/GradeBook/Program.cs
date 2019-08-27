using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        // Static member is not associate with an object instance,
        //     but the "type" that they are defined inside of.
        static void Main(string[] args)
        {
            if (args.Length > 0) {
                Console.WriteLine($"Hello {args[0]}!");
            } else {
                Console.WriteLine("Hello stranger!");
            }

            var testGradeBook = new Book();
            testGradeBook.AddGrade(12.7);
            testGradeBook.AddGrade(10.3);
            testGradeBook.AddGrade(6.11);
            testGradeBook.AddGrade(4.1);
            testGradeBook.AddGrade(56.1);

            testGradeBook.ShowStats();

        }
    }
}
