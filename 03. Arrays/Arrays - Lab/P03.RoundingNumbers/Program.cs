using System;
using System.Linq;

namespace P03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine($"{(decimal)numbers[i]} => {Math.Round((decimal)numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
