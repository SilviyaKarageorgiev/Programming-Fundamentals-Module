using System;

namespace P01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string command = Console.ReadLine();

            while (command != "END")
            {
                bool isInteger = int.TryParse(command, out int value);
                bool isDouble = double.TryParse(command, out double result);
                bool isChar = char.TryParse(command, out char result2);
                bool isBool = bool.TryParse(command, out bool result3);

                if (isInteger)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (isDouble)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }
                                
                command = Console.ReadLine();
            }

        }
    }
}
