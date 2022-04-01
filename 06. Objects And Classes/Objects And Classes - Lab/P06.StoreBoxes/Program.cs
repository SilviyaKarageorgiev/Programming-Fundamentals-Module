using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.StoreBoxes
{

    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

    }

    class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForABox { get; set; }

        public override string ToString()
        {
            return $"{SerialNumber}" + "\n" + $"-- {Item.Name} - ${Item.Price:f2}: {ItemQuantity}" + "\n" + $"-- ${PriceForABox:f2}";

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> list = new List<Box>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArg = command.Split(' ');
                string serialNumber = cmdArg[0];
                string itemName = cmdArg[1];
                int itemQuantity = int.Parse(cmdArg[2]);
                decimal itemPrice = decimal.Parse(cmdArg[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };
                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemQuantity = itemQuantity,
                    PriceForABox = itemQuantity * itemPrice,
                    Item = item

                };

                list.Add(box);

                command = Console.ReadLine();
            }
            List<Box> orderedList = list.OrderByDescending(b => b.PriceForABox).ToList();

            foreach (var item in orderedList)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
