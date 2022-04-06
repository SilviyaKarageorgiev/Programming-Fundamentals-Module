using System;
using System.Linq;

namespace ShootТorТheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            int counter = 0;

            while (input != "End")
            {
                int targetIndex = int.Parse(input);
                if (targetIndex < 0 || targetIndex >= array.Length)
                {
                    input = Console.ReadLine();
                    continue;
                }
                int currTarget = array[targetIndex];
                if (array[targetIndex] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == targetIndex)
                    {
                        array[targetIndex] = -1;
                        counter++;
                        continue;
                    }
                    if (array[i] == -1)
                    {
                        continue;
                    }
                    if (array[i] > currTarget)
                    {
                        array[i] = array[i] - currTarget;
                    }
                    else if (array[i] <= currTarget)
                    {
                        array[i] = array[i] + currTarget;
                    }

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", array)}");
        }
    }
}
