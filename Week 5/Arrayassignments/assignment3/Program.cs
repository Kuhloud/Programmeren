using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Transactions;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enter program of culture
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            // start of code
            int highestGrade = 0;
            int sum = 0;

            // input course 
            Console.Write("Enter course name: ");
            string course = Console.ReadLine();

            // input student
            Console.Write("Enter number of students: ");
            int studentAmount = int.Parse(Console.ReadLine());
            string[] studentNames = new string[studentAmount];
            int[] studentGrades = new int[studentAmount];
            string greatStudent = studentNames[0];
            Console.WriteLine("");

            // input student names
            for (int i = 0; i < studentAmount; i++)
            {
                Console.Write($"Enter name of student {i+1}: ");
                studentNames[i] = Console.ReadLine();
            }
            Console.WriteLine("");
            // input student grades
            for (int i = 0; i < studentAmount; i++)
            {
                Console.Write($"Enter grade of {studentNames[i]}: ");
                studentGrades[i] = int.Parse(Console.ReadLine());
                 sum += studentGrades[i];
            }
            // calculate max value
            int maximum = studentGrades[0];
            maximum = studentGrades[0];
            for (int i = 0; i < studentAmount; i++)
                if (studentGrades[i] > maximum)
                {
                    maximum = studentGrades[i];
                }

            // calculate student with highest grade
            highestGrade = maximum;
            for (int i = 0; i < studentAmount; i++)
            if (studentGrades[i] == highestGrade)
                {
                    greatStudent = $"{studentNames[i]}";
                }
            // display average
             double averageGrade = (double)sum / studentAmount;
            Console.WriteLine($"\nAverage grade: {averageGrade:0.0}");
            
            // display student with the highest grade
            Console.WriteLine($"Student {greatStudent} has highest grade: {highestGrade}\n");

            // display overview
            for (int i = 0; i < studentAmount; i++)
            {
                Console.WriteLine($"Grade for student {studentNames[i]} (course {course}): {studentGrades[i]}");
            }
        }
    }
}