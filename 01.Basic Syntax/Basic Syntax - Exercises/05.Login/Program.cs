using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string trying = Console.ReadLine();
            if (trying != password)
            {
                for (int i = 1; i <= 4; i++)
                {
                    if (trying == password)
                    {
                        Console.WriteLine($"User {username} logged in.");
                        break;
                    }
                    if (i == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    trying = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");

            }
        }
    }
}
