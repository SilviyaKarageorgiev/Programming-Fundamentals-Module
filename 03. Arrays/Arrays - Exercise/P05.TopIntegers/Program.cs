using System;
using System.Linq;

namespace P05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool currentIterationIsBigger = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        currentIterationIsBigger = false;
                    }
                }
                if (currentIterationIsBigger)
                {
                    Console.Write(arr[i] + " ");

                }
            }
            
        }
    }
}
