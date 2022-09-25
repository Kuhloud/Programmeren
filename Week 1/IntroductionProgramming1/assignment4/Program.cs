namespace assignment4
{
    Internal class Program
    {
        static void Main(string[] args)
        {
            // read a number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            // (f10) number = 18

            // assign variable 'result' the result of 'number + number'
            int result = number + number;
            // (f10) result = 36

            // add 10 to result
            result = result + 10;
            // (f10) result = 46

            // divide result by 2 (use /= operator)
            result = result /= 2;
            // (f10) result = 23

            // subtract original number from result ( use -= operator)
            result -= number;
            // (f10) result = 5 
            Console.WriteLine($"result is {result}");

            // wait for user to input
            Console.ReadKey();
        }
    }
}