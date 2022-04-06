using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SpaceTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries).ToList();
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                string[] cmdArg = list[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArg[0];
                int value = 0;

                if (command == "Travel")
                {
                    value = int.Parse(cmdArg[1]);
                    fuel -= value;
                    if (fuel > 0)
                    {
                        Console.WriteLine($"The spaceship travelled {value} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command == "Enemy")
                {
                    value = int.Parse(cmdArg[1]);
                    if (ammunition >= value)
                    {
                        ammunition -= value;
                        Console.WriteLine($"An enemy with {value} armour is defeated.");
                    }
                    else
                    {
                        int needFuel = value * 2;

                        if (fuel >= needFuel)
                        {
                            Console.WriteLine($"An enemy with {value} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                    }
                }
                else if (command == "Repair")
                {
                    value = int.Parse(cmdArg[1]);
                    fuel += value;
                    ammunition += value * 2;
                    Console.WriteLine($"Ammunitions added: {value * 2}.");
                    Console.WriteLine($"Fuel added: {value}.");
                }
                else if (command == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                }
            }

        }
    }
}
