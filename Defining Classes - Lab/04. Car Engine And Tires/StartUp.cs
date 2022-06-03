using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            HashSet<List<int>> press = new HashSet<List<int>>();
            string input = Console.ReadLine();
            while (input != "No more tires")
            {
                var tireInfo = input.Split();

                var currTires = new Tire[4];
                int count = 0;
                for (int i = 0; i < tireInfo.Length; i += 2)
                {
                    int year = int.Parse(tireInfo[i]);
                    double pressure = double.Parse(tireInfo[i + 1]);

                    var tire = new Tire(year, pressure);
                    currTires[count] = tire;
                    count++;
                }
                tires.Add(currTires);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Engines done")
            {
                var engineInfo = input.Split();
                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                var engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "Show special")
            {
                var carInfo = input.Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQty = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                var engine = engines[engineIndex];
                var tirePack = tires[tiresIndex];

                var car = new Car(make, model, year, fuelQty, fuelConsumption, engine, tirePack);

                cars.Add(car);

                input = Console.ReadLine();
            }

            var specialCars = cars.Where(x => 
            x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(p => p.Pressure) >= 9 && 
            x.Tires.Sum(p => p.Pressure) <= 10).ToList();

            foreach (var specialCar in specialCars)
            {
                specialCar.Drive(20);
            }
            foreach (var specialCar in specialCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}\n" +
                    $"Model: {specialCar.Model}\n" +
                    $"Year: {specialCar.Year}\n" +
                    $"HorsePower: {specialCar.Engine.HorsePower}\n" +
                    $"FuelQuantity: {specialCar.FuelQuantity}");
            }


        }
    }
}
