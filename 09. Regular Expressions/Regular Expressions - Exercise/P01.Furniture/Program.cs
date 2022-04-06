using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @">{2}(?<item>[A-Za-z]+)<{2}(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

            List<string> items = new List<string>();
            decimal total = 0;
            string input;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string item = match.Groups["item"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    items.Add(item);
                    total += price * quantity;
                }

            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
