using Microsoft.VisualBasic.FileIO;

namespace assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input weight, length, and gender
            Console.Write("Enter weight (kg): ");
            double weightInKilograms = double.Parse(Console.ReadLine());
            Console.Write("Enter length (cm): ");
            double lengthInCentimeters = double.Parse(Console.ReadLine());
            Console.Write("Enter gender (male/female): ");
            string biologicalSex = Console.ReadLine();
            double BMI = weightInKilograms / ((lengthInCentimeters / 100) * (lengthInCentimeters / 100));
            Console.WriteLine("");

            // display male healthy weight
            double healthyMaleWeightInKgMin = 20 * (lengthInCentimeters / 100) * (lengthInCentimeters / 100);
            double healthyMaleWeightInKgMax = 25 * (lengthInCentimeters / 100) * (lengthInCentimeters / 100);

            // display female healthy weight
            double healthyFemaleWeightInKgMin = 19 * (lengthInCentimeters / 100) * (lengthInCentimeters / 100);
            double healthyFemaleWeightInKgMax = 24 * (lengthInCentimeters / 100) * (lengthInCentimeters / 100);

            switch(biologicalSex.ToLower())
            {
                case "male":
                    Console.WriteLine($"bmi-value: {BMI:0.0}");
                    Console.WriteLine("normal bmi-values (min .. max): 20..25 ");
                    Console.WriteLine($"healthy weight range: {healthyMaleWeightInKgMin:0.0}..{healthyMaleWeightInKgMax:0.0} ");
                    break;

                case "female":
                    Console.WriteLine($"bmi-value: {BMI:0.0}");
                    Console.WriteLine("normal bmi-values (min .. max): 19..24 ");
                    Console.WriteLine($"healthy weight range: {healthyFemaleWeightInKgMin:0.0}..{healthyFemaleWeightInKgMax:0.0} ");
                    break;
                default:
                    Console.WriteLine("Neck yourself");
                    break;
            }

        }
    }
}