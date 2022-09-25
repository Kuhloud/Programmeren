namespace voorbeeld1
{
    internal class Program
    {
        const int PassLimit = 55;
        static void Main(string[] args)
        {
            Console.WriteLine("What is your grade? ");
            int grade = int.Parse(Console.ReadLine());

            if (grade < PassLimit)
            {
                Console.WriteLine("Absolute Retard");
            }
            else if (grade < 80) 
                {
                    Console.WriteLine("ok");
                }
                else
                {
                    Console.WriteLine("INCREDIBLY EPIC");
                }
            }
        }

    }

