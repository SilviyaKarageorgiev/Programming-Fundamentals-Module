using System;
using System.Linq;

namespace P08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (arr[i] + arr[j] == number)
                    {

                        int[] uniquePair = {arr[i], arr[j]};
                        Console.WriteLine(String.Join(" ", uniquePair));

                    }
                }
            }

        }
    }
}
