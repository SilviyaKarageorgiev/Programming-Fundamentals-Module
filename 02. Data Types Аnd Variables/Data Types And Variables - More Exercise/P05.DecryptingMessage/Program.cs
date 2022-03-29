using System;

namespace P05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string realChar = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                int charCode = ((int)currChar + key);
                realChar += (char)charCode;
            }
                Console.Write(realChar);

        }
    }
}
