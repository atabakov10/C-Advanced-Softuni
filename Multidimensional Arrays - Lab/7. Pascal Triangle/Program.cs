using System;
using System.Numerics;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger[][] jagged = new BigInteger[n][];

            for (int row = 0; row < n; row++)
            {
                jagged[row] = new BigInteger[row + 1];
                jagged[row][0] = 1;
                for (int col = 1; col < row; col++)
                {
                    jagged[row][col] =
                        jagged[row - 1][col - 1] +
                        jagged[row - 1][col];
                }
                jagged[row][row] = 1;

            

            
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }
    }
}
