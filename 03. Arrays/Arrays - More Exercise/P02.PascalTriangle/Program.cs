using System;
using System.Collections.Generic;
using System.Threading;

namespace P02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            list.Add(1);
            Console.WriteLine(string.Join(" ", list));
            list.Add(1);
            Console.WriteLine(string.Join(" ", list));
            //list[list.Count - 1] = 1;
            List<int> currList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                

            }
            //недовършена!!!
        }
    }
}
