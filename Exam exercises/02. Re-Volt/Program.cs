using System;

namespace _02.Re_Volt
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            bool isWon = false;

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                matrix[playerRow, playerCol] = '-';

                switch (command)
                {
                    case "up":
                        playerRow--;
                        (playerRow, playerCol) = IsOutside(matrix, playerRow, playerCol);

                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow--;
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerRow++;
                        }

                        break;
                    case "down":
                        playerRow++;
                        (playerRow, playerCol) = IsOutside(matrix, playerRow, playerCol);

                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow++;
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerRow--;
                        }

                        break;
                    case "left":
                        playerCol--;
                        (playerRow, playerCol) = IsOutside(matrix, playerRow, playerCol);

                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol--;
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol++;
                        }

                        break;
                    case "right":
                        playerCol++;
                        (playerRow, playerCol) = IsOutside(matrix, playerRow, playerCol);

                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol++;
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol--;
                        }

                        break;
                }

                (playerRow, playerCol) = IsOutside(matrix, playerRow, playerCol);

                if (matrix[playerRow, playerCol] == 'F')
                {
                    matrix[playerRow, playerCol] = 'f';
                    isWon = true;
                    break;
                }

                matrix[playerRow, playerCol] = 'f';
            }

            if (isWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static (int row, int col) IsOutside(char[,] matrix, int row, int col)
        {
            if (row < 0)
            {
                row = matrix.GetLength(0) - 1;
            }
            else if (row >= matrix.GetLength(0))
            {
                row = 0;
            }

            if (col < 0)
            {
                col = matrix.GetLength(1) - 1;
            }
            else if (col >= matrix.GetLength(1))
            {
                col = 0;
            }

            return (row, col);
        }
    }
}