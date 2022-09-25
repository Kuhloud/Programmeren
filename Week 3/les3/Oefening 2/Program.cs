using System.Runtime.CompilerServices;

namespace Oefening_2
{
    internal class Program
    {
        const double RaiseRate = 0.05;
        const double Minimum = 75;
        static void Main(string[] args)
        {
            Console.Write("Enter current salary: ");
            double CurrentSalary = double.Parse(Console.ReadLine());
            double raise = CurrentSalary * RaiseRate;
            double NewSalary = CurrentSalary + raise;
            if (raise < Minimum)
            {
               double raise = Minimum;
                Console.WriteLine($"This will be the raise: {raise}\n This will be your new salary: {NewSalary}");
            }
        }
    }
}