namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nrOfFullStops, nrOfCommas, nrOfSemiColons;
            Console.Write("Enter a text> ");
            string textInput = Console.ReadLine();
            SearchText(textInput, out nrOfFullStops, out nrOfCommas, out nrOfSemiColons);
            Console.Write($"Result: {nrOfFullStops} full stops, {nrOfCommas} commas, {nrOfSemiColons} semi colons");
        }

        static void SearchText(string textInput, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
        {
            nrOfFullStops = 0;
            nrOfCommas = 0;
            nrOfSemiColons = 0;
            foreach (char character in textInput)
            {
                if (character == '.')
                {
                    nrOfFullStops++;
                }
                else if (character == ',')
                {
                    nrOfCommas++;
                }
                else if (character == ';')
                {
                    nrOfSemiColons++;
                }
            }
        }
    }   
}