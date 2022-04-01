using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList ();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmd = command.Split();
                if (cmd[0] == "Delete")
                {
                    int item = int.Parse(cmd[1]);
                    numbers.RemoveAll(x => x == item);
                }
                else if (cmd[0] == "Insert")
                {
                    int numToInsert = int.Parse(cmd[1]);
                    int indexToInsert = int.Parse(cmd[2]);
                    numbers.Insert(indexToInsert, numToInsert);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
