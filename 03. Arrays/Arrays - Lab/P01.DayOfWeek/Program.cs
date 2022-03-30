using System;

namespace P01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            string[] day =
                {   "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"
                };
            if (dayNumber >= 1 && dayNumber <= day.Length)
            {
                Console.WriteLine(day[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
