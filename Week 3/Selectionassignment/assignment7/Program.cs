using Microsoft.VisualBasic.FileIO;

namespace assignment7
{
    internal class Program
    {
        const int BMIMaleWeightInKgMin = 20;
        const int BMIMaleWeightInKgMax = 25;
        const int BMIFemaleWeightInKgMin = 19;
        const int BMIFemaleWeightInKgMax = 24;
        const int CentimetersInMeters = 100;
        static void Main(string[] args)
        {
            // input weight, length, and gender
            Console.Write("Enter weight (kg): ");
            double weightInKilograms = double.Parse(Console.ReadLine());
            Console.Write("Enter length (cm): ");
            double lengthInCentimeters = double.Parse(Console.ReadLine());
            Console.Write("Enter gender (male/female): ");
            string biologicalSex = Console.ReadLine();
            double BMI = weightInKilograms / Math.Pow((double)lengthInCentimeters / CentimetersInMeters, 2);
            Console.WriteLine("");

            // display male healthy weight
            double healthyMaleWeightInKgMin = BMIMaleWeightInKgMin * Math.Pow((double)lengthInCentimeters / CentimetersInMeters, 2);
            double healthyMaleWeightInKgMax = BMIMaleWeightInKgMax * Math.Pow((double)lengthInCentimeters / CentimetersInMeters, 2);

            // display female healthy weight
            double healthyFemaleWeightInKgMin = BMIFemaleWeightInKgMin * Math.Pow((double)lengthInCentimeters / CentimetersInMeters, 2);
            double healthyFemaleWeightInKgMax = BMIFemaleWeightInKgMax * Math.Pow((double)lengthInCentimeters / CentimetersInMeters, 2);

            if (biologicalSex.ToLower() == "male")
            {
                Console.WriteLine($"bmi-value: {BMI:0.0}");
                Console.WriteLine("normal bmi-values (min .. max): 20..25 ");
                Console.WriteLine($"healthy weight range: {healthyMaleWeightInKgMin:0.0}..{healthyMaleWeightInKgMax:0.0} ");
            }
            else if (biologicalSex.ToLower() == "female")
            { 
            Console.WriteLine($"bmi-value: {BMI:0.0}");
            Console.WriteLine("normal bmi-values (min .. max): 19..24 ");
            Console.WriteLine($"healthy weight range: {healthyFemaleWeightInKgMin:0.0}..{healthyFemaleWeightInKgMax:0.0} ");
            }   
            else
            {
                Console.WriteLine("Neck yourself");
            }

        }
    }
}