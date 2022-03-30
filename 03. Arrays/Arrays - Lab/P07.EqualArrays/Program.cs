using System;
using System.Linq;

namespace P07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool isEqual = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isEqual = true;
                    break;
                }
               
            }
            if (!isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}
