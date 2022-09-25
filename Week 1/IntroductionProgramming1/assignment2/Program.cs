namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read age of user
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            // convert text to an integer value (int)
            int age = int.Parse(input);

            // now we can perform some (arithmetic) operations on the (int) age
            // (which are not possible on the string value!)
            age++;
            // age += 1 werkt ook (gecontroleerd)
            // age++ werkt ook (gecontroleerd)

            // convert integer value to text
            string output = age.ToString();

            // display the increased age
            Console.WriteLine($"Next year you will be {age} years old");
            // age werkt ook (gecontroleerd)

            // wait for the user to enter a key
            Console.ReadKey();
        }
    }
}