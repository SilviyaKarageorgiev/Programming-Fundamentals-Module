using System;
using System.Linq;
using System.Text;

namespace PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder stringBuilder = new StringBuilder();

            string pass = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Done")
            {
                string[] cmdArg = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArg[0];

                if (command == "TakeOdd")
                {
                    for (int i = 1; i < pass.Length; i += 2)
                    {
                        stringBuilder.Append(pass[i]);

                    }
                    pass = stringBuilder.ToString();
                    Console.WriteLine(pass);
                }

                else if (command == "Cut")
                {
                    int index = int.Parse(cmdArg[1]);
                    int length = int.Parse(cmdArg[2]);

                    pass = pass.Remove(index, length);
                    Console.WriteLine(pass);
                }

                else if (command == "Substitute")
                {
                    string substr = cmdArg[1];
                    string replacement = cmdArg[2];
                   
                    if (pass.Contains(substr))
                    {
                        pass = pass.Replace(substr, replacement);
                        Console.WriteLine(pass);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {pass}");

        }
    }
}
