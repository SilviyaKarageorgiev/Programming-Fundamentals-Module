using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace P07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int currentNum = arr[0];
            int counter = 0;
            int longNum = 0;
            int longCounter = counter;

            for (int i = 0; i < arr.Length; i++)
            {
                if (currentNum == arr[i])
                {
                    counter++;
                    if (counter > longCounter)
                    {
                        longNum = currentNum;
                        longCounter = counter;
                    }
                }
                else
                {
                    counter = 1;
                    currentNum = arr[i];
                }
            }
            int[] longArr = new int[longCounter];
            for (int i = 0; i < longArr.Length; i++)
            {
                longArr[i] = longNum;
            }
            Console.WriteLine(String.Join(" ", longArr));
        }
    }
}
