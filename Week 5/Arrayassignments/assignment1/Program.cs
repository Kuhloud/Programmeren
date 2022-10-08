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
            for (int i = 0; i < element.Length; i++) // display 20 elements
            {
                consoleWriteLine++;
                element[i] = new Random().Next(200);
                Console.WriteLine($"Element {i} is {element[i]}");
                elementSum += element[i];
            }
            // calculate average
            double average = (double)elementSum / consoleWriteLine;
            Console.WriteLine($"\nThe Average is {average:0.00}\n");
            
            // display difference
            for (int i = 0; i < element.Length; i++)
            {
                if (average <= element[i])
                {
                    double difference = (double)element[i] - average;
                    Console.WriteLine($"Difference between average and element {i} is {difference:0.00}");
                }
                else if (average >= element[i])
                {
                    double difference = average - (double)element[i];
                    Console.WriteLine($"Difference between average and element {i} is {difference:0.00}");
                }
            }






        }
    }
}