using System;
using System.Numerics;

namespace P08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            DivideFirstToSecond(CalculateFactorial(first), CalculateFactorial(second));            
        }

        static BigInteger CalculateFactorial(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static void DivideFirstToSecond(BigInteger first, BigInteger second)
        {
            decimal result = (decimal)first / (decimal)second;
            Console.WriteLine($"{result:f2}");
        }
    }
}
