using System;

namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal usd = pound * 1.31m;
            Console.WriteLine($"{usd:f3}");

        }
    }
}
