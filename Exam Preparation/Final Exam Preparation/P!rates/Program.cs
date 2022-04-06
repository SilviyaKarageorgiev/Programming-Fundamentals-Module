using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , List<int>> data = new Dictionary<string , List<int>>();
            string input;

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] parts = input.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string town = parts[0];
                int gold = int.Parse(parts[1]);
                int population = int.Parse(parts[2]);

                if (!data.ContainsKey(town))
                {
                    data[town] = new List<int>();
                    data[town].Add(population);
                    data[town].Add(gold);
                }
                else
                {
                    data[town][0] += population;
                    data[town][1] += gold;
                }
            }

            string cmd;

            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = cmd.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];

                if (command == "Plunder")
                {
                    string town = cmdArgs[1];
                    int people = int.Parse(cmdArgs[2]);
                    int gold = int.Parse(cmdArgs[3]);

                    data[town][1] -= people;
                    data[town][0] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (data[town][1] <= 0 || data[town][0] <= 0)
                    {
                        data.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }

                else if (command == "Prosper")
                {
                    string town = cmdArgs[1];
                    int gold = int.Parse(cmdArgs[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        data[town][0] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {data[town][0]} gold.");
                    }
                }
            }

            if (data.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {data.Count} wealthy settlements to go to:");
            }
            
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> Population: {item.Value[1]} citizens, Gold: {item.Value[0]} kg");
            }
        }
    }
}
