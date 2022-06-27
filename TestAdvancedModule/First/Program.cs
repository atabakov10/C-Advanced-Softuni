using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> inputWhiteTiles = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Queue<int> inputGrayTiles = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Dictionary<string, int> places = new Dictionary<string, int>();
            places.Add("Sink", 0);
            places.Add("Oven", 0);
            places.Add("Countertop", 0);
            places.Add("Wall", 0);
            places.Add("Floor", 0);
            

            while (true)
            {
                if (inputWhiteTiles.Count == 0 || inputGrayTiles.Count == 0)
                {
                    break;
                }
            int newTile = inputGrayTiles.Peek() + inputWhiteTiles.Peek();
                if (inputWhiteTiles.Peek() == inputGrayTiles.Peek())
                {
                    if (newTile == 40)
                    {
                        inputWhiteTiles.Pop();
                        inputGrayTiles.Dequeue();
                        places["Sink"]++;
                    }
                    else if (newTile == 50)
                    {
                        inputWhiteTiles.Pop();
                        inputGrayTiles.Dequeue();
                        places["Oven"]++;
                    }
                    else if (newTile == 60)
                    {
                        inputWhiteTiles.Pop();
                        inputGrayTiles.Dequeue();
                        places["Countertop"]++;
                    }
                    else if (newTile == 70)
                    {
                        inputWhiteTiles.Pop();
                        inputGrayTiles.Dequeue();
                        places["Wall"]++;
                    }
                    else
                    {
                        inputWhiteTiles.Pop();
                        inputGrayTiles.Dequeue();
                        places["Floor"]++;
                    }
                }
                else
                {
                    inputWhiteTiles.Push(inputWhiteTiles.Pop() / 2);
                    inputGrayTiles.Enqueue(inputGrayTiles.Dequeue());
                }


            }
            if (inputWhiteTiles.Count > 0)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", inputWhiteTiles)} ");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }
            if (inputGrayTiles.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", inputGrayTiles)} ");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }
            var orderedPlaces = places.OrderByDescending(p => p.Value).ThenBy(p => p.Key);
            foreach (var place in orderedPlaces)
            {
                if (place.Value > 0)
                {
                    Console.WriteLine($"{place.Key}: {place.Value}");
                }
            }

        }
    }
}
