using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n  = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> data = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!data.ContainsKey(name))
                {
                    data[name] = new List<double>();
                }
                data[name].Add(grade);

            }

            foreach (var item in data)
            {
                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }

        }
    }
}
