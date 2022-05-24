using System;
using System.Linq;
using System.Text;

namespace Maximal_Sum
{
	class MaximalSum
	{
		static int Sum3X3(int[,] arr, int row, int col)
		{
			int result = 0;

			for (int r = row; r < row + 3; r++)
			{
				for (int c = col; c < col + 3; c++)
				{
					result += arr[r, c];
				}
			}

			return result;
		}// int Sum3X3(arr, row, col)

		static void PrintArray(int[,] arr, StringBuilder sb, int maxRow, int maxCol)
		{
			StringBuilder temp = new StringBuilder();

			for (int row = maxRow; row < maxRow + 3; row++)
			{
				temp.Clear();

				for (int col = maxCol; col < maxCol + 3; col++)
				{
					temp.Append($"{arr[row, col]} ");
				}

				sb.AppendLine(temp.ToString().TrimEnd());
			}

			Console.WriteLine(sb.ToString());
		}

		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			int rows = dimensions[0];
			int cols = dimensions[1];

			int[,] arr = new int[rows, cols];

			for (int row = 0; row < rows; row++)
			{
				int[] temp = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				for (int col = 0; col < cols; col++)
				{
					arr[row, col] = temp[col];
				}
			}

			int sum = 0;
			int endRow = arr.GetLength(0) - 3;
			int endCol = arr.GetLength(1) - 3;
			int maxRow = 0;
			int maxCol = 0;

			for (int row = 0; row <= endRow; row++)
			{
				for (int col = 0; col <= endCol; col++)
				{
					int currentSum = Sum3X3(arr, row, col);
					if (currentSum > sum)
					{
						sum = currentSum;
						maxRow = row;
						maxCol = col;
					}

				}
			}

			StringBuilder sb = new StringBuilder($"Sum = {sum}\n");

			PrintArray(arr, sb, maxRow, maxCol);

		}
	}
}