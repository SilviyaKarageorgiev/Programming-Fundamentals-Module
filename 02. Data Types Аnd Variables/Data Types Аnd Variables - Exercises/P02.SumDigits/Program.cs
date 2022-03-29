using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string num = Console.ReadLine();
            int sum = 0;
            int currentNum = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                if (i == 0)
                {
                currentNum = int.Parse(num);
                }
                sum += currentNum % 10;
                currentNum /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
