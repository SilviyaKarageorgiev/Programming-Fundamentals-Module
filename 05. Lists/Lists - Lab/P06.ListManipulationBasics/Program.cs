using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (cmd[0] == "Add")
                {
                    numbers.Add(int.Parse(cmd[1]));
                }
                else if (cmd[0] == "Remove")
                {
                    numbers.Remove(int.Parse(cmd[1]));
                }
                else if (cmd[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(cmd[1]));
                }
                else if (cmd[0] == "Insert")
                {
                    numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
