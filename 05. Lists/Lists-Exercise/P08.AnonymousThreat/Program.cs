using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "merge") 
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0 && endIndex >= list.Count)
                    {
                        continue;
                    }
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= list.Count)
                    {
                        endIndex = list.Count - 1;
                    }

                    StringBuilder merged = new StringBuilder();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        merged.Append(list[startIndex]);
                        list.RemoveAt(startIndex);

                    }
                    list.Insert(startIndex, merged.ToString());
                    
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    if (partitions > list.Count)
                    {
                        continue;
                    }

                    string wordToDivide = list[index];

                    char[] divideArray = new char[wordToDivide.Length];

                    for (int i = 0; i <= wordToDivide.Length; i++)
                    {
                        divideArray[i] = wordToDivide[i];
                    }

                    List<string> divideList = new List<string>();   
                    
                    int partisionLength = wordToDivide.Length / partitions;
                    int partitionReminder = wordToDivide.Length % partitions;
                    int lastPartisionLength = partisionLength + partitionReminder;

                    
                    

                }


                
            }

        }
    }
}
