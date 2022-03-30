using System;
using System.Linq;

namespace P04.Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                int temp = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                    
                }
                arr[arr.Length - 1] = temp;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
