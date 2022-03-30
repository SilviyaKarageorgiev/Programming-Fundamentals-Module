using System;
using System.Linq;

namespace P03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arrOne[i] = currArray[0];
                    arrTwo[i] = currArray[1];
                }
                else
                {
                    arrOne[i] = currArray[1];
                    arrTwo[i] = currArray[0];
                }
            }
            Console.WriteLine(String.Join(" ", arrOne));
            Console.WriteLine(String.Join(" ", arrTwo));
        }
    }
}
