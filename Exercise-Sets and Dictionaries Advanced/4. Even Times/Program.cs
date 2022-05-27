using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 1);
                }
                else
                {
                    dict[number]++;
                }
            }

            Console.WriteLine(dict.First(n => n.Value % 2 == 0).Key);
        }
    }
}
