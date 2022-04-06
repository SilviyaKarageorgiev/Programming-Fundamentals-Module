using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string heroName = input[0];
                int hitPoints = int.Parse(input[1]);
                int manaPoints = int.Parse(input[2]);

                data[heroName] = new List<int>();
                data[heroName].Add(hitPoints);
                data[heroName].Add(manaPoints);

            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = cmd.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];
                string hero = cmdArgs[1];

                if (command == "CastSpell")
                {
                    int requiredMp = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    if (data[hero][1] < requiredMp)
                    {
                        Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        data[hero][1] -= requiredMp;
                        Console.WriteLine($"{hero} has successfully cast {spellName} and now has {data[hero][1]} MP!");
                    }
                }

                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    data[hero][0] -= damage;

                    if (data[hero][0] > 0)
                    {
                        Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {data[hero][0]} HP left!");
                    }
                    else
                    {
                        data.Remove(hero);
                        Console.WriteLine($"{hero} has been killed by {attacker}!");
                    }
                }

                else if (command == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    data[hero][1] += amount;
                    int reminder = 0;

                    if (data[hero][1] > 200)
                    {
                        reminder = data[hero][1] - 200;
                        data[hero][1] = 200;
                    }
                    Console.WriteLine($"{hero} recharged for {amount - reminder} MP!");
                }

                else if (command == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    data[hero][0] += amount;
                    int reminder = 0;

                    if (data[hero][0] > 100)
                    {
                        reminder = data[hero][0] - 100;
                        data[hero][0] = 100;
                    }
                    Console.WriteLine($"{hero} healed for {amount - reminder} HP!");
                }
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}");

                List<int> list = item.Value;

                Console.WriteLine($"  HP: {list[0]}");
                Console.WriteLine($"  MP: {list[1]}");

            }

        }
    }
}
