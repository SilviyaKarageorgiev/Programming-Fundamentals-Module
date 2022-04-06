using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int currentIndex = 0;

            while (input != "Love!")
            {
                string[] command = input.Split();
                int length = int.Parse(command[1]);

                currentIndex += length;
                if (currentIndex < 0 || currentIndex >= list.Count)
                {
                    currentIndex = 0;
                }
                if(list[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                    
                }
                else if (list[currentIndex] == 2)
                {
                    Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    list[currentIndex] = 0;
                }
                else
                {
                    list[currentIndex] -= 2;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");

            int counter = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
