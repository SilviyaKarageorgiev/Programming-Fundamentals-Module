using System;
using System.Linq;
using System.Text;

namespace P04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            
            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));    
            }
            Console.WriteLine(text);
        }
    }
}
