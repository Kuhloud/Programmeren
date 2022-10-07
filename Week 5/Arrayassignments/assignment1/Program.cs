namespace assignment1
{
    internal class Program
    {
        const int FixedAmountOfElements = 20;
        static void Main(string[] args)
        {
            int[] element = new int[FixedAmountOfElements];
            int consoleWriteLine = 0;
            int elementSum = 0;

            for (int i = 0; i < element.Length; i++)
            {
                consoleWriteLine++;
                element[i] = new Random().Next(0, 200);
                Console.WriteLine($"Element {i} is {element[i]}");
                elementSum += element[i];
            }
            double average = (double)elementSum / consoleWriteLine;
            Console.WriteLine($"\nThe Average is {average:0.00}\n");
            for (int i = 0; i < element.Length; i++)
            {
                if (average <= element[i])
                {
                    double difference = (double)element[i] - average;
                    Console.WriteLine($"Difference between average and element {i} is {difference:0.00}");
                }
                else if (average >= element[i])
                {
                    double difference = average - (double)element[i];
                    Console.WriteLine($"Difference between average and element {i} is {difference:0.00}");
                }
            }






        }
    }
}