using System.Globalization;

namespace assignment5
{
    internal class Program
    {
        const int MaxInputs = 10;
        static void Main(string[] args)
        {
            // set program of culture
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            // initialize variables
            int oldest = 0;
            int consoleWriteLines = 0;
            int preschoolerSum = 0;
            int childSum = 0;
            int adultSum = 0;
            // initialize array
            int[] allAgeInputs = new int[MaxInputs];
            int[] preschoolerInputs = new int[MaxInputs];
            int[] childInputs = new int[MaxInputs];
            int[] adultInputs = new int[MaxInputs];

            for (int i = 0; i < allAgeInputs.Length; i++)
            {
                Console.Write("Enter age (0=stop): ");
                allAgeInputs[i] = int.Parse(Console.ReadLine());
                if (allAgeInputs[i] == 0)
                {
                    break;
                }
            }
            // display preschooler ages
            Console.WriteLine("\nPRESCHOOLERS");
            for (int i = 0; i < allAgeInputs.Length; i++)
            {
                if (allAgeInputs[i] >= 1 && allAgeInputs[i] <= 3)
                {
                    consoleWriteLines++;
                    Console.WriteLine($"Preschooler {i+1} is {allAgeInputs[i]} years old");
                    preschoolerInputs[i] = allAgeInputs[i];
                    preschoolerSum += allAgeInputs[i];
                    oldest = preschoolerInputs.Max();
                }
                else if (allAgeInputs[i] == 0)
                {
                    consoleWriteLines++;
                }


            }
            double preschoolerAverage = (double)preschoolerSum / consoleWriteLines;
            Console.WriteLine($"Average preschooler is {preschoolerAverage:0.00} years old");
            Console.WriteLine($"Oldest preschooler is {oldest}");

            oldest = 0;
            consoleWriteLines = 0;
            // display children ages
            Console.WriteLine("\nCHILDREN");
            for (int i = 0; i < allAgeInputs.Length; i++)
            {
                if (allAgeInputs[i] >= 4 && allAgeInputs[i] <= 17)
                {
                    consoleWriteLines++;
                    Console.WriteLine($"Child {i + 1} is {allAgeInputs[i]} years old");
                    childInputs[i] = allAgeInputs[i];
                    childSum += allAgeInputs[i];
                    oldest = childInputs.Max();
                }
                else if (allAgeInputs[i] == 0)
                {
                    consoleWriteLines++;
                }

            }
            double childAverage = (double)childSum / consoleWriteLines;
            Console.WriteLine($"Average child is {childAverage:0.00} years old");
            Console.WriteLine($"Oldest child is {oldest}");

            oldest = 0;
            consoleWriteLines = 0;
            // display adult ages
            Console.WriteLine("\nADULTS");
            for (int i = 0; i < allAgeInputs.Length; i++)
            {
                if (allAgeInputs[i] >= 18)
                {
                    consoleWriteLines++;
                    Console.WriteLine($"Adult {i + 1} is {allAgeInputs[i]} years old");
                    adultInputs[i] = allAgeInputs[i];
                    adultSum += allAgeInputs[i];
                    oldest = adultInputs.Max();
                }
                else if (allAgeInputs[i] == 0)
                {
                    consoleWriteLines++;
                }

            }
            double adultAverage = (double)adultSum / consoleWriteLines;
            Console.WriteLine($"Average adult is {adultAverage:0.00} years old");
            Console.WriteLine($"Oldest adult is {oldest}");



        }
    }
}