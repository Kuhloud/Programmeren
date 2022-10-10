namespace assignment5
{
    internal class Program
    {
        const int MaxInputs = 10;
        static void Main(string[] args)
        {
            int[] allAgeInputs = new int[MaxInputs];
            for (int i = 0; i < allAgeInputs.Length; i++)
            {
                Console.Write("Enter age (0=stop): ");
                allAgeInputs[i] = int.Parse(Console.ReadLine());
                if (allAgeInputs[i] == 0)
                {
                    break;
                }
            }
            Console.Write("PRESCHOOLERS");
            for (int i = 0; i < allAgeInputs.Length; i++)
            { 
                
            }

        }
    }
}