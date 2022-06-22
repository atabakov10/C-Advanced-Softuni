using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> waters = new Queue<double>(Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));

            Stack<double> flours = new Stack<double>(Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));

            Dictionary<string, int> products = new Dictionary<string, int>();
            products.Add("Croissant", 0);
            products.Add("Muffin", 0);
            products.Add("Baguette", 0);
            products.Add("Bagel", 0);

            double currentWaterNum = waters.Peek();
            double currentFlourNum = flours.Peek();
            double sum = currentWaterNum + currentFlourNum;
            double sumOfWaterOfMuffin = currentWaterNum * 100 / sum;
            double sumOfFlourOfMuffin = currentFlourNum * 100 / sum;
            while (waters.Count == 0 || flours.Count == 0)
            {
                if (sumOfWaterOfMuffin == 40 && sumOfFlourOfMuffin == 60)
                {
                    waters.Dequeue();
                    flours.Pop();
                }
                else if (sumOfWaterOfMuffin == 50 && sumOfFlourOfMuffin == 50)
                {
                    waters.Dequeue();
                    flours.Pop();
                }
                else if (sumOfWaterOfMuffin == 30 && sumOfFlourOfMuffin == 70)
                {
                    waters.Dequeue();
                    flours.Pop();
                }
                else if (sumOfWaterOfMuffin == 20 && sumOfFlourOfMuffin == 80)
                {
                    waters.Dequeue();
                    flours.Pop();
                }
                
            }


        }
    }
}
