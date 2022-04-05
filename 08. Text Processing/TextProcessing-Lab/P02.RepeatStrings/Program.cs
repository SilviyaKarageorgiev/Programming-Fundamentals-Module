using System;
using System.Text;

namespace P02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string currWord = input[i];

                for (int j = 0; j < currWord.Length; j++)
                {
                    sb.Append(currWord);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
