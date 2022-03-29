using System;
using System.Numerics;

namespace P11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger maxSnowballValue = 0;
            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;


            for (int i = 1; i <= n; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                }

            }
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
        }
    }
}
