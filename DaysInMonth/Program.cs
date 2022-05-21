using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a month between 1 and 12:");
            int month = int.Parse(Console.ReadLine());
            int daysInMonth = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 2:
                    {
                        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                            daysInMonth = 29;
                        else
                            daysInMonth = 28;
                    } break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30; break;
            }
            Console.WriteLine($"Days in month {month} from year {year} are {daysInMonth}");
            Console.ReadKey();
        }
    }
}
