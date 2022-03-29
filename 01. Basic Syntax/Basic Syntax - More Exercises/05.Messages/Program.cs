using System;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());
            string word = string.Empty;


            for (int i = 1; i <= number; i++)
            {
                string text = Console.ReadLine();
                int currentNumber = int.Parse(text);
                int mainDigit = currentNumber % 10;

                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                offset = offset + (text.Length - 1) + 97;
                char letter = (char)offset;
                if (text == "0")
                {
                    word += " ";
                }
                else
                {
                    word += letter;
                }

            }
            Console.WriteLine(word);
        }
    }
}
