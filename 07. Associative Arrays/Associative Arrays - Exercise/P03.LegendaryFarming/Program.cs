using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> legendary = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string itemObtained = string.Empty;

            string[] items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            

            while (string.IsNullOrEmpty(itemObtained))
            {
                for (int i = 1; i < items.Length; i += 2)
                {
                    if (legendary.ContainsKey(items[i].ToLower()))
                    {
                       
                        legendary[items[i].ToLower()] += int.Parse(items[i - 1]);
                        if (legendary[items[i].ToLower()] >= 250)
                        {
                            itemObtained = items[i].ToLower();
                            switch (items[i].ToLower())
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }
                            legendary[items[i].ToLower()] -= 250;

                            foreach (var item in legendary)
                            {
                                string keyMaterial = item.Key;
                                int qty = item.Value;
                                Console.WriteLine($"{keyMaterial}: {qty}");
                            }

                            foreach (var item in junk)
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            return;
                        }

                    }
                    else
                    {
                        if (!junk.ContainsKey(items[i].ToLower()))
                        {
                            junk[items[i].ToLower()] = 0;
                        }
                        junk[items[i].ToLower()] += int.Parse(items[i - 1]);
                    }
                }

                items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

        }
    }
}
