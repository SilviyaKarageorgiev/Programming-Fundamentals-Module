using System;

namespace P03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] path = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

            var file = path[path.Length - 1].Split('.');
            
            string template = file[0];
            string extension = file[1];

            Console.WriteLine($"File name: {template}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
