using System;
using System.Collections.Generic;
using System.Linq;

namespace P11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArg[0];
                int exchangeValue = 0; 

                if (command == "exchange")
                {
                    exchangeValue = int.Parse(cmdArg[1]);
                    if (exchangeValue < 0 || exchangeValue >= array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    array = ExchangeArray(array, exchangeValue).ToArray();
                }
                else if (command == "max")
                {
                    string value = cmdArg[1];
                    if (value == "odd")
                    {
                        MaxOdd(array);
                    }
                    else if (value == "even")
                    {
                        MaxEven(array);
                    }
                }
                else if (command == "min")
                {
                    string value = cmdArg[1];
                    if (value == "odd")
                    {
                        MinOdd(array);
                    }
                    else if (value == "even")
                    {
                        MinEven(array);
                    }
                }
                else if (command == "first")
                {
                    int count = int.Parse(cmdArg[1]);
                    string cmd = cmdArg[2];

                    if (cmd == "odd")
                    {
                        if (count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        FirstOdd(array, count);
                    }
                    else if (cmd == "even")
                    {
                        if (count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        FirstEven(array, count);
                    }
                }
                else if (command == "last")
                {
                    int count = int.Parse(cmdArg[1]);
                    string cmd = cmdArg[2];

                    if (cmd == "odd")
                    {
                        if (count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        LastOdd(array, count);
                    }
                    else if (cmd == "even")
                    {
                        if (count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        LastEven(array, count);
                    }
                }
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        static int[] ExchangeArray(int[] array, int value)
        {

            List<int> exchangeList = new List<int>();

            for (int i = value + 1; i < array.Length; i++)
            {
                exchangeList.Add(array[i]);
            }

            for (int i = 0; i <= value; i++)
            {
                exchangeList.Add(array[i]);
            }

            array = exchangeList.ToArray();

            return array;

        }

        static void MaxOdd(int[] array)
        {
            int max = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] >= max)
                {
                    max = array[i];
                    index = i;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MaxEven(int[] array)
        {
            int max = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] >= max)
                {
                    max = array[i];
                    index = i;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }

        static void MinOdd(int[] array)
        {
            int min = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] <= min)
                {
                    min = array[i];
                    index = i;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MinEven(int[] array)
        {
            int min = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] <= min)
                {
                    min = array[i];
                    index = i;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }

        static void FirstOdd(int[] array, int count)
        {
            List<int> oddList = new List<int>();
            int counterOdd = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && counterOdd + 1 < count)
                {
                    counterOdd++;
                    oddList.Add(array[i]);
                }

            }
            if (counterOdd == -1)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", oddList) + "]");
            }
        }

        static void FirstEven(int[] array, int count)
        {
            List<int> evenList = new List<int>();
            int counterEven = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && counterEven + 1 < count)
                {
                    counterEven++;
                    evenList.Add(array[i]);
                }

            }
            if (counterEven == -1)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", evenList) + "]");
            }
        }

        static void LastOdd(int[] array, int count)
        {
            List<int> oddList = new List<int>();
            int counterOdd = -1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0 && counterOdd + 1 < count)
                {
                    counterOdd++;
                    oddList.Add(array[i]);
                }
            }
            oddList.Reverse();
            if (counterOdd == -1)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", oddList) + "]");
            }
        }

        static void LastEven(int[] array, int count)
        {
            List<int> evenList = new List<int>();
            int counterEven = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0 && counterEven + 1 < count)
                {
                    counterEven++;
                    evenList.Add(array[i]);
                }

            }
            evenList.Reverse();
            if (counterEven == -1)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", evenList) + "]");
            }
        }

    }

}
