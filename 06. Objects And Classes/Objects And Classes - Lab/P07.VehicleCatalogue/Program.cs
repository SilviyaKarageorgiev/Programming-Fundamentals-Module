using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.VehicleCatalogue
{

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {Weight}kg";
        }

    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"{Brand}: {Model} - {HorsePower}hp";
        }

    }

    class Catalog
    {
        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }

        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalogObj = new Catalog();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArg = input.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = cmdArg[0];
                string brand = cmdArg[1];
                string model = cmdArg[2];
                int valueHpOrHeight = int.Parse(cmdArg[3]);

                if (type == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = valueHpOrHeight
                    };
                    catalogObj.Cars.Add(car);

                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = valueHpOrHeight
                    };
                    catalogObj.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            List<Car> orderedCars = catalogObj.Cars.OrderBy(cars => cars.Brand).ToList();
            List<Truck> orderedTrucks = catalogObj.Trucks.OrderBy(trucks => trucks.Brand).ToList();

            if (catalogObj.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var item in orderedCars)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            if (catalogObj.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var item in orderedTrucks)
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }
    }
}
