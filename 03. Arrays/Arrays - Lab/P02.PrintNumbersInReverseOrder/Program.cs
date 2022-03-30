using System;

namespace P02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];
            for (int j = 0; j < num.Length; j++)
            {
                num[j] = int.Parse(Console.ReadLine());
            }

            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write($"{num[i]} ");
            }
        }
    }
}
