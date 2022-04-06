using System;
using System.Linq;

namespace WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string stops = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string str = cmdArgs[2];
                    if (IsValidIndex(stops, index))
                    {
                        stops = stops.Insert(index, str);
                    }
                    Console.WriteLine(stops);
                }
                else if (command == "Remove Stop")
                {
                    int start = int.Parse(cmdArgs[1]);
                    int end = int.Parse(cmdArgs[2]);
                    if (IsValidIndex(stops, start) && IsValidIndex(stops, end))
                    {
                        stops = stops.Remove(start, end - start + 1);
                    }
                    Console.WriteLine(stops);

                }
                else if (command == "Switch")
                {
                    string old = cmdArgs[1];
                    string newStr = cmdArgs[2];

                    stops = stops.Replace(old, newStr);
                    Console.WriteLine(stops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");

        }

        static bool IsValidIndex(string stops, int index)
        {
            return index >= 0 && index < stops.Length;
        }
    }
}
