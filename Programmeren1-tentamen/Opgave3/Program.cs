using System.Xml.Linq;

namespace Opgave3
{
    internal class Program
    {
        const int MaximumAmountOfRandomValues = 20;
        const int LowestMaximumValue = 1;
        const int HighestMaximumValue = 99;
        static void Main(string[] args)
        {
            int lowestValue = 0;
                int highestValue = 0;
            int[] arrayOfRandomNumbers = new int[MaximumAmountOfRandomValues];
            Console.WriteLine($"lowest value: {lowestValue}");
            Console.WriteLine($"highest value: {highestValue}");
            for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
            {
                arrayOfRandomNumbers[i] = new Random().Next(LowestMaximumValue, HighestMaximumValue);
                lowestValue = arrayOfRandomNumbers.Min();
                highestValue = arrayOfRandomNumbers.Max();
                if (arrayOfRandomNumbers[i] == lowestValue + 20 && arrayOfRandomNumbers[i] == highestValue - 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (arrayOfRandomNumbers[i] == lowestValue + 10 && arrayOfRandomNumbers[i] == highestValue - 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write($"{arrayOfRandomNumbers[i]:00} ");
            }
        }
    }
}