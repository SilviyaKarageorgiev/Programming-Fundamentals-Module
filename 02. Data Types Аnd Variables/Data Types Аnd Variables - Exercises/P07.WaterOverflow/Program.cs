using System;

namespace P07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterTankCapacity = 255;
            int waterTank = 0;

            for (int i = 0; i < n; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());
                if (waterTankCapacity < litersOfWater)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                waterTank += litersOfWater;
                waterTankCapacity -= litersOfWater;

            }
            Console.WriteLine(waterTank);
        }
    }
}
