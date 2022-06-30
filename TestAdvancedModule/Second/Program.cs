using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Beaver_at_Work
{
    public class Program
    {
        private static int playerRow;
        private static int playerCol;
        private static char[,] matrix;
        private static string lastDirection;
        private static int countOfHoles = 0;
        private static int countOfRods = 0;


        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            matrix = new char[n, n];

            //Initialize Matrix and set bunny position
            for (int i = 0; i < n; i++)
            {
                char[] input = Console.ReadLine()
                    .ToCharArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];

                    if (matrix[i, j] == 'V')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                  
                    
                }
            }

            string direction = Console.ReadLine();

            while (direction != "End")
            {
                lastDirection = direction;

                if (direction == "up")
                {
                    Move(-1, 0);
                }
                else if (direction == "down")
                {
                    Move(1, 0);
                }
                else if (direction == "right")
                {
                    Move(0, 1);
                }
                else if (direction == "left")
                {
                    Move(0, -1);
                }

                direction = Console.ReadLine();
            }


            if (true)
            {

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write((char)matrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        private static void Move(int row, int col)
        {
            if (!IsInside(playerRow + row, playerCol + col))
            {
                return;
            }
            matrix[playerRow, playerCol] = '*';
            playerRow += row;
            playerCol += col;

            if (char.IsLetter(matrix[playerRow, playerCol]))
            {

                Console.WriteLine();
         
            }
            else if (matrix[playerRow, playerCol] == 'R')
            {
                matrix[playerRow, playerCol] = '-';

                if (lastDirection == "up")
                {
                    if (playerRow == 0)
                    {
                        if (char.IsDigit(matrix[matrix.GetLength(0) - 1, playerCol]))
                        {
                            countOfHoles++;
                        }
                        playerRow = matrix.GetLength(0) - 1;
                        matrix[playerRow, playerCol] = 'V';
                    }
                    else
                    {
                        if (char.IsDigit(matrix[0, playerCol]))
                        {
                            countOfHoles++;
                        }
                        playerRow = 0;
                        matrix[playerRow, playerCol] = 'V';
                    }
                }
                else if (lastDirection == "down")
                {
                    if (playerRow == matrix.GetLength(0) - 1)
                    {
                        if (char.IsLetter(matrix[0, playerCol]))
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            countOfRods++;
                        }
                        playerRow = 0;
                        matrix[playerRow, playerCol] = 'V';
                    }
                    else
                    {
                        
                        playerRow = matrix.GetLength(0) - 1;
                        matrix[playerRow, playerCol] = 'V';
                    }
                }
                else if (lastDirection == "right")
                {
                    if (playerCol == matrix.GetLength(1) - 1)
                    {
                        
                        playerCol = 0;
                        matrix[playerRow, playerCol] = 'V';
                    }
                    else
                    {
                        if (char.IsLetter(matrix[playerRow, matrix.GetLength(1) - 1]))
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            countOfRods++;
                        }
                        playerCol = matrix.GetLength(1) - 1;
                        matrix[playerRow, playerCol] = 'V';
                    }
                }
                else if (lastDirection == "left")
                {
                    if (playerCol == 0)
                    {
                        if (char.IsLetter(matrix[playerRow, matrix.GetLength(1) - 1]))
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            countOfRods++;
                        }
                        playerCol = matrix.GetLength(1) - 1;
                        matrix[playerRow, playerCol] = 'V';
                    }
                    else
                    {
                        if (char.IsLetter(matrix[playerRow, 0]))
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            countOfRods++;
                        }
                        playerCol = 0;
                        matrix[playerRow, playerCol] = 'V';
                    }
                }
            }
            else
            {
                matrix[playerRow, playerCol] = 'V';
            }
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }
    }
}