using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int specialNumber = arr[0];
            int power = arr[1];

            int bombIndex = list.IndexOf(specialNumber);

            while (bombIndex != -1)
            {
                int leftNumbers = bombIndex - power;
                int rightNumbers = bombIndex + power;

                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }
                if (rightNumbers > list.Count - 1)
                {
                    rightNumbers = list.Count - 1;
                }

                list.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);

                bombIndex = list.IndexOf(specialNumber);
            }
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
