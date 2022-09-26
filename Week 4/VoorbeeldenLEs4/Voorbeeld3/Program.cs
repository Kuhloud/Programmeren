namespace Voorbeeld3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validgrade = true;

            do 
            {
                Console.WriteLine("Enter a grade: ");
                int grade = int.Parse(Console.ReadLine());
                if (grade < 1 || grade > 10)
                    validgrade = false;

                else
                    validgrade = true;
            }
            while (!validgrade);
            Console.WriteLine("End of program");
        }
    }
}