using System.Globalization;
using System.Transactions;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zet cultuurprogramma
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            // read the number of seconds
            Console.Write("Enter number of seconds: ");


            // input seconds
            int seconden = int.Parse(Console.ReadLine());


            // define hours
            int uren = seconden / 3600;
            int urenrest = seconden % 3600;
            // 2 hours, 100 seconds

            // define minutes, and seconds
            int minuten = urenrest / 60;
            int minutenrest = urenrest % 60;
            // 2 hours 1 minute, 40 seconds


            // geef digitale tijd aan
            Console.WriteLine($"{uren:00}:{minuten:00}:{minutenrest:00}");

            
            
        }
    }
}