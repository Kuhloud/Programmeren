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
            int[] arrayOfRandomNumbers = new int[MaximumAmountOfRandomValues];
            int lowestValue = HighestMaximumValue;
            int highestValue = LowestMaximumValue;
            for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
            {
                if (arrayOfRandomNumbers[i] > highestValue)
                {
                    highestValue = arrayOfRandomNumbers[i];
                }
                if (arrayOfRandomNumbers[i] < lowestValue)
                {
                    lowestValue = arrayOfRandomNumbers[i];
                }
            }
            Console.WriteLine($"lowest value: {lowestValue}");
            Console.WriteLine($"highest value: {highestValue}");

            for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
            {
                if (arrayOfRandomNumbers[i] > lowestValue + 20 && arrayOfRandomNumbers[i] < highestValue - 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (arrayOfRandomNumbers[i] > lowestValue + 10 && arrayOfRandomNumbers[i] < highestValue - 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write($"{arrayOfRandomNumbers[i]:00} ");
                Console.ResetColor();
            }
        }
    }
}