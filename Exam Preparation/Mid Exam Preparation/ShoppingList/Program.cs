using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                List<string> command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (command[0] == "Urgent")
                {
                    if (list.Contains(command[1]))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    list.Insert(0, command[1]);
                }
                else if (command[0] == "Unnecessary")
                {
                    if (list.Contains(command[1]))
                    {
                        list.Remove(command[1]);

                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command[0] == "Correct")
                {
                    if (list.Contains(command[1]))
                    {
                        list.Insert(list.IndexOf(command[1]), command[2]);
                        list.Remove(command[1]);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (list.Contains(command[1]))
                    {
                        string item = command[1];
                        list.Remove(command[1]);
                        list.Add(item);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
