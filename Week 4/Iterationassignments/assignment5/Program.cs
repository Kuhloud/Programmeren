namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialise value
            int yearInput = 0;
            int programEnd = 1;
            do 
            {
                Console.Write("Enter a year: ");
                yearInput = int.Parse(Console.ReadLine());
                if (yearInput == 0)
                {
                    programEnd = 0;
                }
                else if ((yearInput % 4 == 0 && yearInput % 100 == 0 && yearInput % 400 == 0) || (yearInput % 4 == 0 && yearInput % 100 != 0))
                {
                    Console.WriteLine($"{yearInput} is a leap year.");
                }
                else if ((yearInput % 4 != 0) || (yearInput % 4 == 0 && yearInput % 100 == 0))
                {
                    Console.WriteLine($"{yearInput} is not a leap year.");                   
                } 
                else if (yearInput < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }
            } while (programEnd != 0);
        } 
    }
}