using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.BlackSmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> inputSteel = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            Stack<int> inputCarbon = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            Dictionary<string, int> swords = new Dictionary<string, int>();
            swords.Add("Gladius", 0);
            swords.Add("Shamshir", 0);
            swords.Add("Katana", 0);
            swords.Add("Sabre", 0);
            swords.Add("Broadsword", 0);
            int swordsAdded = 0;




            while (inputSteel.Count != 0 && inputCarbon.Count != 0)
            {
            int currentSteel = inputSteel.Peek();

            int currentCarbon = inputCarbon.Peek();

            int sum = currentSteel + currentCarbon;

                if (sum == 70)
                {
                    swords["Gladius"]++;
                    inputSteel.Dequeue();
                    inputCarbon.Pop();
                    swordsAdded++;
                }
                else if (sum == 80)
                {
                    swords["Shamshir"]++;
                    inputSteel.Dequeue();
                    inputCarbon.Pop();
                    swordsAdded++;
                }
                else if (sum == 90)
                {
                    swords["Katana"]++;
                    inputSteel.Dequeue();
                    inputCarbon.Pop();
                    swordsAdded++;
                }
                else if (sum == 110)
                {
                    swords["Sabre"]++;
                    inputSteel.Dequeue();
                    inputCarbon.Pop();
                    swordsAdded++;
                }
                else if (sum == 150)
                {
                    swords["Broadsword"]++;
                    inputSteel.Dequeue();
                    inputCarbon.Pop();
                    swordsAdded++;
                }
                else
                {
                    inputSteel.Dequeue();
                    
                    inputCarbon.Push(inputCarbon.Pop() + 5);
                }
            }
            if (swordsAdded > 0)
            {
                Console.WriteLine($"You have forged {swordsAdded} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            if (inputSteel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {String.Join(", ", inputSteel)}");

            }
            if (inputCarbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {String.Join(", ", inputCarbon)}");
            }

            foreach (var sword in swords.OrderBy(x => x.Key))
            {
                if (sword.Value > 0)
                {
                    string nameSword = sword.Key;
                    int valueSword = sword.Value;
                    Console.WriteLine($"{nameSword}: {valueSword}");
                }
            }
            

        }
    }
}
