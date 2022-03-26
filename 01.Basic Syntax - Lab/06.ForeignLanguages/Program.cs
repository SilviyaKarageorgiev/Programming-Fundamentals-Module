using System;

namespace _06.ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string country = Console.ReadLine();
            switch (country)
            {
                case "Argentina":
                case "Spain":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
