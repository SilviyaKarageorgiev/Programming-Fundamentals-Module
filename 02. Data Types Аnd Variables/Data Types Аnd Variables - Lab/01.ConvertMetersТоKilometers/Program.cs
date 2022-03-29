using System;

namespace _01.ConvertMetersТоKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000;
            //Console.WriteLine($"{Math.Round(kilometers, 2, MidpointRounding.AwayFromZero):f2}"); 
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
