using System;

namespace P05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char[] text = Console.ReadLine().ToCharArray();

            string digits = string.Empty;
            string letters = string.Empty;
            string chars = string.Empty;

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else
                {
                    chars += symbol;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(chars);

        }
    }
}
