using System;
using System.Linq;



     class DiagonalDifference
{
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            FillMatrix(matrix);

            int sumPrimaryDiagonal = 0;

            int sumSecondaryDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int number = matrix[row, col];
                    if (row == col)
                    {
                        sumPrimaryDiagonal += number;
                    }
                    if (row + col == n - 1)
                    {
                        sumSecondaryDiagonal += number;
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }
        }
    }

