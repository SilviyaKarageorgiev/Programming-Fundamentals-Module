using System;

namespace P02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string first = input[0];
            string second = input[1];

            string longer = string.Empty;
            string shorter = string.Empty;
            int sum = 0;

            if (first.CompareTo(second) > 0)
            {
                longer = second;
                shorter = first;
            }
            else
            {
                longer = first;
                shorter = second;
            }

            for (int i = 0; i < shorter.Length; i++)
            {
                sum += longer[i] * shorter[i];
            }

            for (int j = shorter.Length; j < longer.Length; j++)
            {
                sum += longer[j];
            }
            Console.WriteLine(sum);
        }
    }
}
