using System;
using System.Text.RegularExpressions;

namespace P03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^%$|.]*?\<(?<product>\w+)\>[^%$|.]*?\|(?<count>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)\$";

            decimal totalIncome = 0m;
            string input;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal total = count * price;
                    totalIncome += total;

                    Console.WriteLine($"{name}: {product} - {total:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
