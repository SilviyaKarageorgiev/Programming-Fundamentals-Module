using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmd = command.Split();
                if (cmd[0] == "Add")
                {
                    wagons.Add(int.Parse(cmd[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passengers = int.Parse(cmd[0]);
                        if (passengers <= (capacity - wagons[i]))
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));          

        }
    }
}
