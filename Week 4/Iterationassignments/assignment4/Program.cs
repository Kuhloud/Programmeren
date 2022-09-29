namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int previousNumber = 1;
            int nextNumber = 0;
            int fibonacci = 0;
            for (int n = 1; n <= 20; n++)
            {
                fibonacci = previousNumber + nextNumber;
                previousNumber = nextNumber;
                nextNumber = fibonacci;
                Console.Write($"{fibonacci}, ");
            }
        }
    }
}