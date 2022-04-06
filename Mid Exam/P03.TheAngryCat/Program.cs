using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TheAngryCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> priceRating = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int breakPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();

            int sumLeft = 0;
            int sumRight = 0;

            //int countRight = priceRating.Count - breakPoint - 1;

            for (int i = breakPoint + 1; i < priceRating.Count; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if (priceRating[i] < priceRating[breakPoint])
                    {
                        sumRight += priceRating[i];
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (priceRating[i] >= priceRating[breakPoint])
                    {
                        sumRight += priceRating[i];
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            for (int j = 0; j <= breakPoint - 1; j++)
            {
                if (typeOfItems == "cheap")
                {
                    if (priceRating[j] < priceRating[breakPoint])
                    {
                        sumLeft += priceRating[j];
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (priceRating[j] >= priceRating[breakPoint])
                    {
                        sumLeft += priceRating[j];
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (sumLeft > sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else if (sumRight > sumLeft)
            {
                Console.WriteLine($"Right - {sumRight}");
            }
            else if (sumRight == sumLeft)
            {
                Console.WriteLine($"Left - {sumLeft}");

            }



        }
    }
}
