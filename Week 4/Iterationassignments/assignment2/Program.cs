namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input target number
            Console.Write("Enter target number: ");
            int targetNumber = int.Parse(Console.ReadLine());
     
            // input a random number
            Console.Write("Enter a number: ");
            int randomNumber = int.Parse(Console.ReadLine());
            int numberCount = 0;

            do

            {
                if (targetNumber == randomNumber)
                {
                    Console.Write("Enter a number :");
                    randomNumber = int.Parse(Console.ReadLine());
                    numberCount++;
                }
                else if (targetNumber != randomNumber && randomNumber != 0)
                {
                    Console.Write("Enter a number :");
                    randomNumber = int.Parse(Console.ReadLine());
                }
            } while (randomNumber != 0);

            

            Console.Write($"Count of numbers equal to target number: {numberCount}");
        }
    }
}