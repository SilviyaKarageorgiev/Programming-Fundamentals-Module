using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> firstPlayer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            int sum = 0;

            while (firstPlayer.Count != 0 || secondPlayer.Count != 0)
            {

                if (firstPlayer[0] == secondPlayer[0])
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(firstPlayer[0]);
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                }
                if (firstPlayer.Count == 0)
                {
                    sum = secondPlayer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondPlayer.Count == 0)
                {
                    sum = firstPlayer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
