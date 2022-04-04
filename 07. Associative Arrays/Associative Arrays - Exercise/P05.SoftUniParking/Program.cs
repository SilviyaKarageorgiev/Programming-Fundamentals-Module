using System;
using System.Collections.Generic;

namespace P05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> data = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArg[0];
                string username = cmdArg[1];
                string plateNumber = string.Empty;

                if (command == "register")
                {
                    plateNumber = cmdArg[2];

                    if (!data.ContainsKey(username))
                    {
                        data[username] = plateNumber;
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {data[username]}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!data.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        data.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
                
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
