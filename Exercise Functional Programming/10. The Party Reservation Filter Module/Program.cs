using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_PartyReservationFilterModule
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = Console.ReadLine()
				.Split()
				.ToArray();

			string filter = Console.ReadLine();

			List<string> filters = new List<string>();

			while (filter != "Print")
			{
				string[] filterInfo = filter
					.Split(';')
					.ToArray();

				string action = filterInfo[0];

				if (action == "Add filter")
				{
					filters.Add($"{filterInfo[1]};{filterInfo[2]}");
				}
				else if (action == "Remove filter")
				{
					filters.Remove($"{filterInfo[1]};{filterInfo[2]}");
				}

				filter = Console.ReadLine();
			}

			Func<string, int, bool> lengthFilter = (name, length) => name.Length == length;
			Func<string, string, bool> startsWithFilter = (name, parameter) => name.StartsWith(parameter);
			Func<string, string, bool> endsWithFilter = (name, parameter) => name.EndsWith(parameter);
			Func<string, string, bool> containsFilter = (name, parameter) => name.Contains(parameter);

			foreach (var currentFilter in filters)
			{
				string[] currentFilterInfo = currentFilter.Split(';').ToArray();

				string action = currentFilterInfo[0];
				string parameter = currentFilterInfo[1];

				switch (action)
				{
					case "Starts with":
						names = names.Where(name => !startsWithFilter(name, parameter)).ToArray();
						break;
					case "Ends with":
						names = names.Where(name => !endsWithFilter(name, parameter)).ToArray();
						break;
					case "Length":
						int length = int.Parse(parameter);
						names = names.Where(name => !lengthFilter(name, length)).ToArray();
						break;
					case "Contains":
						names = names.Where(name => !containsFilter(name, parameter)).ToArray();
						break;
				}
			}

			Console.WriteLine(string.Join(" ", names));
		}
	}
}