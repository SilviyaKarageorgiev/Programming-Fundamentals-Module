using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ |-])2\1[0-9]{3}\1[0-9]{4}\b";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);
            var phoneMatches = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", phoneMatches));

        }
    }
}
