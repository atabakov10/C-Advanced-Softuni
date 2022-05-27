using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());
            var sortedElements = new SortedSet<string>();
            for (int i = 0; i < countOfLines; i++)
            {
                string elements = Console.ReadLine();
                string[] chElements = elements.Split(' ');
                foreach (var chElement in chElements)
                {
                    sortedElements.Add(chElement);
                }
            }

            Console.WriteLine(string.Join(" ", sortedElements));
        }
    }
}
