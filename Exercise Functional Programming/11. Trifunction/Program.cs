using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._TriFunction
{
	class TriFunction
	{
		static void Main(string[] args)
		{
			int sumEtalon = int.Parse(Console.ReadLine());

			List<string> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

			Console.WriteLine(Find(list, sumEtalon, Compare));
		}

		private static Func<string, int, bool> Compare = (text, etalon) =>
		{
			int sum = 0;
			foreach (char item in text)
			{
				sum += (int)item;
			}

			return (etalon <= sum);
		};// Compare = (text, etalon)

		private static Func<List<string>, int, Func<string, int, bool>, string> Find = (list, etalon, comparer) =>
		{
			int i = 0;
			bool isLoopExit = false;
			StringBuilder sb = new StringBuilder();

			while ((i < list.Count) && (!isLoopExit))
			{
				if (comparer(list[i], etalon))
				{
					return list[i];
				}
				i++;
			}

			return string.Empty;
		};// Find = (list, comparer)
	}
}