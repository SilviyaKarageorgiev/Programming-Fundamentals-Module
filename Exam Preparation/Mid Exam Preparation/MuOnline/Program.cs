using System;
using System.Collections.Generic;
using System.Linq;

namespace MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoin = 0;


            List<string> list = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                string[] array = list[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                string command = array[0];
                int value = int.Parse(array[1]);

                if (command == "potion")
                {
                    if (health + value > 100)
                    {
                        value = 100 - health;
                        health += value;
                    }
                    else
                    {
                        health += value;
                    }
                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcoin += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {

                    health -= value;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }
            }
 
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoin}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
