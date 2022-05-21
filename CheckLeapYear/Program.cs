using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if (year < 0)
                Console.WriteLine("Invalid value for year");
            else
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    Console.WriteLine($"Leap year: {year}");
                else
                    Console.WriteLine($"Not a leap year: {year}");
            }
            Console.ReadKey();
        }
    }
}
