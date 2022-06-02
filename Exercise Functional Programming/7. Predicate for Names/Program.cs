using System;

namespace _7._Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(' ');

            //Predicate<string> namesLength = n => names.Length <= number;
            foreach (var name in names)
            {
                Predicate<string> namesLength = n => name.Length <= number;

                if (namesLength(name))
                {
                    Console.WriteLine(name);
                }
                
            }
        }
    }
}
