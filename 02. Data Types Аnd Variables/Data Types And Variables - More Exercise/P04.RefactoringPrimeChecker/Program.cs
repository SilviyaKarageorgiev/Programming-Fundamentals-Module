using System;

namespace P04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int cepitel = 2; cepitel < i; cepitel++)
                {
                    if (i % cepitel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{i} -> true");

                }
                else
                {
                    Console.WriteLine($"{i} -> false");

                }
            }

        }
    }
}
