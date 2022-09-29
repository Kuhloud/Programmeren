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
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            // display sum
            int sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine($"sum = {sum}");

            // display average
            double average = (double)sum / 3;
            Console.WriteLine($"average = {average:0.00}");

            // display product
            int product = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine($"product = {product}");

            // display highest and lowest value
            int highestNumber = firstNumber;
            int lowestNumber = firstNumber;
            // 
            if (highestNumber < secondNumber )
            {
                highestNumber = secondNumber;
            }
            // second = highest lowest = third
            else if (highestNumber > thirdNumber)
            {
                highestNumber = thirdNumber;
            }
            // third = highest lowest = first
            if (lowestNumber > secondNumber)
            {
                lowestNumber = secondNumber;
            }
            // second = highest first = lowest
            else if (lowestNumber > thirdNumber)
            {
                lowestNumber = thirdNumber;
            }
               
            Console.WriteLine($"highest = {highestNumber}");
            Console.WriteLine($"lowest = {lowestNumber}");
            
           
        }
    }
}