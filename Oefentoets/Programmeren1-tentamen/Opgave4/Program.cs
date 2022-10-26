namespace Opgave4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int facultyOfRandomValue = 0;
            Random number = new Random();
            bool valueIsZero = false;
            while (!valueIsZero)
            {
                int randomValue = number.Next(10);
                // facultyOfRandomValue = Faculteit(randomValue);
                if (randomValue == 0)
                {
                    valueIsZero = true;
                    Console.Write("\neinde programma");
                }
                else
                {
                    Console.WriteLine($"Faculteit van {randomValue} is {Faculteit(randomValue)}");
                }
            }
        }
        static int Faculteit(int randomValue)
        {
            int facultyOfRandomValue = 1;
            for (int i = 0; i < randomValue; i++)
            {
               facultyOfRandomValue *= (i+1);
            }
            return facultyOfRandomValue;
        }
    }
}