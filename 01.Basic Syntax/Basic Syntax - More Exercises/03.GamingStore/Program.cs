using System;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double currentBalance = budget;
            string command = Console.ReadLine();

            while (command != "Game Time")
            {
                if (command == "OutFall 4")
                {
                    if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                }
                else if (command == "CS: OG")
                {
                    if (currentBalance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                    currentBalance -= 15.99;
                    Console.WriteLine("Bought CS: OG");
                    }
                }
                else if (command == "Zplinter Zell")
                {
                    if (currentBalance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                }
                else if (command == "Honored 2")
                {
                    if (currentBalance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                }
                else if (command == "RoverWatch")
                {
                    if (currentBalance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${budget - currentBalance:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
