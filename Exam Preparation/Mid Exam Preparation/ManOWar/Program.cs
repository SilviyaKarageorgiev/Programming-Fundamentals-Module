using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> pirateShip = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int capacityHealth = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "Retire")
            {
                List<string> cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = cmdArg[0];

                if (command == "Fire")
                {
                    int index = int.Parse(cmdArg[1]);
                    int damage = int.Parse(cmdArg[2]);

                    if (index < 0 || index >= warship.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        warship[index] -= damage;
                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }                    
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    int damage = int.Parse(cmdArg[3]);

                    if (startIndex < 0 || startIndex >= pirateShip.Count || endIndex < 0 || endIndex >= pirateShip.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }

                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(cmdArg[1]);
                    int health = int.Parse(cmdArg[2]);

                    if (index < 0 || index >= pirateShip.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > capacityHealth)
                        {
                            pirateShip[index] = capacityHealth;
                        }
                    }
                }
                else if (command == "Status")
                {
                    int counter = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < (0.2 * capacityHealth))
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"{counter} sections need repair.");
                }

                input = Console.ReadLine();
            }
            int pirateShipSum = 0;
            int warshipSum = 0;

            for (int i = 0; i < pirateShip.Count; i++)
            {
                pirateShipSum += pirateShip[i];
            }
            for (int j = 0; j < warship.Count; j++)
            {
                warshipSum += warship[j];
            }
            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warshipSum}");

        }
    }
}
