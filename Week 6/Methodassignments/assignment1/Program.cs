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
            float price = float.Parse(Console.ReadLine());
            float vatPrice = CalculateVat(price);
            double total = vatPrice + price;
            Console.Write($"price: {price:0.00}, VAT: {vatPrice:0.00}, total: {total:0.00}");
        }


        static float CalculateVat(float price)
        {
            float vatPrice = price * (float)VatRate;

            return vatPrice;
        }
    }
}