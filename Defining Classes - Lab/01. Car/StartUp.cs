using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Make = "BMW";
            c.Model = "X6";
            c.Year = 2022;

            Console.WriteLine($"Make: {c.Make}\nModel: {c.Model}\nYear: {c.Year} ");
        }
    }
}
