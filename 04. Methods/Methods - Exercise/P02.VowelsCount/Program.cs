using System;
using System.Linq;

namespace P02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string word = Console.ReadLine();
            Console.WriteLine(VowelsCounter(word));

        }

        static int VowelsCounter (string word)
        {
            int counter = 0;
            word = word.ToLower();
            char[] vowels = new char[] { 'a', 'o', 'u', 'i', 'e' };

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
