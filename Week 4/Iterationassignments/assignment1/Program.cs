using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // set program of culture
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // display values
            Console.Write("Enter a number: ");
            int randomValue = int.Parse(Console.ReadLine());
            int amountValue = 0;


            do
            {
                amountValue++;
            }
            while (randomValue != 0);
            {
                Console.Write("Enter a number: ");
                randomValue = int.Parse(Console.ReadLine());
            }
            double Average = randomValue / amountValue;
            Console.Write($"Average of all positive numbers is: {Average:0.00} ");
        }
    }
}