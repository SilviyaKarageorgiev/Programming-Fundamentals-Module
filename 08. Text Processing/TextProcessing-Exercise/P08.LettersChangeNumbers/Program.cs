using System;

namespace P08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;

            foreach (var item in input)
            {
                sum += CalculateItemSum(item);
            }

            Console.WriteLine($"{sum:f2}");


        }

        static decimal CalculateItemSum(string item)
        {
            decimal sum = 0;

            char firstLetter = item[0];
            char lastLetter = item[item.Length - 1];
            int num = int.Parse(item.Substring(1, item.Length - 2));

            int firstLetterPosition = AlphabetPosition(firstLetter);
            int lastLetterPosition = AlphabetPosition(lastLetter);

            if (char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPosition;
            }
            else if (char.IsLower(firstLetter)) 
            {
                sum = (decimal)num * firstLetterPosition;
            }

            if (char.IsUpper(lastLetter))
            {
                sum -= lastLetterPosition;
            }
            else if (char.IsLower(lastLetter))
            {
                sum += lastLetterPosition;
            }

            return sum;

        }
        
        static int AlphabetPosition(char ch)
        {
            ch = char.ToLower(ch);
            return (int)ch - 96;
        }
    }
}
