using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArg = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = cmdArg[0];
                string student = cmdArg[1];

                if (!data.ContainsKey(course))
                {
                    data[course] = new List<string>();
                }
                data[course].Add(student);
            }

            
            foreach (var item in data)
            {
                string course = item.Key;
                List<string> students = item.Value;

                Console.WriteLine($"{course}: {students.Count}");

                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
