using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int travelPoits = 0;
            List<string> travelStops = new List<string>();
            string input = Console.ReadLine();
            string pattern = @"([=/])(?<point>[A-Z][a-zA-Z]{2,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                travelPoits += match.Groups["point"].Value.Length;
                travelStops.Add(match.Groups["point"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", travelStops)}");
            Console.WriteLine($"Travel Points: {travelPoits}");
        }
    }
}
