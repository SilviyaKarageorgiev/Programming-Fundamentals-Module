using System;
using System.Collections.Generic;

namespace P04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();

                list.Add(item);
            }
            list.Sort();

            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine($"{j}.{list[j - 1]}");
            }

        }
    }
}
