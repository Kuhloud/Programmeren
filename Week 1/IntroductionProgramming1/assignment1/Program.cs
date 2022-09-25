using System;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let user input name 
            Console.Write("Enter your name: ");

            // variable 'name' is declared here
            string name;

            // read the name of the user and save it in variable 'name'
            name = Console.ReadLine();

            // let user input age
            Console.Write("Enter your age: ");

            // read the age of the user and save it in variable 'age'
            // (variable 'age' is declared here and immediately given a value)
            string age = Console.ReadLine();

            // display name and age
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
            // Console.Write(); zet ze naast elkaar, zonder spatie (gecontroleerd)
            
            // wait for the user to enter a key
            Console.ReadKey();
            // Console.Writeline(); doet niks (gecontroleerd)

        }
    }
}