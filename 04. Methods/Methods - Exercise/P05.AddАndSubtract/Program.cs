using System;

namespace P05.AddАndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(SubstractThirdFromSumOfFirstAndSecond(SumOfFistAndSecond(first, second), third));

        }

        static int SumOfFistAndSecond(int first, int second)
        {
            int result = first + second;
            return result;
        }

        static int SubstractThirdFromSumOfFirstAndSecond(int sum, int third)
        {
            int finalResult = sum - third;
            return finalResult;
        }

    }
}
