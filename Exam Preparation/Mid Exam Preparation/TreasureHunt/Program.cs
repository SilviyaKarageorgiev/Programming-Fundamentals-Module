using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> treasureChest = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                List<string> cmd = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = cmd[0];

                if (command == "Loot")
                {
                    for (int i = 1; i < cmd.Count; i++)
                    {
                        if (treasureChest.Contains(cmd[i]))
                        {
                            continue;
                        }
                        else
                        {
                            treasureChest.Insert(0, cmd[i]);
                        }
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(cmd[1]);
                    if (index < 0 || index >= treasureChest.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    string itemToMove = treasureChest[index];
                    treasureChest.RemoveAt(index);
                    treasureChest.Add(itemToMove);
                }
                else if (command == "Steal")
                {
                    int count = int.Parse(cmd[1]);
                    int startIndex = treasureChest.Count - count;

                    List<string> stolenItems = new List<string>();
                    if (startIndex > 0 && startIndex < treasureChest.Count)
                    {
                        stolenItems.AddRange(treasureChest.TakeLast(count));
                        Console.WriteLine(string.Join(", ", stolenItems));
                        treasureChest.RemoveRange(startIndex, count);
                    }
                    else
                    {
                        stolenItems.AddRange(treasureChest.TakeLast(count));
                        Console.WriteLine(string.Join(", ", stolenItems));
                        treasureChest.Clear();
                    }
                }

                input = Console.ReadLine();
            }

            int sum = 0;
            foreach (var item in treasureChest)
            {
                sum += item.Length;
            }
            double average = sum * 1.0 / treasureChest.Count;

            if (sum == 0)
            {                
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
        }
    }
}
