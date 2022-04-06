using System;

namespace SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int employee1PerHour = int.Parse(Console.ReadLine());
            int employee2PerHour = int.Parse(Console.ReadLine());
            int employee3PerHour = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int efficiency = employee1PerHour + employee2PerHour + employee3PerHour;
            int hours = 0;

            while (students > 0)
            {
                students -= efficiency;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
