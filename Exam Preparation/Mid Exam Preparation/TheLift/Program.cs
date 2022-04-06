using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int peopleInQueue = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] result = new int[wagons.Length];

            bool isFullWagons = false;

            for (int i = 0; i < wagons.Length; i++)
            {
                int currWagon = wagons[i];

                while (currWagon < 4 && peopleInQueue != 0)
                {
                    currWagon++;
                    peopleInQueue--;
                }
                result[i] = currWagon;
                if (result[i] == 4)
                {
                    isFullWagons = true;
                }
                else
                {
                    isFullWagons = false;
                }

             }
            if (peopleInQueue == 0 && isFullWagons == false)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", result));
            }
            else if (peopleInQueue > 0 && isFullWagons == true)
            {
                Console.WriteLine($"There isn't enough space! {peopleInQueue} people in a queue!");
                Console.WriteLine(string.Join(" ", result));
            }
            else if (peopleInQueue == 0 && isFullWagons == true)
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
