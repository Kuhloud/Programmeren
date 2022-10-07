namespace assignment2
{
    internal class Program
    {
        const int FixedAmountOfElements = 20;
        const int MaximumValue = 149;
        const int MinimumValue = 0;
        static void Main(string[] args)
        {
            int[] element = new int[FixedAmountOfElements]; // initialize array
            for (int i = 0; i < element.Length; i++)
            {
                element[i] = new Random().Next(MinimumValue, MaximumValue); // randomize from 0 to 149
                Console.WriteLine($"Element {i} = {element[i]}");
            }
            int minimum = element[0];
            for (int i = 0; i < element.Length; i++) // find minimum value
            {
                if (element[i] < minimum)
                {
                    minimum = element[i];
                }

            }
            int lowestValueCount = 0; // calculate occurence of minimum value
            for (int i = 0; i < element.Length; i++)
            {
                if (element[i] == minimum)
                {
                    lowestValueCount++;
                }
            }
            // display outputs
            Console.WriteLine($"\nSmallest number = {minimum}");
            Console.WriteLine($"Number of occurence = {lowestValueCount}");
        }  
    }
}