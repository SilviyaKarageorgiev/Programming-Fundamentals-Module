using System;

namespace BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunderPerDay = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double plunder = 0;

            for (int day = 1; day <= days; day++)
            {
                plunder += plunderPerDay;

                if (day % 3 == 0)
                {
                    plunder += 0.5 * plunderPerDay;
                }
                if (day % 5 == 0)
                {
                    plunder -= 0.3 * plunder;
                }
                
            }
            if (plunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {plunder:f2} plunder gained.");
                return;
            }
            else
            {
                double percentCollectPlunder = (plunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentCollectPlunder:f2}% of the plunder.");

            }
        }
    }
}
