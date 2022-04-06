using System;

namespace P01.TheHuntingGames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayForOnePerson = double.Parse(Console.ReadLine());

            double water = waterPerDayForOnePerson * players * days;
            double food = foodPerDayForOnePerson * players * days;


            double energyLoss = 0;

            for (int day = 1; day <= days; day++)
            {
                energyLoss = double.Parse(Console.ReadLine());

                double energyCheck = groupEnergy - energyLoss;

                if (energyCheck > 0)
                {
                    groupEnergy -= energyLoss;

                }
                if (energyCheck <= 0)
                {
                    groupEnergy -= energyLoss;
                    break;
                }

                if (day % 2 == 0)
                {
                    water -= 0.3 * water;
                    groupEnergy += 0.05 * groupEnergy;
                }
                if (day % 3 == 0)
                {
                    double foodForDay = food / players;
                    food -= foodForDay;
                    groupEnergy += 0.1 * groupEnergy;
                }


            }
            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
                
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.");
            }
        }
    }
}
