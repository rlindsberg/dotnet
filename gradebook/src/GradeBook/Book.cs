using System;
using System.Collections.Generic;

namespace GradeBook {
    public class Book
    {
        public Book(string name)
        {
            listOfGrades = new List<double>();
            _name = name;
        }
        // This is called a field, implicit typing is now allowed
        private List<double> listOfGrades;
        private string _name;
        
        // Instance member (method) of the class Book
        public void AddGrade(double gradeToBeAdded)
        {
            if (gradeToBeAdded >= 0 && gradeToBeAdded <= 100)
            {
                listOfGrades?.Add(gradeToBeAdded);
            }
            else
            {
                Console.WriteLine("Please provide a valid grade");
            }
        }

        public void ShowStats()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var grade in listOfGrades) {
                result += grade;
                if (grade > highGrade)
                {
                    highGrade = grade;
                }

                if (grade < lowGrade)
                {
                    lowGrade = grade;
                }
            }
            // Count how many items in the list
            result /= listOfGrades.Count;

            // Print out the stats
            // Use one decimal
            Console.WriteLine($"The lowest grade is {lowGrade:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The sum of all grades is {result:N1}");
        }

        public Statistics GetStatistics()
        {
            var stat = new Statistics();
            
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var grade in listOfGrades) {
                result += grade;
                if (grade > highGrade)
                {
                    highGrade = grade;
                }

                if (grade < lowGrade)
                {
                    lowGrade = grade;
                }
            }
            // Count how many items in the list
            result /= listOfGrades.Count;
            
            stat.SetGrade(result, highGrade, lowGrade);
            return stat;

        }
    }
}
