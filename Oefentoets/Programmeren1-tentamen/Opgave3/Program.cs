namespace Opgave3
{
    internal class Program
    {
        const int MaximumWordCount = 19;
        static void Main(string[] args)
        {
            bool letterCountIsZero = false;
            string[] maximumWordInput = new string[MaximumWordCount];
            int wordCount = 0;
            while (!letterCountIsZero && wordCount < maximumWordInput.Length)
            {
                    Console.Write("Geef een woord: ");
                    string wordInput = Console.ReadLine();

                    if (wordInput.Length == 0)
                    {
                        letterCountIsZero = true;
                    }
                    else
                    {
                        maximumWordInput[wordCount] = wordInput;
                        wordCount++;
                    }
                }
                
                for (int i = 0; i < wordCount; i++)
                {
                    if (maximumWordInput[i].Length % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine($"{maximumWordInput[i]}\n");
                    Console.ResetColor();
                    Console.WriteLine("einde programma");

            }
        }
    }
}