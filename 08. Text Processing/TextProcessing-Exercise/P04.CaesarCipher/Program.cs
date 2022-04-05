using System;

namespace P04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string encrypted = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                encrypted += (char)(text[i] + 3);
            }
            Console.WriteLine(encrypted);
        }
    }
}
