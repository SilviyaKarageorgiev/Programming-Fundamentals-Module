using System;
using System.Linq;

namespace P01.StringManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];

                if (command == "Translate")
                {
                    string match = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    text = text.Replace(match, replacement);
                    Console.WriteLine(text);
                }

                else if (command == "Includes")
                {
                    string subStr = cmdArgs[1];

                    if (text.Contains(subStr))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                else if (command == "Start")
                {
                    string substr = cmdArgs[1];

                    if (text.IndexOf(substr) == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                else if (command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }

                else if (command == "FindIndex")
                {
                    string sub = cmdArgs[1];

                    Console.WriteLine(text.LastIndexOf(sub));
                    
                }

                else if (command == "Remove")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);

                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }

            }

        }
    }
}
