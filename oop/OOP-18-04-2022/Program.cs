using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_18_04_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time();
            t.SetHour(12);
            t.SetMinutes(10);
            t.SetSeconds(40);
            Console.WriteLine($"Time is {t.GetTime()}");

            Time t2 = new Time(4, 20, 22);
            Console.WriteLine($"Time is {t2.GetTime()}");

            Console.ReadLine();
        }
    }
}
