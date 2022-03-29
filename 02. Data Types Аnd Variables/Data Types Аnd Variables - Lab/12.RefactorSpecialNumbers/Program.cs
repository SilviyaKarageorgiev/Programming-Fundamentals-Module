using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                int currentNumberSum = 0;

                while (currentNum != 0)
                {
                    currentNumberSum += currentNum % 10;
                    currentNum /= 10;
                }
                bool isSpecial = currentNumberSum == 5 || currentNumberSum == 7 || currentNumberSum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }

        
    }
}
