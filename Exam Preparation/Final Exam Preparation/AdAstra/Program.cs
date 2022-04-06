using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalClories = 0;

            string input = Console.ReadLine();

            string pattern = @"(\||\#)(?<item>[a-zA-Z\s]+)\1(?<expirationDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                totalClories += calories;
            }

            int days = totalClories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                string item = match.Groups["item"].Value;
                string dateExp = match.Groups["expirationDate"].Value;
                string cal = match.Groups["calories"].Value;

                Console.WriteLine($"Item: {item}, Best before: {dateExp}, Nutrition: {cal}");
            }

        }
    }
}
