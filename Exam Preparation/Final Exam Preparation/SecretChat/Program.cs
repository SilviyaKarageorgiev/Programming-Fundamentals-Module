using System;
using System.Linq;

namespace SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string message = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = cmdArgs[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }

                else if (command == "Reverse")
                {
                    string subStr = cmdArgs[1];
                    if (message.Contains(subStr))
                    {
                        int index = message.IndexOf(subStr);
                        message = message.Remove(index, subStr.Length);
                        string reversed = string.Join("", subStr.Reverse());
                        message = message.Insert(message.Length, reversed);
                        Console.WriteLine(message);

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (command == "ChangeAll")
                {
                    string substr = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    message = message.Replace(substr, replacement);
                    Console.WriteLine(message);

                }
            }
            Console.WriteLine($"You have a new text message: {message}");

        }
    }
}
