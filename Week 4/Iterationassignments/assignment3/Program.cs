namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialise values
            int randomNumber = 0;
            int consoleWrite = 0;
            int sum = 0;

            // calculate every 5th input
            do
            {
                consoleWrite++;
                // if it's every 5th input
                if (consoleWrite % 5 == 0)
                {
                    Console.Write("Enter a number: ");
                    randomNumber = int.Parse(Console.ReadLine());
                    sum += randomNumber;
                }
                // if it's not every 5th input
                else if (consoleWrite % 5 != 0)
                {
                    Console.Write("Enter a number: ");
                    randomNumber = int.Parse(Console.ReadLine());
                }
            } while (randomNumber != 0);

            // display sum
            Console.Write($"Sum of 5th, 10th, 15th ... number is: {sum} ");

        }
    }
}