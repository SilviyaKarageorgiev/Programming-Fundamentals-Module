using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] arr = input.Split();
                string command = arr[0];
                int index = int.Parse(arr[1]);
                int value = int.Parse(arr[2]);

                if (command == "Shoot")
                {
                    if (index < 0 || index >= list.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        list[index] -= value;
                        if (list[index] <= 0)
                        {
                            list.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    if (index < 0 || index >= list.Count)
                    {
                        Console.WriteLine("Invalid placement!");
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        list.Insert(index, value);
                    }
                }
                else if (command == "Strike")
                {
                    int startIndex = index - value;
                    int endIndex = index + value;
                    int removeRange = endIndex - startIndex + 1;
                    if (index < 0 || index >= list.Count || startIndex < 0 || startIndex >= list.Count || endIndex < 0 || endIndex >= list.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        list.RemoveRange(startIndex, removeRange);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", list));
        }
    }
}
