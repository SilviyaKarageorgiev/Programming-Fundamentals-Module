using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                var currList = list[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in currList)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
