namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lees 4 willekeurige getallen
            Console.WriteLine("Here are 4 random numbers ");

            
            // kies 4 willekeurige getallen
            Random rnd = new Random();
            int getal1 = rnd.Next(101, 10000);
            int getal2 = rnd.Next(101, 10000);
            int getal3 = rnd.Next(101, 10000);
            int getal4 = rnd.Next(101, 10000);
            


            // lees de 4 getallen op
            Console.WriteLine("Add up the 4 numbers:");
            string input = Console.ReadLine();


            // wijs variabel 'FinalAnswer'
            int FinalAnswer = getal1 + getal2 + getal3 + getal4;
            Console.WriteLine($"The final result is: {FinalAnswer}");

            // wacht for user input
            Console.ReadKey();





        }
    }
}