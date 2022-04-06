using System;
using System.Linq;
using System.Text;

namespace TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;

            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = input.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];

                if (command == "Move")
                {
                    int n = int.Parse(cmdArgs[1]);
                    string subStr = message.Substring(0, n);
                    message = message.Remove(0, n);
                    message = message.Insert(message.Length, subStr);
                    
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];

                    message = message.Insert(index, value);
                    
                }
                else if (command == "ChangeAll")
                {
                    string sub = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    while (message.Contains(sub))
                    {
                        message = message.Replace(sub, replacement);
                    }
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");

        }
    }
}
