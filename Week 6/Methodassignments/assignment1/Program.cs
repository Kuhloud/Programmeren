using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        const double VatRate = 0.21;
        static void Main(string[] args)
        {
            // set program of culture
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;


            Console.Write("Enter a price: ");
            double price = double.Parse(Console.ReadLine());
            float vatPrice = VatAndTotal(VatRate, price);
            double total = vatPrice + price;
            Console.Write($"price: {price:0.00}, VAT: {vatPrice:0.00}, total: {total:0.00}");
        }


        static float VatAndTotal(double VatRate, double price)
        {
            float vatPrice = (float)price * (float)VatRate;

            return vatPrice;
        }
    }
}