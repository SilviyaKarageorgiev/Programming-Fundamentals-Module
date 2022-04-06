using System;

namespace ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double totalPrice = 0;
            double price = 0;
            double finalPrice = 0;
            double taxes = 0;
            double totalAfterDiscount = 0;

            string command = Console.ReadLine();
            while (command != "special" && command != "regular")
            {
                price = double.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPrice += price;
                }

                command = Console.ReadLine();
                if (command == "special")
                {
                    taxes = 0.2 * totalPrice;
                    finalPrice = totalPrice + taxes;
                    totalAfterDiscount = finalPrice - 0.1 * finalPrice;
                    break;
                }
                else if (command == "regular")
                {
                    taxes = 0.2 * totalPrice;
                    finalPrice = totalPrice + taxes;
                    totalAfterDiscount = finalPrice;
                    break;
                }

            }
            if (totalAfterDiscount == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalAfterDiscount:f2}$");

        }
    }
}
