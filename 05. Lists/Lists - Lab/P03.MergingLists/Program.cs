using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int longerList = Math.Max(numbers1.Count, numbers2.Count);

            List<int> result = new List<int>();

            for (int i = 0; i < longerList; i++)
            {
                if (i < numbers1.Count)
                {
                    result.Add(numbers1[i]);
                }
                if (i < numbers2.Count)
                {
                    result.Add(numbers2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
