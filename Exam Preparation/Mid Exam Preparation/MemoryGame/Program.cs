using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();
            int moves = 0;

            while (input != "end")
            {
                int[] indexes = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (indexes[0] < 0 || indexes[1] < 0 || indexes[0] > numbers.Count - 1 || indexes[1] > numbers.Count - 1 || indexes[0] == indexes[1])
                {
                    moves++;
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    numbers.Insert(numbers.Count / 2, $"-{moves}a");
                    numbers.Insert(numbers.Count / 2, $"-{moves}a");
                    input = Console.ReadLine();
                    continue;
                }
                if (numbers[indexes[0]] == numbers[indexes[1]])
                {
                    moves++;
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[indexes[0]]}!");
                    if (indexes[0] < indexes[1])
                    {
                        numbers.RemoveAt(indexes[1]);
                        numbers.RemoveAt(indexes[0]);
                    }
                    else
                    {
                        numbers.RemoveAt(indexes[0]);
                        numbers.RemoveAt(indexes[1]);


                    }
                }
                else if (numbers[indexes[0]] != numbers[indexes[1]])
                {
                    Console.WriteLine("Try again!");
                }
                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
                input = Console.ReadLine();
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", numbers));
            }

        }
    }
}
