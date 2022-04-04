using System;
using System.Collections.Generic;

namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!keyValuePairs.ContainsKey(word.ToLower()))
                {
                    keyValuePairs[word.ToLower()] = 0;
                }
                keyValuePairs[word.ToLower()]++;
            }

            List<string> result = new List<string>();


            foreach (var item in keyValuePairs)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
