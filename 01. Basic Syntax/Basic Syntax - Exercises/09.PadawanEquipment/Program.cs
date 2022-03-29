using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double total = 0;
            double totalMoneyForLightsabers = (students * priceOfLightsaber) + (Math.Ceiling(0.1 * students) * priceOfLightsaber);            
            double totalMoneyForBelts = ((students - Math.Floor((double)students / 6))) * priceOfBelt;
            double totalMoneyForRobe = students * priceOfRobe;
            total = totalMoneyForLightsabers + totalMoneyForBelts + totalMoneyForRobe;

            if (amountOfMoney >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {total - amountOfMoney:f2}lv more.");
            }

        }
    }
}
