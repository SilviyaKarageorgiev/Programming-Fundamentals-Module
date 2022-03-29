using System;
using System.Linq;

namespace P02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            long biggerNum = 0L;
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                long[] currArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                if (currArr[0] > currArr[1])
                {
                    biggerNum = currArr[0];
                }
                else
                {
                    biggerNum = currArr[1];
                }
                while (biggerNum != 0)
                {                    
                    long digit = 0;
                    digit = biggerNum % 10;
                    sum += digit;
                    biggerNum /= 10;
                }
                Console.WriteLine(Math.Abs(sum));
                sum = 0;
            }

        }
    }
}
