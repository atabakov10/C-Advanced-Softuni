using System;
using System.Linq;

namespace _02._Sum_Numbers
{
   class PrintNumbers
    {
        static int Parse(string str)
        {
            int result = int.Parse(str);
            return result;
        }
        static int ParseVariant2(string str) => int.Parse(str);

        static void Main()
        {
            Func<string, int> parseVariant3 = (string str) => int.Parse(str);

            string input = Console.ReadLine();
            int[] nums = input.Split(", ").Select(parseVariant3).ToArray();
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }
    }
}
