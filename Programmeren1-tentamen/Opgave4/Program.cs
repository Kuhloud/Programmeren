using System.Net.Http.Headers;

namespace Opgave4
{
    internal class Program
    {
        const int LowestValue = 1;
        const int HighestValueOfDividend = 50;
        const int HighestValueOfDivisor = 5;
        const int MaximumAmountOfRandomNumbers = 10;
        static void Main(string[] args)
        {
            int deeltal, deler, rest;
            int amountOfTimesItCanBeDivided = 0;
            int[] maxRandomNumbers = new int[MaximumAmountOfRandomNumbers];
            Random randomDividend = new Random();
            Random randomDivisor = new Random();
            for (int i = 0; i < maxRandomNumbers.Length; i++)
            {
                deeltal = randomDividend.Next(LowestValue, HighestValueOfDividend);
                deler = randomDivisor.Next(LowestValue, HighestValueOfDivisor);
                int quotient = IntegerDeling(deeltal, deler, out rest);
                Console.WriteLine($"{deeltal} / {deler} = {quotient} ({rest})");
            }
            Console.WriteLine("\neinde programma");
        }
        static int IntegerDeling(int deeltal, int deler, out int rest)
        {
            int quotient = 0;
            while (deeltal >= deler)
            {
                quotient++;
                deeltal -= deler;
            }
            rest = deeltal;
            return quotient;
        }
    }
}