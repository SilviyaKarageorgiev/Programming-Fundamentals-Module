using System;

namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int initialEnergy = int.Parse(Console.ReadLine());
            
            string input = Console.ReadLine();
            int counter = 0;

            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (distance <= initialEnergy)
                {
                    initialEnergy -= distance;
                    counter++;
                    if (counter % 3 == 0)
                    {
                        initialEnergy += counter;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {initialEnergy} energy");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {counter}. Energy left: {initialEnergy}");
        }
    }
}
