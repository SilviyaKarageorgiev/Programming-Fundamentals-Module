using System;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double largest = 0;
            double middle = 0;
            double lowest = 0;

            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
                if (num2 >= num3)
                {
                    middle = num2;
                    lowest = num3;
                }
                else
                {
                    middle = num3;
                    lowest = num2;
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
                if (num1 >= num3) 
                {
                    middle = num1;
                    lowest = num3;
                }
                else
                {
                    middle = num3;
                    lowest = num1;
                }
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                largest = num3;
                if (num1 >= num2)
                {
                    middle = num1;
                    lowest = num2;
                }
                else
                {
                    middle = num2;
                    lowest = num1;
                }
            }
            Console.WriteLine(largest);
            Console.WriteLine(middle);
            Console.WriteLine(lowest);

        }
    }
}
