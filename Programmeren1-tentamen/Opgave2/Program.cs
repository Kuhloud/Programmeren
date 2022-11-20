namespace Opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inputIsZero = false;            
            while (!inputIsZero)
            {
                Console.Write("Voer een getal in: ");
                int numberInput = int.Parse(Console.ReadLine());
                if (numberInput == 0)
                {
                    inputIsZero = true;
                }
                else
                {
                    int factor = 2;
                    while (numberInput > 1)
                    {
                        if (numberInput % factor == 0)
                        {
                            numberInput = numberInput / factor;
                            Console.Write($"{factor} ");
                        }
                        else
                        {
                            factor++;
                        }
                    }
                }
            }
            Console.WriteLine("einde programma");

        }
    }
}