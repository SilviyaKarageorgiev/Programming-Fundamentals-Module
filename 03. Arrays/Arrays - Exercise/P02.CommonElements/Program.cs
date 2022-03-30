using System;

namespace P02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            foreach (string elementTwo in secondArray)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    string elementOne = firstArray[i];
                    if (elementOne == elementTwo)
                    {
                        Console.Write(elementOne + " ");
                        break;
                    }
                }
            }
            
        }
    }
}
