using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double receivedMoney = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                receivedMoney += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "Nuts" && receivedMoney >= 2)
                {
                    receivedMoney -= 2;
                    Console.WriteLine("Purchased nuts");
                }
                else if (command == "Water" && receivedMoney >= 0.7)
                {
                    receivedMoney -= 0.7;
                    Console.WriteLine("Purchased water");
                }
                else if (command == "Crisps" && receivedMoney >= 1.5)
                {
                    receivedMoney -= 1.5;
                    Console.WriteLine("Purchased crisps");
                }
                else if (command == "Soda" && receivedMoney >= 0.8)
                {
                    receivedMoney -= 0.8;
                    Console.WriteLine("Purchased soda");
                }
                else if (command == "Coke" && receivedMoney >= 1)
                {
                    receivedMoney -= 1;
                    Console.WriteLine("Purchased coke");
                }
                else if (command != "Nuts" && command != "Water" && command != "Crisps" && command != "Soda" && command != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {receivedMoney:f2}");
        }
    }
}
