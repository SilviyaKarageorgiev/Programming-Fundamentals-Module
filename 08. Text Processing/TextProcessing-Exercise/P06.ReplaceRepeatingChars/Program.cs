using System;

namespace P06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {                    
                    text = text.Remove(i, 1);
                    i -= 1;
                }
            }
            Console.WriteLine(text);
        }
    }
}
