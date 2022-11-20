using System.Globalization;

namespace Opgave1
{
    internal class Program
    {
        const double FullCollegePrice = 2209.00;
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
            if (inputFirstTimeStudying == "ja")
            {
                double halfCollegePrice = FullCollegePrice / 2;
                Console.Write("is het een lerarenopleiding? ");
                string teacherStudy = Console.ReadLine();
                if (teacherStudy == "ja")
                {
                    Console.Write($"\nhet collegegeld voor dit collegejaar is de helft ({halfCollegePrice:0.00}), en volgend jaar ook de helft");
                }
                else
                {
                    Console.Write($"\nhet collegegeld voor dit collegejaar is de helft ({halfCollegePrice:0.00}), daarna volledig");
                }


                else
            {
                Console.Write($"\nhet collegegeld voor dit collegejaar is volledig ({FullCollegePrice:0.00} euro)");
            }
           
            }
        }
    }
}