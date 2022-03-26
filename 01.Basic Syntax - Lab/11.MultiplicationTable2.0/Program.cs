using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int theInteger = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 0 && multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
                }
            }
            else
            {
                Console.WriteLine($"{theInteger} X {multiplier} = {theInteger * multiplier}");
            }
        }
    }
}
