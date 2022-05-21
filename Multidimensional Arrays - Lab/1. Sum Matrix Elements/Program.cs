using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsColsNum = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rowsCount = rowsColsNum[0];
            int colsCount = rowsColsNum[1];
            int[,] matrix = new int[rowsCount, colsCount];
            for (int row = 0; row < rowsCount; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            Console.WriteLine(rowsCount);
            Console.WriteLine(colsCount);
            for (int row = 0; row < rowsCount; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < colsCount; col++)
                {
                    Console.WriteLine(matrix[row, col]);
                }
            }
            
        }
    }
}
