using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string car = input[0];
                int mileage = int.Parse(input[1]);
                int fuelAvailable = int.Parse(input[2]);

                map[car] = new List<int>();
                map[car].Add(mileage);
                map[car].Add(fuelAvailable);
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = cmd.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];
                string car = cmdArgs[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);

                    if (fuel > map[car][1])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        map[car][0] += distance;
                        map[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (map[car][0] >= 100000)
                        {
                            map.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                }

                else if (command == "Refuel")
                {
                    int fuel = int.Parse(cmdArgs[2]);
                    map[car][1] += fuel;
                    int rest = 0;
                    if (map[car][1] > 75)
                    {
                        rest = map[car][1] - 75;
                        map[car][1] = 75;
                    }
                    Console.WriteLine($"{car} refueled with {fuel - rest} liters");
                }

                else if (command == "Revert")
                {
                    int kilometers = int.Parse(cmdArgs[2]);
                    map[car][0] -= kilometers;
                    
                    if (map[car][0] < 10000)
                    {
                        map[car][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
            }

            foreach (var item in map)
            {
                string car = item.Key;
                int mileage = item.Value[0];
                int fuel = item.Value[1];

                Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }

        }
    }
}
