using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtyOfFood = int.Parse(Console.ReadLine());
            List<int> ordersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Queue<int> queue = new Queue<int>(ordersList);
            Console.WriteLine(queue.Max());
            int countOrders = queue.Count;
            for (int i = 0; i < countOrders; i++)
            {
                if (qtyOfFood >= queue.Peek())
                {
                    qtyOfFood -= queue.Peek();
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            
        }
    }
}
