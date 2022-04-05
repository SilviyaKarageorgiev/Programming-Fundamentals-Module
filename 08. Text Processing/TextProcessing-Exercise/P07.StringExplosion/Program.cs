using System;
using System.Text;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string line = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int strength = 0; 

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '>')
                {
                    strength += int.Parse(line[i + 1].ToString());
                    sb.Append(line[i]);
                }
                else
                {
                    if (strength > 0)
                    {
                        strength -= 1;
                        continue;
                    }
                    else
                    {
                        sb.Append(line[i]);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
