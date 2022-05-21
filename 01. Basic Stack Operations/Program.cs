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
  
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }


        }
    }
}
