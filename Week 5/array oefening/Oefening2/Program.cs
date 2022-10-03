namespace Oefening2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] numbers = new int[6];

            for (int i = 0; i < numbers.Length; i++);
            {
                numbers[1] = random.Next(1, 11);
            }
        }
    }
}