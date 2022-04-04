using System;
using System.Collections.Generic;

namespace P01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (!map.ContainsKey(item[i]))
                    {
                        map[item[i]] = 0;
                    }
                    map[item[i]]++;
                }
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
