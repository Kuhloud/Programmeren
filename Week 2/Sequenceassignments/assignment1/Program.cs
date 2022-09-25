using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zet cultuurprogramma
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // zet constant
            const double VatRate = 0.21;

            // Lees de prijs
            Console.Write("Enter the price: ");
            

            // initialiseer prijs
            double Price = double.Parse(Console.ReadLine());

            // Bereken de vat en VatPrice
            double vat = Price * VatRate;
            double VatPrice = Price + vat;

            // Geef de prijs en vat
            Console.WriteLine($"Price: {Price:0.00}, VAT: {vat:0.00}, total: {VatPrice:0.00} ");

           
        }
    }
}