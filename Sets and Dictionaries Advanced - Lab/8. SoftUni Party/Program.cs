using System;
using System.Collections.Generic;

namespace _8._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();

            string command = Console.ReadLine();
            while (command != "PARTY")
            {
                if (char.IsDigit(command[0]))
                {
                    vips.Add(command);
                }
                else
                {
                    guests.Add(command);
                }

                command = Console.ReadLine();
            }
            while (command != "END")
            {
                if (char.IsDigit(command[0]))
                {
                    vips.Remove(command);
                }
                else
                {
                    guests.Remove(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(guests.Count + vips.Count);
            foreach (var people in vips)
            {
                Console.WriteLine(people);
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
