using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namesInput = Console.ReadLine().Split(' ').ToList();

            Func<string, string> names = name => "Sir " + name;

            foreach (string name in namesInput)
            {
                Console.WriteLine(names(name));
            }
        }
    }
}
