using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, Dictionary<string, List<string>>>();
            int citiesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < citiesCount; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string continent = line[0];
                string country = line[1];
                string city = line[2];
                AddCity(cities, continent, country, city);
            }

            PrintCitiesByContinentAndCountry(cities);
        }


         static void AddCity(Dictionary<string, Dictionary<string, List<string>>> cities, string continent, string country, string city)
        {
            if (!cities.ContainsKey(continent))
                cities.Add(continent, new Dictionary<string, List<string>>());

            Dictionary<string, List<string>> countries = cities[continent];
            if (!countries.ContainsKey(country))
                countries.Add(country, new List<string>());

            countries[country].Add(city);
        }
         static void PrintCitiesByContinentAndCountry(Dictionary<string, Dictionary<string, List<string>>> cities)
        {
            foreach (var (continentName, countries) in cities)
            {
                Console.WriteLine($"{continentName}:");
                foreach (var (countryName, citiesInCountry) in countries)
                {
                    Console.WriteLine($" {countryName} -> {string.Join(", ", citiesInCountry)}");
                }
            }
        }
    }
}
