using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            if (number == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int result = int.Parse(bigNumber[i].ToString()) * number + remainder;
                remainder = 0;

                if (result > 9)
                {
                    remainder = result / 10;
                    result = result % 10;
                }
                sb.Append(result);

            }
            StringBuilder finalResult = new StringBuilder();
            if (remainder != 0)
            {
                finalResult.Append(remainder);
            }

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                finalResult.Append(sb[i]);
            }
            Console.WriteLine(finalResult.ToString());
        }
    }
}
