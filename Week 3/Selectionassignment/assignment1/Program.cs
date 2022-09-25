using static System.Net.Mime.MediaTypeNames;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input first number
            Console.Write("Enter first number: ");
            int EersteWaarde = int.Parse(Console.ReadLine());

            // input second number
            Console.Write("Enter second number: ");
            int TweedeWaarde = int.Parse(Console.ReadLine());

            // determine value
            if (EersteWaarde > TweedeWaarde)
            {
                
                Console.WriteLine($"\nHighest value is: {EersteWaarde} ");
                Console.WriteLine($"Lowest value is: {TweedeWaarde} ");
                
            }
            else
            {
                
                Console.WriteLine($"\nHighest value is: {TweedeWaarde} ");
                Console.WriteLine($"Lowest value is: {EersteWaarde} ");
            }
        }
    }
}