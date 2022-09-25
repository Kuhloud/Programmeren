namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // display inputs
            Console.Write("Enter first number: ");
            int firstInput = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondInput = int.Parse(Console.ReadLine());
            
            // initialize outcome
            int firstOutcome = firstInput % secondInput;
            int secondOutcome = secondInput % firstInput;


            if (firstOutcome == 0 )
            {
                Console.Write("Number 1 is multiple of number 2");
            }
            else if (secondOutcome == 0)
            {
                Console.Write("Number 2 is multiple of number 1");
            }
            else
            {
                Console.Write("Numbers are no multiples");
            }
        }
    }
}