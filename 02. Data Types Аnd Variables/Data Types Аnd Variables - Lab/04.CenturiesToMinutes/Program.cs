using System;

namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            byte senturies = byte.Parse(Console.ReadLine());
            short years = (short)(senturies * 100);
            int days = (int)(years * 365.2422);
            uint hours = (uint)(days * 24);
            ulong minutes = (ulong)(hours * 60);
            Console.WriteLine($"{senturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
