using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = elements[0];
            int s = elements[1];
            int x = elements[2];

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }


        }
    }
}
