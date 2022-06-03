using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car shokda = new Car();
            Console.WriteLine(shokda.WhoAmI());

            Car car = new Car();
            car.Make = "BMW";
            car.Model = "X6";
            car.Year = 2022;
            car.FuelQuantity = 50;
            car.FuelConsumption = 0.07;
            
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine()
                ;
            car.Drive(700);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();

            car.Drive(50);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();


        }
    }
}
