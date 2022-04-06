using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string info;
            int distance = 0;
            Dictionary<string, int> data = new Dictionary<string, int>();

            while ((info = Console.ReadLine()) != "end of race")
            {
                char[] chars = info.ToCharArray();
                StringBuilder sb = new StringBuilder();

                foreach (var @ch in chars)
                {
                    if (char.IsLetter(ch))
                    {
                        sb.Append(ch);
                    }
                    else if (char.IsDigit(ch))
                    {
                        distance += int.Parse(ch.ToString());
                    }
                }
                if (participants.Contains(sb.ToString()))
                {
                    if (!data.ContainsKey(sb.ToString()))
                    {
                        data[sb.ToString()] = 0;

                    }
                    data[sb.ToString()] += distance;
                }
                sb.Clear();
                distance = 0;
            }

            data = data.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, x => x.Value);

            int counter = 1;
            foreach (var item in data)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                    counter++;
                    continue;
                }
                if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                    counter++;
                    continue;
                }
                if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");

                }
            }

        }

    }
}
