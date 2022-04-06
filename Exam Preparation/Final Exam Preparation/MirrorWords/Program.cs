using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([@#])(?<wordOne>[a-zA-Z]{3,})\1\1(?<wordTwo>[a-zA-Z]{3,})\1";

            Dictionary<string, string> map = new Dictionary<string, string>();
            int validPairsCount = 0;

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    validPairsCount++;

                    //string currMatch = match.Value;
                    //string wordOne = currMatch.Substring(0, currMatch.Length / 2);
                    //string wordTwo = currMatch.Substring(currMatch.Length / 2);
                    //string wordTwoReversed = string.Join("", wordTwo.Reverse());

                    string wordOne = match.Groups["wordOne"].Value;
                    string wordTwo = match.Groups["wordTwo"].Value;
                    string wordTwoReversed = string.Join("", wordTwo.Reverse());

                    if (wordOne.CompareTo(wordTwoReversed) == 0)
                    {
                        map.Add(wordOne, wordTwo);
                    }
                }
            }
            if (validPairsCount != 0)
            {
                Console.WriteLine($"{validPairsCount} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            if (map.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                List<string> listForPrint = new List<string>();
                foreach (var item in map)
                {
                    listForPrint.Add($"{item.Key} <=> {item.Value}");
                }
                Console.WriteLine(string.Join(", ", listForPrint));

            }
        }
    }
}
