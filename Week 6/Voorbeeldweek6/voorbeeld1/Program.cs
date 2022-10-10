namespace voorbeeld1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        

        static int Add(int getal1, int getal2)
        {
            return getal1 + getal2;
        }


        static int Add(int getal1, int getal2, int getal3)
        {
            return getal1 + getal2 + getal3;
        }


        static int Add(int[] getallen)
        {
            int sum = 0;
            for(int i = 0; i < getallen.Length; i++)
            {
                sum += getallen[i];
            }
            return sum;
        }
    }
}