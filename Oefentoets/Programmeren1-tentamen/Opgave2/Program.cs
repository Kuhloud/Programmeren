namespace Opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inputZero = false;
            string asterisk = "*";
            string exclaimationMark = "!";
            string asterisksAndExclaimationMarks = "";
            while (!inputZero)
            {
                asterisksAndExclaimationMarks = "";
                Console.Write("Geef een getal: ");
                int numberInput = int.Parse(Console.ReadLine());
                if (numberInput == 0)
                {
                    inputZero = true;
                    Console.Write("\neinde programma");
                }
                else
                {
                    for (int i = 0; i < numberInput; i++)
                    {
                        if (i < (numberInput / 2))
                        {
                            asterisksAndExclaimationMarks += asterisk;
                        }
                        else
                        {
                            asterisksAndExclaimationMarks += exclaimationMark;
                        }
                    }
                    Console.WriteLine($"{asterisksAndExclaimationMarks}");
                }
            }  

        }
    }
}