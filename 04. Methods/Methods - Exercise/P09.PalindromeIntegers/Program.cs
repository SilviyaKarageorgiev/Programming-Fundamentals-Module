using System;

namespace P09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            PrintPalindrome(command);

        }
        static void PrintPalindrome(string command)
        {

            bool isPalindrome = false;

            while (command != "END")
            {
                for (int i = 0; i < command.Length / 2; i++)
                {
                    if (command[i] == command[command.Length - 1])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                        Console.WriteLine("false");
                        break;
                    }
                    int num = int.Parse(command);
                    num /= 10;
                    command = num.ToString();

                }
                if (isPalindrome)
                {
                    Console.WriteLine("true");

                }
                command = Console.ReadLine();
            }

        }

    }
}
