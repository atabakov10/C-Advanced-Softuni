using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    internal class Masterchef
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dishes = new Dictionary<string, int>
            {
                {"Dipping sauce",0 },
                {"Green salad",0 },
                {"Chocolate cake",0 },
                {"Lobster",0 },
            };


            int[] ingredientsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> ingredients = new Queue<int>(ingredientsInput);

            int[] freshnesValueInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> freshnessValue = new Stack<int>(freshnesValueInput);


            while (true)
            {
                if (ingredients.Count == 0 || freshnessValue.Count == 0)
                {
                    break;
                }
                var currentIngredient = ingredients.Peek();
                if (currentIngredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                var currentFreshnessValue = freshnessValue.Peek();
                var currentFreshnessLevel = currentIngredient * currentFreshnessValue;

                if (currentFreshnessLevel == 150)
                {
                    dishes["Dipping sauce"]++;
                    ingredients.Dequeue();
                }
                else if (currentFreshnessLevel == 250)
                {
                    dishes["Green salad"]++;
                    ingredients.Dequeue();
                }
                else if (currentFreshnessLevel == 300)
                {
                    dishes["Chocolate cake"]++;
                    ingredients.Dequeue();
                }
                else if (currentFreshnessLevel == 400)
                {
                    dishes["Lobster"]++;
                    ingredients.Dequeue();
                }
                else
                {
                    int increasedCurrentIngredient = ingredients.Dequeue() + 5;
                    ingredients.Enqueue(increasedCurrentIngredient);
                }

                freshnessValue.Pop();
            }

            if (IsAllDishesHasBeenPrepared(dishes))
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var dish in dishes.OrderBy(x => x.Key))
            {
                if (dish.Value > 0)
                {
                    Console.WriteLine($" # {dish.Key} --> {dish.Value}");
                }
            }
        }

        private static bool IsAllDishesHasBeenPrepared(Dictionary<string, int> dishes)
        {
            foreach (var dish in dishes)
            {
                if (dish.Value == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}