using System;
using System.Collections.Generic;

namespace _04.GrContinentsCountriesAndCities
{
    class Program
    {
       public static void Main()
        {
            var nestedDictionary = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            var inputNumber = int.Parse(Console.ReadLine());

            for (int countIndex = 0; countIndex < inputNumber; countIndex++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');
                var continent = inputTokens[0];
                var country = inputTokens[1];
                var cities = inputTokens[2];

                if (!nestedDictionary.ContainsKey(continent))
                {
                    nestedDictionary.Add(
                        continent,
                        new SortedDictionary<string, SortedSet<string>>());
                }

                if (!nestedDictionary[continent].ContainsKey(country))
                {
                    nestedDictionary[continent].Add(country, new SortedSet<string>());
                }
                nestedDictionary[continent][country].Add(cities);

            }

            foreach (var items in nestedDictionary)
            {
                var continent = items.Key;
                var countries = items.Value;
                Console.WriteLine($"{continent}:");

                foreach (var countryItems in countries)
                {
                    var country = countryItems.Key;
                    var cities = countryItems.Value;
                    Console.WriteLine($"{ country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
