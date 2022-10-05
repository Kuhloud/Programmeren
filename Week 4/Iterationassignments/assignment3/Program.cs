
namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialise values
            bool randomNumber = false;
            int consoleWrite = 0;
            int sum = 0;

            // calculate every 5th input
            while (!randomNumber)
            {
                Console.Write("Enter a number: ");
                int numberInput = int.Parse(Console.ReadLine());
                consoleWrite++;
                if (consoleWrite % 5 == 0)
                {
                    sum += numberInput;
                }
                else if (numberInput == 0)
                {
                    randomNumber = true;
                }
            } 

            // display sum

            Console.Write($"Sum of 5th, 10th, 15th, ... number is: {sum} ");

        }
    }
}