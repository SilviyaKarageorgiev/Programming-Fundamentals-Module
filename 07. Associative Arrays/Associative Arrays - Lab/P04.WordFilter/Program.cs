using System;

namespace P04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.Length % 2 == 0)
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
