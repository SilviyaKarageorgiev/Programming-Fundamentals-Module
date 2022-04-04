using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace P04.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> data = new Dictionary<string, List<double>>();
            Dictionary<string, double> total = new Dictionary<string, double>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArg[0];
                double price = double.Parse(cmdArg[1]);
                double quantity = double.Parse(cmdArg[2]);

                if (data.ContainsKey(name))
                {
                    data[name][0] = price;
                    data[name][1] += quantity;
                }
                else
                {
                    data.Add(name, new List<double> { price, quantity });
                }


            }

            foreach (var item in data)
            {
                total[item.Key] = item.Value[0] * item.Value[1];
            }

            foreach (var item in total)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

        }
    }
}