using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            int sumFactorial = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                char currentChar = number[i];
                int currentDigit = (int)currentChar - 48;
                int currentDigitFactorial = 1;
                for (int r = currentDigit; r > 1; r--)
                {
                    currentDigitFactorial *= r;
                }
                sumFactorial += currentDigitFactorial;
            }
            if (sumFactorial == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
