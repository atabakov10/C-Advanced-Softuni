using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Celebration
{
    internal class Program
    {
        private static int beaverRow;
        private static int beaverCol;

        private static char[,] matrix;



        private static List<char> list = new List<char>();

        private static int woodBranches;
        private static int woodBranchesCount;
        private static string lastDirection;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size, size];
            for (int r = 0; r < size; r++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int c = 0; c < input.Length; c++)
                {
                    matrix[r, c] = input[c];
                    if (matrix[r, c] == 'B')
                    {
                        beaverRow = r;
                        beaverCol = c;
                    }
                    if (char.IsLower(matrix[beaverRow, beaverCol]))
                    {
                        woodBranchesCount++;
                    }

                }
            }

            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                lastDirection = cmd;
                if (cmd == "up")
                {

                    Movement(-1, 0);

                }
                else if (cmd == "down")
                {
                    Movement(1, 0);
                }
                else if (cmd == "right")
                {
                    Movement(0, 1);

                }
                else if (cmd == "left")
                {
                    Movement(0, -1);
                }


                cmd = Console.ReadLine();

            }
            Console.WriteLine($"The Beaver failed to collect every wood branch. There are {woodBranches} branches left.");
            pringingMatrix(matrix);



        }
        public static void pringingMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ", StringSplitOptions.RemoveEmptyEntries);
                }
                Console.WriteLine();
            }
        }

        public static bool isInMatrix(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        public static void Movement(int row, int col)
        {
            if (!isInMatrix(beaverRow + row, beaverCol + col))
            {
                if (list.Any())
                {
                    list.RemoveAt(list.Count - 1);
                    woodBranchesCount--;
                    return;

                }

            }
            matrix[beaverRow, beaverCol] = '-';
            beaverRow += row;
            beaverCol += col;


            if (lastDirection == "up")
            {
                if (char.IsLower(matrix[beaverRow, beaverCol]))
                {

                    list.Add(matrix[beaverRow, beaverCol]);
                    woodBranches++;
                    woodBranchesCount--;
                }
                else if (matrix[beaverRow, beaverCol] == 'F')
                {
                    matrix[beaverRow, beaverCol] = '-';
                    if (beaverRow == 0)
                    {
                        if (char.IsLower(matrix[matrix.GetLength(0) - 1, beaverCol]))
                        {
                            list.Add(matrix[matrix.GetLength(0) - 1, beaverCol]);
                            beaverRow = matrix.GetLength(0) - 1;
                            woodBranches++;
                            woodBranchesCount--;
                        }
                        beaverRow = matrix.GetLength(0) - 1;


                    }
                    else

                    {
                        if (char.IsLower(matrix[0, beaverCol]))
                        {
                            list.Add(matrix[0, beaverCol]);
                            beaverRow = 0;
                            woodBranches++;
                            woodBranchesCount--;
                        }
                        beaverRow = 0;
                    }
                }
            }
            else if (lastDirection == "down")
            {
                if (char.IsLower(matrix[beaverRow, beaverCol]))
                {
                    list.Add(matrix[beaverRow, beaverCol]);
                    woodBranches++;
                    woodBranchesCount--;
                }
                else if (matrix[beaverRow, beaverCol] == 'F')
                {
                    matrix[beaverRow, beaverCol] = '-';
                    if (beaverRow == matrix.GetLength(0) - 1)
                    {
                        if (char.IsLower(matrix[0, beaverCol]))
                        {
                            list.Add(matrix[0, beaverCol]);
                            beaverRow = 0;
                            woodBranches++;
                            woodBranchesCount--;
                        }
                        beaverRow = 0;
                    }
                    else
                    {
                        if (char.IsLower(matrix[matrix.GetLength(0) - 1, beaverCol]))
                        {
                            list.Add(matrix[matrix.GetLength(0) - 1, beaverCol]);
                            beaverRow = matrix.GetLength(0) - 1;
                            woodBranches++;
                            woodBranchesCount--;
                        }
                        beaverRow = matrix.GetLength(0) - 1;
                    }
                }
            }
            else if (lastDirection == "right")
            {
                if (char.IsLower(matrix[beaverRow, beaverCol]))
                {
                    list.Add(matrix[beaverRow, beaverCol]);
                    woodBranches++;
                    woodBranchesCount--;
                }
                else if (matrix[beaverRow, beaverCol] == 'F')
                {
                    matrix[beaverRow, beaverCol] = '-';
                    if (beaverCol == matrix.GetLength(1) - 1)
                    {
                        if (char.IsLower(matrix[beaverRow, 0]))
                        {
                            list.Add(matrix[beaverRow, 0]);
                            beaverCol = 0;
                            woodBranches++;
                            woodBranchesCount--;
                        }
                        beaverCol = 0;

                    }
                    else
                    {
                        if (char.IsLower(matrix[beaverRow, matrix.GetLength(1) - 1]))
                        {
                            list.Add(matrix[beaverRow, matrix.GetLength(1) - 1]);
                            beaverCol = matrix.GetLength(1) - 1;
                            woodBranches++;
                            woodBranchesCount--;
                        }
                        beaverCol = matrix.GetLength(1) - 1;
                    }
                }

            }
            else if (lastDirection == "left")
            {
                if (char.IsLower(matrix[beaverRow, beaverCol]))
                {
                    list.Add(matrix[beaverRow, beaverCol]);
                    woodBranches++;
                    woodBranchesCount--;
                }
                else if (matrix[beaverRow, beaverCol] == 'F')
                {
                    matrix[beaverRow, beaverCol] = '-';
                    if (beaverCol == 0)
                    {
                        if (char.IsLower(matrix[beaverRow, matrix.GetLength(1) - 1]))
                        {
                            list.Add(matrix[beaverRow, matrix.GetLength(1) - 1]);
                            beaverCol = matrix.GetLength(1) - 1;
                            woodBranches++;
                            woodBranchesCount--;
                        }
                        beaverCol = matrix.GetLength(1) - 1;
                    }
                    else
                    {
                        if (char.IsLower(matrix[beaverRow, 0]))
                        {
                            list.Add(matrix[beaverRow, 0]);
                            beaverCol = 0;
                            woodBranches++;
                            woodBranchesCount--;
                        }
                        beaverCol = 0;
                    }
                }
          }
            matrix[beaverRow, beaverCol] = 'B';
        }
    }
}
