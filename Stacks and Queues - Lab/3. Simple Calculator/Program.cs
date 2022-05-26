using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();
            Stack<string> stack = new Stack<string>();
            foreach (var item in input)
            {               
                stack.Push(item);

                for (int i = 1; i <= input.Length; i++)
                {
                    if (i == )
                    {
                        //do smthng
                    }
                }
            }
            
            
        }
    }
}
