using System;
using System.Security;

namespace P06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                string bracket = Console.ReadLine();

                if (bracket == "(")
                {
                    count++;
                }
                if (bracket == ")")
                {
                    count--;
                }
                if (count < 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                if (count == 2 || count == -2)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
