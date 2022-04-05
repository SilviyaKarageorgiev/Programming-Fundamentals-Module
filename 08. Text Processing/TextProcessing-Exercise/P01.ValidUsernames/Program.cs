using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> validUsernames = new List<string>();

            foreach (var user in usernames)
            {
                bool isValid = true;

                if (user.Length < 3 || user.Length > 16)
                {
                    continue;
                }
                for (int i = 0; i < user.Length; i++)
                {
                    if (!(char.IsLetterOrDigit(user[i]) || user[i] == '-' || user[i] == '_'))
                    {
                        isValid = false;
                    }
                }
                if (isValid)
                {
                    validUsernames.Add(user);
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, validUsernames));
        }
    }
}
