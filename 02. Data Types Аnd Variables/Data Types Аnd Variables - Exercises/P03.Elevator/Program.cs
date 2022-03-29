using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double persons = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            int courses = (int)persons / (int)capacity;

            //Първи вариант:
            if (persons % capacity == 0)
            {
                Console.WriteLine(courses);
            }
            else
            {
                Console.WriteLine(courses + 1);
            }

            //Втори вариант:
            //courses = (int)Math.Ceiling(persons / capacity);
            //Console.WriteLine(courses);
        }
    }
}
