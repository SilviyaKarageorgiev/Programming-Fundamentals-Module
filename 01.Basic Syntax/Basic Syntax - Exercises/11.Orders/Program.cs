using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int daysInMonth = int.Parse(Console.ReadLine());
            int numOfCapsules = int.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;

            for (int i = 1; i <= n; i++)
            {
                price = ((daysInMonth * numOfCapsules) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                total += price;
                if (i == n)
                {
                    break;
                }
                pricePerCapsule = double.Parse(Console.ReadLine());
                daysInMonth = int.Parse(Console.ReadLine());
                numOfCapsules = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
