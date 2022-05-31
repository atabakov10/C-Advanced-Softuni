using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseStringToInt =
                x => int.Parse(x);
            Func<int, bool> isEven =
                x => x % 2 == 0;
            Func<int, int> identity = 
                n => n;

            string input = Console.ReadLine();
            string[] tokens = input.Split(", ");
            int[] nums = tokens.Select(parseStringToInt).ToArray();
            int[] evenNums = nums.Where(isEven).ToArray();
            int[] orderedNums = evenNums.OrderBy(identity).ToArray();

            Console.WriteLine(String.Join(", ", orderedNums));
        }
    }
}
