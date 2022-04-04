using System;
using System.Collections.Generic;

namespace P02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, long> map = new Dictionary<string, long>();
            string input;

            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!map.ContainsKey(input))
                {
                    map[input] = 0;
                }
                map[input] += quantity;

            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
