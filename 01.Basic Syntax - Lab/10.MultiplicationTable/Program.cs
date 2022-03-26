using System;

namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int theInteger = int.Parse(Console.ReadLine());

            for (int times = 1; times <= 10; times++)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
            }

        }
    }
}
