using System;

namespace P08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            
            double maxValue = double.MinValue;
            string model = string.Empty;
            string maxModel = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > maxValue)
                {
                    maxValue = volume;
                    maxModel = model;
                }

            }
            Console.WriteLine(maxModel);

        }
    }
}
