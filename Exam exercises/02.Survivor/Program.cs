using System;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string[][] beach = new string[rows][];
            int tokensFound = 0;
            int opponents = 0;

            for (int row = 0; row < rows; row++)
            {
                beach[row] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string command = Console.ReadLine();

            while (command != "Gong")
            {
                string[] commandData = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(commandData[1]);
                int col = int.Parse(commandData[2]);

                if (row < rows && col < beach[row].Length)
                {
                    if (commandData[0] == "Find")
                    {
                        if (beach[row][col] == "T")
                        {
                            tokensFound++;
                            beach[row][col] = "-";
                        }
                    }
                    else if (commandData[0] == "Opponent")
                    {
                        string direction = commandData[3];

                        switch (direction)
                        {
                            case "up":
                                for (int i = row; i >= row - 3; i--)
                                {
                                    if (i >= 0 && beach[i][col] == "T")
                                    {
                                        opponents++;
                                        beach[i][col] = "-";
                                    }
                                }
                                break;

                            case "down":
                                for (int i = row; i <= row + 3; i++)
                                {
                                    if (i < rows && beach[i][col] == "T")
                                    {
                                        opponents++;
                                        beach[i][col] = "-";
                                    }
                                }
                                break;

                            case "left":
                                for (int i = col; i >= col - 3; i--)
                                {
                                    if (i >= 0 && i < beach[row].Length
                                        && beach[row][i] == "T")
                                    {
                                        opponents++;
                                        beach[row][i] = "-";
                                    }
                                }
                                break;

                            case "right":
                                for (int i = col; i <= col + 3; i++)
                                {
                                    if (i < beach[row].Length && beach[row][i] == "T")
                                    {
                                        opponents++;
                                        beach[row][i] = "-";
                                    }
                                }
                                break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            PrintMatrix(beach);

            Console.WriteLine($"Collected tokens: {tokensFound}");
            Console.WriteLine($"Opponent's tokens: {opponents}");
        }

        static void PrintMatrix(string[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{string.Join(" ", matrix[row][col])} ");
                }
                Console.WriteLine();
            }
        }
    }
}