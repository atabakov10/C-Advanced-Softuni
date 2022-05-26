using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new HashSet<string>();
            string command;
            while ((command = Console.ReadLine())!= "END")
            {
                string[] realCmd = command.Split(", ");
                string cmd = realCmd[0];
                string number = realCmd[1];
                if (cmd == "IN")
                {
                    cars.Add(number);
                }
                else if (cmd == "OUT")
                {
                    cars.Remove(number);
                }
                

                
            }
            foreach (var car in cars)
            {
               Console.WriteLine(car);  
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
