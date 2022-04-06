using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> journal = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] array = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = array[0];
                string item = array[1];

                if (command == "Collect")
                {
                    if (journal.Contains(item))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        journal.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] items = item.Split(':', StringSplitOptions.RemoveEmptyEntries);
                    string oldItem = items[0];
                    string newItem = items[1];

                    if (journal.Contains(oldItem))
                    {
                        int indexOfNewItem = journal.IndexOf(oldItem) + 1;
                        journal.Insert(indexOfNewItem, newItem);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command == "Renew")
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                        journal.Add(item);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", journal));

        }
    }
}
