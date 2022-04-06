using System;
using System.Text.RegularExpressions;

namespace P02.MessageDecrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"^([$%]{1})(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>[0-9]+)\]\|\[(?<second>[0-9]+)\]\|\[(?<third>[0-9]+)\]\|$";

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string tag = match.Groups["tag"].Value;
                    int first = int.Parse(match.Groups["first"].Value);
                    int second = int.Parse(match.Groups["second"].Value);
                    int third = int.Parse(match.Groups["third"].Value);

                    char one = (char)first;
                    char two = (char)second;
                    char three = (char)third;

                    //string decryptedMessage = 
                    Console.WriteLine($"{tag}: {one.ToString()}{two.ToString()}{three.ToString()}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }

            }

        }
    }
}
