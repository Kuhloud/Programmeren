using System.Globalization;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zet cultuurprogramma
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // lees 3 cijfers
            Console.Write("Enter 1st number: ");
            string FirstNumber = Console.ReadLine();
            double Number1 = double.Parse(FirstNumber); 

            Console.Write("Enter 2nd number: ");
            string SecondNumber = Console.ReadLine();
            double Number2 = double.Parse(SecondNumber);

            Console.Write("Enter 3rd number: ");
            string ThirdNumber = Console.ReadLine();
            double Number3 = double.Parse(ThirdNumber);

            // bereken het gemiddelde
            double Average = (Number1 + Number2 + Number3) / 3;
            Console.WriteLine("The Average is: {0}", Average);

            

        }
    }
}