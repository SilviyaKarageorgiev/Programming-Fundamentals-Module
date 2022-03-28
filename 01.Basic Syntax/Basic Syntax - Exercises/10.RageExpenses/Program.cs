using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double expenses = 0;
            int count = 0;

            for (int game = 1; game <= lostGames; game++)
            {
                if (game % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                if (game % 3 == 0)
                {
                    expenses += mousePrice;
                }
                if (game % 2 == 0 && game % 3 == 0)
                {
                    expenses += keyboardPrice;
                    count++;
                    if (count % 2 == 0)
                    {
                        expenses += displayPrice;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
