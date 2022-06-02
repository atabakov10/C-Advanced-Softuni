using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            for (int i = 1; i <= n; i++)
                nums.Add(i);

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < dividers.Length; i++)
            {
                int d = dividers[i];
                Predicate<int> isDivisible = x => x % d == 0;
                nums = nums.Where(x => isDivisible(x)).ToList();

            }
            Console.WriteLine(String.Join(" ", nums));

            
        }
    }
}
