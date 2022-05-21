using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 5);
            Point p2 = new Point(4, 15);
            Console.WriteLine($"Distance between points" +
                $" {p1.GetDistanceToPoint(p2)}");

            Console.ReadLine();
        }
    }
}
