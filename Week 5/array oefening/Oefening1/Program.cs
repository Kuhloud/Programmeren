using System.Xml.Schema;

namespace Oefening1
{
    internal class Program
    {
        const int MonthsInAYear = 12;
        static void Main(string[] args)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int[] profit = new int[MonthsInAYear];

            int total = 0;
            for (int i = 0; i < profit.Length; i++)
            {
                Console.Write($"Enter profit for {months[i]}: ");
                profit[i] = int.Parse(Console.ReadLine());
                total += profit[i];  
            }
             double average = total / profit.Length;

            for (int i = 0; i < profit.Length; i++)
            {
                if (profit[i] > average)
                {
                    string result = months[i];
                    Console.WriteLine($"{result}. {profit[i]}.");
                }
            }
        }
    }
}