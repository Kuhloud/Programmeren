namespace ConsoleApp_lesson2_example
{
    internal class Program
    {
        const double Gravity = 9.81;
        static void Main(string[] args)
        {
            // 1. Read the mass of the object in kg
            Console.Write("Mass of object in kilograms: ");
            string input = Console.ReadLine();
            double MassInKg = double.Parse(input); 
            
            // 2. Calculate the force in Newton on earth
            double ForceOnEarthInNewton = MassInKg * Gravity;

            // 3. Display the force
            Console.WriteLine("The Force on Earth in Newton is: {0} Newton", ForceOnEarthInNewton);
        }
    }
}