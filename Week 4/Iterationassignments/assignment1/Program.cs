namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // display value
            Console.WriteLine("Enter a number: ");
            int randomValue = int.Parse(Console.ReadLine());

            while (randomValue != 0)
            {
                Console.WriteLine("Enter a number: ");
                randomValue = int.Parse(Console.ReadLine());
            }
            Console.Write("Average of all positive numbers is: ");
        }
    }
}