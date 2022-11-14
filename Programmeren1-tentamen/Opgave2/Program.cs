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

                }
            }

        }
    }
}