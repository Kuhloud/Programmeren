using System.Globalization;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // culture of program
            CultureInfo ci = new CultureInfo ("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci; 

            // input numbers
            Console.Write("Enter first number: ");
            double FirstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double SecondNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            double ThirdNumber = double.Parse(Console.ReadLine());

            // display sum
            double sum = FirstNumber + SecondNumber + ThirdNumber;
            Console.WriteLine($"sum = {sum}");

            // display average
            double average = (FirstNumber + SecondNumber + ThirdNumber) / 3;
            Console.WriteLine($"average = {average:0.00}");

            // display product
            double product = FirstNumber * SecondNumber * ThirdNumber;
            Console.WriteLine($"product = {product}");

            // display highest and lowest value
            // first = highest third = lowest
            if (FirstNumber > SecondNumber & FirstNumber > ThirdNumber & SecondNumber > ThirdNumber)
            {
                Console.WriteLine($"highest = {FirstNumber}");
                Console.WriteLine($"lowest = {ThirdNumber}");
            }
            // second = highest lowest = third
            else if (SecondNumber > FirstNumber & SecondNumber > ThirdNumber & FirstNumber > ThirdNumber)
            {
                Console.WriteLine($"highest = {SecondNumber}");
                Console.WriteLine($"lowest = {ThirdNumber}");
            }
            // third = highest lowest = first
            else if (ThirdNumber > FirstNumber & ThirdNumber > SecondNumber & SecondNumber > FirstNumber)
            {
                Console.WriteLine($"highest = {ThirdNumber}");
                Console.WriteLine($"lowest = {FirstNumber}");
            }
            // second = highest first = lowest
            else if (SecondNumber > FirstNumber & SecondNumber > ThirdNumber & ThirdNumber > FirstNumber)
            {
                Console.WriteLine($"highest = {SecondNumber}");
                Console.WriteLine($"lowest = {FirstNumber}");
            }
            // first = highest second = lowest
            else if (FirstNumber > SecondNumber & FirstNumber > ThirdNumber & SecondNumber < ThirdNumber)
            {
                Console.WriteLine($"highest = {FirstNumber}");
                Console.WriteLine($"lowest = {SecondNumber}");
            }
            // third = highest lowest = second
            else 
            {
                Console.WriteLine($"highest = {ThirdNumber}");
                Console.WriteLine($"lowest = {SecondNumber}");
            }
           
        }
    }
}