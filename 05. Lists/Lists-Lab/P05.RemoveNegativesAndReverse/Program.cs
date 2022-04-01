using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList ();

            list.RemoveAll (x => x < 0);
            list.Reverse ();

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
            Console.WriteLine(string.Join(" ", list));
            }

        }
    }
}
