﻿using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // set program of culture
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // initialise values
            int consoleWrite = 0;
            double allInputs = 0;
            double valueInput = 1;
            

        // calculate average of positive numbers
           // if input > 0
            do 
            {
                Console.Write("Enter a number: ");
                valueInput = double.Parse(Console.ReadLine());
                if (valueInput > 0)
                {
                    consoleWrite++;
                    allInputs += valueInput;
                }

            } while (valueInput != 0);
            
            // if input = 0
            if (allInputs == 0)
            {
                consoleWrite++;
            }

            // display average
                double avPositiveNum = allInputs / consoleWrite;
            Console.Write($"Average of all positive numbers is: {avPositiveNum:0.00} ");
        }
    }
}