using System;
using System.Linq;

namespace P04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            //Другият вариант е да си направя още един масив на обърнатите елементи и да принтирам със String.Join
            //Обръщането на масива може и да се направи с Array.Reverse
        }
    }
}
