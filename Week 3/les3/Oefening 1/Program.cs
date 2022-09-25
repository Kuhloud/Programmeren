namespace Oefening_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double HWaarde, LWaarde;
            Console.Write("Insert number here: ");
            double nummer1 = double.Parse(Console.ReadLine());
            Console.Write("Insert number here: ");
            double nummer2 = double.Parse(Console.ReadLine());

            if (nummer1 > nummer2)
                Console.Write($"Dit is de hoogste waarde: {nummer1}\nDit is de kleinste waarde: {nummer2}");
            else
                Console.Write($"Dit is de hoogste waarde: {nummer2}\nDit is de kleinste waarde: {nummer1}");
        }
    }
}