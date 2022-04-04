using System;
using System.Collections.Generic;

namespace P08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArg = input.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string company = cmdArg[0];
                string idNumber = cmdArg[1];

                if (!data.ContainsKey(company))
                {
                    data[company] = new List<string>();
                }
                if (data[company].Contains(idNumber))
                {
                    continue;
                }
                data[company].Add(idNumber);

            }
            foreach (var item in data)
            {
                Console.WriteLine(item.Key);
                List<string> students = item.Value;
                foreach (var student in students)
                {
                    Console.WriteLine($"--{student}");
                }
            }
        }
    }
}
