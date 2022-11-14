using System.Globalization;

namespace Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            double collegeMoney = 0;
            Console.Write("Geef je naam: ");
            string inputNameOfPerson = Console.ReadLine();
            Console.Write($"{inputNameOfPerson}, is dit je eerste bachelor opleiding? ");
            string inputFirstTimeStudying = Console.ReadLine();
            if (inputFirstTimeStudying == "nee")
            {
                collegeMoney = 2209.00;
                Console.Write($"\nhet collegegeld voor dit collegejaar is volledig ({collegeMoney:0.00} euro)");
            }
            else if (inputFirstTimeStudying == "ja")
            {
                collegeMoney = 1104.50;
                Console.Write("is het een lerarenopleiding? ");
                string teacherStudy = Console.ReadLine();
                if (teacherStudy == "nee")
                {

                    Console.Write($"\nhet collegegeld voor dit collegejaar is de helft ({collegeMoney:0.00}), daarna volledig");
                }
                else if (teacherStudy == "ja")
                {
                    Console.Write($"\nhet collegegeld voor dit collegejaar is de helft ({collegeMoney:0.00}), en volgend jaar ook de helft");
                }              
            }
        }
    }
}