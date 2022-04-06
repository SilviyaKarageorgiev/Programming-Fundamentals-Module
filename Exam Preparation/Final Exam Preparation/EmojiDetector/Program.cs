using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"(\:{2}|\*{2})(?<word>[A-Z][a-z]{2,})\1";

            string text = Console.ReadLine();

            long coolThreshold = 1L;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    coolThreshold *= long.Parse(text[i].ToString());
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");

            MatchCollection matches = Regex.Matches(text, pattern);

            int count = 0;
            List<string> coolEmojies = new List<string>();

            foreach (Match match in matches)
            {
                int coolness = 0;

                string currWord = match.Groups["word"].Value;
                count++;

                for (int j = 0; j < currWord.Length; j++)
                {
                    coolness += currWord[j];
                }
                
                if (coolness >= coolThreshold)
                {
                    coolEmojies.Add(match.Value);
                    coolness = 0;
                }
            }

            Console.WriteLine($"{count} emojis found in the text. The cool ones are:");
            
            foreach (var item in coolEmojies)
            {
                Console.WriteLine(item);
            }

        }
    }
}
