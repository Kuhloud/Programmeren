using System;

namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input score
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (score)
            {
                case >= 0 and < 60:
                    Console.WriteLine("grade: F");
                    Console.WriteLine("course not passed");
                    break;
                case >= 60 and < 70:
                    Console.WriteLine("grade: D");
                    Console.WriteLine("course not passed");
                    break;
                case >= 70 and < 80:
                    Console.WriteLine("grade: C");
                    Console.WriteLine("course passed");
                    break;
                case >= 80 and < 90:
                    Console.WriteLine("grade: B");
                    Console.WriteLine("course passed");
                    break;
                case >= 90 and <= 100:
                    Console.WriteLine("grade: A");
                    Console.WriteLine("course passed");
                    break;
                default:
                    Console.WriteLine("enter actual number retard");
                    break;


            }
        }
    }
}