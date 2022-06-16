using System;
using System.Linq;

namespace T04.Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lake = new Lake(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
