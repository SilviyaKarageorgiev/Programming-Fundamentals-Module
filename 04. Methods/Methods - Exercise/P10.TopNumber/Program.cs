using System;
using System.Collections.Generic;

namespace P10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(Environment.NewLine, NumbersWithAtLeastOneOddDigit(NumbersDivideByEight(end))));

        }

        static List<int> NumbersDivideByEight(int end)
        {
            int sum = 0;
            int num = 0;
            List<int> list = new List<int>();

            for (int i = 1; i <= end; i++)
            {
                num = i;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum % 8 == 0)
                {
                    list.Add(i);
                }
                sum = 0;

            }
            return list;
        }

        static List<int> NumbersWithAtLeastOneOddDigit(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int number = list[i];
                int currNum = number;
                int currDigit = 0;
                bool isOdd = false;

                while (currNum > 0)
                {
                    currDigit = currNum % 10;
                    if (currDigit % 2 != 0)
                    {
                        isOdd = true;
                        break;
                    }
                    else
                    {
                        currNum /= 10;

                        continue;
                    }
                }
                if (!isOdd)
                {
                    list.Remove(number);
                    i -= 1;
                }
            }
            return list;

        }

    }
}
