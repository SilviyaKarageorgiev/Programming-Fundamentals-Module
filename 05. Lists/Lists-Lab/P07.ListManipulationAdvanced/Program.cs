using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            int counter = 0;

            while (command != "end")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (cmd[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(cmd[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (cmd[0] == "PrintEven")
                {
                    List<int> evenList = new List<int>();
                    evenList.AddRange(numbers);
                    evenList.RemoveAll(item => item % 2 != 0);
                    Console.WriteLine(string.Join(" ", evenList));
                }
                else if (cmd[0] == "PrintOdd")
                {
                    List<int> oddList = new List<int>();
                    oddList.AddRange(numbers);
                    oddList.RemoveAll(item => item % 2 == 0);
                    Console.WriteLine(string.Join(" ", oddList));
                }
                else if (cmd[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (cmd[0] == "Filter")
                {
                    int filterNum = int.Parse(cmd[2]);
                    List<int> filterList = new List<int>();

                    if (cmd[1] == "<")
                    {
                        filterList = numbers.FindAll(item => item < filterNum);
                        Console.WriteLine(string.Join(" ", filterList));
                    }
                    if (cmd[1] == ">")
                    {
                        filterList = numbers.FindAll(item => item > filterNum);
                        Console.WriteLine(string.Join(" ", filterList));
                    }
                    if (cmd[1] == "<=")
                    {
                        filterList = numbers.FindAll(item => item <= filterNum);
                        Console.WriteLine(string.Join(" ", filterList));
                    }
                    if (cmd[1] == ">=")
                    {
                        filterList = numbers.FindAll(item => item >= filterNum);
                        Console.WriteLine(string.Join(" ", filterList));
                    }
                }
                else if (cmd[0] == "Add")
                {
                    numbers.Add(int.Parse(cmd[1]));
                    counter++;
                }
                else if (cmd[0] == "Remove")
                {
                    numbers.Remove(int.Parse(cmd[1]));
                    counter++;
                }
                else if (cmd[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(cmd[1]));
                    counter++;
                }
                else if (cmd[0] == "Insert")
                {
                    numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                    counter++;
                }

                command = Console.ReadLine();
            }
            if (counter > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
