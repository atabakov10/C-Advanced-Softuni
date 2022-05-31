using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isCapitalFirstLetter =
                (string x) => x.Length > 0 && char.IsUpper(x[0]);
            Console.WriteLine(
                string.Join("\r\n",
                Console.ReadLine()
                .Split(" ")
                .Where(x => isCapitalFirstLetter(x))
                .ToArray()
                )
             );
        }
    }
}
