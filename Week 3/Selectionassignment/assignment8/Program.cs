namespace assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of working hour: ");
            int workingHour = int.Parse(Console.ReadLine());
            Console.Write("Enter number of years: ");
            int serviceLife = int.Parse(Console.ReadLine());
            Console.Write("Enter number of failures: ");
            int failures = int.Parse(Console.ReadLine());

            if (workingHour > 10000 || serviceLife >= 7 || failures > 25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced");
            }
        }
    }
}