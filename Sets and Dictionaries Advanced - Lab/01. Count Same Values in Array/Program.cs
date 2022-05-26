using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> numbersDict 
                = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (numbersDict.ContainsKey(number))
                {
                    numbersDict[number]++;
                }
                else if (!numbersDict.ContainsKey(number))
                {
                    numbersDict[number] = 1;
                }
            }
            foreach (var pair in numbersDict)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
            
        }
    }
}
