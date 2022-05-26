using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int sum = 0;
            for (int i = 2; i <= 1000; i= i + 2)
            {
                sum += i;
                counter++;
            }
            Console.WriteLine($"Sum of even numbers between 1 and 1000 is {sum}, count {counter}");
            
            counter = 0;
            sum = 0;
            for (int i = 2; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    counter++;
                }
            }
            Console.WriteLine($"Sum of even numbers between 1 and 1000 is {sum}, count {counter}");
            Console.ReadKey();
        }
    }
}
