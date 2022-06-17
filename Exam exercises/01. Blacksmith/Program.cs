using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));


            Stack<int> carbon = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int countOfForgedSwords = 0;

            Dictionary<string, int> swords = new Dictionary<string,  int>()
            {
                {"Gladius", 0 },
                {"Shamshir", 0 },
                {"Katana", 0 },
                {"Sabre", 0 },
                {"Broadsword", 0}

            };

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int steelPeek = steel.Peek();
                int carbonPeak = carbon.Peek();
                int sum = steelPeek + carbonPeak;

                if (sum == 70)
                {
                    swords["Gladius"] += 1;
                    countOfForgedSwords += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 80)
                {
                    swords["Shamshir"] += 1;
                    countOfForgedSwords += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 90)
                {
                    swords["Katana"] += 1;
                    countOfForgedSwords += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 110)
                {
                    swords["Sabre"] += 1;
                    countOfForgedSwords += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 150)
                {

                    swords["Broadsword"] += 1;
                    countOfForgedSwords += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else
                {

                    steel.Dequeue();
                    carbon.Push(carbon.Pop() + 5);
                }
            }      
                
               

            if (countOfForgedSwords > 0)
            {
                Console.WriteLine($"You have forged {countOfForgedSwords} swords.");

            }
            else
            {
                Console.WriteLine($"You did not have enough resources to forge a sword.");

            }
            if(steel.Count <= 0)
            {
                Console.WriteLine($"Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }

            if (carbon.Count <= 0)
            {
                Console.WriteLine($"Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }

            if(countOfForgedSwords > 0)
            {
                swords = swords.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            }

            foreach(var item in swords)
            {
                if(item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}