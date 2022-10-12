﻿namespace assignment4
{
    internal class Program
    {
        const int MaxInputs = 20;
        static void Main(string[] args)
        {
            // initialize values
            int consoleWrites = 0;
            int searchValue = 0;

            // initialize array
            int[] allInputs = new int[MaxInputs];

            // display 20 numbers
            for (int i = 0; i < allInputs.Length; i++)
                {
                    Console.Write("Enter a number (0=stop): ");
                    allInputs[i] = int.Parse(Console.ReadLine());
                if (allInputs[i] == 0)
                    {
                    break;
                    }  
                }
            Console.Write("\nEnter a searchvalue: ");
            searchValue = int.Parse(Console.ReadLine());
            for (int i = 0; i < allInputs.Length; i++)
                if (searchValue == allInputs[i])
                {
                    consoleWrites++;
                }
            Console.Write($"Number of occurences of searchvalue ({searchValue}) is: {consoleWrites}");
        }
    }
}