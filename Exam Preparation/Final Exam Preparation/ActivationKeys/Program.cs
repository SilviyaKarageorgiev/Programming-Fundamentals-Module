using System;
using System.Linq;

namespace ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string rawKey = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] instructions = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = instructions[0];

                if (command == "Contains")
                {
                    string substr = instructions[1];

                    if (rawKey.Contains(substr))
                    {
                        Console.WriteLine($"{rawKey} contains {substr}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (command == "Flip")
                {
                    string flip = instructions[1];
                    int startIndex = int.Parse(instructions[2]);
                    int endIndex = int.Parse(instructions[3]);

                    string subStr = rawKey.Substring(startIndex, endIndex - startIndex);
                    string flipped = string.Empty;

                    if (flip == "Upper")
                    {
                        for (int i = 0; i < subStr.Length; i++)
                        {
                            flipped += char.ToUpper(subStr[i]);
                        }

                    }
                    else if (flip == "Lower")
                    {
                        for (int i = 0; i < subStr.Length; i++)
                        {
                            flipped += char.ToLower(subStr[i]);
                        }
                    }

                    rawKey = rawKey.Replace(subStr, flipped);
                    Console.WriteLine(rawKey);
                }

                else if (command == "Slice")
                {
                    int startIndex = int.Parse(instructions[1]);
                    int endIndex = int.Parse(instructions[2]);

                    string sub = rawKey.Substring(startIndex, endIndex - startIndex);
                    rawKey = rawKey.Replace(sub, "");
                    Console.WriteLine(rawKey);
                }

            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
