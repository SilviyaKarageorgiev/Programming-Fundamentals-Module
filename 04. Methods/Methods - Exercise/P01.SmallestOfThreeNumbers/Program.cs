using System;

namespace P01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            PrintSmallestNumber(first, second, third);
        }

        static void PrintSmallestNumber(int a, int b, int c)
        {
            int minNumber = Math.Min(Math.Min(a, b), c);
            Console.WriteLine(minNumber);
        }
    }
}
