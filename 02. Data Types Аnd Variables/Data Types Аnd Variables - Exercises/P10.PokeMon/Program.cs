using System;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int counter = 0;            

            for (int i = n - m; i >= 0; i -= m)
            {
                counter++;
                if (i == n * 0.5 && y != 0)
                {
                    i /= y;
                }
                if (i < m)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(counter);
                    break;
                }
                
            }

        }
    }
}
