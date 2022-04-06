using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> top = new List<int>();

            double average = numbers.Sum() / numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    top.Add(numbers[i]);
                    
                }
            }

            top.Sort();
            top.Reverse();

            if (top.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (top.Count > 5)
            {
                Console.WriteLine(string.Join(" ", top.Take(5)));

                //List<int> newList = new List<int>();
                //for (int i = 0; i < 5; i++)
                //{
                //    newList.Add(top[i]);
                //}
                //Console.WriteLine(string.Join(" ", newList));

            }
            else
            {
                Console.WriteLine(string.Join(" ", top));
            }

        }
    }
}
