using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 16;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 22.50;
                }
            }

            double total = numOfPeople * price;

            if (numOfPeople >= 30 && typeOfGroup == "Students")
            {
                total -= 0.15 * total;
            }
            if (numOfPeople >= 100 && typeOfGroup == "Business")
            {
                total -= 10 * price;
            }
            if (numOfPeople >= 10 && numOfPeople <= 20 && typeOfGroup == "Regular")
            {
                total -= 0.05 * total;
            }

            Console.WriteLine($"Total price: {total:f2}");
                        
        }
    }
}
