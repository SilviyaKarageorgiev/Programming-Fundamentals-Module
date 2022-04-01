using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmd[0] == "Add")
                {
                    list.Add(int.Parse(cmd[1]));
                }
                else if (cmd[0] == "Insert")
                {
                    int numberToInsert = int.Parse(cmd[1]);
                    int indexToInsert = int.Parse(cmd[2]);
                    if (indexToInsert >= list.Count || indexToInsert < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                    list.Insert(indexToInsert, numberToInsert);
                    }

                }
                else if (cmd[0] == "Remove")
                {
                    int indexToRemove = int.Parse(cmd[1]);
                    if (indexToRemove >= list.Count || indexToRemove < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                    list.RemoveAt(indexToRemove);
                    }
                }
                else if (cmd[0] == "Shift")
                {
                    int count = int.Parse(cmd[2]);
                    if (cmd[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = list[0];
                            list.Add(firstNum);
                            list.RemoveAt(0);
                        }

                    }
                    else if (cmd[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                        int lastNum = list[list.Count - 1];
                        list.Insert(0, lastNum);
                        list.RemoveAt(list.Count - 1);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
