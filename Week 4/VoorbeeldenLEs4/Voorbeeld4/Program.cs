namespace Voorbeeld4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int i = 2;
            while ((i < number) && isPrime)
            {
                if ((number % i) == 0)
                {
                    isPrime = false;
                }
                else
                {
                    i += 1;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number");
            }
        }
    }
}