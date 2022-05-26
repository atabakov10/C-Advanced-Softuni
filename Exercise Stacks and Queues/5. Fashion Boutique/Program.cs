using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int numberOfRacks = 1;
            int[] clothesInBoxes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothesInBoxes);
            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum <= capacityOfRack)
                {
                    stack.Pop();
                }
                else
                {
                    numberOfRacks++;
                    sum = 0;
                }
            }
            Console.WriteLine(numberOfRacks);
            
        }
    }
}
