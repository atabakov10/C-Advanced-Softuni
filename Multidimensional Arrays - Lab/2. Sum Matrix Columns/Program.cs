using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
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
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            long[] colSum = new long[colsCount];    

            
            for (int row = 0; row < rowsCount; row++)

                for (int col = 0; col < colsCount; col++)

                    colSum[col] += matrix[row, col];

            for (int col = 0; col < colsCount; col++)
            {
                Console.WriteLine(colSum[col]);
            }

        }
    }
}
