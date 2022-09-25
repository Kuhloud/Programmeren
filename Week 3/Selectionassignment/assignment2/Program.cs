namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1..4): ");
            int number = int.Parse(Console.ReadLine());
            string result = "";
            switch (number)
            {
                case 1:
                    result = "clubs";
                    break;
                case 2:
                    result = "diamonds";
                    break;
                case 3:
                    result = "hearts";
                    break;
                case 4:
                    result = "spades";
                    break;
                default:
                    result = "Incorrect number!";
                    break;


            }
            Console.WriteLine(result);
        }

    }
}
