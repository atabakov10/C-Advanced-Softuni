using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortedDict = new SortedDictionary<char, int>();
            string words = Console.ReadLine();
            foreach (char ch in words)
            {
                if (!sortedDict.ContainsKey(ch))
                {
                    sortedDict.Add(ch, 1);
                }
                else
                {
                    sortedDict[ch]++;
                }
            }
            foreach (var item in sortedDict)
            {
                Console.WriteLine(string.Join(Environment.NewLine, $"{item.Key}: {item.Value} time/s"));
            }
        }
    }
}
