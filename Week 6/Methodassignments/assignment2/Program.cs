namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeNumberCalculation = 1;
            while (primeNumberCalculation != 0)
            {
                Console.Write("Enter Number (0 is stop value): ");
                primeNumberCalculation = int.Parse(Console.ReadLine());

                if (primeNumberCalculation < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                else
                {
                    if (primeNumberCalculation != 0 && IsPrimeNumber(primeNumberCalculation))
                    {
                        Console.WriteLine($"{primeNumberCalculation} is a prime number.");
                    }
                    else if (primeNumberCalculation != 0)
                    {
                        Console.WriteLine($"{primeNumberCalculation} is not a prime number.");
                    }
                }
                        
            } Console.WriteLine("end of program");
        }
        static bool IsPrimeNumber(int primeNumberCalculation)
        {
            bool primeNumber = true;
            int i = 2;
            while  ((i < primeNumberCalculation) && primeNumber)
            {
                if ((primeNumberCalculation % i) == 0)
                {
                    primeNumber = false;
                }
                else 
                {
                    i += 1;
                }
            } 
            return primeNumber;
        }
    }
}