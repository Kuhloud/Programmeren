using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        const int FixedAmountOfElements = 20;
        static void Main(string[] args)
        {
            // set culture program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            // initialize values
            int[] element = new int[FixedAmountOfElements];
            int consoleWriteLine = 0;
            int elementSum = 0;

            // display values
            Random rnd = new Random();
            for (int i = 0; i < element.Length; i++) // display 20 elements
            {
                consoleWriteLine++;
                element[i] = rnd.Next(0,201);
                Console.WriteLine($"Element {i} is {element[i]}");
                elementSum += element[i];
            }
            // calculate average
            double average = (double)elementSum / consoleWriteLine;
            Console.WriteLine($"The Average is: {average:0.00}");
            
            // display difference
            for (int i = 0; i < element.Length; i++)
            {
                    double difference = Math.Abs((double)element[i] - average);
                    Console.WriteLine($"Difference between average and element {i} is {difference:0.00}");
            }






        }
    }
}