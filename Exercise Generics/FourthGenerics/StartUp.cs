﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FourthGenerics
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfLine = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < numberOfLine; i++)
            {
                var input = int.Parse(Console.ReadLine());
                list.Add(input);
            }
            var box = new Box<int>(list);
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(list, indexes[0], indexes[1]);
            Console.WriteLine(box);
        }
    }
}
