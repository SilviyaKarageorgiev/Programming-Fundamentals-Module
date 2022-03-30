using System;
using System.Linq;

namespace P06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 1)
                {
                    Console.WriteLine("0");
                    return;
                }
                leftSum = 0;
                for (int left = i; left > 0; left--)
                { 
                    leftSum += array[left - 1];
                }

                rightSum = 0;
                for (int right = i; right < array.Length - 1; right++)
                {
                    rightSum += array[right + 1];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
                Console.WriteLine("no");
            
        }
    }
}
