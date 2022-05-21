using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int number = int.Parse(command[0]);

                if (number == 1)
                {
                    int number2 = int.Parse(command[1]);
                    stack.Push(number2);
                }
                else if (number == 2)
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                   
                }
                else if (number == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    
                }
                else if (number == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    
                }


            }
            if (stack.Count > 0)
            {
                Console.WriteLine(String.Join(", ", stack));
            }
    }}
}
