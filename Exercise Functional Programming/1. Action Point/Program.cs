using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namesInput = Console.ReadLine().Split(' ').ToList();

            Action<string> print = x => Console.WriteLine(x);
            namesInput.ForEach(print);
        }
    }
}
