namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeNumberCalculation = 0;
            bool primeNumber = false;
            while (!primeNumber)
            {
                Console.Write("Enter Number (0 is stop value): ");
                primeNumberCalculation = int.Parse(Console.ReadLine());
                if (primeNumberCalculation == 0)

                {
                    Console.WriteLine("end of program");
                    primeNumber = true;
                }
                else if (primeNumberCalculation < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                else if (primeNumberCalculation > 0)
                {
                    if (!primeNumber)
                    {
                        Console.WriteLine($"{primeNumberCalculation} is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine($"{primeNumberCalculation} is not a prime number.");
                    }
                }
            }




        }
        static bool IsPrimeNumber(int primeNumberCalculation)
        {
            bool primeNumber = false;
            int i = 2;
            while  ((i < primeNumberCalculation) && !primeNumber)
            {
                if ((primeNumberCalculation % i) == 0)
                {
                    primeNumber = true;
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