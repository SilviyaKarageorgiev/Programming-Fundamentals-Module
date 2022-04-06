using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                data[piece] = new List<string>();
                data[piece].Add(composer);
                data[piece].Add(key);
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = cmd.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = cmdArgs[0];

                if (command == "Add")
                {
                    string piece = cmdArgs[1];
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];

                    if (!data.ContainsKey(piece))
                    {
                        data[piece] = new List<string>();
                        data[piece].Add(composer);
                        data[piece].Add(key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }

                else if (command == "Remove")
                {
                    string piece = cmdArgs[1];
                    if (data.ContainsKey(piece))
                    {
                        data.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                else if (command == "ChangeKey")
                {
                    string piece = cmdArgs[1];
                    string newKey = cmdArgs[2];
                    if (data.ContainsKey(piece))
                    {
                        data[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

            }

            foreach (var item in data)
            {
                string namePiece = item.Key;
                List<string> info = item.Value;
                string nameComposer = data[namePiece][0];
                string nameKey = data[namePiece][1];

                Console.WriteLine($"{namePiece} -> Composer: {nameComposer}, Key: {nameKey}");
            }
        }
    }
}
