using System;

namespace P09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spicesQuantity = 0;
            int counter = 0;

            for (int i = startingYield; i >= 100; i -= 10)
            {
                counter++;
                spicesQuantity += i;
                spicesQuantity -= 26;
            }
            if (spicesQuantity > 26)
            {
            spicesQuantity -= 26;
            }

            Console.WriteLine(counter);
            Console.WriteLine(spicesQuantity);
        }
    }
}
