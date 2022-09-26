namespace Voorbeeld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validgrade = false;

            while (!validgrade)
            {
                Console.WriteLine("Enter a grade: ");
                int grade = int.Parse(Console.ReadLine());
                if (grade >= 1 && grade <= 10)
                    validgrade = true;
            }
            Console.WriteLine("End of program");
            

        }
    }
}