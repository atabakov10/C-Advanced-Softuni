using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> boxesSum = new List<int>();
            int[] firstLootBoxInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondLootBoxInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> firstLootBox = new Queue<int>(firstLootBoxInput);

            Stack<int> secondLootBox = new Stack<int>(secondLootBoxInput);
            while (true)
            {
                if (firstLootBox.Count == 0 || secondLootBox.Count == 0)
                {
                    break;
                }
                var currentFirstLootBox = firstLootBox.Peek();
                var curretSecondLootBox = secondLootBox.Peek();
                var sumLootBoxes = currentFirstLootBox + curretSecondLootBox;
                if (sumLootBoxes % 2 != 0)
                {
                    secondLootBox.Pop();
                    firstLootBox.Enqueue(curretSecondLootBox);
                }
                else
                {

                    boxesSum.Add(currentFirstLootBox);
                    boxesSum.Add(curretSecondLootBox);
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();

                }
                
            }
            if (firstLootBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondLootBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            

            var sumOfBoxes = boxesSum.Sum();
            if (sumOfBoxes >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sumOfBoxes}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sumOfBoxes}");
            }

        }
    }
}
