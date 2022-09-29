namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int FirstNumber = int.Parse(Console.ReadLine());
           
            Console.Write("Enter second number: ");
            int SecondNumber = int.Parse(Console.ReadLine());
           
            Console.Write("Enter third number: ");
            int ThirdNumber = int.Parse(Console.ReadLine());

            if (ThirdNumber < FirstNumber && ThirdNumber < SecondNumber)
            {
                Console.Write("The third number is the smallest of the three");
            }
            else
            {
                Console.Write("The third number is not the smallest of the three");

            }
        }
        
    }
}