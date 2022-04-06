using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.HeroRecruitment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];

                if (command == "Enroll")
                {
                    string heroName = cmdArgs[1];

                    if (!data.ContainsKey(heroName))
                    {
                        data[heroName] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }

                else if (command == "Learn")
                {
                    string heroName = cmdArgs[1];
                    string spellName = cmdArgs[2];

                    if (!data.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (data[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                        else
                        {
                            data[heroName].Add(spellName);
                        }
                    }
                }

                else if (command == "Unlearn")
                {
                    string heroName = cmdArgs[1];
                    string spellName = cmdArgs[2];

                    if (!data.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (!data[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                        else
                        {
                            data[heroName].Remove(spellName);
                        }
                    }
                }

            }
            Console.WriteLine("Heroes:");

            foreach (var item in data)
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
            }



        }
    }
}
