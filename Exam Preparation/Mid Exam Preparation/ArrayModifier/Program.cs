using System;
using System.Linq;

namespace ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] parts = input.Split();
                string command = parts[0];

                if (command == "swap")
                {
                    int token = numbers[int.Parse(parts[1])];
                    
                    numbers[int.Parse(parts[1])] = numbers[int.Parse(parts[2])];
                    numbers[int.Parse(parts[2])] = token;
                }
                else if (command == "multiply")
                {
                    int result = numbers[int.Parse(parts[1])] * numbers[int.Parse(parts[2])];
                    numbers[int.Parse(parts[1])] = result;
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                        
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
