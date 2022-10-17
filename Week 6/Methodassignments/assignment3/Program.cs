namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearInput = 1;
            while (yearInput != 0)
            {
                Console.Write("Enter year (0 is stop value): ");
                yearInput = int.Parse(Console.ReadLine());
                if (yearInput < 0)
                {
                    Console.WriteLine("Negative year entered...");
                }
                else
                {
                    if (yearInput != 0 && IsLeapYear(yearInput))
                    {
                        Console.WriteLine($"{yearInput} is a leap year.");
                    }
                    else if (yearInput != 0)
                    {
                        Console.WriteLine($"{yearInput} is not a leap year.");
                    }
                }
            }
                
        }
        static bool IsLeapYear(int yearInput)
        {
            bool leapYear = true;

                if ((yearInput % 4 == 0 && yearInput % 100 == 0 && yearInput % 400 == 0) || (yearInput % 4 == 0 && yearInput % 100 != 0))
                {
                    leapYear = true;
                }
                else if ((yearInput % 4 != 0) || (yearInput % 4 == 0 && yearInput % 100 == 0))
                {
                    leapYear = false;
                }

            return leapYear;
        }
    }
}