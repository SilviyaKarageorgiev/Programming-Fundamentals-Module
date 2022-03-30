using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Encrypt_SortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int currSum = 0;
                char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
                
                foreach (char ch in name)
                {

                    if (vowels.Contains(ch))
                    {
                        currSum += ch * name.Length;

                    }
                    else
                    {
                        currSum += ch / name.Length;
                    }
                    
                }
                result.Add(currSum);

            }
            result.Sort();
            Console.WriteLine(String.Join(Environment.NewLine, result));

        }
    }
}
