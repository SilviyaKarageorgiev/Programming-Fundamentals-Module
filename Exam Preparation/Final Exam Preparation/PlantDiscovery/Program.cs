using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> dataRarity = new Dictionary<string, string>();
            Dictionary<string, List<double>> dataRaiting = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputRarity = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string plant = inputRarity[0];
                string rarity = inputRarity[1];

                if (!dataRarity.ContainsKey(plant))
                {
                    dataRarity[plant] = "";

                }
                dataRarity[plant] = rarity;
            }

            string input;
            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = input.Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];
                string[] arguments = cmdArgs[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string plant = arguments[0];

                if (command == "Rate")
                {
                    double raiting = double.Parse(arguments[1]);
                    if (!dataRarity.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    if (!dataRaiting.ContainsKey(plant))
                    {
                        dataRaiting[plant] = new List<double>();
                    }
                    dataRaiting[plant].Add(raiting);

                }
                else if (command == "Update")
                {
                    string newRarity = arguments[1];
                    if (dataRarity.ContainsKey(plant))
                    {
                        dataRarity[plant] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        
                    }
                }
                else if (command == "Reset")
                {
                    if (dataRaiting.ContainsKey(plant))
                    {
                        dataRaiting[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                        
                    }
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in dataRarity)
            {
                string plantName = item.Key;
                string plantRarity = item.Value;
                double averageRating = 0;

                if (dataRaiting.ContainsKey(plantName) && dataRaiting[plantName].Any())
                {
                    averageRating = dataRaiting[plantName].Average();
                }

                Console.WriteLine($"- {plantName}; Rarity: {plantRarity}; Rating: {averageRating:f2}");
            }
        }
    }
}
