using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVAT = x => x * 1.20m;

            string input = Console.ReadLine();
            string[] tokens = input.Split(", ");
            decimal[] nums = tokens.Select(decimal.Parse).ToArray();
            decimal[] numsWithVAt = nums.Select(addVAT).ToArray();

            Array.ForEach(numsWithVAt, x => Console.WriteLine("{0:f2}", x));
        }
    }
}
