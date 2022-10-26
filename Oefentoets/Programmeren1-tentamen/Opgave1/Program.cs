namespace Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordReversal = "";
            Console.Write("Geef een woord: ");
            string wordInput = Console.ReadLine();
            for (int i = wordInput.Length - 1; i >= 0; i--)
            {
                wordReversal += wordInput[i];
            }
            if (wordReversal == wordInput)
            {
                Console.Write($"{wordInput} is een palindroom.");
            }
            else
            {
                Console.Write($"{wordInput} is geen palindroom.");
            }
        }
    }
}