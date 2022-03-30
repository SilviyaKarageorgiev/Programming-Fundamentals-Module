using System;
using System.Linq;

namespace P05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
